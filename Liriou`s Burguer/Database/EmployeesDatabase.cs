using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class EmployeesDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public bool Login(Entities.tb_employees employees)
        {
            Entities.tb_employees model = db.tb_employees.FirstOrDefault(l => l.ds_email == employees.ds_email &&
                                                                            l.pw_password == employees.pw_password);

            if (employees.ds_email == "gerente@gmail.com" && employees.pw_password == "1234")
                return true;
            else
                return false;
        }

        public void Inserir(Entities.tb_employees employees)
        {
            db.tb_employees.Add(employees);

            db.SaveChanges();
        }

        public void Inserir1(Entities.tb_employees employees)
        {
            Model.EmployeesModel model = new Model.EmployeesModel();
            employees.nm_firstName = model.firstName;
            employees.nm_lastName = model.lastName;
            employees.nr_rg = model.RG;
            employees.nr_cpf = model.CPF;
            employees.nr_dependents = model.dependents;
            employees.ds_sex = model.sex;
            employees.dt_birth = model.birth;
            employees.ds_state = model.state;
            employees.nr_cep = model.CEP;
            employees.ds_address = model.address;
            employees.ds_note = model.note;
            employees.nr_cellphone = model.cellphone;
            employees.nr_tellphone = model.tellphone;
            employees.ds_email = model.email;
            employees.pw_password = model.password;

            db.tb_employees.Add(employees);
            db.SaveChanges();
        }

        public Entities.tb_employees ConsultaPorID(int id)
        {
            Entities.tb_employees employees = db.tb_employees.FirstOrDefault(t => t.id_emp == id);

            return employees;
        }

        public Entities.tb_employees ConsultaPorData(DateTime data)
        {
            Entities.tb_employees employees = db.tb_employees.FirstOrDefault(t => t.dt_unavailability == data);

            return employees;
        }

        public List<Entities.tb_employees> ConsultarPorNome(Entities.tb_employees employees)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(l => l.nm_firstName == employees.nm_firstName).ToList();

            return list;
        }

        public List<Entities.tb_employees> ConsultarPorRG(Entities.tb_employees employees)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(l => l.nr_rg == employees.nr_rg).ToList();

            return list;
        }

        public List<Entities.tb_employees> ConsultarPorSexo(Entities.tb_employees employees)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(l => l.ds_sex == employees.ds_sex).ToList();

            return list;
        }

        public List<Entities.tb_employees> ConsultarPorNomeRG(Entities.tb_employees employees)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(l => l.nm_firstName == employees.nm_firstName && l.nr_rg == employees.nr_rg).ToList();

            return list;
        }

        public List<Entities.tb_employees> ConsultarPorNomeSexo(Entities.tb_employees employees)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(l => l.nm_firstName == employees.nm_firstName && l.ds_sex == employees.ds_sex).ToList();

            return list;
        }

        public List<Entities.tb_employees> ConsultarPorRGSexo(Entities.tb_employees employees)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(l => l.nr_rg == employees.nr_rg && l.ds_sex == employees.ds_sex).ToList();

            return list;
        }

        public List<Entities.tb_employees> ConsultarTodos()
        {
            List<Entities.tb_employees> list = db.tb_employees.ToList();

            return list;
        }
        public Entities.tb_employees Verificar(Entities.tb_employees verificar)
        {
            Entities.tb_employees dbverificar = db.tb_employees.FirstOrDefault(l => l.nr_cpf == verificar.nr_cpf ||
                                                                                 l.nr_rg == verificar.nr_rg ||
                                                                                 l.nr_cellphone == verificar.nr_cellphone);
            return dbverificar;
        }

        public void AlterarRecuperação(string senha, string cpf,
                                       string rg, string cell)
        {
            Entities.liriousdbEntities db = new Entities.liriousdbEntities();

            if (cpf != "         /")
            {
                Entities.tb_employees novo = db.tb_employees.First(u => u.nr_cpf == cpf);
                novo.pw_password = senha;
                db.SaveChanges();
            }
            else if (rg != string.Empty)
            {
                Entities.tb_employees novo = db.tb_employees.First(u => u.nr_rg == rg);
                novo.pw_password = senha;
                db.SaveChanges();
            }
            else if (cell != string.Empty)
            {
                Entities.tb_employees novo = db.tb_employees.First(u => u.nr_cellphone == cell);
                novo.pw_password = senha;
                db.SaveChanges();
            }
        }

        public List<Entities.tb_employees> Consultar()
        {
            List<Entities.tb_employees> list = db.tb_employees.ToList();

            return list;
        }

        public List<Entities.tb_employees> ConsultarPorTudo(Entities.tb_employees emp,
                                                            Entities.tb_department dept,
                                                            Entities.tb_function func)
        {
            List<Entities.tb_employees> list = null;

            if (emp.nm_firstName != null && emp.dt_birth != null &&
                emp.ds_sex != null && dept.nm_department != null &&
                func.nm_function != null)
            {
                list = db.tb_employees.Where(t => t.nm_firstName == emp.nm_firstName &&
                                             t.dt_birth == emp.dt_birth &&
                                             t.ds_sex == emp.ds_sex).ToList();

            }

            return list;
        }

        public List<Entities.tb_employees> ConsultarFuncionario(string nome)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(t => t.nm_firstName.Contains(nome)).ToList();

            return list;
        }

        public List<Entities.tb_employees> ConsultarFuncionarioRG(string rg)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(t => t.nr_rg == rg).ToList();

            return list;
        }

        public List<Entities.tb_employees> ConsultarData(DateTime data)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(t => t.dt_birth == data).ToList();
            return list;
        }

        public void Alterar(Entities.tb_employees employees)
        {
            Entities.tb_employees list = db.tb_employees.First(t => t.id_emp == employees.id_emp);

            list.ds_address = list.ds_address;
            list.nr_cellphone = list.nr_cellphone;
            list.nr_cep = list.nr_cep;
            list.nr_cpf = list.nr_cpf;
            list.nr_tellphone = list.nr_tellphone;
            list.ds_email = list.ds_email;
            list.ds_sex = list.ds_sex;
            list.nr_rg = list.nr_rg;
            list.ds_state = list.ds_state;
            list.dt_birth = list.dt_birth;
            list.dt_hiring = list.dt_hiring;
            list.dt_resignation = list.dt_resignation;
            list.nm_firstName = list.nm_firstName;
            list.nm_lastName = list.nm_lastName;

            list.ds_note = list.ds_note;
            list.pw_password = list.pw_password;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_employees remover = db.tb_employees.First(t => t.id_emp == id);

            db.tb_employees.Remove(remover);
            db.SaveChanges();
        }

        public Entities.tb_employees BuscarPorID(int id)
        {
            Entities.tb_employees list = db.tb_employees.First(t => t.id_emp == id);
            return list;
        }
    }
}
