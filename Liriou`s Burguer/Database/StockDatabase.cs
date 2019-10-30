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

        public void Inserir(Entities.tb_stock stock)
        {
            db.tb_stock.Add(stock);

            db.SaveChanges();
        }

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

        public void Alterar(Entities.tb_stock stock)
        {
            Entities.tb_stock list = db.tb_stock.FirstOrDefault(t => t.id_stock == stock.id_stock);
            list.ds_place = stock.ds_place;
            list.ds_typeStock = stock.ds_typeStock;
            list.nr_maxAmount = stock.nr_maxAmount;
            
            db.SaveChanges();
        }

        public void Deletar(int id)
        {
            Entities.tb_stock stock = db.tb_stock.First(t => t.id_stock == id);

            db.tb_stock.Remove(stock);
            db.SaveChanges();
        }
    }
}
