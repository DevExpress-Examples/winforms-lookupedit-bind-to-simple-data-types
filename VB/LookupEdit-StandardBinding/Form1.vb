Imports DevExpress.XtraEditors.Repository
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace LookupEdit_StandardBinding
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitData()

			gridControl1.DataSource = Products
			gridView1.Columns("UnitPrice").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			gridView1.Columns("UnitPrice").DisplayFormat.FormatString = "c2"

			' Create an in-place LookupEdit control.
			Dim riLookup As New RepositoryItemLookUpEdit()
			riLookup.DataSource = Categories
			riLookup.ValueMember = "ID"
			riLookup.DisplayMember = "CategoryName"

			' Enable the "best-fit" functionality mode in which columns have proportional widths and the popup window is resized to fit all the columns.
			riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
			' Specify the dropdown height.
			riLookup.DropDownRows = Categories.Count

			' Enable the automatic completion feature. In this mode, when the dropdown is closed, 
			' the text in the edit box is automatically completed if it matches a DisplayMember field value of one of dropdown rows. 
			riLookup.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
			' Specify the column against which an incremental search is performed in SearchMode.AutoComplete and SearchMode.OnlyInPopup modes
			riLookup.AutoSearchColumnIndex = 1

			' Optionally hide the Description column in the dropdown.
			' riLookup.PopulateColumns();
			' riLookup.Columns["Description"].Visible = false;

			gridControl1.RepositoryItems.Add(riLookup)

			' Assign the in-place LookupEdit control to the grid's CategoryID column.
			' Note that the data types of the "ID" and "CategoryID" fields match.
			gridView1.Columns("CategoryID").ColumnEdit = riLookup
			gridView1.BestFitColumns()
		End Sub

		Private Products As New List(Of Product)()
		Private Categories As New List(Of Category)()

		Private Sub InitData()
			Products.Add(New Product() With {.ProductName = "Sir Rodney's Scones", .CategoryID = 3, .UnitPrice = 10})
			Products.Add(New Product() With {.ProductName = "Gustaf's Knäckebröd", .CategoryID = 5, .UnitPrice = 21})
			Products.Add(New Product() With {.ProductName = "Tunnbröd", .CategoryID = 5, .UnitPrice = 9})
			Products.Add(New Product() With {.ProductName = "Guaraná Fantástica", .CategoryID = 1, .UnitPrice = 4.5D})
			Products.Add(New Product() With {.ProductName = "NuNuCa Nuß-Nougat-Creme", .CategoryID = 3, .UnitPrice = 14})
			Products.Add(New Product() With {.ProductName = "Gumbär Gummibärchen", .CategoryID = 3, .UnitPrice = 31.23D})
			Products.Add(New Product() With {.ProductName = "Rössle Sauerkraut", .CategoryID = 7, .UnitPrice = 45.6D})
			Products.Add(New Product() With {.ProductName = "Thüringer Rostbratwurst", .CategoryID = 6, .UnitPrice = 123.79D})
			Products.Add(New Product() With {.ProductName = "Nord-Ost Matjeshering", .CategoryID = 8, .UnitPrice = 25.89D})
			Products.Add(New Product() With {.ProductName = "Gorgonzola Telino", .CategoryID = 4, .UnitPrice = 12.5D})

			Categories.Add(New Category() With {.ID = 1, .CategoryName = "Beverages", .Description = "Soft drinks, coffees, teas, beers, and ales"})
			Categories.Add(New Category() With {.ID = 2, .CategoryName = "Condiments", .Description = "Sweet and savory sauces, relishes, spreads, and seasonings"})
			Categories.Add(New Category() With {.ID = 3, .CategoryName = "Confections", .Description = "Desserts, candies, and sweet breads"})
			Categories.Add(New Category() With {.ID = 4, .CategoryName = "Dairy Products", .Description = "Cheeses"})
			Categories.Add(New Category() With {.ID = 5, .CategoryName = "Grains/Cereals", .Description = "Breads, crackers, pasta, and cereal"})
			Categories.Add(New Category() With {.ID = 6, .CategoryName = "Meat/Poultry", .Description = "Prepared meats"})
			Categories.Add(New Category() With {.ID = 7, .CategoryName = "Produce", .Description = "Dried fruit and bean curd"})
			Categories.Add(New Category() With {.ID = 8, .CategoryName = "Seafood", .Description = "Seaweed and fish"})
		End Sub
	End Class

	Public Class Product
		Public Property ProductName() As String
		Public Property UnitPrice() As Decimal
		Public Property CategoryID() As Integer
	End Class

	Public Class Category
		Public Property ID() As Integer
		Public Property CategoryName() As String
		Public Property Description() As String
	End Class
End Namespace
