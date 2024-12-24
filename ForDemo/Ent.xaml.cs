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
    /// Логика взаимодействия для Ent.xaml
    /// </summary>
    public partial class Ent : Page
    {
        public Ent()
        {
            InitializeComponent();

        }

        private void EntB_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == null || Password.Text == null)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                People a = ForDemEntities1.GetContext().People.FirstOrDefault(x=> x.Password == Password.Text && x.Login == Login.Text);

                if (a != null)
                {
                    if (a.id_role == 1)
                    {
                        AppFrame.frmmain.Navigate(new AdminPG());
                    }
                    if (a.id_role == 2)
                    {

                    }
                }
            }

        }
    }
}
