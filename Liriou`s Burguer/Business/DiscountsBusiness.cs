using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class DiscountsBusiness
    {
        Database.DiscountsDatabase db = new Database.DiscountsDatabase();

        public void Inserir(Database.Entities.tb_discounts dis)
        {
            if (dis.vl_foodPension == Convert.ToDecimal(0.0) && dis.tb_employees.nr_dependents != 0)
            {
                throw new ArgumentException("Pensão Alimentícia Obrigatória!");
            }

            Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
            dis.id_emp = DB.InsertEmp(Model.EmployeesModel.CPF);

            db.Inserir(dis);
        }

        public List<Database.Entities.tb_discounts> Consultar()
        {
            List<Database.Entities.tb_discounts> list = db.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_discounts discounts)
        {
            db.Alterar(discounts);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
