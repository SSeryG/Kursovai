using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using _1.Model;
using System.Windows.Forms;
using _1.View;

namespace _1
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            //Console.OutputEncoding = Encoding.UTF8;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());                        
            /*try
            {
                TFactory factory1 = new TFactory();
                Console.WriteLine(factory1.ShowSpiFactory());
                Console.WriteLine(factory1.FinalyPay());
                Console.WriteLine(factory1.MeanPay());
                Console.WriteLine(factory1.MaxPay());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
        }
    }
}
