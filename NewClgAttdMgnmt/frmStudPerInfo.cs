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

namespace prjStudInfoSys
{
    public partial class frmStudPerInfo : Form
    {
        public frmStudPerInfo()
        {
            InitializeComponent();
        }

        string cnStr = @"Data Source=shh\sqlexpress;Initial Catalog=ClgAttMgmt;Integrated Security=True";
        string QRY = string.Empty;
        SqlConnection CNN;
        SqlCommand CMD;
        int rowPos = 0;

        void ClearMyControls()
        {
            lblID.Text = "";
            txtName.Clear();
            dtpBthDate.Value = System.DateTime.Now;
            txtAddress.Clear();
            txtContNo.Clear();
            txtEmailID.Clear();
            rdbMale.Checked = true;
        }

        void BindMyGrid()
        {
            QRY = "select ";
            QRY += "Stud_ID, ";
            QRY += "Stud_Name, ";
            QRY += "Stud_Gen, ";
            QRY += "Stud_BthDate, ";
            QRY += "Stud_Address, ";
            QRY += "Stud_ContNo, ";
            QRY += "Stud_EmailID, ";
            QRY += "Stud_Course,";
            QRY += "Stud_Semester ";
            QRY += "from Clg_StudInfo ";
            QRY += "WHERE ";
            QRY += "Stud_IsAct ='TRUE';";
            CNN = new SqlConnection(cnStr);
            CMD = new SqlCommand(QRY, CNN);
            SqlDataAdapter DA = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dtGrd1.DataSource = DS.Tables[0];
            rowPos = 0;


        }

        void BindMyGrid(bool Search)
        {
            QRY = "select ";
            QRY += "Stud_ID, ";
            QRY += "Stud_Name, ";
            QRY += "Stud_Gen, ";
            QRY += "Stud_BthDate, ";
            QRY += "Stud_Address, ";
            QRY += "Stud_ContNo, ";
            QRY += "Stud_EmailID,";
            QRY += "Stud_Course,";
            QRY += "Stud_Semester ";
            QRY += "from Clg_StudInfo ";
            QRY += "WHERE ";
            QRY += "Stud_IsAct = 'TRUE' AND ";
            QRY += "(Stud_Name LIKE '%" + txtSearch.Text + "%')";
            CNN = new SqlConnection(cnStr);
            CMD = new SqlCommand(QRY, CNN);
            SqlDataAdapter DA = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dtGrd1.DataSource = DS.Tables[0];


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
               
                pnlControls.Enabled = true;
                ClearMyControls();
                fillComboCourse();
                fillComboSemester();
                txtName.Focus();
                btnAdd.Text = "Save";
                dtGrd1.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                int StudID = 0;
                QRY = "SELECT MAX(Stud_ID) + 1 from Clg_StudInfo";
                CNN = new SqlConnection(cnStr);
                CMD = new SqlCommand(QRY, CNN);
                CNN.Open();
                SqlDataReader DR = CMD.ExecuteReader();
                if (DR.Read())
                {
                    StudID = int.Parse(DR.GetValue(0).ToString());
                }
                DR.Close();
                DR.Dispose();
                CMD.Dispose();

                CMD = new SqlCommand(QRY, CNN);
                DR = CMD.ExecuteReader();

                DR.Close();
                DR.Dispose();
                CMD.Dispose();

                QRY = "INSERT INTO  Clg_StudInfo VALUES(";
                QRY += "" + StudID + ", ";
                QRY += "'" + txtName.Text + "', ";
                if (rdbMale.Checked)
                    QRY += "'Male', ";
                else QRY += "'Female', ";
                QRY += "'" + dtpBthDate.Value.ToShortDateString() + "', ";
                QRY += "'" + txtAddress.Text + "', ";
                QRY += "'" + txtContNo.Text + "', ";
                QRY += "'" + txtEmailID.Text + "',";
                QRY += "'" + cmbClass.Text + "',";
                QRY += "'" + cmbSemester.Text + "',";
                QRY += "'TRUE')";

                CMD = new SqlCommand(QRY, CNN);
                CMD.ExecuteNonQuery();
                CMD.Dispose();


                CNN.Close();
                CNN.Dispose();
                CMD.Dispose();
                pnlControls.Enabled = false;
                dtGrd1.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnAdd.Text = "Add";
                BindMyGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                pnlControls.Enabled = true;
                txtName.Focus();
                btnEdit.Text = "Update";
                dtGrd1.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Enabled = false;
            }
            else
            {

                QRY = "UPDATE Clg_StudInfo SET ";
                QRY += "Stud_Name = '" + txtName.Text + "', ";
                if (rdbMale.Checked)
                    QRY += "Stud_Gen = 'Male', ";
                else
                    QRY += "Stud_Gen = 'Female', ";
                QRY += "Stud_Address = '" + txtAddress.Text + "', ";
                QRY += "Stud_ContNo = '" + txtContNo.Text + "', ";
                QRY += "Stud_EmailID = '" + txtEmailID.Text + "', ";
                QRY += "Stud_BthDate = '" + dtpBthDate.Value.ToShortDateString() + "' ";
                QRY += "WHERE Stud_ID = " + lblID.Text + "";
                CNN = new SqlConnection(cnStr);
                CMD = new SqlCommand(QRY, CNN);
                CNN.Open();
                CMD.ExecuteNonQuery();
                CMD.Dispose();
                  
                CNN.Close();
                CNN.Dispose();
                CMD.Dispose();
                pnlControls.Enabled = false;
                dtGrd1.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = true;
                btnEdit.Text = "Edit";
                BindMyGrid();
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Delete Current Record?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                QRY = "DELETE FROM Clg_StudInfo ";
                QRY += "WHERE Stud_ID = " + lblID.Text + "";
                CNN = new SqlConnection(cnStr);
                CMD = new SqlCommand(QRY, CNN);
                CNN.Open();
                CMD.ExecuteNonQuery();
                CNN.Close();
                CNN.Dispose();
                CMD.Dispose();
                BindMyGrid();
            }
        }

        private void dtGrd1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            FillToControl(e.RowIndex);
        }

        void FillToControl(int RID)
        {

            lblID.Text = dtGrd1.Rows[RID].Cells[0].Value.ToString();
            txtName.Text = dtGrd1.Rows[RID].Cells[1].Value.ToString();
            if (dtGrd1.Rows[RID].Cells[2].Value.ToString() == "Male")
                rdbMale.Checked = true;
            else rdbFemale.Checked = true;
            dtpBthDate.Value = DateTime.Parse(dtGrd1.Rows[RID].Cells[3].Value.ToString());
            txtAddress.Text = dtGrd1.Rows[RID].Cells[4].Value.ToString();
            txtContNo.Text = dtGrd1.Rows[RID].Cells[5].Value.ToString();
            txtEmailID.Text = dtGrd1.Rows[RID].Cells[6].Value.ToString();
            cmbClass.Text = dtGrd1.Rows[RID].Cells[7].Value.ToString();
           cmbSemester.Text = dtGrd1.Rows[RID].Cells[8].Value.ToString();
            lblSearch.Text = "This is " + (RID + 1).ToString() + " OF " + dtGrd1.Rows.Count.ToString() + " Recrod";
            rowPos = RID;

          
        }
        private void frmStudPerInfo_Load(object sender, EventArgs e)
        {
            BindMyGrid();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == "Save")
            {
                btnAdd.Text = "Add";
                pnlControls.Enabled = false;
                dtGrd1.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                BindMyGrid();
            }
            if (btnEdit.Text == "Update")
            {
                btnEdit.Text = "Edit";
                pnlControls.Enabled = false;
                dtGrd1.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = true;
                BindMyGrid();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
                BindMyGrid();
            else
                BindMyGrid(true);

            if (dtGrd1.Rows.Count > 0)
            {
                dtGrd1.Visible = true;
                txtSearch.BackColor = Color.White;
                txtSearch.ForeColor = Color.Black;
                lblSearch.Text = dtGrd1.Rows.Count.ToString() + " Records Found....";
            }
            else
            {
                dtGrd1.Visible = false;
                txtSearch.BackColor = Color.Red;
                txtSearch.ForeColor = Color.White;
                lblSearch.Text = "No Record Found....";
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dtGrd1.Rows.Count == 0)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            rowPos = 0;
            dtGrd1.Rows[rowPos].Selected = true;
            FillToControl(rowPos);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            rowPos = dtGrd1.Rows.Count - 1;
            dtGrd1.Rows[rowPos].Selected = true;
            FillToControl(rowPos);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            rowPos++;
            if (rowPos < dtGrd1.Rows.Count)
                dtGrd1.Rows[rowPos].Selected = true;
            else
            {
                rowPos = dtGrd1.Rows.Count - 1;
                MessageBox.Show("This is Last Record....", "Last Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FillToControl(rowPos);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            rowPos--;
            if (rowPos >= 0)
                dtGrd1.Rows[rowPos].Selected = true;
            else
            {
                rowPos = 0;
                MessageBox.Show("This is First Record....", "First Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FillToControl(rowPos);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            QRY = "DELETE FROM Clg_StudInfoReport";
            CNN = new SqlConnection(cnStr);
            CMD = new SqlCommand(QRY, CNN);
            CNN.Open();
            CMD.ExecuteNonQuery();
            CMD.Dispose();

            QRY = "INSERT INTO Clg_StudInfoReport SELECT * FROM Clg_StudInfo WHERE Stud_IsAct = 'TRUE' AND Stud_ID > 0";
            CMD = new SqlCommand(QRY, CNN);
            CMD.ExecuteNonQuery();
            CNN.Close();
            CMD.Dispose();
            CNN.Dispose();
}

        public void fillComboCourse()
        {

            string qry = "SELECT  * FROM Clg_Course";
            SqlConnection cnn = null;
            SqlDataAdapter sda = null;
            SqlCommand cmd = null;

            cnn = new SqlConnection(cnStr);
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);

            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            cmbClass.ValueMember = "Course_ID";
            cmbClass.DisplayMember = "Course_Name";
            cmbClass.DataSource = dt;
            cnn.Close();
        }
        public void fillComboSemester()
        {
            if (cmbClass.SelectedValue.ToString() != null)
            {
                string qry = "SELECT * FROM Clg_Semester where Course_ID=@Course_ID";
                SqlConnection cnn = null;
                SqlDataAdapter sda = null;
                SqlCommand cmd = null;

                cnn = new SqlConnection(cnStr);
                cnn.Open();
                cmd = new SqlCommand(qry, cnn);

                cmd.Parameters.AddWithValue("@Course_ID", cmbClass.SelectedValue.ToString());

                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                cmbSemester.ValueMember = "Sem_ID";
                cmbSemester.DisplayMember = "Sem_Name";
                cmbSemester.DataSource = dt;
                cnn.Close();
            }
        }

        private void dtGrd1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  dtGrd1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(bool.Parse(dtGrd1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void spltMain_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
