using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class BankAccountDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_bankaccount bank)
        {
            db.tb_bankaccount.Add(bank);

            db.SaveChanges();
        }
    }
}
