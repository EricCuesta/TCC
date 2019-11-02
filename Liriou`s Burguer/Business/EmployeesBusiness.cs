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

        public void VerificarCadastro(Model.EmployeesModel model)
        {
            if (model.firstName == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (model.lastName == string.Empty)
                throw new ArgumentException("O campo sobrenome deve ser preenchido");
            if (model.RG == string.Empty)
                throw new ArgumentException("O campo RG deve ser preenchido");
            if (model.CPF == string.Empty)
                throw new ArgumentException("O campo CPF deve ser preenchido");       
            if (model.sex == string.Empty)
                throw new ArgumentException("O campo sexo deve ser preenchido");
            if (model.state == string.Empty)
                throw new ArgumentException("O campo Estado deve ser preenchido");
            if (model.CEP == string.Empty)
                throw new ArgumentException("O campo CEP deve ser preenchido");
            if (model.address == string.Empty)
                throw new ArgumentException("O campo endereço deve ser preenchido");
            if (model.note == string.Empty)
                throw new ArgumentException("O campo complemento deve ser preenchido");
            if (model.cellphone == string.Empty && model.tellphone == string.Empty)
                throw new ArgumentException("Celular ou Telefone devem ser preenchidos");
            if (model.email == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (model.password == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(model.email);
            if (match.Success == false)
                throw new ArgumentException(model.email + " é um e-mail inválido!");
        }

        public void Inserir(Database.Entities.tb_employees employees)
        {
            db.Inserir(employees);
        }








    //    public List<Database.Entities.tb_employees> Consultar()
    //    {
    //        List<Database.Entities.tb_employees> list = db.Consultar();
    //        return list;
    //    }

    //    public List<Database.Entities.tb_employees> ConsultarFuncionario(string nome)
    //    {
    //        List<Database.Entities.tb_employees> list = db.ConsultarFuncionario(nome);
    //        return list;
    //    }

    //    public List<Database.Entities.tb_employees> ConsultarFuncionarioRG(string rg)
    //    {
    //        List<Database.Entities.tb_employees> list = db.ConsultarFuncionarioRG(rg);
    //        return list;
    //    }

    //    public List<Database.Entities.tb_employees> ConsultarFuncionarioData(DateTime data)
    //    {
    //        List<Database.Entities.tb_employees> list = db.ConsultarData(data);
    //        return list;
    //    }

    //    public string AlterarRecuperação(string senha, string cpf,
    //                                   string rg, string cell)
    //    {
    //        if (senha == string.Empty || senha == "Senha do usuário")
    //        {
    //            return "O campo senha deve ser preenchido";
    //        }
    //        else
    //        {
    //            db.AlterarRecuperação(senha, cpf, rg, cell);
    //        }

    //        return "Alterado com sucesso!";
    //    }

    //    public void Inserir(Database.Entities.tb_employees employees)
    //    {
    //        db.Inserir(employees);
    //    }

    //    public List<Database.Entities.tb_employees> Consultar(string email, string senha)
    //    {
    //        List<Database.Entities.tb_employees> list = db.Consultar();

    //        return list;
    //    }

    //    public void Alterar(Database.Entities.tb_employees employees)
    //    {
    //        db.Alterar(employees);
    //    }

    //    public void Remover(int id)
    //    {
    //        Database.EmployeesDatabase db = new Database.EmployeesDatabase();
    //        db.Remover(id);
    //    }

    //    public Database.Entities.tb_employees BuscarPorID(int id)
    //    {

    //        Database.EmployeesDatabase db = new Database.EmployeesDatabase();
    //        Database.Entities.tb_employees list = db.BuscarPorID(id);
    //        return list;
    //    }
    }
}
