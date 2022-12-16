using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using DataAccess.Repository;
using DataAccess.Models;

namespace SaleManagement.winform;

public partial class frmOrdersObjectAdmin : Form
{
    private IOrderRepository orderRepository;
    private BindingSource? source = null;
    public frmOrdersObjectAdmin()
    {
        InitializeComponent();
        orderRepository = new OrderRepository();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void LoadDgvData()
    {
      
    }

    private void frmOrdersObjectAdmin_Load(object sender, EventArgs e)
    {
        LoadDgvData();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
       
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
       
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        
    }
}
