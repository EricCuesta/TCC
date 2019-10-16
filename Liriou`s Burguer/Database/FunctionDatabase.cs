using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class FunctionDatabase
    {
        public void Inserir(Entities.tb_function function)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_function.Add(function);

            DB.SaveChanges();
        }

        public List<Entities.tb_function> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_function> list = DB.tb_function.ToList();

            return list;
        }

        public void Alterar(Entities.tb_function function)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_function list = DB.tb_function.First(t => t.id_function == function.id_function);
          
            list.nm_function = list.nm_function;
            
            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_function remover = DB.tb_function.First(t => t.id_function == id);

            DB.tb_function.Remove(remover);
            DB.SaveChanges();
        }
    }
}
