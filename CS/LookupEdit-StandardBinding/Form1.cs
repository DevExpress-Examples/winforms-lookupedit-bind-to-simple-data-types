using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookupEdit_StandardBinding {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitData();

            gridControl1.DataSource = Products;
            gridView1.Columns["UnitPrice"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["UnitPrice"].DisplayFormat.FormatString = "c2";

            // Create an in-place LookupEdit control.
            RepositoryItemLookUpEdit riLookup = new RepositoryItemLookUpEdit();
            riLookup.DataSource = Categories;
            riLookup.ValueMember = "ID";
            riLookup.DisplayMember = "CategoryName";

            // Enable the "best-fit" functionality mode in which columns have proportional widths and the popup window is resized to fit all the columns.
            riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            riLookup.DropDownRows = Categories.Count;

            // Enable the automatic completion feature. In this mode, when the dropdown is closed, 
            // the text in the edit box is automatically completed if it matches a DisplayMember field value of one of dropdown rows. 
            riLookup.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            // Specify the column against which an incremental search is performed in SearchMode.AutoComplete and SearchMode.OnlyInPopup modes
            riLookup.AutoSearchColumnIndex = 1;

            // Optionally hide the Description column in the dropdown.
            // riLookup.PopulateColumns();
            // riLookup.Columns["Description"].Visible = false;

            // Assign the in-place LookupEdit control to the grid's CategoryID column.
            // Note that the data types of the "ID" and "CategoryID" fields match.
            gridView1.Columns["CategoryID"].ColumnEdit = riLookup;
            gridView1.BestFitColumns();
        }

        List<Product> Products = new List<Product>();
        List<Category> Categories = new List<Category>();

        private void InitData() {
            Products.Add(new Product() { ProductName = "Sir Rodney's Scones", CategoryID = 3, UnitPrice = 10 });
            Products.Add(new Product() { ProductName = "Gustaf's Knäckebröd", CategoryID = 5, UnitPrice = 21 });
            Products.Add(new Product() { ProductName = "Tunnbröd", CategoryID = 5, UnitPrice = 9 });
            Products.Add(new Product() { ProductName = "Guaraná Fantástica", CategoryID = 1, UnitPrice = 4.5m });
            Products.Add(new Product() { ProductName = "NuNuCa Nuß-Nougat-Creme", CategoryID = 3, UnitPrice = 14 });
            Products.Add(new Product() { ProductName = "Gumbär Gummibärchen", CategoryID = 3, UnitPrice = 31.23m });
            Products.Add(new Product() { ProductName = "Rössle Sauerkraut", CategoryID = 7, UnitPrice = 45.6m });
            Products.Add(new Product() { ProductName = "Thüringer Rostbratwurst", CategoryID = 6, UnitPrice = 123.79m });
            Products.Add(new Product() { ProductName = "Nord-Ost Matjeshering", CategoryID = 8, UnitPrice = 25.89m });
            Products.Add(new Product() { ProductName = "Gorgonzola Telino", CategoryID = 4, UnitPrice = 12.5m });

            Categories.Add(new Category() { ID = 1, CategoryName = "Beverages", Description = "Soft drinks, coffees, teas, beers, and ales" });
            Categories.Add(new Category() { ID = 2, CategoryName = "Condiments", Description = "Sweet and savory sauces, relishes, spreads, and seasonings" });
            Categories.Add(new Category() { ID = 3, CategoryName = "Confections", Description = "Desserts, candies, and sweet breads" });
            Categories.Add(new Category() { ID = 4, CategoryName = "Dairy Products", Description = "Cheeses" });
            Categories.Add(new Category() { ID = 5, CategoryName = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal" });
            Categories.Add(new Category() { ID = 6, CategoryName = "Meat/Poultry", Description = "Prepared meats" });
            Categories.Add(new Category() { ID = 7, CategoryName = "Produce", Description = "Dried fruit and bean curd" });
            Categories.Add(new Category() { ID = 8, CategoryName = "Seafood", Description = "Seaweed and fish" });
        }
    }

    public class Product {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }
    }

    public class Category {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
