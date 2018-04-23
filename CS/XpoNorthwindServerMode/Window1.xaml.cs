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
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace XpoNorthwindServerMode {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            string conn = MSSqlConnectionProvider.GetConnectionString("(local)", "NorthwindXpo");
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.SchemaAlreadyExists);

            InitializeComponent();

            System.Diagnostics.Trace.Listeners.Add(new MyTraceListner(textBox1));

            UnitOfWork uow = new UnitOfWork();
            XPServerCollectionSource col = new XPServerCollectionSource(uow, typeof(NorthwindXpo.Order));
            col.DisplayableProperties = "Customer.CompanyName;Employee.LastName;OrderDate;ShippedDate;"
              + "Freight;ShipName;ShipAddress;ShipCity;ShipRegion;ShipPostalCode;ShipCountry";

            gridControl1.DataSource = col;
            gridControl1.PopulateColumns();
        }
    }

    class MyTraceListner : System.Diagnostics.TraceListener {
        TextBox outputWindow;
        public MyTraceListner(TextBox outputWindow) {
            this.outputWindow = outputWindow;
        }
        public override void Write(string message) {
            outputWindow.AppendText(message);
        }
        public override void WriteLine(string message) {
            outputWindow.AppendText(message + "\r\n");
        }
    }
}
