using BD28.barbershop4DataSetTableAdapters;
using BD28.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BD28.Таблицы
{
    /// <summary>
    /// Логика взаимодействия для Employers.xaml
    /// </summary>
    public partial class Employers : Window
    {
        ApplicationContext db;
        public Employers()
        {
            InitializeComponent();
            db = new ApplicationContext();
            сотрудникиDataGrid.ItemsSource = db.Employers.ToList();

  
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            BD28.barbershop4DataSet barbershop4DataSet = ((BD28.barbershop4DataSet)(this.FindResource("barbershop4DataSet")));
            //// Загрузить данные в таблицу Сотрудники. Можно изменить этот код как требуется.
            //BD28.barbershop4DataSetTableAdapters.СотрудникиTableAdapter barbershop4DataSetСотрудникиTableAdapter = new BD28.barbershop4DataSetTableAdapters.СотрудникиTableAdapter();
            //barbershop4DataSetСотрудникиTableAdapter.Fill(barbershop4DataSet.Сотрудники);
            //System.Windows.Data.CollectionViewSource сотрудникиViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("сотрудникиViewSource")));
            //сотрудникиViewSource.View.MoveCurrentToFirst();


            //var q = select barbershop4DataSet.Сотрудники.NameFirm
            //from table1 INNER join table2 on table1.id = table2.id

            //var q = from b in barbershop4DataSet.Филиалы join barbershop4DataSet.Сотр

            //var query =
            //from p in barbershop4DataSet.Сотрудники
            //select new { p.Код_филиала};



            //код_филиалаComboBox.ItemsSource = query.ToList();
            //string strSQL = string.Format("SELECT Филиалы.Название FROM Сотрудники INNER JOIN Филиалы ON Сотрудники.Код_филиала = Филиалы.Код_филиала");

            //ForeginKeySQL(strSQL);

            string sql = "SELECT * FROM Филиалы";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=.\SQLEXPRESS;Database=Equipment;Trusted_Connection=true";

                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    System.Windows.Data.CollectionViewSource филиалыViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("филиалыViewSource")));
                    филиалыViewSource.View.MoveCurrentToFirst();

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }



            // Загрузить данные в таблицу Филиалы. Можно изменить этот код как требуется.
            BD28.barbershop4DataSetTableAdapters.ФилиалыTableAdapter barbershop4DataSetФилиалыTableAdapter = new BD28.barbershop4DataSetTableAdapters.ФилиалыTableAdapter();
            barbershop4DataSetФилиалыTableAdapter.Fill(barbershop4DataSet.Филиалы);

        }

        //Done
        private void AddSQL(string strSQL)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=.\SQLEXPRESS;Database=Equipment;Trusted_Connection=true";

                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(strSQL, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Добавлено");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void ForeginKeySQL(string strSQL)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=DESKTOP-B2NLQB4\SQLEXPRESS;Initial Catalog=barbershop4;Integrated Security=True";

                try
                {
                    connection.Open();
                    SqlCommand myCommand = new SqlCommand(strSQL, connection);
                    myCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(myCommand);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    филиал.ItemsSource = ds.Tables[0].DefaultView;
                    филиал.DisplayMemberPath = ds.Tables[0].Columns["Название"].ToString();
                    //сотрудникиDataGrid.ItemsSource = ds.Tables[0].Columns["Название"].ToString();
                    //код_филиалаComboBox.ItemsSource = ds.Tables[0].DefaultView;
                    //код_филиалаComboBox.DisplayMemberPath = ds.Tables[0].Columns["Название"].ToString();
                    //филиал.SelectedValuePath = ds.Tables[0].Columns["Код_филиала"].ToString();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void код_филиалаComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (код_филиалаComboBox.SelectedIndex != филиал.SelectedIndex)
            {
                филиал.SelectedIndex = код_филиалаComboBox.SelectedIndex;
            }
            
        }
    }
}
