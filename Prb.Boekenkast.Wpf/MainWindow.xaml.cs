using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace Prb.Boekenkast.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool isNieuw;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void SituatieStandaard()
        {
            grpBoekenkast.IsEnabled = true;
            grpDetails.IsEnabled = false;
        }
        private void SituatieBewerk()
        {
            grpBoekenkast.IsEnabled = false;
            grpDetails.IsEnabled = true;
        }
        private void ControlsLeegmaken()
        {
            txtTitel.Text = "";
            txtJaar.Text = "";
            cmbAuteur.SelectedIndex = -1;
            lblNationaliteit.Content = "";
        }
        private void VulListbox()
        {
            lstBoeken.ItemsSource = null;
        }
        private void lstBoeken_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstBoeken.SelectedItem == null)
                return;
        }

        private void btnNieuw_Click(object sender, RoutedEventArgs e)
        {
            isNieuw = true;
            SituatieBewerk();
            ControlsLeegmaken();
            txtTitel.Focus();
        }

        private void btnWijzig_Click(object sender, RoutedEventArgs e)
        {
            if (lstBoeken.SelectedItem == null)
                return;
            isNieuw = false;
            SituatieBewerk();
            txtTitel.Focus();
        }

        private void btnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            if (lstBoeken.SelectedItem == null)
                return;
        }



        private void btnBewaren_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAnnuleren_Click(object sender, RoutedEventArgs e)
        {
            ControlsLeegmaken();
            SituatieStandaard();
            if(lstBoeken.SelectedIndex >= 0)
            {
                lstBoeken_SelectionChanged(null, null);
            }
        }

        private void cmbAuteur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
