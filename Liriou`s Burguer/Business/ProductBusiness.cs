using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class ProductBusiness
    {
        public void Inserir(Database.Entities.tb_product product)
        {
            Database.ProductDatabase DB = new Database.ProductDatabase();
            DB.Inserir(product);
        }

        public List<Database.Entities.tb_product> Consultar()
        {
            Database.ProductDatabase DB = new Database.ProductDatabase();
            List<Database.Entities.tb_product> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_product product)
        {
            Database.ProductDatabase DB = new Database.ProductDatabase();
            DB.Alterar(product);
        }

        public void Remover(int id)
        {
            Database.ProductDatabase DB = new Database.ProductDatabase();
            DB.Remover(id);
        }
    }
}
