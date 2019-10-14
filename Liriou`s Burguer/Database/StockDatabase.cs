using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class StockDatabase
    {
        public void Inserir(Entities.tb_stock stock)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_stock.Add(stock);

            DB.SaveChanges();
        }

        public List<Entities.tb_stock> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_stock> list = DB.tb_stock.ToList();

            return list;
        }

        public void Alterar(Entities.tb_stock stock)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_stock list = DB.tb_stock.First(t => t.id_stock == stock.id_stock);
            list.ds_place = list.ds_place;
            list.vl_qtdProduct = list.vl_qtdProduct;
            list.vl_qtdSupply = list.vl_qtdSupply;
            
            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_stock remover = DB.tb_stock.First(t => t.id_stock == id);

            DB.tb_stock.Remove(remover);
            DB.SaveChanges();
        }
    }
}
