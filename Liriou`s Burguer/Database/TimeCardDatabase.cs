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

        public void Inserir(Entities.tb_timecard timecard)
        {
            db.tb_timecard.Add(timecard);

            db.SaveChanges();
        }

        public List<Entities.tb_timecard> Consultar()
        {
            List<Entities.tb_timecard> list = db.tb_timecard.ToList();

            return list;
        }

        public void Alterar(Entities.tb_timecard timecard, Entities.tb_points points)
        {
            Entities.tb_timecard list = db.tb_timecard.First(t => t.id_timecard == timecard.id_timecard);
            Entities.tb_points list1 = db.tb_points.First(t => t.id_point == points.id_point);
            list.hr_fixedInput = list.hr_fixedInput;
            list.hr_fixedOutput = list.hr_fixedOutput;
            list.hr_fixedInput = list.hr_fixedInput;
            list.hr_fixedIntOutput = list.hr_fixedIntOutput;
            list1.hr_input = list1.hr_input;
            list1.hr_output = list1.hr_output;
            list1.hr_intInput = list1.hr_intInput;
            list1.hr_intOutput = list1.hr_intOutput;
            list1.hr_toPay = list1.hr_toPay;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_timecard remover = db.tb_timecard.First(t => t.id_timecard == id);

            db.tb_timecard.Remove(remover);
            db.SaveChanges();
        }
    }
}
