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
            if (emp.ds_email == "gerente@gmail.com" && emp.pw_password == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
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

        public List<Entities.tb_employees> Consultar()
        {
            List<Entities.tb_employees> list = db.tb_employees.ToList();

            return list;
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

    }
}
