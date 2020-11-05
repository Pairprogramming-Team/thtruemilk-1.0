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

namespace FormMainGUI.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void chartOrder_Click()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6FD628N\SQLEXPRESS;Initial Catalog=THTrueMilk;Integrated Security=True");
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select Name,Price from Products", con);
            adapt.Fill(ds);
            chartOrder.DataSource = ds;

            chartOrder.Series["TotalMoney"].XValueMember = "Name";
            chartOrder.Series["TotalMoney"].YValueMembers = "Price";
            //chartOrder.Titles.Add("Salary Chart");
            con.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            chartOrder_Click();
        }
    }
}
