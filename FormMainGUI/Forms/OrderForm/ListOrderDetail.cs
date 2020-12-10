﻿using FormMainGUI.DAO;
using FormMainGUI.Utils;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMainGUI.Forms.OrderForm
{
    public partial class fListOrderDetail : MaterialForm
    {
        fOrders orders;
        public fListOrderDetail(fOrders orders)
        {
            InitializeComponent();
            this.orders = orders;
        }

        private void fListOrderDetail_Load(object sender, EventArgs e)
        {
            string OrderID = this.orders.dgvOrdersList.CurrentRow.Cells[0].Value.ToString();
            dgvListOrderDetail.DataSource = OrderDAO.Instance.getListOrderDetailByOrderID(OrderID);
        }
    }
}
