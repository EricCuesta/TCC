using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class CPPDatabase
    {
        public void Inserir(Entities.tb_cpp cpp)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_cpp.Add(cpp);

            DB.SaveChanges();
        }

        public List<Entities.tb_cpp> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_cpp> list = DB.tb_cpp.ToList();

            return list;
        }

        public void Alterar(Entities.tb_cpp cpp)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_cpp list = DB.tb_cpp.First(t => t.id_cpp == cpp.id_cpp);
            list.vl_cpp = list.vl_cpp;
            list.vl_fgts = list.vl_fgts;
            
            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_cpp remover = DB.tb_cpp.First(t => t.id_cpp == id);

            DB.tb_cpp.Remove(remover);
            DB.SaveChanges();
        }
    }
}
