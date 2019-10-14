using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class EmployeesBusiness
    {
        public void Verificar(Database.Entities.tb_employees verificar)
        {
            Database.EmployeesDatabase dbemp = new Database.EmployeesDatabase();
            Database.Entities.tb_employees db = dbemp.Verificar(verificar);

            if (db == null)
                throw new ArgumentException("Credencial inválida");
            else
            {
                Model.UsuarioLogado.ID = db.id_emp;
                Model.UsuarioLogado.rg = db.ds_rg;
                Model.UsuarioLogado.cpf = db.ds_cpf;
                Model.UsuarioLogado.telefone = db.mr_tellphone;
                Model.UsuarioLogado.celular = db.mr_cellphone;
            }
        }

        public void AlterarRecuperação(Database.Entities.tb_employees alterar)
        {
            Database.EmployeesDatabase dbemp = new Database.EmployeesDatabase();

            if (alterar.ds_password == string.Empty || alterar.ds_password == "Senha do usuário")
                throw new ArgumentException("O campo senha deve ser preenchido");

            dbemp.AlterarRecuperação(alterar);
        }
    }
}
