using MaterialSkin;
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
namespace FormMainGUI.Forms
{
    public partial class fOrders : MaterialForm
    {
        public fOrders()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            btnDelete.AutoSize = false;
            btnUpdate.AutoSize = false;
            btnDone.AutoSize = false;
            btnAddToCart.AutoSize = false;

            btnDelete.Size = new System.Drawing.Size(100, 36);
            btnUpdate.Size = new System.Drawing.Size(100, 36);
            btnDone.Size = new System.Drawing.Size(100, 36);
            btnAddToCart.Size = new System.Drawing.Size(150, 36);
        }
    }
}
