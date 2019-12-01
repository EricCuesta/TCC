using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class BenefitsDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_benefits ben)
        {
            db.tb_benefits.Add(ben);

            db.SaveChanges();
        }

        public List<Entities.tb_benefits> Consultar()
        {
            List<Entities.tb_benefits> list = db.tb_benefits.ToList();

            return list;
        }

        public void Alterar(Entities.tb_benefits ben)
        {
            Entities.tb_benefits tb = db.tb_benefits.First(t => t.id_emp == ben.id_emp);
            tb.bt_transport = ben.bt_transport;
            tb.bt_food = ben.bt_food;
            tb.bt_meal = ben.bt_meal;
            tb.bt_lifeSafe = ben.bt_lifeSafe;
            tb.bt_planHealth = ben.bt_planHealth;
            tb.bt_planDental = ben.bt_planDental;
            tb.vl_transport = ben.vl_transport;
            tb.vl_food = ben.vl_food;
            tb.vl_meal = ben.vl_meal;
            tb.vl_lifeSafe = ben.vl_lifeSafe;
            tb.vl_planHealth = ben.vl_planHealth;
            tb.vl_planDental = ben.vl_planDental;

            db.SaveChanges();
        }

        public void Remover(Entities.tb_benefits ben)
        {
            db.tb_benefits.Remove(ben);

            db.SaveChanges();
        }

        public Entities.tb_benefits ConsultarPorID(int id)
        {
            return db.tb_benefits.FirstOrDefault(t => t.id_emp == id);
        }
    }
}
