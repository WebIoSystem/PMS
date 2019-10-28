﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UC_Sales : UserControl
    {
        public UC_Sales()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (Form_FinishOrder uf = new Form_FinishOrder())
            {
                uf.ShowDialog();
            }
        }

        private void UC_Sales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                MessageBox.Show("Hi");
            }
        }

        private void UC_Sales_Load(object sender, EventArgs e)
        {
            
        }
    }
}
