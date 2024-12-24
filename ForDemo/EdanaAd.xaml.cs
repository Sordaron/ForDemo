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
using System.Windows.Shapes;

namespace ForDemo
{
    /// <summary>
    /// Логика взаимодействия для EdanaAd.xaml
    /// </summary>
    public partial class EdanaAd : Window
    {
        Zayavki _Curent = new Zayavki();
        public EdanaAd(Zayavki _cur)
        {
            InitializeComponent();
            if (_cur != null)
            {
                _Curent = _cur;
            }


            Cli.SelectedValuePath = "Id";
            Cli.DisplayMemberPath = "Login";
            Cli.ItemsSource = ForDemEntities1.GetContext().People.Where(x=> x.id_role == 2).ToList();

            wo.SelectedValuePath = "Id";
            wo.DisplayMemberPath = "Login";
            wo.ItemsSource = ForDemEntities1.GetContext().People.Where(x => x.id_role == 3).ToList();

            StatusCB.SelectedValuePath = "Id";
            StatusCB.DisplayMemberPath = "Name";
            StatusCB.ItemsSource = ForDemEntities1.GetContext().Statuses.ToList();

            DataContext = _Curent;

        }

        private void EntB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ForDemEntities1.GetContext().SaveChanges();

                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
