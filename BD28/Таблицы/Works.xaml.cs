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
    /// Логика взаимодействия для Works.xaml
    /// </summary>
    public partial class Works : Window
    {
        public Works()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            BD28.barbershop4DataSet barbershop4DataSet = ((BD28.barbershop4DataSet)(this.FindResource("barbershop4DataSet")));
            // Загрузить данные в таблицу Работы. Можно изменить этот код как требуется.
            BD28.barbershop4DataSetTableAdapters.РаботыTableAdapter barbershop4DataSetРаботыTableAdapter = new BD28.barbershop4DataSetTableAdapters.РаботыTableAdapter();
            barbershop4DataSetРаботыTableAdapter.Fill(barbershop4DataSet.Работы);
            System.Windows.Data.CollectionViewSource работыViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("работыViewSource")));
            работыViewSource.View.MoveCurrentToFirst();
        }
    }
}
