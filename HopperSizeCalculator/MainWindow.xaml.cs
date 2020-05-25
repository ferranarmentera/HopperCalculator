using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HopperSizeCalculator
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            double PesoInyectada, CycleTime, TiempoSecMin, TiempoSecMax, MinDryerTime, MaxDryerTime;
            try
            {

                Console.WriteLine("Peso de la inyectada con coloada en gr");
                PesoInyectada = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ciclo /Segundos");
                CycleTime = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Tiempo de secado minimo / Horas ");
                TiempoSecMin = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Tiempo de secado máximo /horas");
                TiempoSecMax = Convert.ToDouble(Console.ReadLine());

                MinDryerTime = 3.6 * PesoInyectada / CycleTime * TiempoSecMin;
                MaxDryerTime = 3.6 * PesoInyectada / CycleTime * TiempoSecMax;

                Console.WriteLine("La capacidad minima de la estufa es de " + MinDryerTime + " Kg" + " y la maxima  de " + MaxDryerTime + " Kg");
                Console.ReadLine();

            }
            catch (FormatException)
            {
                Console.WriteLine("The value entered is not a number");
            }



        }
    }

}
  
