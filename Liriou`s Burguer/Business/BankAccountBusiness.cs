using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liriou_s_Burguer.Database.Entities;

namespace Liriou_s_Burguer.Business
{
    class BankAccountBusiness
    {
        Database.BankAccountDatabase db = new Database.BankAccountDatabase();

        public void Insirir(tb_bankaccount bank, int id)
        {
            bank.id_emp = id;

            db.Inserir(bank);
        }

        public string VericarParametros(tb_bankaccount bank)
        {
            if (bank.nm_bank == string.Empty)
            {
                return "Nome do Banco Obrigatório!";
            }
            if (bank.nr_account == string.Empty)
            {
                return "Conta Obrigatória!";
            }
            if (bank.nr_agency == 0)
            {
                return "Agência Obrigatória!";
            }
            if (bank.ds_typePerson == string.Empty)
            {
                return "Tipo de Pessoa Obrigatória!";
            }

            return string.Empty;
        }

        public void Alterar(tb_bankaccount bank, int id)
        {
            bank.id_emp = id;

            db.Alterar(bank);
        }

        public tb_bankaccount ConsultarPorID(int id)
        {
            return db.ConsultarPorID(id);
        }

        public void Remover(tb_bankaccount bank)
        {
            db.Remover(bank);
        }
    }
}
