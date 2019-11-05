using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Liriou_s_Burguer.Business
{
    class EmployeesBusiness
    {
        Database.EmployeesDatabase db = new Database.EmployeesDatabase();

        public bool Login(Database.Entities.tb_employees employees)
        {
            if (employees.ds_email == string.Empty || employees.ds_email == "Email do usuário")
                throw new ArgumentException("O campo email deve ser preenchido");

            if (employees.pw_password == string.Empty || employees.pw_password == "Senha do usuário")
                throw new ArgumentException("O campo senha deve ser preenchido");

            bool verificacao = db.Login(employees);

            if (verificacao == true)
                return true;
            else
                return false;
        }

        public void VerificarRecuperação(Database.Entities.tb_employees employees)
        {
            if (employees.nr_rg == string.Empty)
                throw new ArgumentException("O campo RG deve ser preenchido");
            if (employees.nr_cpf == string.Empty)
                throw new ArgumentException("O campo CPF deve ser preenchido");
            if (employees.nr_cellphone == string.Empty)
                throw new ArgumentException("O campo celular deve ser preenchido");

            db.VerificarRecuperação(employees);
        }

        public void AlterarRecuperação(Database.Entities.tb_employees employees)
        {
            if (employees.pw_password == string.Empty || employees.pw_password == "Senha do usuário")
                throw new ArgumentException("O campo senha deve ser preenchido");

            db.AlterarRecuperação(employees);
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
            if (employees.ds_sex == "Masculino")
                employees.ds_sex = "M";
            else
                employees.ds_sex = "F";
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
            if (employees.bt_employee == false && employees.bt_manager == false)
                throw new ArgumentException("Escolha Funcionario ou Gerente!");
        }

        public void Inserir1(Database.Entities.tb_employees employees)
        {
            employees.nm_firstName = Model.EmployeesModel.firstName;
            employees.nm_lastName = Model.EmployeesModel.lastName;
            employees.nr_rg = Model.EmployeesModel.RG;
            employees.nr_cpf = Model.EmployeesModel.CPF;
            employees.nr_dependents = Model.EmployeesModel.dependents;
            employees.ds_sex = Model.EmployeesModel.sex;
            employees.dt_birth = Model.EmployeesModel.birth;
            employees.ds_state = Model.EmployeesModel.state;
            employees.nr_cep = Model.EmployeesModel.CEP;
            employees.ds_address = Model.EmployeesModel.address;
            employees.ds_note = Model.EmployeesModel.note;
            employees.nr_cellphone = Model.EmployeesModel.cellphone;
            employees.nr_tellphone = Model.EmployeesModel.tellphone;
            employees.ds_email = Model.EmployeesModel.email;
            employees.pw_password = Model.EmployeesModel.password;
            employees.bt_manager = Model.EmployeesModel.manager;
            employees.bt_employee = Model.EmployeesModel.employeer;
            employees.bt_rh = Model.EmployeesModel.RH;
            employees.bt_financial = Model.EmployeesModel.financial;
            employees.bt_stock = Model.EmployeesModel.stock;
            employees.bt_crm = Model.EmployeesModel.CRM;
            db.Inserir1(employees);
        }

        public Database.Entities.tb_employees ConsultarPorID(int id)
        {
            Database.Entities.tb_employees employees = db.ConsultaPorID(id);

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

        public void Alterar(Database.Entities.tb_employees employees)
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
            if (employees.ds_sex == "Masculino")
                employees.ds_sex = "M";
            else
                employees.ds_sex = "F";
            if (employees.ds_state == string.Empty)
                throw new ArgumentException("O campo Estado deve ser preenchido");
            if (employees.nr_cep == string.Empty)
                throw new ArgumentException("O campo CEP deve ser preenchido");
            if (employees.ds_address == string.Empty)
                throw new ArgumentException("O campo endereço deve ser preenchido");
            if (employees.ds_note == string.Empty)
                throw new ArgumentException("O campo complemento deve ser preenchido");
            if (employees.nr_cellphone == string.Empty && employees.nr_tellphone == string.Empty)
                throw new ArgumentException("Celular ou Telefone devem ser preenchidos");
            if (employees.ds_email == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (employees.pw_password == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(employees.ds_email);
            if (match.Success == false)
                throw new ArgumentException(employees.ds_email + " é um e-mail inválido!");

            Model.EmployeesModel.firstName = employees.nm_firstName;
            Model.EmployeesModel.lastName = employees.nm_lastName;
            Model.EmployeesModel.RG = employees.nr_rg;
            Model.EmployeesModel.CPF = employees.nr_cpf;
            Model.EmployeesModel.dependents = employees.nr_dependents;
            Model.EmployeesModel.sex = employees.ds_sex;
            Model.EmployeesModel.birth = employees.dt_birth;
            Model.EmployeesModel.state = employees.ds_state;
            Model.EmployeesModel.CEP = employees.nr_cep;
            Model.EmployeesModel.address = employees.ds_state;
            Model.EmployeesModel.note = employees.ds_note;
            Model.EmployeesModel.cellphone = employees.nr_cellphone;
            Model.EmployeesModel.tellphone = employees.nr_tellphone;
            Model.EmployeesModel.email = employees.ds_email;
            Model.EmployeesModel.password = employees.pw_password;
            Model.EmployeesModel.manager = Convert.ToBoolean(employees.bt_manager);
            Model.EmployeesModel.employeer = Convert.ToBoolean(employees.bt_employee);
            Model.EmployeesModel.RH = Convert.ToBoolean(employees.bt_rh);
            Model.EmployeesModel.financial = Convert.ToBoolean(employees.bt_financial);
            Model.EmployeesModel.stock = Convert.ToBoolean(employees.bt_stock);
            Model.EmployeesModel.CRM = Convert.ToBoolean(employees.bt_crm);

            db.Alterar(employees);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
