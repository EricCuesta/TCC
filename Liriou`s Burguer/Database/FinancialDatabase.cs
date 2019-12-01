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
            try
            {
                Entities.tb_employees tb = DB.tb_employees.First(t => t.nr_rg == rg);

                return tb.id_emp;
            }
            catch (Exception)
            {
                throw new ArgumentException("Não foi possivel encontar o Funcionário!");
            }
        }

        public void Alterar(Entities.tb_financial fin)
        {
            Entities.tb_financial tb = DB.tb_financial.FirstOrDefault(t => t.id_emp == fin.id_emp);
            tb.vl_grossSalary = fin.vl_grossSalary;
            tb.vl_netSalary = fin.vl_netSalary;
            tb.ds_typeSalary = fin.ds_typeSalary;
            tb.dt_fromDate = fin.dt_fromDate;
            tb.dt_toDate = fin.dt_toDate;

            DB.SaveChanges();
        }

        public void Remover(Entities.tb_financial fin)
        {
            DB.tb_financial.Remove(fin);

            DB.SaveChanges();
        }

        public Entities.tb_financial ConsultarPorID(int id)
        {
            return DB.tb_financial.FirstOrDefault(t => t.id_emp == id);
        }
    }
}
