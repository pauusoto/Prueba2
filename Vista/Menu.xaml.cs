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
using MahApps.Metro.Controls;

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Menu : MetroWindow
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnAdministracionClientes_Click(object sender, RoutedEventArgs e)
        {
            AdmiClientes admi = new AdmiClientes();
            admi.Show();
        }

        private void BtnListadoClientes_Click(object sender, RoutedEventArgs e)
        {
            ListaClientes lista_clientes = new ListaClientes();
            lista_clientes.Show();
        }

        private void BtnContratos_Click(object sender, RoutedEventArgs e)
        {
            AdmiContratos admiCon = new AdmiContratos();
            admiCon.Show();

        }

        private void BtnListadoContratos_Click(object sender, RoutedEventArgs e)
        {
            ListaContratos lista_contra = new ListaContratos();
            lista_contra.Show();
        }
    }
}
