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

namespace wpfBank.Pages
{

    public partial class Log : Page
    {
        private User currentUser;
        public Log(User currentUser)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Deposist deposist = new Deposist();
            this.NavigationService.Navigate(deposist);
        }
        private void Tarif_Click(object sender, RoutedEventArgs e)
        {
            Tariff tariffPage = new Tariff();
            this.NavigationService.Navigate(tariffPage);
        }
    }
}
