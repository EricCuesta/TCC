using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class DepartmentDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_department department)
        {
            db.tb_department.Add(department);

            db.SaveChanges();
        }

        public Entities.tb_department ConsultaPorID(int id)
        {
            Entities.tb_department department = db.tb_department.FirstOrDefault(t => t.id_department == id);

            return department;
        }

        public List<Entities.tb_department> ConsultarPorNome(Entities.tb_department department)
        {
            List<Entities.tb_department> list = db.tb_department.Where(l => l.nm_department == department.nm_department).ToList();

            return list;
        }

        public List<Entities.tb_department> ConsultarTodos()
        {
            List<Entities.tb_department> list = db.tb_department.ToList();

            return list;
        }

        public void Alterar(Entities.tb_department department)
        {
            Entities.tb_department list = db.tb_department.First(t => t.id_department == department.id_department);
            list.nm_department = department.nm_department;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_department remover = db.tb_department.First(t => t.id_department == id);

            db.tb_department.Remove(remover);
            db.SaveChanges();
        }
    }
}
