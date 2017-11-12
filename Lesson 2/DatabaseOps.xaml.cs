using DataAccess;
using DataAccess.Northwind2013DataSetTableAdapters;
using System.Windows;

namespace Lesson_2
{
    /// <summary>
    /// Interaction logic for DatabaseOps.xaml
    /// Krzysztof Szczurowski
    /// Repo address: https://github.com/kriss3/BCIT_WPF_COMP3608_Week3Lab2.git
    /// Using Northwind2013.accdb as a DataSource;
    /// </summary>
    public partial class DatabaseOps : Window
    {
        Northwind2013DataSet aset = new Northwind2013DataSet();
        CustomersTableAdapter custAdap = new CustomersTableAdapter();
        OrdersTableAdapter ordAdap = new OrdersTableAdapter();
        Order_Details_ExtendedTableAdapter ord_det_extAdap = new Order_Details_ExtendedTableAdapter();

        public DatabaseOps()
        {
            InitializeComponent();

            custAdap.Fill(aset.Customers);
            ordAdap.Fill(aset.Orders);
            ord_det_extAdap.Fill(aset.Order_Details_Extended);
            Grid1.DataContext = aset.Customers;
        }
    }
}
