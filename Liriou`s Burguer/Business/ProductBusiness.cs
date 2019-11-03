using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class ProductBusiness
    {
        Database.ProductDatabase db = new Database.ProductDatabase();

        public void Inserir(Database.Entities.tb_product product)
        {
            if (product.nm_product == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (product.ds_typeProduct == null)
                throw new ArgumentException("O campo tipo deve ser definido");
            if (product.ds_placeStock == string.Empty)
                throw new ArgumentException("O campo descrição do estoque deve ser definido");
            if (product.vl_amount == 0)
                throw new ArgumentException("O campo quantidade deve ser preenchido");
            if (product.vl_value == Convert.ToDecimal("0,00"))
                throw new ArgumentException("O campo valor deve ser preenchido");

            db.Inserir(product);
        }

        public Database.Entities.tb_product ConsultarPorID(int id)
        {
            Database.Entities.tb_product product = db.ConsultaPorID(id);

            return product;
        }

        public List<Database.Entities.tb_product> Consultar(Database.Entities.tb_product product)
        {
            List<Database.Entities.tb_product> list = new List<Database.Entities.tb_product>();

            if (product.ds_typeProduct == string.Empty)
                list = db.ConsultarPorNome(product);
            else if (product.nm_product == string.Empty)
                list = db.ConsultarPorTipo(product);

            return list;
        }

        public List<Database.Entities.tb_product> ConsultarTodos()
        {
            List<Database.Entities.tb_product> list = db.ConsultarTodos();
            return list;
        }

        public void Alterar(Database.Entities.tb_product product)
        {
            if (product.nm_product == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (product.ds_typeProduct == null)
                throw new ArgumentException("O campo tipo deve ser definido");
            if (product.ds_placeStock == string.Empty)
                throw new ArgumentException("O campo descrição do estoque deve ser definido");
            if (product.vl_amount == 0)
                throw new ArgumentException("O campo quantidade deve ser preenchido");
            if (product.vl_value == Convert.ToDecimal("0,00"))
                throw new ArgumentException("O campo valor deve ser preenchido");

            db.Alterar(product);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
