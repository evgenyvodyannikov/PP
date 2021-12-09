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

namespace isrpo_2.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {

        Entities context = new Entities();
        public LoginPage()
        {
            InitializeComponent();
            GetLogins();

        }

        public void GetLogins()
        {
            for (int i = 1; i <= context.Client.ToArray().Length; i++)
                LoginTB.Items.Add(context.Client.Find(i).Login);
        }



        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            string password = context.Client.Where(client => client.Login == LoginTB.SelectedItem).Single().Password;
            if(PasswordB.Password == password)
            {
                MessageBox.Show("ok");
            }    

        }
    }
}
