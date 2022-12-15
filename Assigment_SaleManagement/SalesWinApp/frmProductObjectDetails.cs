using DataAccess.Repository;
using DataAccess.Models;

namespace SaleManagement.winform;

public partial class frmProductObjectDetails : Form
{
    public bool InsertOrUpdate { get; set; }
    public IProductRepository productRepository { get; set; }
    public Product product { get; set; }
    public frmProductObjectDetails()
    {
        InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Are you sure you want to insert or update", "Are you sure?", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
        {
            if (CheckValid())
            {
                var c = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                    ProductName = txtProductName.Text,
                    Category = int.Parse(txtCategory.Text),
                    Weight = txtWeight.Text,
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitInStock.Text),
                };
                //save to database
                if (InsertOrUpdate)
                {
                    productRepository.Update(c);
                }
                else
                {
                    productRepository.CreateMember(c);
                }
                // load lai 
                this.DialogResult = DialogResult.OK;
            }
        }
           
        
    }

    private void frmProductObjectDetails_Load(object sender, EventArgs e)
    {
        if (InsertOrUpdate)
        {
            txtProductId.Enabled = false;
            txtProductId.Text = product.ProductId.ToString();
            txtProductName.Text = product.ProductName;
            txtCategory.Text = product.Category.ToString();
            txtUnitInStock.Text = product.UnitsInStock.ToString();
            txtUnitPrice.Text = product.UnitPrice.ToString();
            txtWeight.Text = product.Weight.ToString();
        }
    }

    private bool CheckValid()
    {
        if (txtProductId.Text.Trim() == "" || txtCategory.Text.Trim() == "" || txtProductName.Text.Trim() == ""
            || txtUnitInStock.Text.Trim() == ""
            || txtUnitPrice.Text.Trim() == ""
            || txtWeight.Text.Trim() == "")
        {
            MessageBox.Show("Required text box must have value", "Warning");
            return false;
        }
        else if(productRepository.GetProductById(int.Parse(txtProductId.Text.Trim())) != null)
        {
            MessageBox.Show("Product Id is existed", "Warning");
            return false;
        }
        return true;
    }

}
