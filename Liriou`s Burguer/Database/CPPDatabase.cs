using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class CPPDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_cpp cpp)
        {
            db.tb_cpp.Add(cpp);

            db.SaveChanges();
        }

        public List<Entities.tb_cpp> Consultar()
        {
            List<Entities.tb_cpp> list = db.tb_cpp.ToList();

            return list;
        }

        public void Alterar(Entities.tb_cpp cpp)
        {
            Entities.tb_cpp list = db.tb_cpp.First(t => t.id_cpp == cpp.id_cpp);
            list.vl_cpp = list.vl_cpp;
            list.vl_fgts = list.vl_fgts;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_cpp remover = db.tb_cpp.First(t => t.id_cpp == id);

            db.tb_cpp.Remove(remover);
            db.SaveChanges();
        }
    }
}
