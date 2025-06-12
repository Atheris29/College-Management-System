using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewClgAttdMgnmt
{
    
    public partial class addClass : Form
    {
        public addClass()
        {
            InitializeComponent();
        }

        string str = @"Data Source=shh\sqlexpress;Initial Catalog=ClgAttMgmt;Integrated Security=True";
        SqlConnection cnn = null;
        SqlDataAdapter sda = null;
        SqlCommand cmd = null;


        private void addClass_Load(object sender, EventArgs e)
        {
            pnlCourse.Visible = false;
        }
        
        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            pnlCourse.Visible = true;
            pnlSemester.Visible = false;
        }
        
        private void btnNewSem_Click(object sender, EventArgs e)
        {
            pnlCourse.Visible = true;
            pnlSubject.Visible = false;
            pnlSemester.Visible = true;
            fillComboCourse();

        }
        private void btnNewSub_Click(object sender, EventArgs e)
        {
            cmbCourse.Visible = true;
            pnlCourse.Visible = true;
            pnlSubject.Visible = true;
            pnlSemester.Visible = true;
            fillComboCourse();
        }

        private void pnlbtnCourse_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("SELECT Course_Name FROM Clg_Course WHERE Course_Name = '"+cmbCourse.Text+"'",cnn);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            if (dt1.Rows.Count >= 1)
            {
                MessageBox.Show("Course Name Already Exists");
            }
            else
            {
                cnn.Open();
                cmd = new SqlCommand("INSERT INTO Clg_Course(Course_Name) VALUES('" + txtCourse.Text + "')", cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Course "+ txtCourse.Text+ "Added Succesfully");

            }
        }


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

            cmbCourse.ValueMember = "Course_ID";
            cmbCourse.DisplayMember = "Course_Name";
            cmbCourse.DataSource = dt;
            cnn.Close();
    
        }

        public void fillComboSemester()
        {
            if (cmbCourse.SelectedValue.ToString() != null)
            {
                string qry = "SELECT * FROM Clg_Semester where Course_ID=@Course_ID";
                cnn = new SqlConnection(str);
                cnn.Open();
                cmd = new SqlCommand(qry, cnn);

                cmd.Parameters.AddWithValue("@Course_ID", cmbCourse.SelectedValue.ToString());

                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                DataRow dr = dt.NewRow();
                dr[0] = 0;
                dr[1] = "---Select---";
                dt.Rows.InsertAt(dr, 0);

                cmbSubSem.ValueMember = "Sem_ID";
                cmbSubSem.DisplayMember = "Sem_Name";
                cmbSubSem.DataSource = dt;
                cnn.Close();
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = cmbCourse.SelectedValue.ToString();
            fillComboSemester();
        }

        private void pnlbtnSem_Click(object sender, EventArgs e)
        {
           
            cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Clg_Semester(Sem_Name,Course_ID) Values('" + pnltxtSemester.Text + "','" + label4.Text + "')", cnn);
            cmd.ExecuteNonQuery();
           
            cnn.Close();
            MessageBox.Show("Semester Added Succesfully");
        }

      

        private void pnlbtnSub_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            cnn.Open();  
            SqlCommand cmd = new SqlCommand("INSERT INTO Clg_Subject(Sub_Name,Course_ID,Sem_ID) Values('" +pnltxtSub.Text + "','" + label4.Text + "','" + label5.Text + "');", cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Subject Added Succesfully");
        }

        private void cmbSubSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = cmbSubSem.SelectedValue.ToString();
        }

       

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnAddClass_Click(object sender, EventArgs e)
        //{
        //    string qry = string.Empty;
        //    string str = @"Data Source=shh\sqlexpress;Initial Catalog=ClgAttMgmt;Integrated Security=True";
        //    SqlConnection cnn = null;
        //    SqlDataAdapter sda = null;
        //    SqlCommand cmd = null;

        //    cnn = new SqlConnection(str);
        //    qry = "INSERT INTO Clg_Course(Course_Name) Values('" + txtCourse.Text + "') SELECT TOP 1 Course_ID FROM Clg_Course ORDER BY Course_ID DESC; ";


        //    cnn.Open();

        //    cmd = new SqlCommand(qry,cnn); cmd.ExecuteNonQuery();
        //    SqlDataReader sr = cmd.ExecuteReader();
        //    sr.Read();
        //    label4.Text = sr["Course_ID"].ToString();
        //    sr.Close();

        //    string qry2 = "INSERT INTO Clg_Semester(Sem_Name,Course_ID) Values('" + txtSemester.Text + "','" + label4.Text + "') SELECT TOP 1 Sem_ID FROM Clg_Semester ORDER BY Sem_ID DESC; ";
        //    MessageBox.Show(qry2); 
        //    SqlCommand cmd1 = new SqlCommand(qry2, cnn); cmd1.ExecuteNonQuery();
        //        SqlDataReader sr1 = cmd1.ExecuteReader();

        //        sr1.Read();
        //            label5.Text = sr1["Sem_ID"].ToString();
        //        sr1.Close();

        //        string qry3 = "INSERT INTO Clg_Subject(Sub_Name,Course_ID,Sem_ID) Values('" + txtSubject.Text + "','" + label4.Text + "','" + label5.Text + "');";
        //    SqlCommand cmd2 = new SqlCommand(qry3, cnn); cmd2.ExecuteNonQuery();


        //    cnn.Close();

        //    MessageBox.Show("Class  :  '" + txtCourse.Text + "' Added Successfully ");
        //    MessageBox.Show(label4.Text);


        //}

       


    }
}
