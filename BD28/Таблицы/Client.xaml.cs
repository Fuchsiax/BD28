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

namespace BD28.Таблицы
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            BD28.barbershop4DataSet barbershop4DataSet = ((BD28.barbershop4DataSet)(this.FindResource("barbershop4DataSet")));
            // Загрузить данные в таблицу Клиенты. Можно изменить этот код как требуется.
            BD28.barbershop4DataSetTableAdapters.КлиентыTableAdapter barbershop4DataSetКлиентыTableAdapter = new BD28.barbershop4DataSetTableAdapters.КлиентыTableAdapter();
            barbershop4DataSetКлиентыTableAdapter.Fill(barbershop4DataSet.Клиенты);
            System.Windows.Data.CollectionViewSource клиентыViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("клиентыViewSource")));
            клиентыViewSource.View.MoveCurrentToFirst();
        }
    }
}
