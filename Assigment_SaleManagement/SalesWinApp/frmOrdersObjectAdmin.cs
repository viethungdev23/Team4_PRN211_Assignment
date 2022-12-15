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
        dgvOrder.DataSource = null;
        source = new BindingSource
        {
            DataSource = orderRepository.GetOrders()
        };

        dgvOrder.DataSource = source;
        dgvOrder.Columns["Member"].Visible = false;
        dgvOrder.Columns["OrderDetails"].Visible = false;
    }

    private void frmOrdersObjectAdmin_Load(object sender, EventArgs e)
    {
        LoadDgvData();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Are you sure you want to delete", "Are you sure?", MessageBoxButtons.YesNo);
        if(result == DialogResult.Yes) 
        {
            var rowIndex = dgvOrder.CurrentCell.RowIndex;
            MessageBox.Show(dgvOrder.Rows[rowIndex].Cells[0].Value.ToString());
            orderRepository.Delete(Int32.Parse(dgvOrder.Rows[rowIndex].Cells[0].Value.ToString()));
            LoadDgvData();
        }
        
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        frmOrderObjectDetailCreate frm = new frmOrderObjectDetailCreate();
        if (frm.ShowDialog() == DialogResult.OK)
        {
            LoadDgvData();
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        var selectedRowIndex = dgvOrder.CurrentCell.RowIndex;
        var orderId = Int32.Parse(dgvOrder.Rows[selectedRowIndex].Cells["OrderId"].Value.ToString());
        var order = orderRepository.GetOrderById(orderId);
        if (order == null)
        {
            MessageBox.Show("Please select order");
            return;
        }

        frmOrderObjectDetailUpdate frm = new frmOrderObjectDetailUpdate
        {
            order = order,
        };
        if (frm.ShowDialog() == DialogResult.OK)
        {
            LoadDgvData();
        }
    }
}
