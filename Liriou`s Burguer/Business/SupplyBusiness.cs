using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class SupplyBusiness
    {
        public void Inserir(Database.Entities.tb_supply supply)
        {
            Database.SupplyDatabase DB = new Database.SupplyDatabase();
            DB.Inserir(supply);
        }

        public List<Database.Entities.tb_supply> Consultar()
        {
            Database.SupplyDatabase DB = new Database.SupplyDatabase();
            List<Database.Entities.tb_supply> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_supply supply)
        {
            Database.SupplyDatabase DB = new Database.SupplyDatabase();
            DB.Alterar(supply);
        }

        public void Remover(int id)
        {
            Database.SupplyDatabase DB = new Database.SupplyDatabase();
            DB.Remover(id);
        }
    }
}
