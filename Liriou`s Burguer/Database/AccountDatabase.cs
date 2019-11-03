using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class AccountDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_account account)
        {
            db.tb_account.Add(account);

            db.SaveChanges();
        }

        public Entities.tb_account ConsultaPorID(int id)
        {
            Entities.tb_account account = db.tb_account.FirstOrDefault(t => t.id_account == id);

            return account;
        }

        public List<Entities.tb_account> ConsultarPorNome(Entities.tb_account account)
        {
            List<Entities.tb_account> list = db.tb_account.Where(l => l.nm_account == account.nm_account).ToList();

            return list;
        }

        public List<Entities.tb_account> ConsultarPorIdentificação(Entities.tb_account account)
        {
            List<Entities.tb_account> list = db.tb_account.Where(l => l.nr_identification == account.nr_identification).ToList();

            return list;
        }

        public List<Entities.tb_account> ConsultarTodos()
        {
            List<Entities.tb_account> list = db.tb_account.ToList();

            return list;
        }

        public void Alterar(Entities.tb_account account)
        {
            Entities.tb_account list = db.tb_account.FirstOrDefault(t => t.id_account == account.id_account);
            list.nm_account = account.nm_account;
            list.nr_identification = account.nr_identification;
            list.vl_value = account.vl_value;
            list.ds_note = account.ds_note;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_account account = db.tb_account.First(t => t.id_account == id);

            db.tb_account.Remove(account);
            db.SaveChanges();
        }
    }
}
