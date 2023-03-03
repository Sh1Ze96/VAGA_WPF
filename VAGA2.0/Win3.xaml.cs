using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VAGA2._0
{
    /// <summary>
    /// Логика взаимодействия для Win3.xaml
    /// </summary>
    public partial class Win3 : Window
    {
        public class User
        {
            public string name { get; set; }
            public string dataOfBirth { get; set; }
            public string age { get; set; }
            public string klass { get; set; }

            public User(string _name, string _dataOfBirth, string _age, string _klass)
            {
                this.name = _name;
                this.dataOfBirth = _dataOfBirth;
                this.age = _age;
                this.klass = _klass;
            }
        }
        public List<User> user = new List<User>();
        public void LoadUser(List<User> _user)
        {
            userList.Items.Clear(); // очищаем лист с элементами

            for (int i = 0; i < _user.Count; i++) // перебираем элементы
            {
                userList.Items.Add(_user[i]); // добавляем элементы в ListBox
            }
        }
        public Win3()
        {
            InitializeComponent();

            // Добавляем данные
            user.Add(new User("Toyota Celica", "серебристый", "1973", "E"));
            user.Add(new User("Toyota GT86", "оранжевый", "2012", "J"));
            user.Add(new User("Toyota Supra", "красный", "1986", "S"));
            user.Add(new User("Toyota Supra IV (A80)", "розовый", "1993-1996", "S"));
            user.Add(new User("Toyota Supra IV (A80)", "серебристый", "1996-2002", "S"));
            user.Add(new User("Toyota Voxy.", "белый", "2023", "M"));
            LoadUser(user); // выводим данные на экран
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }
        private void ActiveFilter(object sender, RoutedEventArgs e)
        {
            List<User> newUsers = new List<User>();
            newUsers = user;

            if (genderFilter.SelectedIndex == 0)
                newUsers = user.FindAll(x => x.klass == "M");
            else if (genderFilter.SelectedIndex == 1) 
                newUsers = user.FindAll(x => x.klass == "S");
            else if (genderFilter.SelectedIndex == 2)
                 newUsers = user.FindAll(x => x.klass == "J");
            else 
                 newUsers = user.FindAll(x => x.klass == "E");
            LoadUser(newUsers);
        }
    }
}
