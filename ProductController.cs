using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClassExample
{

    internal class ProductController : ICrud<Product>
    {
        public string Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Product Detail(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> List()
        {
            throw new NotImplementedException();
        }

        public string Update(Product entity, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
