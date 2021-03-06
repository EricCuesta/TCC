﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liriou_s_Burguer.Database.Entities;

namespace Liriou_s_Burguer.Business
{
    class FinancialBusiness
    {
        Database.FinancialDatabase db = new Database.FinancialDatabase();

        public void insirir(tb_financial fin, int id)
        {
            fin.id_emp = id;

            db.Inserir(fin);
        }

        public string VericarParametros(tb_financial fin)
        {
            if (fin.vl_grossSalary == Convert.ToDecimal(0.0))
            {
                return "Salário Obrigatório!";
            }
            if (fin.ds_typeSalary == string.Empty)
            {
                return "Tipo de Salário Obrigatório!";
            }

            return string.Empty;
        }

        public string Verificar(string mesAno, string rg0)
        {
            if (rg0 == ",   ,   -")
            {
                return "Insira um RG!";
            }
            else if (mesAno == "/")
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
            return "Qtd " + tb.nr_dependents.ToString();
        }

        public string Bruto()
        {
            tb_financial tb = DB.tb_financial.First(t => t.id_emp == id);
            return "R$ " + tb.vl_grossSalary;
        }

        public string HorasÁPagar()
        {
            tb_points tb = DB.tb_points.First(t => t.id_emp == id);
            return tb.hr_toPay + " Hrs";
        }

        double SL = 0;
        public string ValeTransporte(int ano, int mes)
        {
            Model.PayrollModel.Tarifa = Convert.ToDecimal( 8.60 );

            tb_benefits tb = DB.tb_benefits.First(t => t.id_emp == id);
            tb_financial F = DB.tb_financial.First(t => t.id_emp == id);
            if (tb.bt_transport == true)
            {
                int qtdDiasUteis = this.QtdDeDiasUteis(ano, mes);
                double VL = Convert.ToDouble(Model.PayrollModel.Tarifa) * qtdDiasUteis;
                double bruto = Convert.ToDouble(F.vl_grossSalary);

                SL = bruto - (bruto * 0.06);
                return "R$ " + VL.ToString();
            }
            else
            {
                return "R$ 00,00";
            }
        }

        public string ValeAlimentação(int ano, int mes)
        {
            tb_benefits tb = DB.tb_benefits.First(t => t.id_emp == id);
            if (tb.bt_food == true)
            {
                int qtdDiasUteis = this.QtdDeDiasUteis(ano, mes);

                decimal VA = Convert.ToDecimal(qtdDiasUteis * tb.vl_food);
                return "R$ " + VA.ToString();
            }
            else
            {
                return "R$ 00,00";
            }
        }

        public string ValeRefeição(int ano, int mes)
        {
            tb_benefits tb = DB.tb_benefits.First(t => t.id_emp == id);
            if (tb.bt_meal == true)
            {
                int qtdDiasUteis = this.QtdDeDiasUteis(ano, mes);

                decimal VR = Convert.ToDecimal(qtdDiasUteis * tb.vl_meal);
                return "R$ " + VR.ToString();
            }
            else
            {
                return "R$ 00,00";
            }
        }

        public string SeguroDeVida()
        {
            tb_benefits tb = DB.tb_benefits.First(t => t.id_emp == id);
            if (tb.bt_lifeSafe == true)
            {
                return "R$ " + tb.vl_lifeSafe.ToString();
            }
            else
            {
                return "R$ 00,00";
            }
        }

        public string PlanoDeSaúde()
        {
            tb_benefits tb = DB.tb_benefits.First(t => t.id_emp == id);
            if (tb.bt_planHealth == true)
            {
                return "R$ " + tb.vl_planHealth.ToString();
            }
            else
            {
                return "R$ 00,00";
            }
        }

        public string PlanoDental()
        {
            tb_benefits tb = DB.tb_benefits.First(t => t.id_emp == id);
            if (tb.bt_planDental == true)
            {
                return "R$ " + tb.vl_planDental.ToString();
            }
            else
            {
                return "R$ 00,00";
            }
        }

        public string SalárioFamília()
        {
            tb_employees tb = DB.tb_employees.First(t => t.id_emp == id);
            tb_financial financial = DB.tb_financial.First(t => t.id_emp == id);

            double bruto = Convert.ToDouble(financial.vl_grossSalary);
            double SF;
            if (bruto <= 907.77)
            {
                 SF = tb.nr_dependents * 46.54;
            }
            else if (bruto > 907.77 && bruto < 1364.43)
            {
                SF = tb.nr_dependents * 32.80;
            }
            else
            {
                SF = 00.00;
            }

            SL = SL + SF;
            return "R$ " + SL.ToString();
        }

        double inss = 00.00;
        public string INSS()
        {
            tb_financial financial = DB.tb_financial.First(t => t.id_emp == id);

            double bruto = Convert.ToDouble(financial.vl_grossSalary);
            if (bruto <= 1659.38)
            {
                inss = bruto * 0.08;
            }
            if (bruto > 1659.38 && bruto <= 2765.66)
            {
                inss = bruto * 0.09;
            }
            if (bruto >= 2765.67 &&  bruto <= 5531.31)
            {
                inss = bruto * 0.11;
            }
            if (bruto > 5531.31)
            {
                inss = 00.00;
            }

            SL = SL - inss;
            return "R$ " + inss.ToString();
        }

        public string PensãoAlimentícia()
        {
            tb_discounts tb = DB.tb_discounts.First(t => t.id_emp == id);
            return "R$ " + tb.vl_foodPension.ToString();
        }

        public string ImpostoDeRenda()
        {
            tb_financial financial = DB.tb_financial.First(t => t.id_emp == id);
            tb_employees tb = DB.tb_employees.First(t => t.id_emp == id);

            double bruto = Convert.ToDouble(financial.vl_grossSalary);
            double IR = 00.00;
            double aliquota = 00.00;
            double dedução = 00.00;
            if (bruto <= 1903.98)
            {
                aliquota = 0.0;
                dedução = 0.0;
            }
            if (bruto >= 1903.99 && bruto <= 2826.65)
            {
                aliquota = 0.075;
                dedução = 142.80;
            }
            if (bruto >= 2826.66 && bruto <= 3751.05)
            {
                aliquota = 0.15;
                dedução = 354.80;
            }
            if (bruto >= 3751.06 && bruto <= 4664.68)
            {
                aliquota = 0.225;
                dedução = 636.13;
            }
            if (bruto >= 4664.69)
            {
                aliquota = 0.275;
                dedução = 869.36;
            }

            double dependentes = tb.nr_dependents * 189.59;
            IR = ((bruto - dependentes - inss) * aliquota) - dedução;
            return "R$ " + IR.ToString();
        }

        public string FGTS()
        {
            tb_financial F = DB.tb_financial.First(t => t.id_emp == id);
            double fgts = Convert.ToDouble(F.vl_grossSalary) * 0.08;

            return "R$ " + fgts.ToString();
        
        }

        public string Liquido()
        {
            return "R$ " + SL;
        }

        public void Alterar(tb_financial fin, int id)
        {
            fin.id_emp = id;

            db.Alterar(fin);
        }

        public tb_financial ConsultarPorID(int id)
        {
            return db.ConsultarPorID(id);
        }

        public void Remover(tb_financial fin)
        {
            db.Remover(fin);
        }
    }
}
