using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class FunctionDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_function function)
        {
            db.tb_function.Add(function);

            db.SaveChanges();
        }

        public Entities.tb_function ConsultaPorID(int id)
        {
            Entities.tb_function function = db.tb_function.FirstOrDefault(t => t.id_function == id);

            return function;
        }

        public List<Entities.tb_function> ConsultarPorNome(Entities.tb_function function)
        {
            List<Entities.tb_function> list = db.tb_function.Where(l => l.nm_function == function.nm_function).ToList();

            return list;
        }

        public List<Entities.tb_function> ConsultarTodos()
        {
            List<Entities.tb_function> list = db.tb_function.ToList();

            return list;
        }

        public void Alterar(Entities.tb_function function)
        {
            Entities.tb_function list = db.tb_function.First(t => t.id_function == function.id_function);
          
            list.nm_function = list.nm_function;
            
            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_function remover = db.tb_function.First(t => t.id_function == id);

            db.tb_function.Remove(remover);
            db.SaveChanges();
        }
    }
}
