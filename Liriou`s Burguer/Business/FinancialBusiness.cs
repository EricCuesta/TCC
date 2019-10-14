using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class FinancialBusiness
    {
        public void Inserir(Database.Entities.tb_financial financial)
        {
            Database.FinancialDatabase DB = new Database.FinancialDatabase();
            DB.Inserir(financial);
        }

        public List<Database.Entities.tb_financial> Consultar()
        {
            Database.FinancialDatabase DB = new Database.FinancialDatabase();
            List<Database.Entities.tb_financial> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_financial financial)
        {
            Database.FinancialDatabase DB = new Database.FinancialDatabase();
            DB.Alterar(financial);
        }

        public void Remover(int id)
        {
            Database.FinancialDatabase DB = new Database.FinancialDatabase();
            DB.Remover(id);
        }
    }
}
