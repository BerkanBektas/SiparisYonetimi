using SiparisYonetimi.Business.Repositories;
using SiparisYonetimi.Entities;
using System;
using Umbraco.Core.Composing.CompositionExtensions;

namespace SiparisYonetimi.Business.Managers
{
    public class BrandManager : Repository<Brand>//Repository classından miras aldık böylece içindeki tüm metotları brand clas'ı için kullanabileceğiz
    {
        //Burada markaya özel metotlar yazılabilir, örneğin markaya ait ürünleri listeleyen metot gibi 
       
    }
}
