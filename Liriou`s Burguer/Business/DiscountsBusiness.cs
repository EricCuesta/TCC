using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liriou_s_Burguer.Database.Entities;

namespace Liriou_s_Burguer.Business
{
    class DiscountsBusiness
    {
        Database.DiscountsDatabase db = new Database.DiscountsDatabase();

        public void insirir(tb_discounts dis, int id)
        {
            dis.id_emp = id;

            db.Inserir(dis);
        }

        public string VericarParametros(tb_discounts dis)
        {
            if (dis.vl_foodPension == Convert.ToDecimal(0.0) && Model.EmployeesModel.dependents != 0)
            {
                return "Pensão Alimentícia Obrigatória!";
            }

            return string.Empty;
        }

        public List<tb_discounts> Consultar()
        {
            List<tb_discounts> list = db.Consultar();
            return list;
        }

        public void Alterar(tb_discounts dis, int id)
        {
            dis.id_emp = id;

            db.Alterar(dis);
        }

        public tb_discounts ConsultarPorID(int id)
        {
            return db.ConsultarPorID(id);
        }

        public void Remover(tb_discounts dis)
        {
            db.Remover(dis);
        }
    }
}
