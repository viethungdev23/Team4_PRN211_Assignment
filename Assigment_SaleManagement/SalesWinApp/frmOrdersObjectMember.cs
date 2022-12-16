using DataAccess.Repository;


namespace SaleManagement.winform;

public partial class frmOrdersObjectMember : Form
{
    public int memberId { get; set; }
    private BindingSource source;
    private IOrderRepository orderRepository;
    public frmOrdersObjectMember()
    {
        InitializeComponent();
        orderRepository = new OrderRepository();
    }

    private void LoadDgvData()
    {
        dgvOrder.DataSource = null;
        source = new BindingSource
        {
            DataSource = orderRepository.GetOrdersByMemberId(memberId)
        };

        dgvOrder.DataSource = source;

        dgvOrder.Columns["Member"].Visible = false;
        dgvOrder.Columns["OrderDetails"].Visible = false;
    }

    private void frmOrdersObjectMember_Load(object sender, EventArgs e)
    {
        LoadDgvData();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
