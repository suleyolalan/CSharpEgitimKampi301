using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product //ürünlerimiz için ihtiyaç olunan propertyleri yazalım
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; } //Her bir ütünün kategorisi olacak o yüzden kategori Id ekledik
        public virtual Category Category { get; set; } // kategori tablosunun değerlerine ürün üzerinden ulaşabilmek için de bu satırı eklemiş olduk
        public List<Order> Orders { get; set; }
    }
}
