using Inlämningsuppgift1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift1.Repos
{
    public class AdvertRepo
    {
        private BlocketDBEntities _db;

        public AdvertRepo()
        {
            _db = new BlocketDBEntities();
        }

        public List<Advert> GetAllAdverts()
        {
            return _db.Adverts.Include("Category").ToList();
        }
        public void InsertNewAdvert(Advert advert)
        {
            _db.Adverts.Add(advert);
            _db.SaveChangesAsync();
        }
        public Advert GetAdverts(int AdvertID)
        {
            return _db.Adverts.Find(AdvertID);
        }
        public void UpdateAdverts(Advert newAdvert)
        {

            Advert orgAdvert = _db.Adverts
                .Find(newAdvert.AdvertID);

            _db.Entry(orgAdvert).CurrentValues.SetValues(newAdvert);
            _db.SaveChanges();
        }
        public void DeleteAdvert(int advertid)
        {
            Advert adverts = GetAdverts(advertid);
            _db.Adverts.Remove(adverts);
            _db.SaveChanges();
        }
        public List<Advert> SearchAdvert(string condition)
        {
            return  _db.Adverts.Where(x => x.AdvertTitle.StartsWith(condition)).ToList();
        }
        public List<Advert> SearchAdvertCategory(string condition)
        {
            return _db.Adverts.Where(x => x.Category.CategoryName.ToLower().StartsWith(condition.ToLower())).ToList();
        }
        public List<Advert> GetAllMobiles()
        {
            return _db.Adverts.Where(x => x.Category.CategoryName == "Phone").ToList();
        }
        public List<Advert> GetAllCars()
        {
            return _db.Adverts.Where(x => x.Category.CategoryName == "Cars").ToList();
        }
        public List<Advert> GetAllComputers()
        {
            return _db.Adverts.Where(x => x.Category.CategoryName == "Computer").ToList();
        }
        public List<Advert> GetAllClothes()
        {
            return _db.Adverts.Where(x => x.Category.CategoryName == "Clothes").ToList();
        }

    }
}
