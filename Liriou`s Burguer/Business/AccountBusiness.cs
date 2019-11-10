using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class AccountBusiness
    {
        Database.AccountDatabase db = new Database.AccountDatabase();

        public void Inserir(Database.Entities.tb_account account)
        {
            if (account.nm_account == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (account.nr_identification == string.Empty)
                throw new ArgumentException("O campo identificação deve ser definido");
            if (account.vl_value == Convert.ToDecimal("0,00"))
                throw new ArgumentException("O campo quantidade deve ser preenchido");

            db.Inserir(account);
        }

        public Database.Entities.tb_account ConsultarPorID(int id)
        {
            Database.Entities.tb_account account = db.ConsultaPorID(id);

            return account;
        }

        public List<Database.Entities.tb_account> Consultar(Database.Entities.tb_account account)
        {
            List<Database.Entities.tb_account> list = new List<Database.Entities.tb_account>();

            if (account.nm_account != null && account.nr_identification == "-")
                list = db.ConsultarPorNome(account);
            else if (account.nm_account == null || account.nm_account == string.Empty && account.nr_identification != "-")
                list = db.ConsultarPorIdentificação(account);
            else if (account.nm_account != null && account.nr_identification != "-")
                list = db.ConsultarPorNomeIdentificação(account);

            return list;
        }

        public List<Database.Entities.tb_account> ConsultarTodos()
        {
            List<Database.Entities.tb_account> list = db.ConsultarTodos();
            return list;
        }

        public void Alterar(Database.Entities.tb_account account)
        {
            if (account.nm_account == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (account.nr_identification == string.Empty)
                throw new ArgumentException("O campo identificação deve ser definido");
            if (account.vl_value == Convert.ToDecimal("0,00"))
                throw new ArgumentException("O campo quantidade deve ser preenchido");

            db.Alterar(account);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
