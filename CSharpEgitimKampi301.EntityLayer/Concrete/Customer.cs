using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Customer // müşteri listesi de oluşturalım
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
    }
}

/* !!!!!! Her bir class ı, sadece o class ile ilgili olan propertylerle eşleştiriyoruz
* bunun da ismi Solid Prensipleri içerisinde Single Responsibility (Tek Sorumluluk İlkesi) olarak geçiyor.
*/