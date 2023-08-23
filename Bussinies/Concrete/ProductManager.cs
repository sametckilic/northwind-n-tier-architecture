using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
