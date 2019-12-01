using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liriou_s_Burguer.Database.Entities;

namespace Liriou_s_Burguer.Business
{
    class TimeCardBusiness
    {
        Database.TimeCardDatabase db = new Database.TimeCardDatabase();

        public void Insirir(tb_timecard ticd, int id)
        {
            ticd.id_emp = id;

            db.Inserir(ticd);
        }

        public string VericarParametros(tb_timecard ticd)
        {
            if (ticd.hr_fixedInput == string.Empty || ticd.hr_fixedOutput == string.Empty
            || ticd.hr_fixedIntInput == string.Empty || ticd.hr_fixedIntOutput == string.Empty)
            {
                return "Horários de entrada e saída Obrigatórios!";
            }

            return string.Empty;
        }

        public List<tb_timecard> Consultar()
        {
            List<tb_timecard> list = db.Consultar();
            return list;
        }

        public void Alterar(tb_timecard ticd, int id)
        {
            ticd.id_emp = id;

            db.Alterar(ticd);
        }

        public tb_timecard ConsultarPorID(int id)
        {
            return db.ConsultarPorID(id);
        }

        public void Remover(tb_timecard ticd)
        {
            db.Remover(ticd);
        }
    }
}
