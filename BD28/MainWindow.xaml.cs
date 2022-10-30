using BD28.Таблицы;
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

namespace BD28
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Архив_Click(object sender, RoutedEventArgs e)
        {
            Arxiv arxiv = new Arxiv();
            arxiv.Show();
        }

        private void Должности_Click(object sender, RoutedEventArgs e)
        {
            Position position = new Position();
            position.Show();
        }

        private void Клиенты_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void Работы_Click(object sender, RoutedEventArgs e)
        {
            Works works = new Works();
            works.Show();
        }

        private void Сотрудники_Click(object sender, RoutedEventArgs e)
        {
            Employers employers = new Employers();
            employers.Show();
        }

        private void Стрижки_Click(object sender, RoutedEventArgs e)
        {
            Haircut haircut = new Haircut();
            haircut.Show();
        }

        private void Филиалы_Click(object sender, RoutedEventArgs e)
        {
            Filial filial = new Filial();
            filial.Show();
        }

        private void Цены_Click(object sender, RoutedEventArgs e)
        {
            Price price = new Price();
            price.Show();
        }
    }
}
