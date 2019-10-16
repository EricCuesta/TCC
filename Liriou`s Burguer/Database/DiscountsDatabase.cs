using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class DiscountsDatabase
    {
        public void Inserir(Entities.tb_discounts discounts)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_discounts.Add(discounts);

            DB.SaveChanges();
        }

        public List<Entities.tb_discounts> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_discounts> list = DB.tb_discounts.ToList();

            return list;
        }

        public void Alterar(Entities.tb_discounts discounts)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_discounts list = DB.tb_discounts.First(t => t.id_discounts == discounts.id_discounts);
            list.vl_fgts = list.vl_fgts;
            list.vl_incomeTax = list.vl_incomeTax;
            list.vl_inss = list.vl_inss;
           
            
            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_discounts remover = DB.tb_discounts.First(t => t.id_discounts == id);

            DB.tb_discounts.Remove(remover);
            DB.SaveChanges();
        }
    }
}
