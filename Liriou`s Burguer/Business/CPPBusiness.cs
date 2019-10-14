using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class CPPBusiness
    {
        public void Inserir(Database.Entities.tb_cpp cpp)
        {
            Database.CPPDatabase DB = new Database.CPPDatabase();
            DB.Inserir(cpp);
        }

        public List<Database.Entities.tb_cpp> Consultar()
        {
            Database.CPPDatabase DB = new Database.CPPDatabase();
            List<Database.Entities.tb_cpp> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_cpp cpp)
        {
            Database.CPPDatabase DB = new Database.CPPDatabase();
            DB.Alterar(cpp);
        }

        public void Remover(int id)
        {
            Database.CPPDatabase DB = new Database.CPPDatabase();
            DB.Remover(id);
        }
    }
}
