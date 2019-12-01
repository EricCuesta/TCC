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

        public Entities.tb_bankaccount ConsultarPorID(int id)
        {
            return db.tb_bankaccount.FirstOrDefault(t => t.id_emp == id);
        }

        public void Alterar(Entities.tb_bankaccount bank)
        {
            Entities.tb_bankaccount tb = db.tb_bankaccount.FirstOrDefault(t => t.id_emp == bank.id_emp);
            tb.nm_bank = bank.nm_bank;
            tb.nr_account = bank.nr_account;
            tb.nr_agency = bank.nr_agency;
            tb.ds_typePerson = bank.ds_typePerson;

            db.SaveChanges();
        }

        public void Remover(Entities.tb_bankaccount bank)
        {
            db.tb_bankaccount.Remove(bank);

            db.SaveChanges();
        }
    }
}
