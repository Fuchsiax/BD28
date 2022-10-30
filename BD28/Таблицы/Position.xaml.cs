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
    /// Логика взаимодействия для Position.xaml
    /// </summary>
    public partial class Position : Window
    {
        public Position()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            BD28.barbershop4DataSet barbershop4DataSet = ((BD28.barbershop4DataSet)(this.FindResource("barbershop4DataSet")));
            // Загрузить данные в таблицу Должности. Можно изменить этот код как требуется.
            BD28.barbershop4DataSetTableAdapters.ДолжностиTableAdapter barbershop4DataSetДолжностиTableAdapter = new BD28.barbershop4DataSetTableAdapters.ДолжностиTableAdapter();
            barbershop4DataSetДолжностиTableAdapter.Fill(barbershop4DataSet.Должности);
            System.Windows.Data.CollectionViewSource должностиViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("должностиViewSource")));
            должностиViewSource.View.MoveCurrentToFirst();
        }
    }
}
