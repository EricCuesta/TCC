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
            if (bank.nm_bank == string.Empty)
            {
                throw new ArgumentException("Nome do Banco Obrigatório!");
            }
            if (bank.nr_account == string.Empty)
            {
                throw new ArgumentException("Conta Obrigatória!");
            }
            if (bank.nr_agency == 0)
            {
                throw new ArgumentException("Agência Obrigatória!");
            }
            if (bank.ds_typePerson == string.Empty)
            {
                throw new ArgumentException("Tipo de Pessoa Obrigatória!");
            }

            Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
            bank.id_emp = DB.InsertEmp(Model.EmployeesModel.CPF);

            db.Inserir(bank);
        }
    }
}
