using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class StockBusiness
    {
        public void Inserir(Database.Entities.tb_stock stock)
        {
            Database.StockDatabase DB = new Database.StockDatabase();
            DB.Inserir(stock);
        }

        public List<Database.Entities.tb_stock> Consultar()
        {
            Database.StockDatabase DB = new Database.StockDatabase();
            List<Database.Entities.tb_stock> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_stock stock)
        {
            Database.StockDatabase DB = new Database.StockDatabase();
            DB.Alterar(stock);
        }

        public void Remover(int id)
        {
            Database.StockDatabase DB = new Database.StockDatabase();
            DB.Remover(id);
        }
    }
}
