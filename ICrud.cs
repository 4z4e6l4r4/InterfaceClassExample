using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClassExample
{
    //entity aslında bir parametre
    interface ICrud<Entity>
    {
        //interface ayrı bir class türü içinde metot yazmıyorsun
        public string Add(Entity entity);
        public string Update(Entity entity, int Id);
        public bool Delete(int Id);
        public List<Entity> List();
        //ya da liste dizisini döndür: public string[] List();
        public Entity Detail(int Id);
    }
}
