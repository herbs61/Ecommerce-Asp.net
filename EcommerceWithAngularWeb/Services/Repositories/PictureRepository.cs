using EcommerceWithAngularWeb.Data;
using EcommerceWithAngularWeb.Models;
using EcommerceWithAngularWeb.Services.Infrastuctures;

namespace EcommerceWithAngularWeb.Services.Repositories
{
    public class PictureRepository : IPicture
    {
        private ApplicationDbContext _context;
        public PictureRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.Pictures.Count();
        }

        public void Delete(int id)
        {
            var picture = _context.Pictures.FirstOrDefault(c => c.Id == id);
            if (picture != null)
            {
                _context.Pictures.Remove(picture);
            }
        }

        public IEnumerable<Picture> GetPictures()
        {
            return _context.Pictures;
        }

        public Picture GetPicture(int id)
        {
            var picture = _context.Pictures.FirstOrDefault(c => c.Id == id);
            if (picture != null)
            {
                return picture;
            }
            return null;

        }

        public void Insert(Picture picture)
        {
            _context.Pictures.Add(picture);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Picture picture)
        {
            _context.Pictures.Update(picture);
        }
    }
}
