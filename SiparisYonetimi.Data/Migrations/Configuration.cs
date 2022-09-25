namespace SiparisYonetimi.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SiparisYonetimi.Data.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;//Otomatik migration özelliğini aç 
            AutomaticMigrationDataLossAllowed = true;//Migration işlemlerinde data kayıplarına izin ver 
        }

        protected override void Seed(DatabaseContext context)
        {
            //Bu metot veritabanı oluşturulduktan sonra çalışır ve tablolara örnek kayıt ekleyebilmemizi sağlar 
            if (!context.Users.Any())
            {
                context.Users.Add(new Entities.User // Yeni bir kullanıcı oluştur ve context'e ekle 
                {
                    CreateDate = DateTime.Now,
                    Email = "admin@SiparisYonetimi.net",
                    Id = 1,
                    IsActive=true,
                    IsAdmin=true,
                    Name="Admin",
                    Username="Admin",
                    Password="123"
                });
                context.SaveChanges();//Değişiklikleri veritabanına işle 
            }
        }
    }
}
