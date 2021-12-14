Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace XpoNorthwindServerMode

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Dim conn As String = MSSqlConnectionProvider.GetConnectionString("(local)", "NorthwindXpo")
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.SchemaAlreadyExists)
            Me.InitializeComponent()
            System.Diagnostics.Trace.Listeners.Add(New MyTraceListner(Me.textBox1))
            Dim uow As UnitOfWork = New UnitOfWork()
            Dim col As XPServerCollectionSource = New XPServerCollectionSource(uow, GetType(NorthwindXpo.Order))
            col.DisplayableProperties = "Customer.CompanyName;Employee.LastName;OrderDate;ShippedDate;" & "Freight;ShipName;ShipAddress;ShipCity;ShipRegion;ShipPostalCode;ShipCountry"
            Me.gridControl1.ItemsSource = col
            Me.gridControl1.PopulateColumns()
        End Sub
    End Class

    Friend Class MyTraceListner
        Inherits System.Diagnostics.TraceListener

        Private outputWindow As TextBox

        Public Sub New(ByVal outputWindow As TextBox)
            Me.outputWindow = outputWindow
        End Sub

        Public Overrides Sub Write(ByVal message As String)
            outputWindow.AppendText(message)
        End Sub

        Public Overrides Sub WriteLine(ByVal message As String)
            outputWindow.AppendText(message & Microsoft.VisualBasic.Constants.vbCrLf)
        End Sub
    End Class
End Namespace
