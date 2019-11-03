using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class FinancialDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_financial financial)
        {
            db.tb_financial.Add(financial);

            db.SaveChanges();
        }

        public int Consultar(string rg)
        {
            Entities.tb_employees tb = db.tb_employees.FirstOrDefault(t => t.nr_rg == rg);

            return tb.id_emp;
        }

        public void Alterar(Entities.tb_financial financial)
        {
            Entities.tb_financial list = db.tb_financial.First(t => t.id_salary == financial.id_salary);
            
            list.dt_fromDate = list.dt_fromDate;
            list.dt_toDate = list.dt_toDate;
            list.vl_grossSalary = list.vl_grossSalary;
            list.vl_netSalary = list.vl_netSalary;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_financial remover = db.tb_financial.First(t => t.id_salary == id);

            db.tb_financial.Remove(remover);
            db.SaveChanges();
        }
    }
}
