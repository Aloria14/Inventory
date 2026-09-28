using System.Text.RegularExpressions;


namespace Inventory
{
    public partial class frmAddProduct : Form 
    {
        private string? _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;
        private BindingSource showProductList;

        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            //Exception here
            {
                throw new StringFormatException("Invalid product name. Please enter only letters.");
            }
            return name;
        }
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
            //Exception here
            {
                throw new NumberFormatException("Invalid quantity. Please enter only numbers.");
            }
            return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
            //Exception here
            {
                throw new CurrencyFormatException("Invalid selling price. Please enter a valid currency amount.");
            }
            return Convert.ToDouble(price);
        }


        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = { "Beverages", "Bread/Bakery", "Canned/Jarred Goods" ,"Dairy" ,
            "Frozen Foods", "Meat", "Personal Care", "Other" };
            foreach (string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }
        }
       
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTextBox2.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtProductName.Clear();
                cbCategory.SelectedIndex = -1;
                dtPickerMfgDate.Value = DateTime.Now;
                dtPickerExpDate.Value = DateTime.Now;
                richTextBox2.Clear();
                txtQuantity.Clear();
                txtSellPrice.Clear();
            }
        }
    }
    public class NumberFormatException : Exception
    {
        public NumberFormatException(string message) : base(message) { }
    }

    public class StringFormatException : Exception
    {
        public StringFormatException(string message) : base(message) { }
    }

    public class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string message) : base(message) { }
    }
}
