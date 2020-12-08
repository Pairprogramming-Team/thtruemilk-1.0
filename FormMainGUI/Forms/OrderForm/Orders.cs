﻿using FormMainGUI.DAO;
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
using FormMainGUI.ModelDB;

namespace FormMainGUI.Forms.OrderForm
{
    public partial class fOrders : MaterialForm
    {
        private ModelDB.Account account1;
        public fOrders(Account account)
        {
            InitializeComponent();

            btnDelete.AutoSize = false;
            btnAdd.AutoSize = false;
            btnUpdate.AutoSize = false;

            btnDelete.Size = new System.Drawing.Size(100, 36);
            btnAdd.Size = new System.Drawing.Size(100, 36);
            btnUpdate.Size = new System.Drawing.Size(100, 36);
            this.account1 = account;
            
        }

        private void fOrders_Load(object sender, EventArgs e)
        {
            dgvOrdersList.DataSource = OrderDAO.Instance.getListOrder();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fOrdersDetail fOrdersDetail = new fOrdersDetail(this, account1);
            fOrdersDetail.ShowDialog();
        }
    }
}
