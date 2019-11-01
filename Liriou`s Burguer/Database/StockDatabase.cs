using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class StockDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public Entities.tb_stock ConsultaPorID(int id)
        {
            Entities.tb_stock stock = db.tb_stock.FirstOrDefault(t => t.id_stock == id);

            return stock;
        }

        public List<Entities.tb_stock> ConsultarTodos()
        {
            List<Entities.tb_stock> list = db.tb_stock.ToList();

            return list;
        }
    }
}
