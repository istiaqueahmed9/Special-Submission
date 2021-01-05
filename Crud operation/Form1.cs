using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Crud_operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PH8MNDF\SQLEXPRESS01;Initial Catalog=Employee;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentRecord();

        }

        private void GetStudentRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PH8MNDF\SQLEXPRESS01;Initial Catalog=Employee;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from EmployeeTable , con ");
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            EmployeeRecord.DataSource = dt;
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            if (Isvalid())
                SqlCommand cmd = new SqlCommand("INSERT INTO EMPLOYEE VALUES (@Name @FatherName @Salary @Address @mobile)", con;
            cmd.commandType= CommandType.Text
                cmd.parameter.AddWithValue("@Name", EmployeeName.text);
            cmd.parameter.AddWithValue("@FatherName", EmployeeName.text);
            cmd.parameter.AddWithValue("@Salary", EmployeeName.text);
            cmd.parameter.AddWithValue(" @Address", EmployeeName.text);
            cmd.parameter.AddWithValue(" @mobile, EmployeeName.text);
        }

        private bool Isvalid()
        {
            if (EmployeeName.text = = string.Empty)
            {
                Message.show("Employee Name is Required", "failed", MessageBoxIcon.ok, MessageBoxIcon.Error);
                getEmployeeRecord();
                return false
            }
            return true
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private static void ResetFormControls()
        {
            EmployeeName.clear();
            FatherName.clear();
            Address.clear();
            Mobile.clear();
            Salary.clear();
        }
    }
}
E