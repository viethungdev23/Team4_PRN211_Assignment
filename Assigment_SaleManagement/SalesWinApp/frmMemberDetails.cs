using DataAccess.Models;
using DataAccess.Repository;
namespace SaleManagement.winform;

public partial class frmMemberDetails : Form
{
    public bool InsertOrUpdate { get; set; }
    public IMemberRepository memberRepository { get; set; }
    public Member member { get; set; }
    public frmMemberDetails()
    {
        InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
        if(member != null)
        {
            frmProfile frmProfile = new frmProfile(member.MemberId);
            frmProfile.Show();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        // collect thong tin trong form
        var result = MessageBox.Show("Are you sure you want to update Account", "Are you sure?", MessageBoxButtons.YesNo);
        if(result == DialogResult.Yes)
        {
            if (CheckValid())
            {
                var c = new Member
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompany.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                };
                //save to database
                if (InsertOrUpdate)
                {
                    memberRepository.Update(c);
                }
                else
                {
                    memberRepository.CreateMember(c);
                }
                // load lai 
                this.DialogResult = DialogResult.OK;
            }
        }
        
        
    }

    private void frmMemberDetails_Load(object sender, EventArgs e)
    {
        if (InsertOrUpdate) {
            txtMemberId.Enabled = false;
            txtMemberId.Text = member.MemberId.ToString();
            txtEmail.Text = member.Email;
            txtPassword.Text = member.Password;
            txtCompany.Text = member.CompanyName;
            txtCity.Text = member.City;
            txtCountry.Text = member.Country;
        }
        else if (InsertOrUpdate == false) {
            txtMemberId.Enabled = false;
        }
    }

    private bool CheckValid()
    {
        if(txtEmail.Text.Trim() == "" || txtPassword.Text.Trim() == "")
        {
            MessageBox.Show("Required text box must have value", "Warning");
            return false;
        }
        else if (memberRepository.GetMemberByEmail(txtEmail.Text) != null && txtEmail.Text != member.Email)
        {
            MessageBox.Show("Email is existed", "Warning");
            return false;
        }
        return true;
    }
}
