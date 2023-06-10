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
using classlibrary;
using my_class_library;

namespace classlibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            {
                List<Vehicle> vehicles = new List<Vehicle>();

                InitializeComponent();

                Air air = new Air("green");
                Land car = new Land("purple", 4);
                Plane plane = new Plane("Pink", 3);
                Helicopter helicopter = new Helicopter("orange", 2);
                Sea submarine = new Sea("Green", "Submarine");

                vehicles.Add(car);
                vehicles.Add(plane);
                vehicles.Add(helicopter);
                vehicles.Add(submarine);
                vehicles.Add(air);

                foreach (Vehicle vehicle in vehicles)
                {
                    MessageBox.Show(vehicle.ToString());
                }
            }
        }
    }
}
