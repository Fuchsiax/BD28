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
    /// Логика взаимодействия для Price.xaml
    /// </summary>
    public partial class Price : Window
    {
        public Price()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            BD28.barbershop4DataSet barbershop4DataSet = ((BD28.barbershop4DataSet)(this.FindResource("barbershop4DataSet")));
            // Загрузить данные в таблицу Цены. Можно изменить этот код как требуется.
            BD28.barbershop4DataSetTableAdapters.ЦеныTableAdapter barbershop4DataSetЦеныTableAdapter = new BD28.barbershop4DataSetTableAdapters.ЦеныTableAdapter();
            barbershop4DataSetЦеныTableAdapter.Fill(barbershop4DataSet.Цены);
            System.Windows.Data.CollectionViewSource ценыViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ценыViewSource")));
            ценыViewSource.View.MoveCurrentToFirst();
        }
    }
}
