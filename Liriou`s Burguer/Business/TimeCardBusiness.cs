using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class TimeCardBusiness
    {
        Database.TimeCardDatabase db = new Database.TimeCardDatabase();

        public void Inserir(Database.Entities.tb_timecard ticd)
        {
            if (ticd.hr_fixedInput == string.Empty || ticd.hr_fixedOutput == string.Empty
            || ticd.hr_fixedIntInput == string.Empty || ticd.hr_fixedIntOutput == string.Empty)
            {
                throw new ArgumentException("Horários de entrada e saída Obrigatórios!");
            }

            Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
            ticd.id_emp = DB.InsertEmp(Model.EmployeesModel.CPF);

            db.Inserir(ticd);
        }

        public List<Database.Entities.tb_timecard> Consultar()
        {
            List<Database.Entities.tb_timecard> list = db.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_timecard timecard, Database.Entities.tb_points points)
        {
            db.Alterar(timecard, points);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
