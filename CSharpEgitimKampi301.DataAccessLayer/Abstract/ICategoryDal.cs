using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category> // burda IGenericDal yazdık dedik ki sen burdan miras alacaksın. Kim için alacak? Category sınıfı için dedik
    {
    }
}
