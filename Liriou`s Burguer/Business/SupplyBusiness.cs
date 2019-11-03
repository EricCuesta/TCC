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
            if (supply.vl_value == Convert.ToDecimal("0,00"))
                throw new ArgumentException("O campo valor deve ser preenchido");

            db.Inserir(supply);
        }

        public Database.Entities.tb_supply ConsultarPorID(int id)
        {
            Database.Entities.tb_supply supply = db.ConsultaPorID(id);

            return supply;
        }

        public List<Database.Entities.tb_supply> Consultar(Database.Entities.tb_supply supply)
        {
            List<Database.Entities.tb_supply> list = new List<Database.Entities.tb_supply>();

            list = db.ConsultarPorNome(supply);

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
            if (supply.vl_value == Convert.ToDecimal("0,00"))
                throw new ArgumentException("O campo valor deve ser preenchido");
            db.Alterar(supply);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
