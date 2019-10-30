using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class ProductDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_product product)
        {
            db.tb_product.Add(product);

            db.SaveChanges();
        }

        public Entities.tb_product ConsultaPorID(int id)
        {
            Entities.tb_product product = db.tb_product.FirstOrDefault(t => t.id_product == id);

            return product;
        }

        public List<Entities.tb_product> ConsultarPorNome(Entities.tb_product product)
        {
            List<Entities.tb_product> list = db.tb_product.Where(l => l.nm_product == product.nm_product).ToList();

            return list;
        }

        public List<Entities.tb_product> ConsultarPorTipo(Entities.tb_product product)
        {
            List<Entities.tb_product> list = db.tb_product.Where(l => l.ds_typeProduct == product.ds_typeProduct).ToList();

            return list;
        }

        public List<Entities.tb_product> ConsultarTodos()
        {
            List<Entities.tb_product> list = db.tb_product.ToList();

            return list;
        }

        public void Alterar(Entities.tb_product product)
        {
            Entities.tb_product list = db.tb_product.FirstOrDefault(t => t.id_product == product.id_product);
            list.ds_typeStock = product.ds_typeStock;
            list.nm_product = product.nm_product;
            list.ds_typeProduct = product.ds_typeProduct;
            list.vl_amount = product.vl_amount;
            list.vl_value = product.vl_value;
            list.ds_note = product.ds_note;

            db.SaveChanges();
        }

        public void Deletar(int id)
        {
            Entities.tb_product product = db.tb_product.First(t => t.id_product == id);

            db.tb_product.Remove(product);
            db.SaveChanges();
        }
    }
}
