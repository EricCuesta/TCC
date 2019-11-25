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

        public int InsertEmp(string cpf)
        {
            Entities.tb_employees tb = db.tb_employees.First(t => t.nr_cpf == cpf);
            return tb.id_emp;
        }

        public bool Login(Entities.tb_employees emp)
        {
            Entities.tb_employees tb = db.tb_employees.FirstOrDefault(t => t.ds_email == emp.ds_email &&
                                                                      t.pw_password == emp.pw_password);

            if (tb != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Entities.tb_employees UsuárioLogado(string email, string senha)
        {
            return db.tb_employees.First(t => t.ds_email == email && t.pw_password == senha);
        }

        public Entities.tb_employees VerificarRecuperação(Entities.tb_employees employees)
        {
            Entities.tb_employees verificar = db.tb_employees.FirstOrDefault(l => l.nr_cpf == employees.nr_cpf ||
                                                                                 l.nr_rg == employees.nr_rg ||
                                                                                 l.nr_cellphone == employees.nr_cellphone);
            return verificar;
        }

        public void AlterarRecuperação(Entities.tb_employees employees)
        {
            if (employees.nr_cpf != string.Empty)
            {
                Entities.tb_employees novo = db.tb_employees.First(u => u.pw_password == employees.pw_password);
                novo.pw_password = employees.pw_password;
                db.SaveChanges();
            }
            else if (employees.nr_rg != string.Empty)
            {
                Entities.tb_employees novo = db.tb_employees.First(u => u.nr_rg == employees.nr_rg);
                novo.pw_password = employees.pw_password;
                db.SaveChanges();
            }
            else if (employees.nr_cellphone != string.Empty)
            {
                Entities.tb_employees novo = db.tb_employees.First(u => u.nr_cellphone == employees.nr_cellphone);
                novo.pw_password = employees.pw_password;
                db.SaveChanges();
            }
        }

        public void Inserir1(Entities.tb_employees employees)
        {
            db.tb_employees.Add(employees);

            db.SaveChanges();
        }

        public Entities.tb_employees ConsultaPorID(int id)
        {
            Entities.tb_employees employees = db.tb_employees.FirstOrDefault(t => t.id_emp == id);

            return employees;
        }

        public void Alterar(Entities.tb_employees employees)
        {
            Entities.tb_employees list = db.tb_employees.First(t => t.id_emp == employees.id_emp);
            list.nm_firstName = employees.nm_firstName;
            list.nm_lastName = employees.nm_lastName;
            list.nr_rg = employees.nr_rg;
            list.nr_cpf = employees.nr_cpf;
            list.nr_dependents = employees.nr_dependents;
            list.ds_sex = employees.ds_sex;
            list.dt_birth = employees.dt_birth;
            list.ds_state = employees.ds_state;
            list.nr_cep = employees.nr_cep;
            list.ds_address = employees.ds_address;
            list.ds_note = employees.ds_note;
            list.nr_cellphone = employees.nr_cellphone;
            list.nr_tellphone = employees.nr_tellphone;
            list.ds_email = employees.ds_email;
            list.pw_password = employees.pw_password;
            list.bt_manager = employees.bt_manager;
            list.bt_employee = employees.bt_employee;
            list.bt_rh = employees.bt_rh;
            list.bt_financial = employees.bt_financial;
            list.bt_stock = employees.bt_stock;
            list.bt_crm = employees.bt_crm;
            list.dt_hiring = list.dt_hiring;
            list.dt_resignation = list.dt_resignation;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_employees tb = db.tb_employees.FirstOrDefault(t => t.id_emp == id);
            db.tb_employees.Remove(tb);

            db.SaveChanges();
        }

        List<Entities.tb_employees> listEmployees = null;
        public void ConsultarSemFiltros()
        {
            listEmployees = db.tb_employees.ToList();
        }

        public void ConsultarPorNome(string nome)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(t => t.nm_firstName.Contains(nome)).ToList();
            if (listEmployees == null)
            {
                listEmployees = list;
            }
            else
            {
                listEmployees = listEmployees.Where(t => t.nm_firstName.Contains(nome)).ToList();
            }
        }

        public void ConsultarPorAno(string ano)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(t => t.dt_birth.Substring(6, 4) == ano).ToList();
            if (listEmployees == null)
            {
                listEmployees = list;
            }
            else
            {
                listEmployees = listEmployees.Where(t => t.dt_birth.Substring(6, 4) == ano).ToList();
            }
        }

        public void ConsultarPorSexo(string sexo)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(t => t.ds_sex == sexo).ToList();
            if (listEmployees == null)
            {
                listEmployees = list;
            }
            else
            {
                listEmployees = listEmployees.Where(t => t.ds_sex == sexo).ToList();
            }
        }

        public void ConsultarPorRG(string rg)
        {
            List<Entities.tb_employees> list = db.tb_employees.Where(t => t.nr_rg == rg).ToList();
            if (listEmployees == null)
            {
                listEmployees = list;
            }
            else
            {
                listEmployees = listEmployees.Where(t => t.nr_rg == rg).ToList();
            }
        }

        public void ConsultarPorDept(string dept)
        {
            List<Entities.tb_deptfunction> listDept = db.tb_deptfunction.Where(t => t.nm_department == dept).ToList();
            List<Entities.tb_employees> list = new List<Entities.tb_employees>();
            foreach (Entities.tb_deptfunction item in listDept)
            {
                list.Add(item.tb_employees);
            }

            if (listEmployees == null)
            {
                listEmployees = list;
            }
            else
            {
                List<Entities.tb_employees> listEmp = new List<Entities.tb_employees>();
                foreach (Entities.tb_employees item in list)
                {
                    Entities.tb_employees emp = new Entities.tb_employees();
                    emp = listEmployees.FirstOrDefault(t => t.id_emp == item.id_emp);

                    if (emp != null)
                    {
                        listEmp.Add(emp);
                    }
                }

                listEmployees = listEmp;
            }
        }

        public void ConsultarPorFunc(string func)
        {
            List<Entities.tb_deptfunction> listFunc = db.tb_deptfunction.Where(t => t.nm_function == func).ToList();
            List<Entities.tb_employees> list = new List<Entities.tb_employees>();
            foreach (Entities.tb_deptfunction item in listFunc)
            {
                list.Add(item.tb_employees);
            }

            if (listEmployees == null)
            {
                listEmployees = list;
            }
            else
            {
                List<Entities.tb_employees> listEmp = new List<Entities.tb_employees>();
                foreach (Entities.tb_employees item in list)
                {
                    Entities.tb_employees emp = new Entities.tb_employees();
                    emp = listEmployees.FirstOrDefault(t => t.id_emp == item.id_emp);

                    if (emp != null)
                    {
                        listEmp.Add(emp);
                    }
                }

                listEmployees = listEmp;
            }
        }

        public List<Entities.tb_employees> Consultar()
        {
            return listEmployees;
        }
    }
}
