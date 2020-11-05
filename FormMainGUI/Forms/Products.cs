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

namespace FormMainGUI.Forms
{
    public partial class Products : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=THTrueMilk;Integrated Security=True");

        public Products()
        {
            InitializeComponent();
        }

        private void body_Paint(object sender, PaintEventArgs e)
        { 
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Products_Load(object sender, EventArgs e)
        {
            //var data = new SqlDataAdapter("SELECT * FROM SANPHAM,ChiTietSanPham ", sql);
            //var table = new DataTable();
            //data.Fill(table);
            //dgvSP.DataSource = table;
            DataTable data = new DataTable("products");
            data.Columns.Add("Product ID", System.Type.GetType("System.String"));
            data.Columns.Add("Name", System.Type.GetType("System.String"));
            data.Columns.Add("Quantity", System.Type.GetType("System.String"));
            data.Columns.Add("Price", System.Type.GetType("System.String"));
            data.Columns.Add("StatusProduct", System.Type.GetType("System.String"));
            data.Columns.Add("MFG", System.Type.GetType("System.String")); 
            data.Columns.Add("EXP", System.Type.GetType("System.String"));
            data.Columns.Add("DateOfProduct", System.Type.GetType("System.String"));
            data.Rows.Add(new object[] { "SP01", "Sữa chua TH true YOGURT", "99", "15000", "CTHD01", "99", "15000", "CTHD01" });
            data.Rows.Add(new object[] { "SP02", "Sữa chua TH true YOGURT", "99", "15000", "CTHD01", "99", "15000", "CTHD01" });
            data.Rows.Add(new object[] { "SP03", "Sữa chua TH true YOGURT", "99", "15000", "CTHD01", "99", "15000", "CTHD01" });
            data.Rows.Add(new object[] { "SP04", "Sữa chua TH true YOGURT", "99", "15000", "CTHD01", "99", "15000", "CTHD01" });
            data.Rows.Add(new object[] { "SP05", "Sữa chua TH true YOGURT", "99", "15000", "CTHD01", "99", "15000", "CTHD01" });
            data.Rows.Add(new object[] { "SP06", "Sữa chua TH true YOGURT", "99", "15000", "CTHD01", "99", "15000", "CTHD01" });
            data.Rows.Add(new object[] { "SP07", "Sữa chua TH true YOGURT", "99", "15000", "CTHD01", "99", "15000", "CTHD01" });
            data.Rows.Add(new object[] { "SP08", "Sữa chua TH true YOGURT", "99", "15000", "CTHD01", "99", "15000", "CTHD01" });
            data.Rows.Add(new object[] { "SP10", "Sữa chua TH true YOGURT", "99", "15000", "CTHD01", "99", "15000", "CTHD01" });
            data.Rows.Add(new object[] { "SP11", "Sữa chua TH true YOGURT", "99", "15000", "CTHD01", "99", "15000", "CTHD01" });
            dgvSP.DataSource = data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAdd form = new formAdd();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate update = new FormUpdate();
            update.ShowDialog();
        }
    }
}
