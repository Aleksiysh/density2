using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Плотность
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }

        static double ToDouble(String str)
        {
            str = str.Replace(".", ",");
            return Convert.ToDouble(str); ;
        }

        public static string CalcDispense(string dens20, string t)
        {
            var denss = new double[] {
                    0.65,0.66,0.67,0.68,0.69,0.7,0.71,0.72,
                    0.73,0.74,0.75,0.76,0.77,0.78,0.79,0.8,
                    0.81,0.82,0.83,0.84,0.85,0.86,0.87,0.88,
                    0.89,0.9,0.91,0.92,0.93,0.94,0.95,0.96,
                    0.97,0.98,0.99};
            var k = new double[] {
                    0.000962,0.000949,0.000936,0.000925,0.00091,0.000897,0.000884,
                    0.00087,0.000857,0.000844,0.000831,0.000818,0.000805,0.000792,
                    0.000778,0.000765,0.000752,0.000738,0.000725,0.000712,0.000699,
                    0.000686,0.000673,0.00066,0.000647,0.000633,0.00062,0.000607,
                    0.000594,0.000581,0.000567,0.000554,0.000541,0.000528,0.000515};

            var i = 0;
            //Console.Write("Плотность при 20 Гр.С :");
            var dbdens20 = ToDouble(dens20);
            //Console.Write("Текущая температура: ");
            var dbt = ToDouble(t);
            
            if(dbdens20<0.650 ||dbdens20>1)
            {
                return "ОШИБКА";
            }
            for (i = denss.Length - 1; i >= 0; i--)
            {
                if (dbdens20 >= denss[i])
                {
                    break;
                }
            }
        
            return Convert.ToString (dbdens20 + (k[i] * (20 - dbt)));
        }
    }
}
