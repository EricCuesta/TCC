using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class BankAccountDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_benefits benefits)
        {
            db.tb_benefits.Add(benefits);

            db.SaveChanges();
        }

        public List<Entities.tb_benefits> Consultar()
        {
            List<Entities.tb_benefits> list = db.tb_benefits.ToList();

            return list;
        }

        public void Alterar(Entities.tb_benefits benefits)
        {
            Entities.tb_benefits list = db.tb_benefits.First(t => t.id_benefits == benefits.id_benefits);

            list.bt_food = list.bt_food;
            list.bt_lifeSafe = list.bt_lifeSafe;
            list.bt_meal = list.bt_meal;
            list.bt_planHealth = list.bt_planHealth;
            list.bt_transport = list.bt_transport;
            list.bt_planDental = list.bt_planDental;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_benefits remover = db.tb_benefits.First(t => t.id_benefits == id);

            db.tb_benefits.Remove(remover);
            db.SaveChanges();
        }
    }
}
