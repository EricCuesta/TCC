using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class DiscountsBusiness
    {
        public void Inserir(Database.Entities.tb_discounts discounts)
        {
            Database.DiscountsDatabase DB = new Database.DiscountsDatabase();
            DB.Inserir(discounts);
        }

        public List<Database.Entities.tb_discounts> Consultar()
        {
            Database.DiscountsDatabase DB = new Database.DiscountsDatabase();
            List<Database.Entities.tb_discounts> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_discounts discounts)
        {
            Database.DiscountsDatabase DB = new Database.DiscountsDatabase();
            DB.Alterar(discounts);
        }

        public void Remover(int id)
        {
            Database.DiscountsDatabase DB = new Database.DiscountsDatabase();
            DB.Remover(id);
        }
    }
}
