using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class StockBusiness
    {
        Database.StockDatabase db = new Database.StockDatabase();

        public Database.Entities.tb_stock ConsultarPorID(int id)
        {
            Database.StockDatabase dbstock = new Database.StockDatabase();
            Database.Entities.tb_stock stock = dbstock.ConsultaPorID(id);

            return stock;
        }

        public List<Database.Entities.tb_stock> ConsultarTodos()
        {

            List<Database.Entities.tb_stock> list = db.ConsultarTodos();
            return list;
        }
    }
}
