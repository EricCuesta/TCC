using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class FinancialDatabase
    {
        public void Inserir(Entities.tb_financial financial)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_financial.Add(financial);

            DB.SaveChanges();
        }

        public Entities.tb_financial ConsultarFinancial(string rg)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_employees tb_employees = new Entities.tb_employees();

            Entities.tb_financial tb = DB.tb_financial.FirstOrDefault(t => tb_employees.ds_rg == rg);

            return tb;
        }

        public void Alterar(Entities.tb_financial financial)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_financial list = DB.tb_financial.First(t => t.id_salary == financial.id_salary);
            
            list.dt_fromDate = list.dt_fromDate;
            list.dt_toDate = list.dt_toDate;
            list.vl_grossSalary = list.vl_grossSalary;
            list.vl_netSalary = list.vl_netSalary;

            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_financial remover = DB.tb_financial.First(t => t.id_salary == id);

            DB.tb_financial.Remove(remover);
            DB.SaveChanges();
        }
    }
}
