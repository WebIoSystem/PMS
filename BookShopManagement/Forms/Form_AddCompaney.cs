using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using BookShopManagement.Classes;

namespace BookShopManagement.Forms
{
    public partial class Form_AddCompaney : Form
    {
        public Form_AddCompaney()
        {
            InitializeComponent();
        }
        DataContext dc = new DataContext("Data Source=DESKTOP-V5HQLAQ;Initial Catalog=PMS;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table<companey> com = dc.GetTable<companey>();
            companey c = new companey();
            c._name = name.Text;
            c._adress = adress.Text;
            c._contact = contact.Text;
            c._lus = date.Text;
            com.InsertOnSubmit(c);
            dc.SubmitChanges();
            MessageBox.Show("Data Added Successfully");
            this.Close();

        }
    }
}
