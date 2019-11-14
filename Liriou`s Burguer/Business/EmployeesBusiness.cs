using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Liriou_s_Burguer.Model;

namespace Liriou_s_Burguer.Business
{
    class EmployeesBusiness
    {
        Database.EmployeesDatabase db = new Database.EmployeesDatabase();

        public bool Login(Database.Entities.tb_employees emp)
        {
            if (emp.ds_email == string.Empty || emp.ds_email == "Email do usuário")
            {
                throw new ArgumentException("O campo email deve ser preenchido");
            }
            else if (emp.pw_password == string.Empty || emp.pw_password == "Senha do usuário")
            {
                throw new ArgumentException("O campo senha deve ser preenchido");
            }
            else
            {
                return db.Login(emp);
            }
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

        public void Inserir()
        {
            if (EmployeesModel.firstName == string.Empty)
            {
                throw new ArgumentException("O campo nome deve ser preenchido");
            }
            if (EmployeesModel.lastName == string.Empty)
            {
                throw new ArgumentException("O campo sobrenome deve ser preenchido");
            }
            if (EmployeesModel.RG == string.Empty)
            {
                throw new ArgumentException("O campo RG deve ser preenchido");
            }
            if (EmployeesModel.CPF == string.Empty)
            {
                throw new ArgumentException("O campo CPF deve ser preenchido");
            }
            if (EmployeesModel.sex != string.Empty)
            {
                if (EmployeesModel.sex == "Masculino")
                {
                    EmployeesModel.sex = "M";
                }
                else
                {
                    EmployeesModel.sex = "F";
                }
            }
            if (EmployeesModel.sex == string.Empty)
            {
                throw new ArgumentException("O campo sexo é obrigatório!");
            }
            if (EmployeesModel.state == string.Empty)
            {
                throw new ArgumentException("O campo estado é obrigatório!");
            }
            if (EmployeesModel.CEP == string.Empty)
            {
                throw new ArgumentException("O campo CEP deve ser preenchido");
            }
            if (EmployeesModel.address == string.Empty)
            {
                throw new ArgumentException("O campo endereço deve ser preenchido");
            }
            if (EmployeesModel.email == string.Empty)
            {
                throw new ArgumentException("O campo email é obrigatória!");
            }
            if (EmployeesModel.password == string.Empty)
            {
                throw new ArgumentException("O campo nome deve ser preenchido");
            }
            if (EmployeesModel.employeer == false && EmployeesModel.manager == false)
            {
                throw new ArgumentException("Escolha Funcionario ou Gerente!");
            }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(EmployeesModel.email);
            if (match.Success == false)
            {
                throw new ArgumentException(EmployeesModel.email + " é um e-mail inválido!");
            }
        }

        public void Inserir1(Database.Entities.tb_employees emp)
        {
            emp.nm_firstName = EmployeesModel.firstName;
            emp.nm_lastName = EmployeesModel.lastName;
            emp.nr_rg = EmployeesModel.RG;
            emp.nr_cpf = EmployeesModel.CPF;
            emp.nr_dependents = EmployeesModel.dependents;
            emp.ds_sex = EmployeesModel.sex;
            emp.dt_birth = EmployeesModel.birth;
            emp.ds_state = EmployeesModel.state;
            emp.nr_cep = EmployeesModel.CEP;
            emp.ds_address = EmployeesModel.address;
            emp.ds_note = EmployeesModel.note;
            emp.nr_cellphone = EmployeesModel.cellphone;
            emp.nr_tellphone = EmployeesModel.tellphone;
            emp.ds_email = EmployeesModel.email;
            emp.pw_password = EmployeesModel.password;
            emp.bt_manager = EmployeesModel.manager;
            emp.bt_employee = EmployeesModel.employeer;
            emp.bt_rh = EmployeesModel.RH;
            emp.bt_provider = EmployeesModel.Provider;
            emp.bt_financial = EmployeesModel.financial;
            emp.bt_stock = EmployeesModel.stock;
            emp.bt_crm = EmployeesModel.CRM;
            db.Inserir1(emp);
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
