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
                                                                                 l.mr_tellphone == verificar.mr_tellphone ||
                                                                                 l.mr_cellphone == verificar.mr_cellphone);
            return database;
        }

        public void AlterarRecuperação(Entities.tb_employees alterar)
        {
            Entities.liriousdbEntities db = new Entities.liriousdbEntities();
            Entities.tb_employees novo = db.tb_employees.First(u => u.id_emp == Model.UsuarioLogado.ID);

            novo.ds_password = alterar.ds_password;

            db.SaveChanges();
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

        public List<Entities.tb_employees> Login(string email, string senha)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_employees> list = DB.tb_employees.Where(t => t.ds_email == email && t.ds_password == senha).ToList();

            return list;
        }

        public void Alterar(Entities.tb_employees employees)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_employees list = DB.tb_employees.First(t => t.id_emp == employees.id_emp);

            list.ds_address = list.ds_address;
            list.mr_cellphone = list.mr_cellphone;
            list.ds_cep = list.ds_cep;
            list.ds_country = list.ds_country;
            list.ds_cpf = list.ds_cpf;
            list.mr_tellphone = list.mr_tellphone;
            list.ds_email = list.ds_email;
            list.ds_sex = list.ds_sex;
            list.ds_rg = list.ds_rg;
            list.ds_state = list.ds_state;
            list.dt_birth = list.dt_birth;
            list.dt_hiring = list.dt_hiring;
            list.dt_resignation = list.dt_resignation;
            list.nm_firstName = list.nm_firstName;
            list.nm_lastName = list.nm_lastName;
            list.vl_qtdDependents = list.vl_qtdDependents;
            list.ds_complement = list.ds_complement;
            list.ds_password = list.ds_password;
            
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
