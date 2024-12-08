using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinnessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        //Ayırt ermesi kolay olsun diye başlarına T harfi yerleştirdik T olanlar business katmanı oluyor.
        void TInsert(T entity); 
        void TUpdate(T entity); 
        void TDelete(T entity); 
        List<T> TGetAll(); 
        T TGetById(int id); 
    }
}
