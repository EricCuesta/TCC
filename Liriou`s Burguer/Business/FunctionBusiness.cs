using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class FunctionBusiness
    {
        public void Inserir(Database.Entities.tb_function function)
        {
            Database.FunctionDatabase DB = new Database.FunctionDatabase();
            DB.Inserir(function);
        }

        public List<Database.Entities.tb_function> Consultar()
        {
            Database.FunctionDatabase DB = new Database.FunctionDatabase();
            List<Database.Entities.tb_function> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_function function)
        {
            Database.FunctionDatabase DB = new Database.FunctionDatabase();
            DB.Alterar(function);
        }

        public void Remover(int id)
        {
            Database.FunctionDatabase DB = new Database.FunctionDatabase();
            DB.Remover(id);
        }
    }
}
