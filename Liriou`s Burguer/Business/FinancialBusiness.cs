using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liriou_s_Burguer.Database.Entities;

namespace Liriou_s_Burguer.Business
{
    class FinancialBusiness
    {
        public void Inserir(Database.Entities.tb_financial financial)
        {
            Database.FinancialDatabase DB = new Database.FinancialDatabase();
            DB.Inserir(financial);
        }

        public string Verificar(Model.PayrollModel model)
        {
            if (model.RG == ",   ,   -")
            {
                return "Insira um RG!";
            }
            else if (model.data == "/")
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
            Database.FinancialDatabase DB = new Database.FinancialDatabase();
            id = DB.Consultar(rg);
        }

        liriousdbEntities DB = new liriousdbEntities();
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
            tb_employees tb = DB.tb_employees.First(t => t.id_emp == id);
            return tb.nm_firstName + " " + tb.nm_lastName;
        }

        public string Dependents()
        {
            tb_employees tb = DB.tb_employees.First(t => t.id_emp == id);
            return tb.ds_dependents.ToString();
        }

        public string Bruto()
        {
            tb_financial tb = DB.tb_financial.First(t => t.id_emp == id);
            return "R$ " + tb.vl_grossSalary;
        }

        public string HorasÁPagar()
        {
            tb_points tb = DB.tb_points.First(t => t.id_emp == id);
            return tb.vl_hoursToPay + " Hrs";
        }

        decimal SL = 0;
        public string ValeTransporte(int ano, int mes)
        {
            tb_benefits tb = DB.tb_benefits.First(t => t.id_emp == id);
            tb_financial F = DB.tb_financial.First(t => t.id_emp == id);
            if (tb.bl_transport.ToUpper() == "TRUE")
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
            tb_benefits tb = DB.tb_benefits.First(t => t.id_emp == id);
            if (tb.bl_food.ToUpper() == "TRUE")
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

        public void Alterar(tb_financial financial)
        {
            Database.FinancialDatabase DB = new Database.FinancialDatabase();
            DB.Alterar(financial);
        }

        public void Remover(int id)
        {
            Database.FinancialDatabase DB = new Database.FinancialDatabase();
            DB.Remover(id);
        }


    }
}
