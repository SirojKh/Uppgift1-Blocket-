using Inlämningsuppgift1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift1.Repos
{
    public class UserRepo
    {
        private BlocketDBEntities _db;

        public UserRepo()
        {
            _db = new BlocketDBEntities();
        }

        public List<User> GetAllUsers()
        {
            return _db.Users.ToList();
        }
        public void InsertNewUser(User user)
        {
            _db.Users.Add(user);

            _db.SaveChangesAsync();
        }


    }
}
