using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class EmployeesDatabase
    {
        public Entities.tb_employees Verificar(Entities.tb_employees verificar)
        {
            Entities.liriousdbEntities db = new Entities.liriousdbEntities();
            Entities.tb_employees database = db.tb_employees.FirstOrDefault(l => l.ds_cpf == verificar.ds_cpf ||
                                                                                 l.ds_rg == verificar.ds_rg ||
                                                                                 l.nr_cellphone == verificar.nr_cellphone);
            return database;
        }

        public void AlterarRecuperação(string senha, string cpf,
                                       string rg, string cell)
        {
            Entities.liriousdbEntities db = new Entities.liriousdbEntities();

            if (cpf != "         /")
            {
                Entities.tb_employees novo = db.tb_employees.First(u => u.ds_cpf == cpf);
                novo.pw_password = senha;
                db.SaveChanges();
            }
            else if (rg != string.Empty)
            {
                Entities.tb_employees novo = db.tb_employees.First(u => u.ds_rg == rg);
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
        public void Inserir(Entities.tb_employees employees)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_employees.Add(employees);

            DB.SaveChanges();
        }

        public List<Entities.tb_employees> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_employees> list = DB.tb_employees.ToList();

            return list;
        }
        public List<Entities.tb_employees> ConsultarPorTudo (Entities.tb_employees emp,
                                                             Entities.tb_department dept,
                                                             Entities.tb_function func)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List < Entities.tb_employees > list = null;

            if (emp.nm_firstName != null && emp.dt_birth != null &&
                emp.ds_sex != null && dept.nm_department != null &&
                func.nm_function != null)
            {
                list = DB.tb_employees.Where(t => t.nm_firstName == emp.nm_firstName &&
                                             t.dt_birth == emp.dt_birth &&
                                             t.ds_sex == emp.ds_sex).ToList();
                
            }

            return list;
        }
        public List<Entities.tb_employees> ConsultarFuncionario(string nome)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_employees> list = DB.tb_employees.Where(t => t.nm_firstName.Contains(nome)).ToList();
                
            return list;
        }
        public List<Entities.tb_employees> ConsultarFuncionarioRG(string rg)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_employees> list = DB.tb_employees.Where(t => t.ds_rg == rg).ToList();

            return list;
        }
       public List<Entities.tb_employees> ConsultarData(DateTime data)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_employees> list = DB.tb_employees.Where(t => t.dt_birth == data).ToList();
            return list;
        }


        public bool Login(string email, string senha)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            bool v = DB.tb_employees.Any(t => t.ds_email == email && t.pw_password == senha);

            if (v == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Alterar(Entities.tb_employees employees)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_employees list = DB.tb_employees.First(t => t.id_emp == employees.id_emp);

            list.ds_address = list.ds_address;
            list.nr_cellphone = list.nr_cellphone;
            list.ds_cep = list.ds_cep;
            list.ds_country = list.ds_country;
            list.ds_cpf = list.ds_cpf;
            list.nr_tellphone = list.nr_tellphone;
            list.ds_email = list.ds_email;
            list.ds_sex = list.ds_sex;
            list.ds_rg = list.ds_rg;
            list.ds_state = list.ds_state;
            list.dt_birth = list.dt_birth;
            list.dt_hiring = list.dt_hiring;
            list.dt_resignation = list.dt_resignation;
            list.nm_firstName = list.nm_firstName;
            list.nm_lastName = list.nm_lastName;
           
            list.ds_note= list.ds_note;
            list.pw_password = list.pw_password;
            
            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_employees remover = DB.tb_employees.First(t => t.id_emp == id);

            DB.tb_employees.Remove(remover);
            DB.SaveChanges();
        }

        public Entities.tb_employees BuscarPorID(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_employees list = DB.tb_employees.First(t => t.id_emp == id);
            return list;
        }
    }
}
