using Inlämningsuppgift1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift1.Repos
{
    public class CategoryRepo
    {
        private BlocketDBEntities _db;

        public CategoryRepo()
        {
            _db = new BlocketDBEntities();
        }

        public Category GetCategory(string category)
        {
            return _db.Categories.SingleOrDefault(x => x.CategoryName == category);
        }



    }
}
