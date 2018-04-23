Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace XpoNorthwindServerMode
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			Dim conn As String = MSSqlConnectionProvider.GetConnectionString("(local)", "NorthwindXpo")
			XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.SchemaAlreadyExists)

			InitializeComponent()

			System.Diagnostics.Trace.Listeners.Add(New MyTraceListner(textBox1))

			Dim uow As New UnitOfWork()
			Dim col As New XPServerCollectionSource(uow, GetType(NorthwindXpo.Order))
			col.DisplayableProperties = "Customer.CompanyName;Employee.LastName;OrderDate;ShippedDate;" & "Freight;ShipName;ShipAddress;ShipCity;ShipRegion;ShipPostalCode;ShipCountry"

			gridControl1.DataSource = col
			gridControl1.PopulateColumns()
		End Sub
	End Class

	Friend Class MyTraceListner
		Inherits System.Diagnostics.TraceListener
		Private outputWindow As TextBox
		Public Sub New(ByVal outputWindow As TextBox)
			Me.outputWindow = outputWindow
		End Sub
		Public Overrides Overloads Sub Write(ByVal message As String)
			outputWindow.AppendText(message)
		End Sub
		Public Overrides Overloads Sub WriteLine(ByVal message As String)
			outputWindow.AppendText(message & Constants.vbCrLf)
		End Sub
	End Class
End Namespace
