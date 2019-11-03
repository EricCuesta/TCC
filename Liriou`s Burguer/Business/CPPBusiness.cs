using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class CPPBusiness
    {
        Database.CPPDatabase db = new Database.CPPDatabase();

        public void Inserir(Database.Entities.tb_cpp cpp)
        {
            db.Inserir(cpp);
        }

        public List<Database.Entities.tb_cpp> Consultar()
        {
            List<Database.Entities.tb_cpp> list = db.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_cpp cpp)
        {
            db.Alterar(cpp);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
