using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class FunctionBusiness
    {
        Database.FunctionDatabase db = new Database.FunctionDatabase();

        public void Inserir(Database.Entities.tb_function function)
        {
            db.Inserir(function);
        }

        public Database.Entities.tb_function ConsultarPorID(int id)
        {
            Database.FunctionDatabase dbfunction = new Database.FunctionDatabase();
            Database.Entities.tb_function function = dbfunction.ConsultaPorID(id);

            return function;
        }

        public List<Database.Entities.tb_function> Consultar(Database.Entities.tb_function function)
        {
            Database.FunctionDatabase dbfunction = new Database.FunctionDatabase();
            List<Database.Entities.tb_function> list = new List<Database.Entities.tb_function>();

            list = dbfunction.ConsultarPorNome(function);

            return list;
        }

        public List<Database.Entities.tb_function> ConsultarTodos()
        {
            List<Database.Entities.tb_function> list = db.ConsultarTodos();
            return list;
        }

        public void Alterar(Database.Entities.tb_function function)
        {
            db.Alterar(function);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
