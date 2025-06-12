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
    public partial class StdAttd : Form
    {
        public StdAttd()
        {
            InitializeComponent();
            fillComboCourse();
            fillComboSemester();
            fillComboSubject();


        }
        string str = @"Data Source=shh\sqlexpress;Initial Catalog=ClgAttMgmt;Integrated Security=True";
        SqlConnection cnn = null;
        SqlDataAdapter sda = null;
        SqlCommand cmd = null;

        //--------------------------ComboCourse------------------------------------
        public void fillComboCourse()
        {
            string qry = "SELECT * FROM Clg_Course";
            cnn = new SqlConnection(str);
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);

            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            DataRow dr = dt.NewRow();
            dr[0] = 0;
            dr[1] = "---Select---";
            dt.Rows.InsertAt(dr, 0);

            cmbClass.ValueMember = "Course_ID";
            cmbClass.DisplayMember = "Course_Name";
            cmbClass.DataSource = dt;
            cnn.Close();

        }
        //--------------------------ComboSemester------------------------------------
        public void fillComboSemester()
        {
            if (cmbClass.SelectedValue.ToString() != null)
            {
                string qry = "SELECT * FROM Clg_Semester where Course_ID=@Course_ID";
                cnn = new SqlConnection(str);
                cnn.Open();
                cmd = new SqlCommand(qry, cnn);

                cmd.Parameters.AddWithValue("@Course_ID", cmbClass.SelectedValue.ToString());

                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                DataRow dr = dt.NewRow();
                dr[0] = 0;
                dr[1] = "---Select---";
                dt.Rows.InsertAt(dr, 0);

                cmbSem.ValueMember = "Sem_ID";
                cmbSem.DisplayMember = "Sem_Name";
                cmbSem.DataSource = dt;
                cnn.Close();
            }
        }
        //--------------------------ComboSubject------------------------------------
        public void fillComboSubject()
        {
            if (cmbSem.SelectedValue.ToString() != null)
            {
                string qry = "SELECT * FROM Clg_Subject where Sem_ID=@Sem_ID";

                cnn = new SqlConnection(str);
                cnn.Open();
                cmd = new SqlCommand(qry, cnn);

                cmd.Parameters.AddWithValue("@Sem_ID", cmbSem.SelectedValue.ToString());

                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                DataRow dr = dt.NewRow();
                dr[0] = 0;
                dr[1] = "---Select---";
                dt.Rows.InsertAt(dr, 0);

                cmbSubject.ValueMember = "Sub_ID";
                cmbSubject.DisplayMember = "Sub_Name";
                cmbSubject.DataSource = dt;
                cnn.Close();
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillComboSemester();
        }

        private void cmbSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillComboSubject();
        }

        public void BindData()
        {
            string qry = "SELECT Stud_ID,Stud_Name FROM Clg_StudInfo WHERE Stud_Course ='" + cmbClass.Text + "' AND Stud_Semester ='" + cmbSem.Text + "' ";

            DataTable dt = new DataTable();
            cnn = new SqlConnection(str);
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //---------------------------------------------------------------------------------------


        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex == 0)
            {
                MessageBox.Show("Select Course");
            }
            else if (cmbSem.SelectedIndex == 0)
            {
                MessageBox.Show("Select Semester");
            }
            else if (cmbSubject.SelectedIndex == 0)
            {
                MessageBox.Show("Select Subject");
            }
            else
            {
                BindData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            char attd = 'A';


            cnn = new SqlConnection(str);
            cnn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null)
                {
                    attd = 'A'; 
                }

                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {

                    bool chk = (bool)dataGridView1.Rows[i].Cells[0].Value;
                    if (chk == true)
                    {
                        attd = 'P';
                    }
                   
                }
                string qry = "INSERT INTO Clg_Attendance ";
                qry += "VALUES ( " + dataGridView1.Rows[i].Cells["Stud_ID"].Value + ", ";
                qry += " '" + dataGridView1.Rows[i].Cells["name"].Value + "',   ";
                qry += " '" + cmbClass.Text + "' ,";
                qry += "' " + cmbSem.Text + " ' ,  ";
                qry += " '" + cmbSubject.Text + "', ";
                qry += " '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', ";
                qry += " '" + attd + "');";
                cmd = new SqlCommand(qry, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Record Insereted Successfully");
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            cmbClass.SelectedIndex = 0;
          //dataGridView1.DataSource = null;
          //  dataGridView1.Rows.Clear();
          //  dataGridView1.Refresh();
            BindData();

        }



        private void StdAttd_Load(object sender, EventArgs e)
        {
           
            
        }

        

       
        //-----------------------------------------------------------------------------------------------
    }
}
