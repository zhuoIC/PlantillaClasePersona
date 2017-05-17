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
//-----------------------------
using NHJ.Wpf_EnlacesDataContextAClases;

namespace Wpf_PlantillaClasePersona
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListaPersonas _listaPersonas = null;
        int indice = 1;

        public MainWindow()
        {
            InitializeComponent();
            _listaPersonas = new ListaPersonas();
            grdDatos.DataContext = _listaPersonas;
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            Persona unaPersona = _listaPersonas[indice++ % _listaPersonas.Count()];
            grdDatos.DataContext = unaPersona;
        }
    }
}
