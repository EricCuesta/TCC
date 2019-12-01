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
        public bool Login(Entities.tb_employees emp)
        {
            Entities.tb_employees tb = db.tb_employees.FirstOrDefault(t => t.ds_email.ToLower() == emp.ds_email &&
                                                                      t.pw_password.ToLower() == emp.pw_password);

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

        public Entities.tb_employees ConsultarPorID(int id)
        {
            Entities.tb_employees emp = db.tb_employees.FirstOrDefault(t => t.id_emp == id);
            return emp;
        }

        public void Alterar(Entities.tb_employees emp, int id)
        {
            Entities.tb_employees tb = db.tb_employees.FirstOrDefault(t => t.id_emp == id);
            tb.nm_firstName = emp.nm_firstName;
            tb.nm_lastName = emp.nm_lastName;
            tb.nr_cpf = emp.nr_cpf;
            tb.nr_rg = emp.nr_rg;
            tb.nr_dependents = emp.nr_dependents;
            tb.ds_sex = emp.ds_sex;
            tb.dt_birth = emp.dt_birth;
            tb.ds_state = emp.ds_state;
            tb.nr_cep = emp.nr_cep;
            tb.ds_address = emp.ds_address;
            tb.ds_note = emp.ds_note;
            tb.nr_cellphone = emp.nr_cellphone;
            tb.nr_tellphone = emp.nr_tellphone;
            tb.ds_email = emp.ds_email;
            tb.pw_password = emp.pw_password;
            tb.dt_hiring = emp.dt_hiring;
            tb.dt_resignation = emp.dt_resignation;
            tb.bt_employee = emp.bt_employee;
            tb.bt_manager = emp.bt_manager;
            tb.bt_crm = emp.bt_crm;
            tb.bt_provider = emp.bt_provider;
            tb.bt_stock = emp.bt_stock;
            tb.bt_rh = emp.bt_rh;
            tb.bt_financial = emp.bt_financial;

            db.SaveChanges();
        }

        public void Remover(Entities.tb_employees emp)
        {
            db.tb_employees.Remove(emp);

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

        public int Insirir(Entities.tb_employees emp)
        {
            int idEmp = db.tb_employees.Max(t => t.id_emp) + 1;
            emp.id_emp = idEmp;

            db.tb_employees.Add(emp);
            db.SaveChanges();

            return idEmp;
        }

        public Entities.tb_employees ReturnEmployee(int id)
        {
            return db.tb_employees.FirstOrDefault(t => t.id_emp == id);
        }
    }
}
