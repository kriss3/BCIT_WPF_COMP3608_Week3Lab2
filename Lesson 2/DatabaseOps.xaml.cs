using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataAccess;
using DataAccess.Northwind2013DataSetTableAdapters;

namespace Lesson_2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
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
