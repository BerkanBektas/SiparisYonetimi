using SiparisYonetimi.Data;
using SiparisYonetimi.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SiparisYonetimi.Business.Managers
{
    public class UserManager
    {
        DatabaseContext context = new DatabaseContext();
        public List<User> GetAll()
        {
            return context.Users.ToList();
        }
    }
}
