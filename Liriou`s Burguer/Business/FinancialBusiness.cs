using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class FinancialBusiness
    {
        Database.FinancialDatabase db = new Database.FinancialDatabase();

        public void Inserir(Database.Entities.tb_financial financial)
        {
            db.Inserir(financial);
        }

        public string Verificar(string mesAno, string rg0)
        {
            if (Model.PayrollModel.RG == ",   ,   -")
            {
                return "Insira um RG!";
            }
            else if (Model.PayrollModel.data == "/")
            {
                return "insira um mes/ano";
            }
            else
            {
                return "";
            }
        }

        int id;
        public void Consultar(string rg)
        {
            id = db.Consultar(rg);
        }

        Database.Entities.liriousdbEntities DB = new Database.Entities.liriousdbEntities();
        public int QtdDeDiasUteis(int ano, int mes)
        {
            int qtdDias = DateTime.DaysInMonth(ano, mes);

            int qtdDiasUteis = 0;
            for (int i = 1; i <= qtdDias; i++)
            {
                DateTime data = new DateTime(ano, mes, i);
                DayOfWeek day = data.DayOfWeek;
                int s = Convert.ToInt32(day);

                if (s != 6 && s != 0)
                {
                    qtdDiasUteis = qtdDiasUteis + 1;
                }
            }

            return qtdDiasUteis;
        }

        public string NomeCompleto()
        {
            Database.Entities.tb_employees tb = DB.tb_employees.First(t => t.id_emp == id);
            return tb.nm_firstName + " " + tb.nm_lastName;
        }

        public string Dependents()
        {
            Database.Entities.tb_employees tb = DB.tb_employees.First(t => t.id_emp == id);
            return tb.nr_dependents.ToString();
        }

        public string Bruto()
        {
            Database.Entities.tb_financial tb = DB.tb_financial.First(t => t.id_emp == id);
            return "R$ " + tb.vl_grossSalary;
        }

        public string HorasÁPagar()
        {
            Database.Entities.tb_points tb = DB.tb_points.First(t => t.id_emp == id);
            return tb.hr_toPay + " Hrs";
        }

        decimal SL = 0;
        public string ValeTransporte(int ano, int mes)
        {
            Database.Entities.tb_benefits tb = DB.tb_benefits.First(t => t.id_emp == id);
            Database.Entities.tb_financial F = DB.tb_financial.First(t => t.id_emp == id);
            if (tb.bt_transport == true)
            {
                int qtdDiasUteis = this.QtdDeDiasUteis(ano, mes);

                decimal VL = Convert.ToDecimal(qtdDiasUteis * 8.60);

                double bruto = Convert.ToDouble(F.vl_grossSalary);
                SL = Convert.ToDecimal(bruto - bruto * 0.06);

                return "R$ " + VL.ToString();
            }
            else
            {
                SL = 0;
                return "R$ 00,00";
            }
        }

        public string ValeAlimentação(int ano, int mes)
        {
            Database.Entities.tb_benefits tb = DB.tb_benefits.First(t => t.id_emp == id);
            if (tb.bt_food == true)
            {
                int qtdDiasUteis = this.QtdDeDiasUteis(ano, mes);

                decimal VA = Convert.ToDecimal(qtdDiasUteis * 30);
                return "R$ " + VA.ToString();
            }
            else
            {
                return "R$ 00,00";
            }
        }

        public string Liquido()
        {
            return "R$ " + SL;
        }

        public void Alterar(Database.Entities.tb_financial financial)
        {
            db.Alterar(financial);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
