using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class DepartmentDatabase
    {

        public void Inserir(Entities.tb_department department)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_department.Add(department);

            DB.SaveChanges();
        }

        public List<Entities.tb_department> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_department> list = DB.tb_department.ToList();

            return list;
        }

        public void Alterar(Entities.tb_department department)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_department list = DB.tb_department.First(t => t.id_department == department.id_department);
            list.nm_department = list.nm_department;
            

            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_department remover = DB.tb_department.First(t => t.id_department == id);

            DB.tb_department.Remove(remover);
            DB.SaveChanges();
        }
    }
}
