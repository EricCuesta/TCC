using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class TimeCardDatabase
    {
        Entities.liriousdbEntities db = new Entities.liriousdbEntities();

        public void Inserir(Entities.tb_timecard ticd)
        {
            db.tb_timecard.Add(ticd);

            db.SaveChanges();
        }

        public List<Entities.tb_timecard> Consultar()
        {
            List<Entities.tb_timecard> list = db.tb_timecard.ToList();

            return list;
        }

        public void Alterar(Entities.tb_timecard ticd)
        {
            Entities.tb_timecard tb = db.tb_timecard.FirstOrDefault(t => t.id_emp == ticd.id_emp);
            tb.hr_fixedInput = ticd.hr_fixedInput;
            tb.hr_fixedOutput = ticd.hr_fixedOutput;
            tb.hr_fixedIntInput = ticd.hr_fixedIntInput;
            tb.hr_fixedIntOutput = ticd.hr_fixedIntOutput;

            db.SaveChanges();
        }

        public void Remover(Entities.tb_timecard ticd)
        {
            db.tb_timecard.Remove(ticd);

            db.SaveChanges();
        }

        public Entities.tb_timecard ConsultarPorID(int id)
        {
            return db.tb_timecard.FirstOrDefault(t => t.id_emp == id);
        }
    }
}
