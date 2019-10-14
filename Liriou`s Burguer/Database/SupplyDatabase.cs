using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class SupplyDatabase
    {

        public void Inserir(Entities.tb_supply supply)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_supply.Add(supply);

            DB.SaveChanges();
        }

        public List<Entities.tb_supply> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_supply> list = DB.tb_supply.ToList();

            return list;
        }

        public void Alterar(Entities.tb_supply supply)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_supply list = DB.tb_supply.First(t => t.id_supply == supply.id_supply);
            list.nm_supply = list.nm_supply;
            list.vl_amount = list.vl_amount;
            list.vl_value = list.vl_value;
            list.ds_Note = list.ds_Note;
            
            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_supply remover = DB.tb_supply.First(t => t.id_supply == id);

            DB.tb_supply.Remove(remover);
            DB.SaveChanges();
        }
    }
}
