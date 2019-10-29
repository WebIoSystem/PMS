using BookShopManagement.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.Mapping;

namespace BookShopManagement.Forms
{
    public partial class Form_AddCategory : Form
    {
        DataContext dc = new DataContext("Data Source=DESKTOP-V5HQLAQ;Initial Catalog=PMS;Integrated Security=True");
        
        public Form_AddCategory()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_AddCategory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table<category> vis = dc.GetTable<category>();
            category c = new category();
            c.Cname = name.Text;
            c.Lastupdatestatus = dateTimePicker1.Value.ToString();
            c.Datetime = dateTimePicker1.Value.ToString();
            vis.InsertOnSubmit(c);
            dc.SubmitChanges();
            MessageBox.Show("Data Added Successfully");

        }
    }
}
