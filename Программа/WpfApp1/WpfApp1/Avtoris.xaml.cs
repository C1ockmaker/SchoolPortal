using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Avtoris.xaml
    /// </summary>
    public partial class Avtoris : Window
    {
        SchoolPortalEntities x = new SchoolPortalEntities();

        public Avtoris()
        {
            InitializeComponent();
        }
               
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(cb1.IsChecked == true && cb2.IsChecked != true)
            {
                try
                {
                    var loginpass = x.Students.Single(g => g.Login == tb1.Text && g.Password == tb2.Text);
                    if (loginpass.Login == tb1.Text && loginpass.Password == tb2.Text)
                    {
                        App.Current.Resources["id"] = loginpass.id_Student;
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Hide();                  
                    }
                    else
                    {
                        MessageBox.Show("Проверьте правильность ввода логина, пароля или выбранного пункта.", "Ошибка при входе", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Проверьте правильность ввода логина, пароля или выбранного пункта.", "Ошибка при входе", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                if (cb2.IsChecked == true && cb1.IsChecked != true)
                {
                    try
                    {
                        var loginpass1 = x.Teachers.Single(g => g.Login == tb1.Text && g.Password == tb2.Text);
                        if (loginpass1.Login == tb1.Text && loginpass1.Password == tb2.Text)
                        {
                            App.Current.Resources["id"] = loginpass1.id_Teacher;
                            Teacher teacher = new Teacher();
                            teacher.Show();
                            this.Hide();                            
                        }
                        else
                        {
                            MessageBox.Show("Проверьте правильность ввода логина или пароля.", "Ошибка при входе", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Проверьте правильность ввода логина, пароля или выбранного пункта.", "Ошибка при входе", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Проверьте правильность выбранного пункта", "Ошибка при входе", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }


           
        }
    }
}
