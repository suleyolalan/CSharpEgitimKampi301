using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T entity); // T türünde bir entity parametresii alıyoruz
        void Update(T entity); // T değeri sıraısyla customer,category,order,product entitylerini alsın
        void Delete(int id); // Delete için dışarıdan id gönderiyoruz ve bu İd'ye göre işlem yapacağız
        List<T> GetAll(); // Bütün verileri getirecek olan GetAll metodu tanımladık
        T GetById(int id); // T türünde GetById isminde dışarıdan int id parametresi alan bir mett oluşturduk

    }
}
// Mesela ben sadece kategori sayısını ekrana getirmek isteyebilrim
// veya kategoriler içerisinde durumu true olan verileri getirmek isteyebilirim
// veya kategoriler içerisinde A harfi ile başlayan kategorileri getirmek isteyebilirim 
// işte bunlar için ne yapacağım ???
// o zaman devreye girecek olan yapı ""entity' ye özgü metot yazılan yapı"" olacak
// bunun için de benim her bir entity'mize tek tek GenericDal'la haberleştirmem lazım