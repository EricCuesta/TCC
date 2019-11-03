using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class DiscountsBusiness
    {
        Database.DiscountsDatabase db = new Database.DiscountsDatabase();

        public void Inserir(Database.Entities.tb_discounts discounts)
        {
            db.Inserir(discounts);
        }

        public List<Database.Entities.tb_discounts> Consultar()
        {
            List<Database.Entities.tb_discounts> list = db.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_discounts discounts)
        {
            db.Alterar(discounts);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
