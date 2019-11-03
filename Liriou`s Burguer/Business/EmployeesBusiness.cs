using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Liriou_s_Burguer.Business
{
    class EmployeesBusiness
    {
        Database.EmployeesDatabase db = new Database.EmployeesDatabase();

        public bool VerificarLogin(Database.Entities.tb_employees login)
        {
            if (login.ds_email == string.Empty || login.ds_email == "Email do usuário")
                throw new ArgumentException("O campo email deve ser preenchido");

            if (login.pw_password == string.Empty || login.pw_password == "Senha do usuário")
                throw new ArgumentException("O campo senha deve ser preenchido");

            bool verificacao = db.Login(login);

            if (verificacao == true)
                return true;
            else
                return false;
        }

        public void Inserir(Database.Entities.tb_employees employees)
        {
            if (employees.nm_firstName == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (employees.nm_lastName == string.Empty)
                throw new ArgumentException("O campo sobrenome deve ser preenchido");
            if (employees.nr_rg == string.Empty)
                throw new ArgumentException("O campo RG deve ser preenchido");
            if (employees.nr_cpf == string.Empty)
                throw new ArgumentException("O campo CPF deve ser preenchido");       
            if (employees.ds_sex == string.Empty)
                throw new ArgumentException("O campo sexo deve ser preenchido");
            if (employees.ds_state == string.Empty)
                throw new ArgumentException("O campo Estado deve ser preenchido");
            if (employees.nr_cep == string.Empty)
                throw new ArgumentException("O campo CEP deve ser preenchido");
            if (employees.ds_address == string.Empty)
                throw new ArgumentException("O campo endereço deve ser preenchido");
            if (employees.ds_note == string.Empty)
                throw new ArgumentException("O campo complemento deve ser preenchido");
            if (employees.nr_cellphone== string.Empty && employees.nr_tellphone == string.Empty)
                throw new ArgumentException("Celular ou Telefone devem ser preenchidos");
            if (employees.ds_email == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (employees.pw_password == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(employees.ds_email);
            if (match.Success == false)
                throw new ArgumentException(employees.ds_email + " é um e-mail inválido!");

            db.Inserir(employees);
        }

        public void Inserir1(Database.Entities.tb_employees employees)
        {
            db.Inserir1(employees);
        }

        public Database.Entities.tb_employees ConsultarPorID(int id)
        {
            Database.Entities.tb_employees employees = db.ConsultaPorID(id);

            return employees;
        }

        public Database.Entities.tb_employees ConsultarPorData(DateTime data)
        {
            Database.Entities.tb_employees employees = db.ConsultaPorData(data);

            return employees;
        }

        public List<Database.Entities.tb_employees> Consultar(Database.Entities.tb_employees employees)
        {
            List<Database.Entities.tb_employees> list = new List<Database.Entities.tb_employees>();

            if (employees.nm_firstName != string.Empty && employees.nr_rg == string.Empty && employees.ds_sex == null)
                list = db.ConsultarPorNome(employees);
            else if (employees.nm_firstName == string.Empty && employees.nr_rg != string.Empty && employees.ds_sex == null)
                list = db.ConsultarPorRG(employees);
            else if (employees.nm_firstName == string.Empty && employees.nr_rg == string.Empty && employees.ds_sex != null)
                list = db.ConsultarPorSexo(employees);
            else if (employees.nm_firstName != string.Empty && employees.nr_rg != string.Empty && employees.ds_sex == null)
                list = db.ConsultarPorNomeRG(employees);
            else if (employees.nm_firstName != string.Empty && employees.nr_rg == string.Empty && employees.ds_sex != null)
                list = db.ConsultarPorNomeSexo(employees);
            else if (employees.nm_firstName == string.Empty && employees.nr_rg != string.Empty && employees.ds_sex != null)
                list = db.ConsultarPorRGSexo(employees);

            return list;
        }

        public List<Database.Entities.tb_employees> ConsultarTodos()
        {
            List<Database.Entities.tb_employees> list = db.ConsultarTodos();
            return list;
        }
        public List<Database.Entities.tb_employees> Consultar()
        {
            List<Database.Entities.tb_employees> list = db.Consultar();
            return list;
        }

        public List<Database.Entities.tb_employees> ConsultarFuncionario(string nome)
        {
            List<Database.Entities.tb_employees> list = db.ConsultarFuncionario(nome);
            return list;
        }

        public List<Database.Entities.tb_employees> ConsultarFuncionarioRG(string rg)
        {
            List<Database.Entities.tb_employees> list = db.ConsultarFuncionarioRG(rg);
            return list;
        }

        public List<Database.Entities.tb_employees> ConsultarFuncionarioData(DateTime data)
        {
            List<Database.Entities.tb_employees> list = db.ConsultarData(data);
            return list;
        }

        public void Verificar(Database.Entities.tb_employees recuperar)
        {
            if (recuperar.nr_rg == string.Empty)
                throw new ArgumentException("O campo rg deve ser preenchido");
            if (recuperar.nr_cpf == string.Empty)
                throw new ArgumentException("O campo cpf deve ser preenchido");
            if (recuperar.nr_cellphone == string.Empty)
                throw new ArgumentException("O campo celular deve ser preenchido");

            db.Verificar(recuperar);
        }
        public string AlterarRecuperação(string senha, string cpf,
                                       string rg, string cell)
        {
            if (senha == string.Empty || senha == "Senha do usuário")
            {
                return "O campo senha deve ser preenchido";
            }
            else
            {
                db.AlterarRecuperação(senha, cpf, rg, cell);
            }

            return "Alterado com sucesso!";
        }

        public void Alterar(Database.Entities.tb_employees employees)
        {
            db.Alterar(employees);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
