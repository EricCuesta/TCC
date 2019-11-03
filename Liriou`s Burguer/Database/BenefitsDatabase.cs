using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class BenefitsDatabase
    {
        public void Inserir(Entities.tb_benefits benefits)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_benefits.Add(benefits);

            DB.SaveChanges();
        }

        public List<Entities.tb_benefits> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_benefits> list = DB.tb_benefits.ToList();

            return list;
        }

        public void Alterar(Entities.tb_benefits benefits)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_benefits list = DB.tb_benefits.First(t => t.id_benefits == benefits.id_benefits);
           
            list.bt_food = list.bt_food;
            list.bt_lifeSafe = list.bt_lifeSafe;
            list.bt_meal = list.bt_meal;
            list.bt_planHealth = list.bt_planHealth;
            list.bt_transport = list.bt_transport;
            list.bt_planDental = list.bt_planDental;

            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_benefits remover = DB.tb_benefits.First(t => t.id_benefits == id);

            DB.tb_benefits.Remove(remover);
            DB.SaveChanges();
        }
    }
}
