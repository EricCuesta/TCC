using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Liriou_s_Burguer.Business
{
    class EmployeesBusiness
    {
        public void Verificar(Database.Entities.tb_employees verificar)
        {
            
            Database.EmployeesDatabase dbemp = new Database.EmployeesDatabase();
            Database.Entities.tb_employees db = dbemp.Verificar(verificar);

            if (verificar.ds_email == string.Empty)
            {
                throw new ArgumentException("Email não preenchido!");
            }
            if (verificar.pw_password == string.Empty)
            {
                throw new ArgumentException("Senha não preenchida!");
            }

            if (db == null)
                throw new ArgumentException("Credencial inválida");
            else
            {
                Model.UsuarioLogado.ID = db.id_emp;
                Model.UsuarioLogado.rg = db.ds_rg;
                Model.UsuarioLogado.cpf = db.ds_cpf;
                Model.UsuarioLogado.telefone = db.nr_tellphone;
                Model.UsuarioLogado.celular = db.nr_cellphone;
            }
        }
        public void ConsultarFuncionario(string nome)
        {
           
        }

        public void AlterarRecuperação(Database.Entities.tb_employees alterar)
        {
            Database.EmployeesDatabase dbemp = new Database.EmployeesDatabase();

            if (alterar.pw_password == string.Empty || alterar.pw_password == "Senha do usuário")
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

        public string Login(string email, string senha)
        {
            if (email == string.Empty)
            {
                return "Email obrigatório!";
            }
            if (senha == string.Empty)
            {
                return "Senha obrigatória!";
            }
            Database.Entities.tb_employees db = new Database.Entities.tb_employees();
            Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
            bool v = DB.Login(email, senha);
            if (email == "admim@gmail.com" && senha == "1234")
            {
                return "true";
            }
            else if (v == true)
            {
                return "false";
            }
            else
            {
                return "Email e senha não existem!";
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

        public string VerificarCadastro (Model.EmployeesModel model)
        {
            if (model.firstName == string.Empty)
            {
                return "Nome não pode ser vazio";
            }

            if (model.lastName == string.Empty)
            {
                return "Sobrenome não pode ser vazio";
            }
            if (model.CPF == string.Empty)
            {
                return "CPF deve ser preenchido!";
            }

            if (model.CEP == string.Empty)
            {
                return "CEP deve ser preenchido!";
            }

            if (model.RG == string.Empty)
            {
                return "RG deve ser preenchido!";
            }
            if (model.cellphone == string.Empty)
            {
                return "Celular deve ser preenchido!";
            }

            if (model.email == string.Empty)
            {
                return "Email deve ser preenchido!";
            }

            if (model.password == string.Empty)
            {
                return "Senha deve ser preenchido!";
            }
            if (model.RG.Length < 6)
            {
                return "Tipo de RG inválido!";
            }
            if (model.CEP.Length < 9)
            {
                return "CEP Inválido";
            }
            if (model.cellphone.Length < 16)
            {
                return "Celular inválido";
            }

            string email = model.email;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return "true";
            }
            else
            {
                return email + " é um Email inválido!";
            }
        }
    }
}
