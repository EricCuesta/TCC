using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class SupplyBusiness
    {
        Database.SupplyDatabase db = new Database.SupplyDatabase();

        public void Inserir(Database.Entities.tb_supply supply)
        {
            if (supply.nm_supply == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (supply.vl_amount == 0)
                throw new ArgumentException("O campo quantidade deve ser preenchido");
            if (supply.vl_value == Convert.ToInt32("0,00"))
                throw new ArgumentException("O campo valor deve ser preenchido");

            db.Inserir(supply);
        }

        public Database.Entities.tb_supply ConsultarPorID(int id)
        {
            Database.SupplyDatabase dbsupply = new Database.SupplyDatabase();
            Database.Entities.tb_supply supply = dbsupply.ConsultaPorID(id);

            return supply;
        }

        public List<Database.Entities.tb_supply> Consultar(Database.Entities.tb_supply supply)
        {
            Database.SupplyDatabase dbsupply = new Database.SupplyDatabase();
            List<Database.Entities.tb_supply> list = new List<Database.Entities.tb_supply>();

            if (supply.nm_supply == string.Empty)
                list = dbsupply.ConsultarPorNome(supply);

            return list;
        }

        public List<Database.Entities.tb_supply> ConsultarTodos()
        {
            List<Database.Entities.tb_supply> list = db.ConsultarTodos();
            return list;
        }

        public void Alterar(Database.Entities.tb_supply supply)
        {
            if (supply.nm_supply == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (supply.vl_amount == 0)
                throw new ArgumentException("O campo quantidade deve ser preenchido");
            if (supply.vl_value == Convert.ToInt32("0,00"))
                throw new ArgumentException("O campo valor deve ser preenchido");
            db.Alterar(supply);
        }

        public void Deletar(int id)
        {
            db.Deletar(id);
        }
    }
}
