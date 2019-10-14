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
            if (verificar.ds_email == string.Empty)
            {
                throw new ArgumentException("Email não preenchido!");
            }
            if (verificar.ds_password == string.Empty)
            {
                throw new ArgumentException("Senha não preenchida!");
            }
        }

        public void AlterarRecuperação(Database.Entities.tb_employees alterar)
        {
            Database.EmployeesDatabase dbemp = new Database.EmployeesDatabase();

            if (alterar.ds_password == string.Empty || alterar.ds_password == "Senha do usuário")
                throw new ArgumentException("O campo senha deve ser preenchido");

            dbemp.AlterarRecuperação(alterar);
        }
        public void Inserir(Database.Entities.tb_employees employees)
        {
            Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
            DB.Inserir(employees);
        }

        public List<Database.Entities.tb_employees> Consultar(string email, string senha)
        {
            Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
            List<Database.Entities.tb_employees> list = DB.Consultar();

            return list;
        }

        public List<Database.Entities.tb_employees> Login(string email, string senha)
        {
            Database.Entities.tb_employees db = new Database.Entities.tb_employees();
            Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
            List<Database.Entities.tb_employees> list = DB.Login(email, senha);

            if (db.ds_email == string.Empty)
            {
                throw new ArgumentException("Email deve ser preenchido!");
            }

            if (db.ds_password == string.Empty)
            {
                throw new ArgumentException("Senha deve ser preenchida!");
            }

            bool verificação = DB.Consultar(email, senha);

            if (verificação == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Alterar(Database.Entities.tb_employees employees)
        {
            Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
            DB.Alterar(employees);
        }

        public void Remover(int id)
        {
            Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
            DB.Remover(id);
        }

        public Database.Entities.tb_employees BuscarPorID(int id)
        {

            Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
            Database.Entities.tb_employees list = DB.BuscarPorID(id);
            return list;
        }
    }
}
