﻿using SiparisYonetimi.Data;
using SiparisYonetimi.Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Model;
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
        public List<User> GetAll(string kelime)
        {
            return context.Users.Where(user => user.Name.Contains(kelime)|| user.Surname.Contains(kelime)|| user.Email.Contains(kelime)).ToList();
        }
        public int Add(User user)
        {
            context.Users.Add(user);//Context e gelen user'ı ekliyor 
            return context.SaveChanges();
        }
        public User Find(int id)
        {
            return context.Users.Find(id);
        }
        public int Update(User user)
        {
            context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }
       
        public int Remove(User user)
        {
            context.Users.Remove(user);
            return context.SaveChanges();
        }
    }
}
