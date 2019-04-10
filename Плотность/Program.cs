using System;
using System.Collections.Generic;
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

        public static double ToDouble(String str)
        {
            str = str.Replace(".", ",");
            return Convert.ToDouble(str); ;
        }

        //таблица средних температурных поправок плотности нефтепродуктов
        //Key Плотность при 20 Гр.С     Value температурная поправка
        private static readonly Dictionary<double, double> dict = new Dictionary<double, double> {
                {    0.65 ,    0.000962  },
                {    0.66 ,    0.000949  },
                {    0.67 ,    0.000936  },
                {    0.68 ,    0.000925  },
                {    0.69 ,    0.00091   },
                {    0.7  ,    0.000897  },
                {    0.71 ,    0.000884  },
                {    0.72 ,    0.00087   },
                {    0.73 ,    0.000857  },
                {    0.74 ,    0.000844  },
                {    0.75 ,    0.000831  },
                {    0.76 ,    0.000818  },
                {    0.77 ,    0.000805  },
                {    0.78 ,    0.000792  },
                {    0.79 ,    0.000778  },
                {    0.8  ,    0.000765  },
                {    0.81 ,    0.000752  },
                {    0.82 ,    0.000738  },
                {    0.83 ,    0.000725  },
                {    0.84 ,    0.000712  },
                {    0.85 ,    0.000699  },
                {    0.86 ,    0.000686  },
                {    0.87 ,    0.000673  },
                {    0.88 ,    0.00066   },
                {    0.89 ,    0.000647  },
                {    0.9  ,    0.000633  },
                {    0.91 ,    0.00062   },
                {    0.92 ,    0.000607  },
                {    0.93 ,    0.000594  },
                {    0.94 ,    0.000581  },
                {    0.95 ,    0.000567  },
                {    0.96 ,    0.000554  },
                {    0.97 ,    0.000541  },
                {    0.98 ,    0.000528  },
                {    0.99 ,    0.000515  }
            };

        
        // t1 температура фактическая
        // t2 температура расчетная
        // disp плотность при температуре t1
        // возвращает плотность при температуре t2
        public static double CalcDispenseVar(double t1, double t2, double disp)
        {
            foreach (var item in dict)
            {
                var d20 = (t1 - 20) * item.Value + disp;
                if (d20 >= item.Key && d20 < item.Key + 0.01)
                {
                    return (disp + (item.Value * (t1 - t2)));
                }
            }
            return 0;
        }
    }
}
