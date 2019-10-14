using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class ProductDatabase
    {
        public void Inserir(Entities.tb_product product)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_product.Add(product);

            DB.SaveChanges();
        }

        public List<Entities.tb_product> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_product> list = DB.tb_product.ToList();

            return list;
        }

        public void Alterar(Entities.tb_product product)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_product list = DB.tb_product.First(t => t.id_product == product.id_product);
            list.nm_product = list.nm_product;
            list.vl_amount = list.vl_amount;
            list.vl_value = list.vl_value;
            list.ds_Note = list.ds_Note;
            list.ds_type = list.ds_type;
            
            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_product remover = DB.tb_product.First(t => t.id_product == id);

            DB.tb_product.Remove(remover);
            DB.SaveChanges();
        }
    }
}
