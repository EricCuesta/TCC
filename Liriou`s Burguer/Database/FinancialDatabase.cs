using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class FinancialDatabase
    {
        Entities.liriousdbEntities DB = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_financial financial)
        {
            DB.tb_financial.Add(financial);

            DB.SaveChanges();
        }

        public int Consultar(string rg)
        {
            Entities.tb_employees tb = DB.tb_employees.First(t => t.nr_rg == rg);

            return tb.id_emp;
        }

        public void Alterar(Entities.tb_financial financial)
        {
            Entities.tb_financial list = DB.tb_financial.First(t => t.id_salary == financial.id_salary);

            list.dt_fromDate = list.dt_fromDate;
            list.dt_toDate = list.dt_toDate;
            list.vl_grossSalary = list.vl_grossSalary;
            list.vl_netSalary = list.vl_netSalary;

            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_financial remover = DB.tb_financial.First(t => t.id_salary == id);

            DB.tb_financial.Remove(remover);
            DB.SaveChanges();
        }
    }
}
