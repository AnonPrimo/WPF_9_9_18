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

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cm.Items.Add(0);
            cm.Items.Add(5);
            cm.Items.Add(15);
            cm.Items.Add(30);
            cm.Items.Add(45);
            cm.Items.Add(60);
            cm.Items.Add(90);
            cm.Items.Add(120);
            cm.Items.Add(150);
            cm.Items.Add(180);
            cm.Items.Add(200);
            cm.Items.Add(250);

        }
    }
}
