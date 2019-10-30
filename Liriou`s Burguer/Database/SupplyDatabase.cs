using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class SupplyDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_supply supply)
        {
            db.tb_supply.Add(supply);

            db.SaveChanges();
        }

        public Entities.tb_supply ConsultaPorID(int id)
        {
            Entities.tb_supply supply = db.tb_supply.FirstOrDefault(t => t.id_supply == id);

            return supply;
        }

        public List<Entities.tb_supply> ConsultarPorNome(Entities.tb_supply supply)
        {
            List<Entities.tb_supply> list = db.tb_supply.Where(l => l.nm_supply == supply.nm_supply).ToList();

            return list;
        }

        public List<Entities.tb_supply> ConsultarTodos()
        {
            List<Entities.tb_supply> list = db.tb_supply.ToList();

            return list;
        }

        public void Alterar(Entities.tb_supply supply)
        {
            Entities.tb_supply list = db.tb_supply.FirstOrDefault(t => t.id_supply == supply.id_supply);
            list.ds_typeStock = supply.ds_typeStock;
            list.nm_supply = supply.nm_supply;
            list.vl_amount = supply.vl_amount;
            list.vl_value = supply.vl_value;
            list.ds_note = supply.ds_note;
        }

        public void Deletar(int id)
        {
            Entities.tb_supply supply = db.tb_supply.First(t => t.id_supply == id);

            db.tb_supply.Remove(supply);
            db.SaveChanges();
        }
    }
}
