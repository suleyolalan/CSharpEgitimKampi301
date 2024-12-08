using CSharpEgitimKampi301.BusinnessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinnessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _customerDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _customerDal = categoryDal;
        }

        public void TDelete(Category entity)
        {
           
        }
        public List<Category> TGetAll()
        {
            throw new NotImplementedException();
        }
        public Category TGetById(int id)
        {
            throw new NotImplementedException();
        }
        public void TInsert(Category entity)
        {
            throw new NotImplementedException();
        }
        public void TUpdate(Category entity)
        {
            throw new NotImplementedException();
        }
    }

}
