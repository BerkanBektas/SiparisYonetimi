using SiparisYonetimi.Entities;
using System.ComponentModel;
using System.Data.Entity;//Bu kötüphane entity framework paketinden geliyor 

namespace SiparisYonetimi.Data
{
    public class DatabaseContext :DbContext // Burada Entity framework'ün DbContext sınıfından miras alıyoruz DataBaseContext sınıfından dbcontext'leri kullanabilmek için
    {
        public DatabaseContext()
        {
             
        }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products  { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
/*
 * Proje yaparken classları ve database contexti kurduktan sonra veritabanını otomatik oluşturmak yerine migrationla oluşturmanız gerekir
 * Migration'u aktif etmek için visual studio'da en üst menüden Tools > Nuget pack... Manager > Package manage console menüsü aktif ediyoruz. Aşağıdaki pmc alanını açıyoruz 
 * Önce default project bölümünden database context imizin bulunduğu data katmanını seçiyoruz
 * Sonra  aşağıdaki kod alanına Enable-migrations yazıp enter a basarak Initialcreate class'ının oluşturulmasını sağlıyoruz 
 * Oluşan Confriguration sınıfının içerisinde başlangıç verisi oluşturabileceğimiz seed metodu oluşuyor bunu kullanarak veritabanı oluştuktan sonra örnek data oluşturabiliriz 
 * Eğer enable-migrations tan sonra initial create classı oluşmazsa pmc komut ekranına add-migration InitialCreate yazıp enter a basarak kendimiz oluşturabilir
 * 
 */ 

