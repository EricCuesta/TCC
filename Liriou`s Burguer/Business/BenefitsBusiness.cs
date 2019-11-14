using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class BenefitsBusiness
    {
        Database.BenefitsDatabase db = new Database.BenefitsDatabase();

        public void Inserir(Database.Entities.tb_benefits ben)
        {
            if (ben.bt_food == true && ben.vl_food == Convert.ToDecimal(0.0))
            {
                throw new ArgumentException("Insira um valor em Vale Alimentação!");
            }
            if (ben.bt_transport == true && ben.vl_transport == Convert.ToDecimal(0.0))
            {
                throw new ArgumentException("Insira um valor em Vale Transporte!");
            }
            if (ben.bt_meal == true && ben.vl_meal == Convert.ToDecimal(0.0))
            {
                throw new ArgumentException("Insira um valor em Vale Refeição!");
            }
            if (ben.bt_lifeSafe == true && ben.vl_lifeSafe == Convert.ToDecimal(0.0))
            {
                throw new ArgumentException("Insira um valor em Seguro de Vida!");
            }
            if (ben.bt_planDental == true && ben.vl_planDental == Convert.ToDecimal(0.0))
            {
                throw new ArgumentException("Insira um valor em Plano Odontológico!");
            }
            if (ben.bt_planHealth == true && ben.vl_planHealth == Convert.ToDecimal(0.0))
            {
                throw new ArgumentException("Insira um valor em Plano de Saúde!");
            }

            Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
            ben.id_emp = DB.InsertEmp(Model.EmployeesModel.CPF);

            db.Inserir(ben);
        }

        public List<Database.Entities.tb_benefits> Consultar()
        {
            List<Database.Entities.tb_benefits> list = db.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_benefits benefits)
        {
            db.Alterar(benefits);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
