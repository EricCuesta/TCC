using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class BankAccountBusiness
    {
        Database.BankAccountDatabase db = new Database.BankAccountDatabase();

        public void Inserir(Database.Entities.tb_bankaccount bank)
        {
            db.Inserir(bank);
        }
    }
}
