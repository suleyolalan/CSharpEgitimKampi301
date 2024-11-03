using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Field-Variable-Property önemli ifadeler
 * Field: Class ın içinde direkt olarak tanımlanırsa (mesela int x;)   
 * Property: Class ın içinde get ve set olarak tanımlanırsa ( int y {get; set;} )
 * Variable: Metot içinde tanımlanırsa değişken diyoruz ( void () { int z;} )
 */

/* get ve set'ten bahsedelim
 * get : almak. Mesela Kategori adı her zaman büyük harfle gelsin diyebiliriz
 * set : ayarlamak. Eğer kategori adı beş harften oluşuyorsa şu şu olsun tarzında kurallar koyabiliriz
 */


namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; } // otomatik yazmak için prop yazıp tab tuşuna bastık
        //kod first yaklaşımı için otomatik artan olduğunu bildirmek adına sınıfın ismi birebir aynı yazılıp sonuna Id eklenmeli
        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

    }
}

