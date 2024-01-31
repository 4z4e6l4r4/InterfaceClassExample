using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClassExample
{
    internal class UserController : ICrud<User>
    {
        public string Add(User entity)
        {
            string email = "xxxttt@gmail.com";

            if (email.ToLower() != entity.Email.ToLower())
            {
                return "Ekleme Başarılı";
            }
            else
            {
                return "Ekleme Başarısız";
            }
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public User Detail(int Id)
        {
            throw new NotImplementedException();
        }

        public List<User> List()
        {
            throw new NotImplementedException();
        }

        public string Update(User entity, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
