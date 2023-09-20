﻿using EcommerceWithAngularWeb.Data;
using EcommerceWithAngularWeb.Models;
using EcommerceWithAngularWeb.Services.Infrastuctures;

namespace EcommerceWithAngularWeb.Services.Repositories
{
    public class CartItemRepository : ICartItem
    {
        private ApplicationDbContext _context;
        public CartItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.CartItems.Count();
        }

        public void Delete(int id)
        {
            var cartItem = _context.CartItems.FirstOrDefault(c => c.Id == id);
            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
            }
        }

        public IEnumerable<CartItem> GetCartItems()
        {
            return _context.CartItems;
        }

        public CartItem GetCartItem(int id)
        {
            var cartItem = _context.CartItems.FirstOrDefault(c => c.Id == id);
            if (cartItem != null)
            {
                return cartItem;
            }
            return null;

        }

        public void Insert(CartItem cartItem)
        {
            _context.CartItems.Add(cartItem);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(CartItem cartItem)
        {
            _context.CartItems.Update(cartItem);
        }
    }

}
