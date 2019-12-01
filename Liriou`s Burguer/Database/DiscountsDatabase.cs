using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class DiscountsDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_discounts dis)
        {
            db.tb_discounts.Add(dis);

            db.SaveChanges();
        }

        public List<Entities.tb_discounts> Consultar()
        {
            List<Entities.tb_discounts> list = db.tb_discounts.ToList();

            return list;
        }

        public void Alterar(Entities.tb_discounts dis)
        {
            Entities.tb_discounts tb = db.tb_discounts.FirstOrDefault(t => t.id_emp == dis.id_emp);
            tb.vl_foodPension = dis.vl_foodPension;

            db.SaveChanges();
        }

        public void Remover(Entities.tb_discounts dis)
        {
            db.tb_discounts.Remove(dis);

            db.SaveChanges();
        }

        public Entities.tb_discounts ConsultarPorID(int id)
        {
            return db.tb_discounts.FirstOrDefault(t => t.id_emp == id);
        }
    }
}
