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
            list.vl_familySalary = list.vl_familySalary;
            list.vl_food = list.vl_food;
            list.vl_lifeInsurance = list.vl_lifeInsurance;
            list.vl_meal = list.vl_meal;
            list.vl_planHealth = list.vl_planHealth;
            list.vl_transport = list.vl_transport;

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
