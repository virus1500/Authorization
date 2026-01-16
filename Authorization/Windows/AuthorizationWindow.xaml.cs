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

namespace Authorization.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {

        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(PassPb.ToString()) || string.IsNullOrEmpty(LoginTb.Text))
            {
                MessageBox.Show("Введите логин и/или пароль", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (LoginTb.Text=="false" || PassPb.ToString()=="null") 
                {
                    MessageBox.Show("Неверныей логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    
                }
            }
        }
    }
}
