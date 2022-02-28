using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
  
    public partial class MainWindow : Window
    {
        SchoolPortalEntities x = new SchoolPortalEntities();
        int id_p = Convert.ToInt32(App.Current.Resources["id"]);
        string gat = "";
        public MainWindow()
        {
            InitializeComponent();          
            var g = x.Students.Single(g1 => g1.id_Student == id_p);
            tb1.Text = g.Last_name +" "+ g.First_name + " " + g.Middle_name;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данная функция, не доработана, приношу свои извинения", "Оповещения", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {        
            var g = x.Grades_Students.Where(g1 => g1.id_Student == id_p);          
            dt1.ItemsSource = g.ToList();

            dt1.Visibility = Visibility.Visible;
            dg2.Visibility = Visibility.Hidden;

            bt6.Visibility = Visibility.Visible;
            bt7.Visibility = Visibility.Visible;
            bt5.Visibility = Visibility.Hidden;
            bt4.Visibility = Visibility.Hidden;
            bt2.Visibility = Visibility.Hidden;
            cb1.Visibility = Visibility.Hidden;
            lb1.Visibility = Visibility.Hidden;
            Rtb.Visibility = Visibility.Hidden;
            tb3.Visibility = Visibility.Hidden;
            lb2.Visibility = Visibility.Hidden;
            lb3.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {           
            dg2.ItemsSource = x.Schedule.ToList();
            dt1.Visibility = Visibility.Hidden;
            dg2.Visibility = Visibility.Visible;

            bt6.Visibility = Visibility.Visible;
            bt7.Visibility = Visibility.Visible;
            bt5.Visibility = Visibility.Hidden;
            bt4.Visibility = Visibility.Hidden;
            bt2.Visibility = Visibility.Hidden;
            cb1.Visibility = Visibility.Hidden;
            lb1.Visibility = Visibility.Hidden;
            Rtb.Visibility = Visibility.Hidden;
            tb3.Visibility = Visibility.Hidden;
            lb2.Visibility = Visibility.Hidden;
            lb3.Visibility = Visibility.Hidden;
        }

        private void Bt5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sr = new StreamReader("Чат_" + cb1.Text + "_" + App.Current.Resources["id"] + ".txt");
                string text = sr.ReadToEnd();

                var document = new FlowDocument();
                var paragraph = new Paragraph();
                paragraph.Inlines.Add(text);
                document.Blocks.Add(paragraph);
                Rtb.Document = document;
                gat = "Чат_" + cb1.Text + "_"+App.Current.Resources["id"]+".txt";

            }
            catch
            {
                MessageBox.Show("Выберите один из чатов", "Ошибка при выборе", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (gat == "")
            {
                MessageBox.Show("Выберите один из чатов", "Ошибка при выборе", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (tb3.Text != "" && tb3.Text != " " && tb3.Text != "  " && tb3.Text != "   " && tb3.Text != "    ")
                {
                    try
                    {
                        StreamWriter f = new StreamWriter(gat, true);
                        f.WriteLine("");
                        f.WriteLine("" + tb1.Text + ": " + tb3.Text + "");
                        f.Close();

                        var sr = new StreamReader(gat);
                        string text = sr.ReadToEnd();
                        var document = new FlowDocument();
                        var paragraph = new Paragraph();
                        paragraph.Inlines.Add(text);
                        document.Blocks.Add(paragraph);
                        Rtb.Document = document;
                        tb3.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Подождите перед повторной отправкой", "Отправка", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Сообщение не должно быть пустым.", "Ошибка при отправке", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void Bt7_Click(object sender, RoutedEventArgs e)
        {
            bt6.Visibility = Visibility.Hidden;
            bt7.Visibility = Visibility.Hidden;
            dt1.Visibility = Visibility.Hidden;
            dg2.Visibility = Visibility.Hidden;
            bt5.Visibility = Visibility.Visible;
            bt4.Visibility = Visibility.Visible;
            bt2.Visibility = Visibility.Visible;
            cb1.Visibility = Visibility.Visible;
            lb1.Visibility = Visibility.Visible;
            Rtb.Visibility = Visibility.Visible;
            tb3.Visibility = Visibility.Visible;
            lb2.Visibility = Visibility.Visible;
            lb3.Visibility = Visibility.Visible;
        }

        private void Bt4_Click(object sender, RoutedEventArgs e)
        {
            bt6.Visibility = Visibility.Visible;
            bt7.Visibility = Visibility.Visible;
            dt1.Visibility = Visibility.Visible;
            dg2.Visibility = Visibility.Visible;
            bt5.Visibility = Visibility.Hidden;
            bt4.Visibility = Visibility.Hidden;
            bt2.Visibility = Visibility.Hidden;
            cb1.Visibility = Visibility.Hidden;
            lb1.Visibility = Visibility.Hidden;
            Rtb.Visibility = Visibility.Hidden;
            tb3.Visibility = Visibility.Hidden;
            lb2.Visibility = Visibility.Hidden;
            lb3.Visibility = Visibility.Hidden;
        }
    }
}
