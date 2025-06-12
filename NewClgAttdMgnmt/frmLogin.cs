using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace NewClgAttdMgnmt
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string qry = string.Empty;
            string str =@"Data Source=shh\sqlexpress;Initial Catalog=ClgAttMgmt;Integrated Security=True";
            SqlConnection cnn = null;
            SqlDataAdapter sda = null;  
            
            cnn = new SqlConnection(str);
            qry = "SELECT * FROM Clg_Users WHERE User_Name = '" + UsrLoginTxt.Text + "'and  User_Pass = '" + Passtxt.Text + "'";
            cnn.Open();
            sda=new SqlDataAdapter(qry,cnn);
            DataTable dt =new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Login  Successfully");
                FrmHome home = new FrmHome();
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Enter Valid Username and Password");

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
