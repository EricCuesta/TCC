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

        public void Inserir(Database.Entities.tb_stock stock)
        {
            if (stock.ds_place == string.Empty)
                throw new ArgumentException("O campo lugar deve ser definido");
            if (stock.ds_typeStock == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (stock.nr_maxAmount == null)
                throw new ArgumentException("O campo quantidade máxima deve ser definido");

            db.Inserir(stock);
        }

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

        public void Alterar(Database.Entities.tb_stock stock)
        {
            if (stock.ds_place == string.Empty)
                throw new ArgumentException("O campo lugar deve ser definido");
            if (stock.ds_typeStock == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (stock.nr_maxAmount == null)
                throw new ArgumentException("O campo quantidade máxima deve ser definido");

            db.Alterar(stock);
        }

        public void Deletar(int id)
        {

            db.Deletar(id);
        }
    }
}
