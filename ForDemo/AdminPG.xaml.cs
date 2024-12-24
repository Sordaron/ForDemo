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

namespace ForDemo
{
    /// <summary>
    /// Логика взаимодействия для AdminPG.xaml
    /// </summary>
    public partial class AdminPG : Page
    {
        public AdminPG()
        {
            InitializeComponent();
            DG.ItemsSource = ForDemEntities1.GetContext().Zayavki.ToList();



            var a = ForDemEntities1.GetContext().Zayavki.Where(x => x.Status == 1).ToList();
            var b = a.Average(X => X.DateAVG);
            AVGHour.Text = b.ToString();
            CouT.Text  = ForDemEntities1.GetContext().Zayavki.Where(x=> x.Status ==1).Count().ToString();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            EdanaAd edanaAd = new EdanaAd((sender as Button).DataContext as Zayavki);
            edanaAd.ShowDialog();



            
            DG.ItemsSource = ForDemEntities1.GetContext().Zayavki.ToList();
        }
    }
}
