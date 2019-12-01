using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Liriou_s_Burguer.Model;
using Liriou_s_Burguer.Business;
using Liriou_s_Burguer.Database.Entities;

namespace Liriou_s_Burguer.Business
{
    class EmployeesBusiness
    {
        Database.EmployeesDatabase db = new Database.EmployeesDatabase();
        DeptFunctionBusiness defuB = new DeptFunctionBusiness();
        TimeCardBusiness ticdB = new TimeCardBusiness();
        FinancialBusiness finB = new FinancialBusiness();
        BenefitsBusiness benB = new BenefitsBusiness();
        BankAccountBusiness bankB = new BankAccountBusiness();
        DiscountsBusiness disB = new DiscountsBusiness();

        public bool Login(tb_employees emp)
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

        public tb_employees ConsultarPorID(int id)
        {
            tb_employees emp = db.ReturnEmployee(id);
            return emp;
        }

        public string DeleteEmployee(int id)
        {
            tb_employees emp = ConsultarPorID(id);
            tb_deptfunction defu = defuB.ConsultarPorID(id);
            tb_timecard ticd = ticdB.ConsultarPorID(id);
            tb_financial fin = finB.ConsultarPorID(id);
            tb_benefits ben = benB.ConsultarPorID(id);
            tb_bankaccount bank = bankB.ConsultarPorID(id);
            tb_discounts dis = disB.ConsultarPorID(id);

            if (emp != null && defu != null && ticd != null && fin != null && ben != null && bank != null && dis != null)
            {
                this.Remover(emp, defu, ticd, fin, ben, bank, dis);
                return "Funcionário Removido com Sucesso!";
            }
            else
            {
                return "Funcionário Inexistente!";
            }
        }

        public List<tb_employees> Consultar(string nome, string ano, string sexo, string rg, string dept, string func)
        {
            if (sexo == "Empty")
            {
                sexo = string.Empty;
            }
            if (dept == "Empty")
            {
                dept = string.Empty;
            }
            if (func == "Empty")
            {
                func = string.Empty;
            }
            if (rg.Contains(","))
            {
                rg = rg.Replace(",", ".");
            }
            if (rg == "  .   .   -" || rg == string.Empty)
            {
                rg = string.Empty;
            }

            // Consultar Sem Filtros
            if (nome == string.Empty && ano == string.Empty && sexo == string.Empty && rg == string.Empty && dept == string.Empty && func == string.Empty)
            {
                db.ConsultarSemFiltros();
            }

            // Consultar por Nome
            if (nome != string.Empty)
            {
                db.ConsultarPorNome(nome);
            }

            // Consultar por Ano
            if (ano != string.Empty)
            {
                db.ConsultarPorAno(ano);
            }

            // Consultar por Sexo
            if (sexo != string.Empty)
            {
                db.ConsultarPorSexo(sexo);
            }

            // Consultar por RG
            if (rg != string.Empty)
            {
                db.ConsultarPorRG(rg);
            }

            // Consultar por Departamento
            if (dept != string.Empty)
            {
                db.ConsultarPorDept(dept);
            }

            // Consultar por Cargo
            if (func != string.Empty)
            {
                db.ConsultarPorFunc(func);
            }

            return db.Consultar();
        }

        public string VericarParametros(tb_employees emp)
        {
            if (emp.nm_firstName == string.Empty)
            {
                return "O campo nome deve ser preenchido!";
            }
            if (emp.nm_lastName == string.Empty)
            {
                return "O campo sobrenome deve ser preenchido!";
            }
            if (emp.nr_rg == string.Empty)
            {
                return "O campo RG deve ser preenchido!";
            }
            if (emp.nr_cpf == string.Empty)
            {
                return "O campo CPF deve ser preenchido!";
            }
            if (emp.ds_sex != "Masculino" && emp.ds_sex != "Feminino")
            {
                return "O campo sexo deve ser preenchido!";
            }
            if (emp.ds_sex == "Masculino")
            {
                emp.ds_sex = "M";
            }
            if (emp.ds_sex == "Feminino")
            {
                emp.ds_sex = "F";
            }
            if (emp.ds_state == string.Empty)
            {
                return "O campo estado deve ser preenchido!";
            }
            if (emp.nr_cep == string.Empty)
            {
                return "O campo CEP deve ser preenchido!";
            }
            if (emp.ds_address == string.Empty)
            {
                return "O campo endereço deve ser preenchido!";
            }
            if (emp.ds_email == string.Empty)
            {
                return "O campo email deve ser preenchido!";
            }
            if (emp.ds_email != string.Empty)
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(emp.ds_email);
                if (match.Success == false)
                {
                    return emp.ds_email + " Não é um email válido";
                }
            }
            if (emp.pw_password == string.Empty)
            {
                return "O campo senha deve ser preenchido!";
            }
            if (emp.bt_employee == false && emp.bt_manager == false)
            {
                return "Escolha Funcionario ou Gerente!";
            }
            if (emp.bt_manager == true && emp.bt_employee == false)
            {
                emp.bt_crm = true;
                emp.bt_provider = true;
                emp.bt_financial = true;
                emp.bt_rh = true;
                emp.bt_stock = true;
            }

            return string.Empty;
        }

        public string InsertEmployee(tb_employees emp, tb_deptfunction defu, tb_timecard ticd,
        tb_financial fin, tb_benefits ben, tb_bankaccount bank, tb_discounts dis)
        {
            string error = string.Empty;

            if (error == string.Empty)
            {
                error = this.VericarParametros(emp);
            }

            if (error == string.Empty)
            {
                error = defuB.VericarParametros(defu);
            }

            if (error == string.Empty)
            {
                error = ticdB.VericarParametros(ticd);
            }

            if (error == string.Empty)
            {
                error = finB.VericarParametros(fin);
            }

            if (error == string.Empty)
            {
                error = benB.VericarParametros(ben);
            }

            if (error == string.Empty)
            {
                error = bankB.VericarParametros(bank);
            }

            if (error == string.Empty)
            {
                error = disB.VericarParametros(dis);
            }

            if (error == string.Empty)
            {
                this.Insirir(emp, defu, ticd, fin, ben, bank, dis);
                return "Insirido com sucesso!";
            }
            else
            {
                return error;
            }
        }

        public string UpdateEmployee(tb_employees emp, tb_deptfunction defu, tb_timecard ticd,
        tb_financial fin, tb_benefits ben, tb_bankaccount bank, tb_discounts dis)
        {
            string error = string.Empty;

            if (error == string.Empty)
            {
                error = this.VericarParametros(emp);
            }

            if (error == string.Empty)
            {
                error = defuB.VericarParametros(defu);
            }

            if (error == string.Empty)
            {
                error = ticdB.VericarParametros(ticd);
            }

            if (error == string.Empty)
            {
                error = finB.VericarParametros(fin);
            }

            if (error == string.Empty)
            {
                error = benB.VericarParametros(ben);
            }

            if (error == string.Empty)
            {
                error = bankB.VericarParametros(bank);
            }

            if (error == string.Empty)
            {
                error = disB.VericarParametros(dis);
            }

            if (error == string.Empty)
            {
                this.Alterar(emp, defu, ticd, fin, ben, bank, dis);
                return "Alterado com sucesso!";
            }
            else
            {
                return error;
            }
        }

        private void Insirir(tb_employees emp, tb_deptfunction defu, tb_timecard ticd,
        tb_financial fin, tb_benefits ben, tb_bankaccount bank, tb_discounts dis)
        {
            int id = db.Insirir(emp);
            defuB.Insirir(defu, id);
            ticdB.Insirir(ticd, id);
            finB.insirir(fin, id);
            benB.Insirir(ben, id);
            bankB.Insirir(bank, id);
            disB.insirir(dis, id);
        }

        private void Alterar(tb_employees emp, tb_deptfunction defu, tb_timecard ticd,
        tb_financial fin, tb_benefits ben, tb_bankaccount bank, tb_discounts dis)
        {
            int id = EmployeesModel.ID;
            defuB.Alterar(defu, id);
            ticdB.Alterar(ticd, id);
            finB.Alterar(fin, id);
            benB.Alterar(ben, id);
            bankB.Alterar(bank, id);
            disB.Alterar(dis, id);
            db.Alterar(emp, id);
        }

        public void Remover(tb_employees emp, tb_deptfunction defu, tb_timecard ticd,
        tb_financial fin, tb_benefits ben, tb_bankaccount bank, tb_discounts dis)
        {
            defuB.Remover(defu);
            ticdB.Remover(ticd);
            finB.Remover(fin);
            benB.Remover(ben);
            bankB.Remover(bank);
            disB.Remover(dis);
            db.Remover(emp);
        }
    }
}
