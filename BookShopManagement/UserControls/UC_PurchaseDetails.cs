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
    public partial class UC_PurchaseDetails : UserControl
    {
        public UC_PurchaseDetails()
        {
            InitializeComponent();
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using (Form_AddNewBook abn = new Form_AddNewBook())
            {
                abn.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form_AddCategory ads = new Form_AddCategory())
            {
                ads.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_AddCompaney ad = new Form_AddCompaney();

            ad.Show();
            
        }
    }
}
