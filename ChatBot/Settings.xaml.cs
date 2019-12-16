using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChatBot
{
    /// <summary>
    /// Lógica de interacción para Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();

            FondoComboBox.ItemsSource = typeof(Colors).GetProperties();

            RobotComboBox.ItemsSource = typeof(Colors).GetProperties();

            UsuarioComboBox.ItemsSource = typeof(Colors).GetProperties();

        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {           
            
            Properties.Settings.Default.ColorFondo = FondoComboBox.SelectedItem.ToString();
            //Properties.Settings.Default.ColorRobot = RobotComboBox.SelectedValue.ToString();
            //Properties.Settings.Default.ColorUsuario = RobotComboBox.SelectedValue.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
