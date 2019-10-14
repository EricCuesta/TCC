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

        public List<Entities.tb_financial> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_financial> list = DB.tb_financial.ToList();

            return list;
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
