using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Teacher.xaml
    /// </summary>
    public partial class Teacher : Window
    {
        SchoolPortalEntities school = new SchoolPortalEntities();
        int id_p = Convert.ToInt32(App.Current.Resources["id"]);
        int proverk = 0;
        int dat = 0;
        int ida = 0;
        string gafa;
        int ida1 = 0;
        string gat;
        string teachles;
        public Teacher()
        {
            InitializeComponent();

            var g = school.Teachers.Single(g1 => g1.id_Teacher == id_p);
            tb1.Text = g.FIO_Teacher;

            var h = g.Subject;

            if (h == "Algebra")
            {
                tb2.Text = "Алгебре";
                teachles = "Алгебра";
                dat = school.Schedule.Max(m => m.id_Day);
                for (int i = 1; i <= dat; i++)
                {
                    try
                    {
                        var sich = school.Schedule.Where(q => q.Lesson1 == "Algebra" || q.Lesson2 == "Algebra" || q.Lesson3 == "Algebra" || q.Lesson4 == "Algebra" || q.Lesson5 == "Algebra" || q.Lesson6 == "Algebra");
                        var chis = sich.Single(j => j.id_Day == i);

                        gafa = Convert.ToString(chis.Date);
                        string[] dan = gafa.Split(new char[] { ' ' });
                        string[] dan1 = dan[0].Split(new char[] { '.' });
                        cb3.Items.Add(dan1[0] + "/" + dan1[1] + "/" + dan1[2]);
                        cb5.Items.Add(dan1[0] + "/" + dan1[1] + "/" + dan1[2]);
                    }
                    catch
                    {
                    }
                }

            }
            if (h == "Geometry")
            {
                tb2.Text = "Геометрии";
                teachles = "Геометрия";
                dat = school.Schedule.Max(m => m.id_Day);

                for (int i = 1; i <= dat; i++)
                {
                    try
                    {
                        var sich = school.Schedule.Where(q => q.Lesson1 == "Geometry" || q.Lesson2 == "Geometry" || q.Lesson3 == "Geometry" || q.Lesson4 == "Geometry" || q.Lesson5 == "Geometry" || q.Lesson6 == "Geometry");
                        var chis = sich.Single(j => j.id_Day == i);

                        gafa = Convert.ToString(chis.Date);
                        string[] dan = gafa.Split(new char[] { ' ' });
                        string[] dan1 = dan[0].Split(new char[] { '.' });
                        cb3.Items.Add(dan1[0] + "/" + dan1[1] + "/" + dan1[2]);
                        cb5.Items.Add(dan1[0] + "/" + dan1[1] + "/" + dan1[2]);
                    }
                    catch
                    {
                    }
                }

            }
            if (h == "Russian language")
            {
                tb2.Text = "Русскому языку";
                teachles = "Русский_язык";

                dat = school.Schedule.Max(m => m.id_Day);


                for (int i = 1; i <= dat; i++)
                {
                    try
                    {
                        var sich = school.Schedule.Where(q => q.Lesson1 == "Russian language" || q.Lesson2 == "Russian language" || q.Lesson3 == "Russian language" || q.Lesson4 == "Russian language" || q.Lesson5 == "Russian language" || q.Lesson6 == "Russian language");
                        var chis = sich.Single(j => j.id_Day == i);

                        gafa = Convert.ToString(chis.Date);
                        string[] dan = gafa.Split(new char[] { ' ' });
                        string[] dan1 = dan[0].Split(new char[] { '.' });
                        cb3.Items.Add(dan1[0] + "/" + dan1[1] + "/" + dan1[2]);
                        cb5.Items.Add(dan1[0] + "/" + dan1[1] + "/" + dan1[2]);
                    }
                    catch
                    {
                    }
                }
            }
            if (h == "Literature")
            {
                tb2.Text = "Литературе";
                teachles = "Литература";
                dat = school.Schedule.Max(m => m.id_Day);
                for (int i = 1; i <= dat; i++)
                {
                    try
                    {
                        var sich = school.Schedule.Where(q => q.Lesson1 == "Literature" || q.Lesson2 == "Literature" || q.Lesson3 == "Literature" || q.Lesson4 == "Literature" || q.Lesson5 == "Literature" || q.Lesson6 == "Literature");
                        var chis = sich.Single(j => j.id_Day == i);

                        gafa = Convert.ToString(chis.Date);
                        string[] dan = gafa.Split(new char[] { ' ' });
                        string[] dan1 = dan[0].Split(new char[] { '.' });
                        cb3.Items.Add(dan1[0] + "/" + dan1[1] + "/" + dan1[2]);
                        cb5.Items.Add(dan1[0] + "/" + dan1[1] + "/" + dan1[2]);
                    }
                    catch
                    {
                    }
                }

            }
            if (h == "Physical education")
            {
                tb2.Text = "Физкультуре";
                teachles = "Физкультура";

                dat = school.Schedule.Max(m => m.id_Day);
                for (int i = 1; i <= dat; i++)
                {
                    try
                    {
                        var sich = school.Schedule.Where(q => q.Lesson1 == "Physical education" || q.Lesson2 == "Physical education" || q.Lesson3 == "Physical education" || q.Lesson4 == "Physical education" || q.Lesson5 == "Physical education" || q.Lesson6 == "Physical education");
                        var chis = sich.Single(j => j.id_Day == i);

                        gafa = Convert.ToString(chis.Date);
                        string[] dan = gafa.Split(new char[] { ' ' });
                        string[] dan1 = dan[0].Split(new char[] { '.' });
                        cb3.Items.Add(dan1[0] + "/" + dan1[1] + "/" + dan1[2]);
                        cb5.Items.Add(dan1[0] + "/" + dan1[1] + "/" + dan1[2]);
                    }
                    catch
                    {
                    }
                }

            }
            if (h == "Work")
            {
                tb2.Text = "Трудам";
                teachles = "Труды";
                dat = school.Schedule.Max(m => m.id_Day);
                for (int i = 1; i <= dat; i++)
                {
                    try
                    {
                        var sich = school.Schedule.Where(q => q.Lesson1 == "Work" || q.Lesson2 == "Work" || q.Lesson3 == "Work" || q.Lesson4 == "Work" || q.Lesson5 == "Work" || q.Lesson6 == "Work");
                        var chis = sich.Single(j => j.id_Day == i);

                        gafa = Convert.ToString(chis.Date);
                        string[] dan = gafa.Split(new char[] { ' ' });
                        string[] dan1 = dan[0].Split(new char[] { '.' });
                        cb3.Items.Add(dan1[0] + "/" + dan1[1] + "/" + dan1[2]);
                        cb5.Items.Add(dan1[0] + "/" + dan1[1] + "/" + dan1[2]);
                    }
                    catch
                    {
                    }
                }

            }

            int maz = school.Students.Max(m => m.id_Student);
            for (int i = 1; i <= maz; i++)
            {
                var chis = school.Students.Single(j => j.id_Student == i);
                cb2.Items.Add(chis.Last_name + " " + chis.First_name + " " + chis.Middle_name);
                cb8.Items.Add(chis.Last_name + " " + chis.First_name + " " + chis.Middle_name);
            }

            ida = school.Students.Max(m => m.id_Student);
            for (int i = 1; i <= ida; i++)
            {
                var chis = school.Students.Single(j => j.id_Student == i);
                tb7.Items.Add(chis.id_Student);
                cb6.Items.Add(chis.id_Student);
                cb1.Items.Add(chis.id_Student);
            }


            for (int i = 2; i <= 5; i++)
            {
                tb8.Items.Add(i);
                cb4.Items.Add(i);
            }
            tb8.Items.Add("+");
            tb8.Items.Add("б");
            tb8.Items.Add("н");
            tb8.Items.Add("п");
            cb4.Items.Add("+");
            cb4.Items.Add("б");
            cb4.Items.Add("н");
            cb4.Items.Add("п");

            ida = school.Students.Max(m => m.id_Student);
            for (int i = 1; i <= ida; i++)
            {
                var chis = school.Students.Single(j => j.id_Student == i);
                tb9.Items.Add(chis.Number_phone);
            }

            ida1 = school.Algebra_grades.Max(n1 => n1.id);
            for (int i = 1; i <= ida1; i++)
            {
                var chis = school.Algebra_grades.Single(j => j.id == i);
                cb7.Items.Add(chis.id);
            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var g = school.Teachers.Single(g1 => g1.id_Teacher == id_p);
            var r = school.Schedule.Where(g1 => g1.Lesson1 == g.Subject || g1.Lesson2 == g.Subject || g1.Lesson3 == g.Subject || g1.Lesson4 == g.Subject || g1.Lesson5 == g.Subject || g1.Lesson6 == g.Subject);
            dg2.ItemsSource = r.ToList();
            dg2.Visibility = Visibility.Visible;
            //-------------------------------------
            dg3.Visibility = Visibility.Hidden;
            tb3.Visibility = Visibility.Hidden;
            label6.Visibility = Visibility.Hidden;
            label7.Visibility = Visibility.Hidden;
            label8.Visibility = Visibility.Hidden;
            bt11.Visibility = Visibility.Hidden;
            bt12.Visibility = Visibility.Hidden;

            bt4.Visibility = Visibility.Visible;
            bt5.Visibility = Visibility.Visible;
            //----------------------------------------
            Rtd.Visibility = Visibility.Hidden;
            tb5.Visibility = Visibility.Hidden;
            bt1.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            label3.Visibility = Visibility.Hidden;
            label4.Visibility = Visibility.Hidden;
            label5.Visibility = Visibility.Hidden;
            bt6.Visibility = Visibility.Hidden;
            bt7.Visibility = Visibility.Hidden;
            cb1.Visibility = Visibility.Hidden;
            cb8.Visibility = Visibility.Hidden;
            //-----------------------------------------
            tv_vistav1.Visibility = Visibility.Hidden;
            tv_vistav2.Visibility = Visibility.Hidden;
            tv_vistav3.Visibility = Visibility.Hidden;
            tv_vistav4.Visibility = Visibility.Hidden;
            tv_vistav5.Visibility = Visibility.Hidden;
            tv_vistav6.Visibility = Visibility.Hidden;
            bt13.Visibility = Visibility.Hidden;
            bt14.Visibility = Visibility.Hidden;
            bt15.Visibility = Visibility.Hidden;
            dg5.Visibility = Visibility.Hidden;


            bt8.Visibility = Visibility.Hidden;
            bt9.Visibility = Visibility.Hidden;
            tb_ismen1.Visibility = Visibility.Hidden;
            tb_ismen2.Visibility = Visibility.Hidden;
            tb_ismen3.Visibility = Visibility.Hidden;
            tb_ismen4.Visibility = Visibility.Hidden;
            cb5.Visibility = Visibility.Hidden;
            cb6.Visibility = Visibility.Hidden;
            cb7.Visibility = Visibility.Hidden;
            cb4.Visibility = Visibility.Hidden;

            tb_dobav1.Visibility = Visibility.Hidden;
            tb_dobav2.Visibility = Visibility.Hidden;
            tb_dobav3.Visibility = Visibility.Hidden;
            tb_dobav4.Visibility = Visibility.Hidden;
            tb7.Visibility = Visibility.Hidden;
            tb8.Visibility = Visibility.Hidden;
            cb2.Visibility = Visibility.Hidden;
            cb3.Visibility = Visibility.Hidden;
            bt_dobav1.Visibility = Visibility.Hidden;
            lab1.Visibility = Visibility.Hidden;
            tb9.Visibility = Visibility.Hidden;
        }

        private void Cb1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Bt3_Click(object sender, RoutedEventArgs e)
        {
            dg3.ItemsSource = school.Students.ToList();

            dg3.Visibility = Visibility.Visible;
            tb3.Visibility = Visibility.Visible;
            label6.Visibility = Visibility.Visible;
            label7.Visibility = Visibility.Visible;
            label8.Visibility = Visibility.Visible;
            bt11.Visibility = Visibility.Visible;
            bt12.Visibility = Visibility.Visible;

            bt4.Visibility = Visibility.Hidden;
            bt5.Visibility = Visibility.Hidden;

            Rtd.Visibility = Visibility.Hidden;
            tb5.Visibility = Visibility.Hidden;
            bt1.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            label3.Visibility = Visibility.Hidden;
            label4.Visibility = Visibility.Hidden;
            label5.Visibility = Visibility.Hidden;
            bt6.Visibility = Visibility.Hidden;
            bt7.Visibility = Visibility.Hidden;
            cb1.Visibility = Visibility.Hidden;
            cb8.Visibility = Visibility.Hidden;

            tv_vistav1.Visibility = Visibility.Hidden;
            tv_vistav2.Visibility = Visibility.Hidden;
            tv_vistav3.Visibility = Visibility.Hidden;
            tv_vistav4.Visibility = Visibility.Hidden;
            tv_vistav5.Visibility = Visibility.Hidden;
            tv_vistav6.Visibility = Visibility.Hidden;
            bt13.Visibility = Visibility.Hidden;
            bt14.Visibility = Visibility.Hidden;
            bt15.Visibility = Visibility.Hidden;
            dg5.Visibility = Visibility.Hidden;

            dg2.Visibility = Visibility.Hidden;

            bt8.Visibility = Visibility.Hidden;
            bt9.Visibility = Visibility.Hidden;
            tb_ismen1.Visibility = Visibility.Hidden;
            tb_ismen2.Visibility = Visibility.Hidden;
            tb_ismen3.Visibility = Visibility.Hidden;
            tb_ismen4.Visibility = Visibility.Hidden;
            cb5.Visibility = Visibility.Hidden;
            cb6.Visibility = Visibility.Hidden;
            cb7.Visibility = Visibility.Hidden;
            cb4.Visibility = Visibility.Hidden;

            tb_dobav1.Visibility = Visibility.Hidden;
            tb_dobav2.Visibility = Visibility.Hidden;
            tb_dobav3.Visibility = Visibility.Hidden;
            tb_dobav4.Visibility = Visibility.Hidden;
            tb7.Visibility = Visibility.Hidden;
            tb8.Visibility = Visibility.Hidden;
            cb2.Visibility = Visibility.Hidden;
            cb3.Visibility = Visibility.Hidden;
            bt_dobav1.Visibility = Visibility.Hidden;

            lab1.Visibility = Visibility.Hidden;
            tb9.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tyr = school.Students.Where(j => j.Last_name == tb3.Text || j.First_name == tb3.Text || j.Middle_name == tb3.Text);
            dg3.ItemsSource = tyr.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dg3.ItemsSource = school.Students.ToList();

            //dg3.Visibility = Visibility.Hidden;
            tb3.Visibility = Visibility.Hidden;
            label6.Visibility = Visibility.Hidden;
            label7.Visibility = Visibility.Hidden;
            label8.Visibility = Visibility.Hidden;
            bt11.Visibility = Visibility.Hidden;
            bt12.Visibility = Visibility.Hidden;
            bt4.Visibility = Visibility.Visible;
            bt5.Visibility = Visibility.Visible;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {                          
            

            var g = school.Teachers.Single(g1 => g1.id_Teacher == id_p);

            var h = g.Subject;

            if (h == "Algebra")
            {
                dg5.ItemsSource = school.Algebra_grades.ToList();
            }
            if (h == "Geometry")
            {
                dg5.ItemsSource = school.Geometry_grades.ToList();
            }
            if (h == "Russian language")
            {
                dg5.ItemsSource = school.Russian_language_grades.ToList();
            }
            if (h == "Literature")
            {
                dg5.ItemsSource = school.Literature_grades.ToList();
            }
            if (h == "Physical education")
            {
                dg5.ItemsSource = school.Physical_education_grades.ToList();
            }
            if (h == "Work")
            {
                dg5.ItemsSource = school.Work_grades.ToList();
            }

            tv_vistav1.Visibility = Visibility.Visible;
            tv_vistav2.Visibility = Visibility.Visible;
            tv_vistav3.Visibility = Visibility.Visible;
            tv_vistav4.Visibility = Visibility.Visible;
            tv_vistav5.Visibility = Visibility.Visible;
            tv_vistav6.Visibility = Visibility.Visible;
            bt13.Visibility = Visibility.Visible;
            bt14.Visibility = Visibility.Visible;
            bt15.Visibility = Visibility.Visible;
            dg5.Visibility = Visibility.Visible;

            dg3.Visibility = Visibility.Hidden;

            bt8.Visibility = Visibility.Hidden;
            bt9.Visibility = Visibility.Hidden;
            tb_ismen1.Visibility = Visibility.Hidden;
            tb_ismen2.Visibility = Visibility.Hidden;
            tb_ismen3.Visibility = Visibility.Hidden;
            tb_ismen4.Visibility = Visibility.Hidden;
            cb5.Visibility = Visibility.Hidden;
            cb6.Visibility = Visibility.Hidden;
            cb7.Visibility = Visibility.Hidden;
            cb4.Visibility = Visibility.Hidden;

            tb_dobav1.Visibility = Visibility.Hidden;
            tb_dobav2.Visibility = Visibility.Hidden;
            tb_dobav3.Visibility = Visibility.Hidden;
            tb_dobav4.Visibility = Visibility.Hidden;
            tb7.Visibility = Visibility.Hidden;
            tb8.Visibility = Visibility.Hidden;
            cb2.Visibility = Visibility.Hidden;
            cb3.Visibility = Visibility.Hidden;
            bt_dobav1.Visibility = Visibility.Hidden;

            dg2.Visibility = Visibility.Hidden;

            lab1.Visibility = Visibility.Hidden;
            tb9.Visibility = Visibility.Hidden;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                if (proverk == 0)
                {
                    if (tb7.Text != "" && cb2.Text != "" && tb8.Text != "" && cb3.Text != "")
                    {
                        int h = Convert.ToInt32(tb7.Text);
                        var ld = school.Students.Single(g1 => g1.id_Student == h);
                        var j = school.Students.Single(g1 => g1.Last_name + " " + g1.First_name + " " + g1.Middle_name == cb2.Text);

                        int max3 = school.Students.Max(k => k.id_Student);

                        if (j.id_Student == ld.id_Student && max3 >= Convert.ToInt32(tb7.Text))
                        {
                            var g = school.Teachers.Single(g1 => g1.id_Teacher == id_p);
                            var h1 = g.Subject;

                            if (h1 == "Algebra")
                            {

                                string[] dan3 = cb3.Text.Split(new char[] { '/' });
                                string hl3 = dan3[0] + "." + dan3[1] + "." + dan3[2] + " 0:00:00";
                                var jk3 = Convert.ToDateTime(hl3);
                                var l3 = school.Schedule.Single(k => k.Date == jk3);
                                int t3 = Convert.ToInt32(tb7.Text);
                                var gfh3 = school.Algebra_grades.Where(gjk => gjk.id_Day == l3.id_Day && gjk.id_Student == t3);
                                var coun = gfh3.Count(k => k.id_Day == l3.id_Day);

                                if (coun < 2)
                                {

                                    int max = school.Algebra_grades.Max(k => k.id);
                                    int max1 = school.Grades_Students.Max(k => k.id);
                                    string[] dan = cb3.Text.Split(new char[] { '/' });
                                    string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                    var jk = Convert.ToDateTime(hl);
                                    var l = school.Schedule.Single(k => k.Date == jk);

                                    Algebra_grades algebra = new Algebra_grades { id = max + 1, id_Day = l.id_Day, id_Teacher = g.id_Teacher, id_Student = Convert.ToInt32(tb7.Text), Grades = tb8.Text };
                                    school.Algebra_grades.Add(algebra);
                                    school.SaveChanges();

                                    Grades_Students grades = new Grades_Students { id = max1 + 1, id_Day = l.id_Day, id_Student = Convert.ToInt32(tb7.Text), Algebra = tb8.Text, Geometry = "-", Literature = "-", Physical_education = "-", Russian_language = "-", Work_ = "-" };
                                    school.Grades_Students.Add(grades);
                                    school.SaveChanges();

                                    dg5.ItemsSource = school.Algebra_grades.ToList();

                                    cb7.Items.Clear();
                                    ida1 = school.Algebra_grades.Max(n1 => n1.id);
                                    for (int i = 1; i <= ida1; i++)
                                    {
                                        var chis = school.Algebra_grades.Single(j32 => j32.id == i);
                                        cb7.Items.Add(chis.id);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Больше оценок в этот день поставить нельзя", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                                }
                            }
                            if (h1 == "Geometry")
                            {

                                string[] dan3 = cb3.Text.Split(new char[] { '/' });
                                string hl3 = dan3[0] + "." + dan3[1] + "." + dan3[2] + " 0:00:00";
                                var jk3 = Convert.ToDateTime(hl3);
                                var l3 = school.Schedule.Single(k => k.Date == jk3);
                                int t3 = Convert.ToInt32(tb7.Text);
                                var gfh3 = school.Geometry_grades.Where(gjk => gjk.id_Day == l3.id_Day && gjk.id_Student == t3);
                                var coun = gfh3.Count(k => k.id_Day == l3.id_Day);

                                if (coun < 2)
                                {
                                    int max = school.Geometry_grades.Max(k => k.id);
                                    int max1 = school.Grades_Students.Max(k => k.id);
                                    string[] dan = cb3.Text.Split(new char[] { '/' });
                                    string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                    var jk = Convert.ToDateTime(hl);
                                    var l = school.Schedule.Single(k => k.Date == jk);

                                    Geometry_grades geometry = new Geometry_grades { id = max + 1, id_Day = l.id_Day, id_Teacher = g.id_Teacher, id_Student = Convert.ToInt32(tb7.Text), Grades = tb8.Text };
                                    school.Geometry_grades.Add(geometry);
                                    school.SaveChanges();

                                    Grades_Students grades = new Grades_Students { id = max1 + 1, id_Day = l.id_Day, id_Student = Convert.ToInt32(tb7.Text), Algebra = "-", Geometry = tb8.Text, Literature = "-", Physical_education = "-", Russian_language = "-", Work_ = "-" };
                                    school.Grades_Students.Add(grades);
                                    school.SaveChanges();

                                    dg5.ItemsSource = school.Geometry_grades.ToList();

                                    cb7.Items.Clear();
                                    ida1 = school.Algebra_grades.Max(n1 => n1.id);
                                    for (int i = 1; i <= ida1; i++)
                                    {
                                        var chis = school.Algebra_grades.Single(j32 => j32.id == i);
                                        cb7.Items.Add(chis.id);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Больше оценок в этот день поставить нельзя", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                                }
                            }
                            if (h1 == "Russian language")
                            {
                                string[] dan3 = cb3.Text.Split(new char[] { '/' });
                                string hl3 = dan3[0] + "." + dan3[1] + "." + dan3[2] + " 0:00:00";
                                var jk3 = Convert.ToDateTime(hl3);
                                var l3 = school.Schedule.Single(k => k.Date == jk3);
                                int t3 = Convert.ToInt32(tb7.Text);
                                var gfh3 = school.Russian_language_grades.Where(gjk => gjk.id_Day == l3.id_Day && gjk.id_Student == t3);
                                var coun = gfh3.Count(k => k.id_Day == l3.id_Day);

                                if (coun < 2)
                                {
                                    int max = school.Russian_language_grades.Max(k => k.id);
                                    int max1 = school.Grades_Students.Max(k => k.id);
                                    string[] dan = cb3.Text.Split(new char[] { '/' });
                                    string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                    var jk = Convert.ToDateTime(hl);
                                    var l = school.Schedule.Single(k => k.Date == jk);

                                    Russian_language_grades russian = new Russian_language_grades { id = max + 1, id_Day = l.id_Day, id_Teacher = g.id_Teacher, id_Student = Convert.ToInt32(tb7.Text), Grades = tb8.Text };
                                    school.Russian_language_grades.Add(russian);
                                    school.SaveChanges();

                                    Grades_Students grades = new Grades_Students { id = max1 + 1, id_Day = l.id_Day, id_Student = Convert.ToInt32(tb7.Text), Algebra = "-", Geometry = "-", Literature = "-", Physical_education = "-", Russian_language = tb8.Text, Work_ = "-" };
                                    school.Grades_Students.Add(grades);
                                    school.SaveChanges();

                                    dg5.ItemsSource = school.Russian_language_grades.ToList();

                                    cb7.Items.Clear();
                                    ida1 = school.Algebra_grades.Max(n1 => n1.id);
                                    for (int i = 1; i <= ida1; i++)
                                    {
                                        var chis = school.Algebra_grades.Single(j32 => j32.id == i);
                                        cb7.Items.Add(chis.id);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Больше оценок в этот день поставить нельзя", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                                }
                            }
                            if (h1 == "Literature")
                            {
                                string[] dan3 = cb3.Text.Split(new char[] { '/' });
                                string hl3 = dan3[0] + "." + dan3[1] + "." + dan3[2] + " 0:00:00";
                                var jk3 = Convert.ToDateTime(hl3);
                                var l3 = school.Schedule.Single(k => k.Date == jk3);
                                int t3 = Convert.ToInt32(tb7.Text);
                                var gfh3 = school.Literature_grades.Where(gjk => gjk.id_Day == l3.id_Day && gjk.id_Student == t3);
                                var coun = gfh3.Count(k => k.id_Day == l3.id_Day);

                                if (coun < 2)
                                {
                                    int max = school.Literature_grades.Max(k => k.Id);
                                    int max1 = school.Grades_Students.Max(k => k.id);
                                    string[] dan = cb3.Text.Split(new char[] { '/' });
                                    string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                    var jk = Convert.ToDateTime(hl);
                                    var l = school.Schedule.Single(k => k.Date == jk);

                                    Literature_grades literature = new Literature_grades { Id = max + 1, id_Day = l.id_Day, id_Teacher = g.id_Teacher, id_Student = Convert.ToInt32(tb7.Text), Grades = tb8.Text };
                                    school.Literature_grades.Add(literature);
                                    school.SaveChanges();

                                    Grades_Students grades = new Grades_Students { id = max1 + 1, id_Day = l.id_Day, id_Student = Convert.ToInt32(tb7.Text), Algebra = "-", Geometry = "-", Literature = tb8.Text, Physical_education = "-", Russian_language = "-", Work_ = "-" };
                                    school.Grades_Students.Add(grades);
                                    school.SaveChanges();
                                    dg5.ItemsSource = school.Literature_grades.ToList();

                                    cb7.Items.Clear();
                                    ida1 = school.Algebra_grades.Max(n1 => n1.id);
                                    for (int i = 1; i <= ida1; i++)
                                    {
                                        var chis = school.Algebra_grades.Single(j32 => j32.id == i);
                                        cb7.Items.Add(chis.id);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Больше оценок в этот день поставить нельзя", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                                }
                            }
                            if (h1 == "Physical education")
                            {

                                string[] dan3 = cb3.Text.Split(new char[] { '/' });
                                string hl3 = dan3[0] + "." + dan3[1] + "." + dan3[2] + " 0:00:00";
                                var jk3 = Convert.ToDateTime(hl3);
                                var l3 = school.Schedule.Single(k => k.Date == jk3);
                                int t3 = Convert.ToInt32(tb7.Text);
                                var gfh3 = school.Physical_education_grades.Where(gjk => gjk.id_Day == l3.id_Day && gjk.id_Student == t3);
                                var coun = gfh3.Count(k => k.id_Day == l3.id_Day);

                                if (coun < 2)
                                {
                                    int max = school.Physical_education_grades.Max(k => k.id);
                                    int max1 = school.Grades_Students.Max(k => k.id);
                                    string[] dan = cb3.Text.Split(new char[] { '/' });
                                    string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                    var jk = Convert.ToDateTime(hl);
                                    var l = school.Schedule.Single(k => k.Date == jk);

                                    Physical_education_grades physical = new Physical_education_grades { id = max + 1, id_Day = l.id_Day, id_Teacher = g.id_Teacher, id_Student = Convert.ToInt32(tb7.Text), Grades = tb8.Text };
                                    school.Physical_education_grades.Add(physical);
                                    school.SaveChanges();

                                    Grades_Students grades = new Grades_Students { id = max1 + 1, id_Day = l.id_Day, id_Student = Convert.ToInt32(tb7.Text), Algebra = "-", Geometry = "-", Literature = "-", Physical_education = tb8.Text, Russian_language = "-", Work_ = "-" };
                                    school.Grades_Students.Add(grades);
                                    school.SaveChanges();
                                    dg5.ItemsSource = school.Physical_education_grades.ToList();

                                    cb7.Items.Clear();
                                    ida1 = school.Algebra_grades.Max(n1 => n1.id);
                                    for (int i = 1; i <= ida1; i++)
                                    {
                                        var chis = school.Algebra_grades.Single(j32 => j32.id == i);
                                        cb7.Items.Add(chis.id);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Больше оценок в этот день поставить нельзя", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                                }
                            }
                            if (h1 == "Work")
                            {
                                string[] dan3 = cb3.Text.Split(new char[] { '/' });
                                string hl3 = dan3[0] + "." + dan3[1] + "." + dan3[2] + " 0:00:00";
                                var jk3 = Convert.ToDateTime(hl3);
                                var l3 = school.Schedule.Single(k => k.Date == jk3);
                                int t3 = Convert.ToInt32(tb7.Text);
                                var gfh3 = school.Work_grades.Where(gjk => gjk.id_Day == l3.id_Day && gjk.id_Student == t3);
                                var coun = gfh3.Count(k => k.id_Day == l3.id_Day);

                                if (coun < 2)
                                {


                                    int max = school.Work_grades.Max(k => k.id);
                                    int max1 = school.Grades_Students.Max(k => k.id);
                                    string[] dan = cb3.Text.Split(new char[] { '/' });
                                    string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                    var jk = Convert.ToDateTime(hl);
                                    var l = school.Schedule.Single(k => k.Date == jk);

                                    Work_grades work = new Work_grades { id = max + 1, id_Day = l.id_Day, id_Teacher = g.id_Teacher, id_Student = Convert.ToInt32(tb7.Text), Grades = tb8.Text };
                                    school.Work_grades.Add(work);
                                    school.SaveChanges();

                                    Grades_Students grades = new Grades_Students { id = max1 + 1, id_Day = l.id_Day, id_Student = Convert.ToInt32(tb7.Text), Algebra = "-", Geometry = "-", Literature = "", Physical_education = "-", Russian_language = "-", Work_ = tb8.Text };
                                    school.Grades_Students.Add(grades);
                                    school.SaveChanges();

                                    dg5.ItemsSource = school.Work_grades.ToList();

                                    cb7.Items.Clear();
                                    ida1 = school.Algebra_grades.Max(n1 => n1.id);
                                    for (int i = 1; i <= ida1; i++)
                                    {
                                        var chis = school.Algebra_grades.Single(j32 => j32.id == i);
                                        cb7.Items.Add(chis.id);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Больше оценок в этот день поставить нельзя.", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("ФИО ученика, не совпадает с его id или другими данными, повторно проверьте заполнение данных.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                else
                {
                    if (proverk == 1)
                    {
                        lab1.Visibility = Visibility.Visible;
                        tb9.Visibility = Visibility.Visible;
                        if (tb7.Text != "" && cb2.Text != "" && tb8.Text != "" && cb3.Text != "" && tb9.Text != "")
                        {
                            int h2 = Convert.ToInt32(tb7.Text);
                            var ld2 = school.Students.Single(g1 => g1.id_Student == h2);
                            var j2 = school.Students.Single(g1 => g1.Number_phone == tb9.Text);
                            string name = ld2.Last_name + " " + ld2.First_name + " " + ld2.Middle_name;

                            int max4 = school.Students.Max(k => k.id_Student);

                            if (j2.id_Student == ld2.id_Student && max4 >= Convert.ToInt32(tb7.Text) && name == cb2.Text)
                            {
                                var g = school.Teachers.Single(g1 => g1.id_Teacher == id_p);
                                var h1 = g.Subject;

                                if (h1 == "Algebra")
                                {
                                    string[] dan3 = cb3.Text.Split(new char[] { '/' });
                                    string hl3 = dan3[0] + "." + dan3[1] + "." + dan3[2] + " 0:00:00";
                                    var jk3 = Convert.ToDateTime(hl3);
                                    var l3 = school.Schedule.Single(k => k.Date == jk3);
                                    int t3 = Convert.ToInt32(tb7.Text);
                                    var gfh3 = school.Algebra_grades.Where(gjk => gjk.id_Day == l3.id_Day && gjk.id_Student == t3);
                                    var coun = gfh3.Count(k => k.id_Day == l3.id_Day);
                                  if (coun < 2)
                                  {
                                        int max = school.Algebra_grades.Max(k => k.id);
                                    int max1 = school.Grades_Students.Max(k => k.id);
                                    string[] dan = cb3.Text.Split(new char[] { '/' });
                                    string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                    var jk = Convert.ToDateTime(hl);
                                    var l = school.Schedule.Single(k => k.Date == jk);
                                  
                                    Algebra_grades algebra = new Algebra_grades { id = max + 1, id_Day = l.id_Day, id_Teacher = g.id_Teacher, id_Student = Convert.ToInt32(tb7.Text), Grades = tb8.Text };
                                    school.Algebra_grades.Add(algebra);
                                    school.SaveChanges();

                                    Grades_Students grades = new Grades_Students { id = max1 + 1, id_Day = l.id_Day, id_Student = Convert.ToInt32(tb7.Text), Algebra = tb8.Text, Geometry = "-", Literature = "-", Physical_education = "-", Russian_language = "-", Work_ = "-" };
                                    school.Grades_Students.Add(grades);
                                    school.SaveChanges();

                                    dg5.ItemsSource = school.Algebra_grades.ToList();

                                        cb7.Items.Clear();
                                        ida1 = school.Algebra_grades.Max(n1 => n1.id);
                                        for (int i = 1; i <= ida1; i++)
                                        {
                                            var chis = school.Algebra_grades.Single(j32 => j32.id == i);
                                            cb7.Items.Add(chis.id);
                                        }
                                    }
                                  else
                                  {
                                        MessageBox.Show("Больше оценок в этот день поставить нельзя", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                                  }
                                }
                                if (h1 == "Geometry")
                                {
                                    string[] dan3 = cb3.Text.Split(new char[] { '/' });
                                    string hl3 = dan3[0] + "." + dan3[1] + "." + dan3[2] + " 0:00:00";
                                    var jk3 = Convert.ToDateTime(hl3);
                                    var l3 = school.Schedule.Single(k => k.Date == jk3);
                                    int t3 = Convert.ToInt32(tb7.Text);
                                    var gfh3 = school.Geometry_grades.Where(gjk => gjk.id_Day == l3.id_Day && gjk.id_Student == t3);
                                    var coun = gfh3.Count(k => k.id_Day == l3.id_Day);
                                  if (coun < 2)
                                  {

                                        int max = school.Geometry_grades.Max(k => k.id);
                                    int max1 = school.Grades_Students.Max(k => k.id);
                                    string[] dan = cb3.Text.Split(new char[] { '/' });
                                    string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                    var jk = Convert.ToDateTime(hl);
                                    var l = school.Schedule.Single(k => k.Date == jk);

                                    Geometry_grades geometry = new Geometry_grades { id = max + 1, id_Day = l.id_Day, id_Teacher = g.id_Teacher, id_Student = Convert.ToInt32(tb7.Text), Grades = tb8.Text };
                                    school.Geometry_grades.Add(geometry);
                                    school.SaveChanges();

                                    Grades_Students grades = new Grades_Students { id = max1 + 1, id_Day = l.id_Day, id_Student = Convert.ToInt32(tb7.Text), Algebra = "-", Geometry = tb8.Text, Literature = "-", Physical_education = "-", Russian_language = "-", Work_ = "-" };
                                    school.Grades_Students.Add(grades);
                                    school.SaveChanges();


                                    dg5.ItemsSource = school.Geometry_grades.ToList();

                                        cb7.Items.Clear();
                                        ida1 = school.Algebra_grades.Max(n1 => n1.id);
                                        for (int i = 1; i <= ida1; i++)
                                        {
                                            var chis = school.Algebra_grades.Single(j32 => j32.id == i);
                                            cb7.Items.Add(chis.id);
                                        }

                                    }
                                  else
                                  {
                                        MessageBox.Show("Больше оценок в этот день поставить нельзя", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                                  }
                                }
                                if (h1 == "Russian language")
                                {
                                    string[] dan3 = cb3.Text.Split(new char[] { '/' });
                                    string hl3 = dan3[0] + "." + dan3[1] + "." + dan3[2] + " 0:00:00";
                                    var jk3 = Convert.ToDateTime(hl3);
                                    var l3 = school.Schedule.Single(k => k.Date == jk3);
                                    int t3 = Convert.ToInt32(tb7.Text);
                                    var gfh3 = school.Russian_language_grades.Where(gjk => gjk.id_Day == l3.id_Day && gjk.id_Student == t3);
                                    var coun = gfh3.Count(k => k.id_Day == l3.id_Day);
                                  if (coun < 2)
                                  {


                                        int max = school.Russian_language_grades.Max(k => k.id);
                                    int max1 = school.Grades_Students.Max(k => k.id);
                                    string[] dan = cb3.Text.Split(new char[] { '/' });
                                    string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                    var jk = Convert.ToDateTime(hl);
                                    var l = school.Schedule.Single(k => k.Date == jk);

                                    Russian_language_grades russian = new Russian_language_grades { id = max + 1, id_Day = l.id_Day, id_Teacher = g.id_Teacher, id_Student = Convert.ToInt32(tb7.Text), Grades = tb8.Text };
                                    school.Russian_language_grades.Add(russian);
                                    school.SaveChanges();

                                    Grades_Students grades = new Grades_Students { id = max1 + 1, id_Day = l.id_Day, id_Student = Convert.ToInt32(tb7.Text), Algebra = "-", Geometry = "-", Literature = "-", Physical_education = "-", Russian_language = tb8.Text, Work_ = "-" };
                                    school.Grades_Students.Add(grades);
                                    school.SaveChanges();


                                    dg5.ItemsSource = school.Russian_language_grades.ToList();

                                        cb7.Items.Clear();
                                        ida1 = school.Algebra_grades.Max(n1 => n1.id);
                                        for (int i = 1; i <= ida1; i++)
                                        {
                                            var chis = school.Algebra_grades.Single(j32 => j32.id == i);
                                            cb7.Items.Add(chis.id);
                                        }

                                    }
                                  else
                                  {
                                        MessageBox.Show("Больше оценок в этот день поставить нельзя", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                                  }
                                }
                                if (h1 == "Literature")
                                {
                                    string[] dan3 = cb3.Text.Split(new char[] { '/' });
                                    string hl3 = dan3[0] + "." + dan3[1] + "." + dan3[2] + " 0:00:00";
                                    var jk3 = Convert.ToDateTime(hl3);
                                    var l3 = school.Schedule.Single(k => k.Date == jk3);
                                    int t3 = Convert.ToInt32(tb7.Text);
                                    var gfh3 = school.Literature_grades.Where(gjk => gjk.id_Day == l3.id_Day && gjk.id_Student == t3);
                                    var coun = gfh3.Count(k => k.id_Day == l3.id_Day);
                                  if (coun < 2)
                                  {

                                        int max = school.Literature_grades.Max(k => k.Id);
                                    int max1 = school.Grades_Students.Max(k => k.id);
                                    string[] dan = cb3.Text.Split(new char[] { '/' });
                                    string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                    var jk = Convert.ToDateTime(hl);
                                    var l = school.Schedule.Single(k => k.Date == jk);

                                    Literature_grades literature = new Literature_grades { Id = max + 1, id_Day = l.id_Day, id_Teacher = g.id_Teacher, id_Student = Convert.ToInt32(tb7.Text), Grades = tb8.Text };
                                    school.Literature_grades.Add(literature);
                                    school.SaveChanges();

                                    Grades_Students grades = new Grades_Students { id = max1 + 1, id_Day = l.id_Day, id_Student = Convert.ToInt32(tb7.Text), Algebra = "-", Geometry = "-", Literature = tb8.Text, Physical_education = "-", Russian_language = "-", Work_ = "-" };
                                    school.Grades_Students.Add(grades);
                                    school.SaveChanges();

                                    dg5.ItemsSource = school.Literature_grades.ToList();

                                        cb7.Items.Clear();
                                        ida1 = school.Algebra_grades.Max(n1 => n1.id);
                                        for (int i = 1; i <= ida1; i++)
                                        {
                                            var chis = school.Algebra_grades.Single(j32 => j32.id == i);
                                            cb7.Items.Add(chis.id);
                                        }

                                    }
                                  else
                                  {
                                        MessageBox.Show("Больше оценок в этот день поставить нельзя", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                                  }
                                }
                                if (h1 == "Physical education")
                                {
                                    string[] dan3 = cb3.Text.Split(new char[] { '/' });
                                    string hl3 = dan3[0] + "." + dan3[1] + "." + dan3[2] + " 0:00:00";
                                    var jk3 = Convert.ToDateTime(hl3);
                                    var l3 = school.Schedule.Single(k => k.Date == jk3);
                                    int t3 = Convert.ToInt32(tb7.Text);
                                    var gfh3 = school.Physical_education_grades.Where(gjk => gjk.id_Day == l3.id_Day && gjk.id_Student == t3);
                                    var coun = gfh3.Count(k => k.id_Day == l3.id_Day);
                                  if (coun < 2)
                                  {

                                        int max = school.Physical_education_grades.Max(k => k.id);
                                    int max1 = school.Grades_Students.Max(k => k.id);
                                    string[] dan = cb3.Text.Split(new char[] { '/' });
                                    string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                    var jk = Convert.ToDateTime(hl);
                                    var l = school.Schedule.Single(k => k.Date == jk);

                                    Physical_education_grades physical = new Physical_education_grades { id = max + 1, id_Day = l.id_Day, id_Teacher = g.id_Teacher, id_Student = Convert.ToInt32(tb7.Text), Grades = tb8.Text };
                                    school.Physical_education_grades.Add(physical);
                                    school.SaveChanges();

                                    Grades_Students grades = new Grades_Students { id = max1 + 1, id_Day = l.id_Day, id_Student = Convert.ToInt32(tb7.Text), Algebra = "-", Geometry = "-", Literature = "-", Physical_education = tb8.Text, Russian_language = "-", Work_ = "-" };
                                    school.Grades_Students.Add(grades);
                                    school.SaveChanges();

                                    dg5.ItemsSource = school.Physical_education_grades.ToList();

                                        cb7.Items.Clear();
                                        ida1 = school.Algebra_grades.Max(n1 => n1.id);
                                        for (int i = 1; i <= ida1; i++)
                                        {
                                            var chis = school.Algebra_grades.Single(j32 => j32.id == i);
                                            cb7.Items.Add(chis.id);
                                        }

                                    }
                                  else
                                  {
                                        MessageBox.Show("Больше оценок в этот день поставить нельзя", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                                  }
                                }
                                if (h1 == "Work")
                                {

                                    string[] dan3 = cb3.Text.Split(new char[] { '/' });
                                    string hl3 = dan3[0] + "." + dan3[1] + "." + dan3[2] + " 0:00:00";
                                    var jk3 = Convert.ToDateTime(hl3);
                                    var l3 = school.Schedule.Single(k => k.Date == jk3);
                                    int t3 = Convert.ToInt32(tb7.Text);
                                    var gfh3 = school.Work_grades.Where(gjk => gjk.id_Day == l3.id_Day && gjk.id_Student == t3);
                                    var coun = gfh3.Count(k => k.id_Day == l3.id_Day);
                                  if (coun < 2)
                                  {
                                        int max = school.Work_grades.Max(k => k.id);
                                    int max1 = school.Grades_Students.Max(k => k.id);
                                    string[] dan = cb3.Text.Split(new char[] { '/' });
                                    string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                    var jk = Convert.ToDateTime(hl);
                                    var l = school.Schedule.Single(k => k.Date == jk);

                                    Work_grades work = new Work_grades { id = max + 1, id_Day = l.id_Day, id_Teacher = g.id_Teacher, id_Student = Convert.ToInt32(tb7.Text), Grades = tb8.Text };
                                    school.Work_grades.Add(work);
                                    school.SaveChanges();

                                    Grades_Students grades = new Grades_Students { id = max1 + 1, id_Day = l.id_Day, id_Student = Convert.ToInt32(tb7.Text), Algebra = "-", Geometry = "-", Literature = "", Physical_education = "-", Russian_language = "-", Work_ = tb8.Text };
                                    school.Grades_Students.Add(grades);
                                    school.SaveChanges();

                                       

                                        dg5.ItemsSource = school.Work_grades.ToList();

                                        cb7.Items.Clear();
                                        ida1 = school.Algebra_grades.Max(n1 => n1.id);
                                        for (int i = 1; i <= ida1; i++)
                                        {
                                            var chis = school.Algebra_grades.Single(j32 => j32.id == i);
                                            cb7.Items.Add(chis.id);
                                        }
                                    }
                                  else
                                  {
                                        MessageBox.Show("Больше оценок в этот день поставить нельзя", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                                  }
                                }
                                proverk = 0;
                                lab1.Visibility = Visibility.Hidden;
                                tb9.Visibility = Visibility.Hidden;
                            }
                            else
                            {
                                MessageBox.Show("ФИО ученика, не совпадает с его id или другими данными, повторно проверьте заполнение данных.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("В процессе дабовлении оценки, была выявлена ошибка, ввода. Для решения проблемы заполните данные в допольнительном поле.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                lab1.Visibility = Visibility.Visible;
                tb9.Visibility = Visibility.Visible;
                proverk = 1;
            }
        }

        private void Bt8_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                if (cb4.Text != "" && cb6.Text != "" && cb5.Text != "" && cb7.Text != "")
                {
                    var g = school.Teachers.Single(g1 => g1.id_Teacher == id_p);
                    var h1 = g.Subject;

                    if (h1 == "Algebra")
                    {
                        string[] dan1 = cb5.Text.Split(new char[] { '/' });
                        string hl1 = dan1[0] + "." + dan1[1] + "." + dan1[2] + " 0:00:00";
                        var jk1 = Convert.ToDateTime(hl1);
                        var l1 = school.Schedule.Single(k => k.Date == jk1);
                        int t1 = Convert.ToInt32(cb6.Text);
                        var gfh1 = school.Algebra_grades.Where(gjk => gjk.id_Day == l1.id_Day && gjk.id_Student == t1);
                        int u = Convert.ToInt32(cb7.Text);
                        var kop11 = gfh1.Max(b => b.id);
                        var kop12 = gfh1.Min(b => b.id);
                        var gfh2 = gfh1.Single(p => p.id == u);

                        if (u == kop11)
                        {
                            string[] dan = cb5.Text.Split(new char[] { '/' });
                            string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                            var jk = Convert.ToDateTime(hl);
                            var l = school.Schedule.Single(k => k.Date == jk);
                            int t = Convert.ToInt32(cb6.Text);
                            var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Algebra != "-");
                            var kop = gfh.Max(b => b.id);
                            var lhg = school.Grades_Students.Single(llo => llo.id == kop);
                            lhg.Algebra = cb4.Text;
                            dg6.ItemsSource = gfh.ToList();
                        }
                        else
                        {
                            if (u == kop12)
                            {
                                string[] dan = cb5.Text.Split(new char[] { '/' });
                                string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                var jk = Convert.ToDateTime(hl);
                                var l = school.Schedule.Single(k => k.Date == jk);
                                int t = Convert.ToInt32(cb6.Text);
                                var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Algebra != "-");
                                var kop = gfh.Min(b => b.id);
                                var lhg = school.Grades_Students.Single(llo => llo.id == kop);
                                lhg.Algebra = cb4.Text;
                                dg6.ItemsSource = gfh.ToList();
                            }
                        }

                        gfh2.Grades = cb4.Text;
                        school.SaveChanges();
                        MessageBox.Show("Изменение прошли успешно.", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                        dg5.ItemsSource = gfh1.ToList();

                    }
                    if (h1 == "Geometry")
                    {
                        string[] dan1 = cb5.Text.Split(new char[] { '/' });
                        string hl1 = dan1[0] + "." + dan1[1] + "." + dan1[2] + " 0:00:00";
                        var jk1 = Convert.ToDateTime(hl1);
                        var l1 = school.Schedule.Single(k => k.Date == jk1);
                        int t1 = Convert.ToInt32(cb6.Text);
                        var gfh1 = school.Geometry_grades.Where(gjk => gjk.id_Day == l1.id_Day && gjk.id_Student == t1);
                        int u = Convert.ToInt32(cb7.Text);
                        var kop11 = gfh1.Max(b => b.id);
                        var kop12 = gfh1.Min(b => b.id);
                        var gfh2 = gfh1.Single(p => p.id == u);

                        if (u == kop11)
                        {
                            string[] dan = cb5.Text.Split(new char[] { '/' });
                            string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                            var jk = Convert.ToDateTime(hl);
                            var l = school.Schedule.Single(k => k.Date == jk);
                            int t = Convert.ToInt32(cb6.Text);
                            var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Geometry != "-");
                            var kop = gfh.Max(b => b.id);
                            var lhg = school.Grades_Students.Single(llo => llo.id == kop);
                            lhg.Geometry = cb4.Text;
                            dg6.ItemsSource = gfh.ToList();
                        }
                        else
                        {
                            if (u == kop12)
                            {
                                string[] dan = cb5.Text.Split(new char[] { '/' });
                                string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                var jk = Convert.ToDateTime(hl);
                                var l = school.Schedule.Single(k => k.Date == jk);
                                int t = Convert.ToInt32(cb6.Text);
                                var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Geometry != "-");
                                var kop = gfh.Min(b => b.id);
                                var lhg = school.Grades_Students.Single(llo => llo.id == kop);
                                lhg.Geometry = cb4.Text;
                                dg6.ItemsSource = gfh.ToList();
                            }
                        }

                        gfh2.Grades = cb4.Text;
                        school.SaveChanges();
                        MessageBox.Show("Изменение прошли успешно.", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                        dg5.ItemsSource = gfh1.ToList();

                    }
                    if (h1 == "Russian language")
                    {
                        string[] dan1 = cb5.Text.Split(new char[] { '/' });
                        string hl1 = dan1[0] + "." + dan1[1] + "." + dan1[2] + " 0:00:00";
                        var jk1 = Convert.ToDateTime(hl1);
                        var l1 = school.Schedule.Single(k => k.Date == jk1);
                        int t1 = Convert.ToInt32(cb6.Text);
                        var gfh1 = school.Russian_language_grades.Where(gjk => gjk.id_Day == l1.id_Day && gjk.id_Student == t1);
                        int u = Convert.ToInt32(cb7.Text);
                        var kop11 = gfh1.Max(b => b.id);
                        var kop12 = gfh1.Min(b => b.id);
                        var gfh2 = gfh1.Single(p => p.id == u);

                        if (u == kop11)
                        {
                            string[] dan = cb5.Text.Split(new char[] { '/' });
                            string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                            var jk = Convert.ToDateTime(hl);
                            var l = school.Schedule.Single(k => k.Date == jk);
                            int t = Convert.ToInt32(cb6.Text);
                            var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Russian_language != "-");
                            var kop = gfh.Max(b => b.id);
                            var lhg = school.Grades_Students.Single(llo => llo.id == kop);
                            lhg.Russian_language = cb4.Text;
                            dg6.ItemsSource = gfh.ToList();
                        }
                        else
                        {
                            if (u == kop12)
                            {
                                string[] dan = cb5.Text.Split(new char[] { '/' });
                                string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                var jk = Convert.ToDateTime(hl);
                                var l = school.Schedule.Single(k => k.Date == jk);
                                int t = Convert.ToInt32(cb6.Text);
                                var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Russian_language != "-");
                                var kop = gfh.Min(b => b.id);
                                var lhg = school.Grades_Students.Single(llo => llo.id == kop);
                                lhg.Russian_language = cb4.Text;
                                dg6.ItemsSource = gfh.ToList();
                            }
                        }
                        gfh2.Grades = cb4.Text;
                        school.SaveChanges();
                        MessageBox.Show("Изменение прошли успешно.", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                        dg5.ItemsSource = gfh1.ToList();
                    }
                    if (h1 == "Literature")
                    {
                        string[] dan1 = cb5.Text.Split(new char[] { '/' });
                        string hl1 = dan1[0] + "." + dan1[1] + "." + dan1[2] + " 0:00:00";
                        var jk1 = Convert.ToDateTime(hl1);
                        var l1 = school.Schedule.Single(k => k.Date == jk1);
                        int t1 = Convert.ToInt32(cb6.Text);
                        var gfh1 = school.Literature_grades.Where(gjk => gjk.id_Day == l1.id_Day && gjk.id_Student == t1);
                        int u = Convert.ToInt32(cb7.Text);
                        var kop11 = gfh1.Max(b => b.Id);
                        var kop12 = gfh1.Min(b => b.Id);
                        var gfh2 = gfh1.Single(p => p.Id == u);

                        if (u == kop11)
                        {
                            string[] dan = cb5.Text.Split(new char[] { '/' });
                            string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                            var jk = Convert.ToDateTime(hl);
                            var l = school.Schedule.Single(k => k.Date == jk);
                            int t = Convert.ToInt32(cb6.Text);
                            var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Literature != "-");
                            var kop = gfh.Max(b => b.id);
                            var lhg = school.Grades_Students.Single(llo => llo.id == kop);
                            lhg.Literature = cb4.Text;
                            dg6.ItemsSource = gfh.ToList();
                        }
                        else
                        {
                            if (u == kop12)
                            {
                                string[] dan = cb5.Text.Split(new char[] { '/' });
                                string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                var jk = Convert.ToDateTime(hl);
                                var l = school.Schedule.Single(k => k.Date == jk);
                                int t = Convert.ToInt32(cb6.Text);
                                var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Literature != "-");
                                var kop = gfh.Min(b => b.id);
                                var lhg = school.Grades_Students.Single(llo => llo.id == kop);
                                lhg.Literature = cb4.Text;
                                dg6.ItemsSource = gfh.ToList();
                            }
                        }

                        gfh2.Grades = cb4.Text;
                        school.SaveChanges();
                        MessageBox.Show("Изменение прошли успешно.", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                        dg5.ItemsSource = gfh1.ToList();
                    }
                    if (h1 == "Physical education")
                    {
                        string[] dan1 = cb5.Text.Split(new char[] { '/' });
                        string hl1 = dan1[0] + "." + dan1[1] + "." + dan1[2] + " 0:00:00";
                        var jk1 = Convert.ToDateTime(hl1);
                        var l1 = school.Schedule.Single(k => k.Date == jk1);
                        int t1 = Convert.ToInt32(cb6.Text);
                        var gfh1 = school.Physical_education_grades.Where(gjk => gjk.id_Day == l1.id_Day && gjk.id_Student == t1);
                        int u = Convert.ToInt32(cb7.Text);
                        var kop11 = gfh1.Max(b => b.id);
                        var kop12 = gfh1.Min(b => b.id);
                        var gfh2 = gfh1.Single(p => p.id == u);

                        if (u == kop11)
                        {
                            string[] dan = cb5.Text.Split(new char[] { '/' });
                            string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                            var jk = Convert.ToDateTime(hl);
                            var l = school.Schedule.Single(k => k.Date == jk);
                            int t = Convert.ToInt32(cb6.Text);
                            var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Physical_education != "-");
                            var kop = gfh.Max(b => b.id);
                            var lhg = school.Grades_Students.Single(llo => llo.id == kop);
                            lhg.Physical_education = cb4.Text;
                            dg6.ItemsSource = gfh.ToList();
                        }
                        else
                        {
                            if (u == kop12)
                            {
                                string[] dan = cb5.Text.Split(new char[] { '/' });
                                string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                var jk = Convert.ToDateTime(hl);
                                var l = school.Schedule.Single(k => k.Date == jk);
                                int t = Convert.ToInt32(cb6.Text);
                                var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Physical_education != "-");
                                var kop = gfh.Min(b => b.id);
                                var lhg = school.Grades_Students.Single(llo => llo.id == kop);
                                lhg.Physical_education = cb4.Text;
                                dg6.ItemsSource = gfh.ToList();
                            }
                        }

                        gfh2.Grades = cb4.Text;
                        school.SaveChanges();
                        MessageBox.Show("Изменение прошли успешно.", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                        dg5.ItemsSource = gfh1.ToList();
                    }
                    if (h1 == "Work")
                    {
                        string[] dan1 = cb5.Text.Split(new char[] { '/' });
                        string hl1 = dan1[0] + "." + dan1[1] + "." + dan1[2] + " 0:00:00";
                        var jk1 = Convert.ToDateTime(hl1);
                        var l1 = school.Schedule.Single(k => k.Date == jk1);
                        int t1 = Convert.ToInt32(cb6.Text);
                        var gfh1 = school.Work_grades.Where(gjk => gjk.id_Day == l1.id_Day && gjk.id_Student == t1);
                        int u = Convert.ToInt32(cb7.Text);
                        var kop11 = gfh1.Max(b => b.id);
                        var kop12 = gfh1.Min(b => b.id);
                        var gfh2 = gfh1.Single(p => p.id == u);

                        if (u == kop11)
                        {
                            string[] dan = cb5.Text.Split(new char[] { '/' });
                            string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                            var jk = Convert.ToDateTime(hl);
                            var l = school.Schedule.Single(k => k.Date == jk);
                            int t = Convert.ToInt32(cb6.Text);
                            var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Work_ != "-");
                            var kop = gfh.Max(b => b.id);
                            var lhg = school.Grades_Students.Single(llo => llo.id == kop);
                            lhg.Work_ = cb4.Text;
                            dg6.ItemsSource = gfh.ToList();
                        }
                        else
                        {
                            if (u == kop12)
                            {
                                string[] dan = cb5.Text.Split(new char[] { '/' });
                                string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                                var jk = Convert.ToDateTime(hl);
                                var l = school.Schedule.Single(k => k.Date == jk);
                                int t = Convert.ToInt32(cb6.Text);
                                var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Work_ != "-");
                                var kop = gfh.Min(b => b.id);
                                var lhg = school.Grades_Students.Single(llo => llo.id == kop);
                                lhg.Work_ = cb4.Text;
                                dg6.ItemsSource = gfh.ToList();
                            }
                        }
                        gfh2.Grades = cb4.Text;
                        school.SaveChanges();
                        MessageBox.Show("Изменение прошли успешно.", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                        dg5.ItemsSource = gfh1.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность заполненых полей.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Bt9_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cb6.Text != "" && cb5.Text != "")
                {

                    var g = school.Teachers.Single(g1 => g1.id_Teacher == id_p);
                    var h1 = g.Subject;



                    if (h1 == "Algebra")
                    {

                        string[] dan = cb5.Text.Split(new char[] { '/' });
                        string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                        var jk = Convert.ToDateTime(hl);
                        var l = school.Schedule.Single(k => k.Date == jk);
                        int t = Convert.ToInt32(cb6.Text);
                        var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Algebra != "-");
                        var coun1 = school.Schedule.Where(k => k.Date == jk);
                        var coun2 = coun1.Count(f => f.Lesson1 == "Algebra" || f.Lesson2 == "Algebra" || f.Lesson3 == "Algebra" || f.Lesson4 == "Algebra" || f.Lesson5 == "Algebra" || f.Lesson6 == "Algebra");
                        dg6.ItemsSource = gfh.ToList();


                        string[] dan1 = cb5.Text.Split(new char[] { '/' });
                        string hl1 = dan1[0] + "." + dan1[1] + "." + dan1[2] + " 0:00:00";
                        var jk1 = Convert.ToDateTime(hl1);
                        var l1 = school.Schedule.Single(k => k.Date == jk1);
                        int t1 = Convert.ToInt32(cb6.Text);
                        var gfh1 = school.Algebra_grades.Where(gjk => gjk.id_Day == l1.id_Day && gjk.id_Student == t1);
                        dg5.ItemsSource = gfh1.ToList();

                    }
                    if (h1 == "Geometry")
                    {
                        string[] dan = cb5.Text.Split(new char[] { '/' });
                        string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                        var jk = Convert.ToDateTime(hl);
                        var l = school.Schedule.Single(k => k.Date == jk);
                        int t = Convert.ToInt32(cb6.Text);
                        var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Geometry != "-");
                        var coun1 = school.Schedule.Where(k => k.Date == jk);
                        var coun2 = coun1.Count(f => f.Lesson1 == "Geometry" || f.Lesson2 == "Geometry" || f.Lesson3 == "Geometry" || f.Lesson4 == "Geometry" || f.Lesson5 == "Geometry" || f.Lesson6 == "Geometry");
                        dg6.ItemsSource = gfh.ToList();

                        string[] dan1 = cb5.Text.Split(new char[] { '/' });
                        string hl1 = dan1[0] + "." + dan1[1] + "." + dan1[2] + " 0:00:00";
                        var jk1 = Convert.ToDateTime(hl1);
                        var l1 = school.Schedule.Single(k => k.Date == jk1);
                        int t1 = Convert.ToInt32(cb6.Text);
                        var gfh1 = school.Geometry_grades.Where(gjk => gjk.id_Day == l1.id_Day && gjk.id_Student == t1);
                        dg5.ItemsSource = gfh1.ToList();

                    }
                    if (h1 == "Russian language")
                    {
                        string[] dan = cb5.Text.Split(new char[] { '/' });
                        string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                        var jk = Convert.ToDateTime(hl);
                        var l = school.Schedule.Single(k => k.Date == jk);
                        int t = Convert.ToInt32(cb6.Text);
                        var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Russian_language != "-");
                        var coun1 = school.Schedule.Where(k => k.Date == jk);
                        var coun2 = coun1.Count(f => f.Lesson1 == "Russian language" || f.Lesson2 == "Russian language" || f.Lesson3 == "Russian language" || f.Lesson4 == "Russian language" || f.Lesson5 == "Russian language" || f.Lesson6 == "Russian language");
                        dg6.ItemsSource = gfh.ToList();

                        string[] dan1 = cb5.Text.Split(new char[] { '/' });
                        string hl1 = dan1[0] + "." + dan1[1] + "." + dan1[2] + " 0:00:00";
                        var jk1 = Convert.ToDateTime(hl1);
                        var l1 = school.Schedule.Single(k => k.Date == jk1);
                        int t1 = Convert.ToInt32(cb6.Text);
                        var gfh1 = school.Russian_language_grades.Where(gjk => gjk.id_Day == l1.id_Day && gjk.id_Student == t1);
                        dg5.ItemsSource = gfh1.ToList();
                    }
                    if (h1 == "Literature")
                    {
                        string[] dan = cb5.Text.Split(new char[] { '/' });
                        string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                        var jk = Convert.ToDateTime(hl);
                        var l = school.Schedule.Single(k => k.Date == jk);
                        int t = Convert.ToInt32(cb6.Text);
                        var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Literature != "-");
                        var coun1 = school.Schedule.Where(k => k.Date == jk);
                        var coun2 = coun1.Count(f => f.Lesson1 == "Literature" || f.Lesson2 == "Literature" || f.Lesson3 == "Literature" || f.Lesson4 == "Literature" || f.Lesson5 == "Literature" || f.Lesson6 == "Literature");
                        dg6.ItemsSource = gfh.ToList();

                        string[] dan1 = cb5.Text.Split(new char[] { '/' });
                        string hl1 = dan1[0] + "." + dan1[1] + "." + dan1[2] + " 0:00:00";
                        var jk1 = Convert.ToDateTime(hl1);
                        var l1 = school.Schedule.Single(k => k.Date == jk1);
                        int t1 = Convert.ToInt32(cb6.Text);
                        var gfh1 = school.Literature_grades.Where(gjk => gjk.id_Day == l1.id_Day && gjk.id_Student == t1);
                        dg5.ItemsSource = gfh1.ToList();
                    }
                    if (h1 == "Physical education")
                    {
                        string[] dan = cb5.Text.Split(new char[] { '/' });
                        string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                        var jk = Convert.ToDateTime(hl);
                        var l = school.Schedule.Single(k => k.Date == jk);
                        int t = Convert.ToInt32(cb6.Text);
                        var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Physical_education != "-");
                        var coun1 = school.Schedule.Where(k => k.Date == jk);
                        var coun2 = coun1.Count(f => f.Lesson1 == "Physical education" || f.Lesson2 == "Physical education" || f.Lesson3 == "Physical education" || f.Lesson4 == "Physical education" || f.Lesson5 == "Physical education" || f.Lesson6 == "Physical education");
                        dg6.ItemsSource = gfh.ToList();

                        string[] dan1 = cb5.Text.Split(new char[] { '/' });
                        string hl1 = dan1[0] + "." + dan1[1] + "." + dan1[2] + " 0:00:00";
                        var jk1 = Convert.ToDateTime(hl1);
                        var l1 = school.Schedule.Single(k => k.Date == jk1);
                        int t1 = Convert.ToInt32(cb6.Text);
                        var gfh1 = school.Physical_education_grades.Where(gjk => gjk.id_Day == l1.id_Day && gjk.id_Student == t1);
                        dg5.ItemsSource = gfh1.ToList();
                    }
                    if (h1 == "Work")
                    {
                        string[] dan = cb5.Text.Split(new char[] { '/' });
                        string hl = dan[0] + "." + dan[1] + "." + dan[2] + " 0:00:00";
                        var jk = Convert.ToDateTime(hl);
                        var l = school.Schedule.Single(k => k.Date == jk);
                        int t = Convert.ToInt32(cb6.Text);
                        var gfh = school.Grades_Students.Where(g1 => g1.id_Day == l.id_Day && g1.id_Student == t && g1.Work_ != "-");
                        var coun1 = school.Schedule.Where(k => k.Date == jk);
                        var coun2 = coun1.Count(f => f.Lesson1 == "Work" || f.Lesson2 == "Work" || f.Lesson3 == "Work" || f.Lesson4 == "Work" || f.Lesson5 == "Work" || f.Lesson6 == "Work");
                        dg6.ItemsSource = gfh.ToList();

                        string[] dan1 = cb5.Text.Split(new char[] { '/' });
                        string hl1 = dan1[0] + "." + dan1[1] + "." + dan1[2] + " 0:00:00";
                        var jk1 = Convert.ToDateTime(hl1);
                        var l1 = school.Schedule.Single(k => k.Date == jk1);
                        int t1 = Convert.ToInt32(cb6.Text);
                        var gfh1 = school.Work_grades.Where(gjk => gjk.id_Day == l1.id_Day && gjk.id_Student == t1);
                        dg5.ItemsSource = gfh1.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            if (gat == null)
            {
                MessageBox.Show("Выберите чат с учеником", "Ошибка при выборе", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (tb5.Text != "" && tb5.Text != " " && tb5.Text != "  " && tb5.Text != "   " && tb5.Text != "    ")
                {
                    try
                    {
                        StreamWriter f = new StreamWriter(gat, true);
                        f.WriteLine("");
                        f.WriteLine("" + tb1.Text + ": " + tb5.Text + "");
                        f.Close();

                        var sr = new StreamReader(gat);
                        string text = sr.ReadToEnd();
                        var document = new FlowDocument();
                        var paragraph = new Paragraph();
                        paragraph.Inlines.Add(text);
                        document.Blocks.Add(paragraph);
                        Rtd.Document = document;
                        tb5.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Подождите перед повторной отправкой", "Отправка", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                int studid = Convert.ToInt32(cb1.Text);
              string studFIO = cb8.Text;
              var stu = school.Students.Single(h => h.id_Student == studid &&  h.Last_name + " " + h.First_name + " "+ h.Middle_name == studFIO);
              if (stu.id_Student == Convert.ToInt32(cb1.Text) && stu.Last_name + " " + stu.First_name + " " + stu.Middle_name == cb8.Text)
              {              
                var sr = new StreamReader("Чат_"+ teachles + "_"+cb1.Text+".txt");
                string text = sr.ReadToEnd();

                var document = new FlowDocument();
                var paragraph = new Paragraph();
                paragraph.Inlines.Add(text);
                document.Blocks.Add(paragraph);
                Rtd.Document = document;
                gat = "Чат_" + teachles + "_" + cb1.Text + ".txt";
              }
              else
              {
                 MessageBox.Show("Проверьте заполнения полей.", "Ошибка при выборе", MessageBoxButton.OK, MessageBoxImage.Error);
              }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность выбора чата.", "Ошибка при выборе", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Bt5_Click(object sender, RoutedEventArgs e)
        {
            Rtd.Visibility = Visibility.Visible;
            tb5.Visibility = Visibility.Visible;
            bt1.Visibility = Visibility.Visible;
            label1.Visibility = Visibility.Visible;
            label2.Visibility = Visibility.Visible;
            label3.Visibility = Visibility.Visible;
            label4.Visibility = Visibility.Visible;
            label5.Visibility = Visibility.Visible;
            bt6.Visibility = Visibility.Visible;
            bt7.Visibility = Visibility.Visible;
            cb1.Visibility = Visibility.Visible;
            cb8.Visibility = Visibility.Visible;
            bt4.Visibility = Visibility.Hidden;
            bt5.Visibility = Visibility.Hidden;          
            dg2.Visibility = Visibility.Hidden;

            dg3.Visibility = Visibility.Hidden;
            tb3.Visibility = Visibility.Hidden;
            label6.Visibility = Visibility.Hidden;
            label7.Visibility = Visibility.Hidden;
            label8.Visibility = Visibility.Hidden;
            bt11.Visibility = Visibility.Hidden;
            bt12.Visibility = Visibility.Hidden;


            tv_vistav1.Visibility = Visibility.Hidden;
            tv_vistav2.Visibility = Visibility.Hidden;
            tv_vistav3.Visibility = Visibility.Hidden;
            tv_vistav4.Visibility = Visibility.Hidden;
            tv_vistav5.Visibility = Visibility.Hidden;
            tv_vistav6.Visibility = Visibility.Hidden;
            bt13.Visibility = Visibility.Hidden;
            bt14.Visibility = Visibility.Hidden;
            bt15.Visibility = Visibility.Hidden;
            dg5.Visibility = Visibility.Hidden;

            dg2.Visibility = Visibility.Hidden;

            bt8.Visibility = Visibility.Hidden;
            bt9.Visibility = Visibility.Hidden;
            tb_ismen1.Visibility = Visibility.Hidden;
            tb_ismen2.Visibility = Visibility.Hidden;
            tb_ismen3.Visibility = Visibility.Hidden;
            tb_ismen4.Visibility = Visibility.Hidden;
            cb5.Visibility = Visibility.Hidden;
            cb6.Visibility = Visibility.Hidden;
            cb7.Visibility = Visibility.Hidden;
            cb4.Visibility = Visibility.Hidden;

            tb_dobav1.Visibility = Visibility.Hidden;
            tb_dobav2.Visibility = Visibility.Hidden;
            tb_dobav3.Visibility = Visibility.Hidden;
            tb_dobav4.Visibility = Visibility.Hidden;
            tb7.Visibility = Visibility.Hidden;
            tb8.Visibility = Visibility.Hidden;
            cb2.Visibility = Visibility.Hidden;
            cb3.Visibility = Visibility.Hidden;
            bt_dobav1.Visibility = Visibility.Hidden;

            lab1.Visibility = Visibility.Hidden;
            tb9.Visibility = Visibility.Hidden;

        }

        private void Bt6_Click(object sender, RoutedEventArgs e)
        {
            bt4.Visibility = Visibility.Visible;
            bt5.Visibility = Visibility.Visible;
            Rtd.Visibility = Visibility.Hidden;
            tb5.Visibility = Visibility.Hidden;
            bt1.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            label3.Visibility = Visibility.Hidden;
            label4.Visibility = Visibility.Hidden;
            label5.Visibility = Visibility.Hidden;
            bt6.Visibility = Visibility.Hidden;
            bt7.Visibility = Visibility.Hidden;
            cb1.Visibility = Visibility.Hidden;
            cb8.Visibility = Visibility.Hidden;

            var g = school.Teachers.Single(g1 => g1.id_Teacher == id_p);
            var r = school.Schedule.Where(g1 => g1.Lesson1 == g.Subject || g1.Lesson2 == g.Subject || g1.Lesson3 == g.Subject || g1.Lesson4 == g.Subject || g1.Lesson5 == g.Subject || g1.Lesson6 == g.Subject);
            dg2.ItemsSource = r.ToList();
            dg2.Visibility = Visibility.Visible;

        }

        private void Bt13_Click(object sender, RoutedEventArgs e)
        {
            bt8.Visibility = Visibility.Visible;
            bt9.Visibility = Visibility.Visible;
            tb_ismen1.Visibility = Visibility.Visible;
            tb_ismen2.Visibility = Visibility.Visible;
            tb_ismen3.Visibility = Visibility.Visible;
            tb_ismen4.Visibility = Visibility.Visible;
            cb5.Visibility = Visibility.Visible;
            cb6.Visibility = Visibility.Visible;
            cb7.Visibility = Visibility.Visible;
            cb4.Visibility = Visibility.Visible;
            bt13.Visibility = Visibility.Hidden;
            bt14.Visibility = Visibility.Hidden;
            bt15.Visibility = Visibility.Hidden;
        }

        private void Bt14_Click(object sender, RoutedEventArgs e)
        {
            tb_dobav1.Visibility = Visibility.Visible;
            tb_dobav2.Visibility = Visibility.Visible;
            tb_dobav3.Visibility = Visibility.Visible;
            tb_dobav4.Visibility = Visibility.Visible;                  
            tb7.Visibility = Visibility.Visible;
            tb8.Visibility = Visibility.Visible;
            cb2.Visibility = Visibility.Visible;
            cb3.Visibility = Visibility.Visible;
            bt_dobav1.Visibility = Visibility.Visible;
            bt13.Visibility = Visibility.Hidden;
            bt14.Visibility = Visibility.Hidden;
            bt15.Visibility = Visibility.Hidden;
        }

        private void Bt15_Click(object sender, RoutedEventArgs e)
        {
            tv_vistav1.Visibility = Visibility.Hidden;
            tv_vistav2.Visibility = Visibility.Hidden;
            tv_vistav3.Visibility = Visibility.Hidden;
            tv_vistav4.Visibility = Visibility.Hidden;
            tv_vistav5.Visibility = Visibility.Hidden;
            tv_vistav6.Visibility = Visibility.Hidden;
            bt13.Visibility = Visibility.Hidden;
            bt14.Visibility = Visibility.Hidden;
            bt15.Visibility = Visibility.Hidden;
            dg5.Visibility = Visibility.Hidden;
            dg2.Visibility = Visibility.Visible;

        }
    }
}
