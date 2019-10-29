using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace BookShopManagement.Classes
{
    [Table(Name="companey")]
    class companey
    {
        private int id;
        [Column(Name ="id",IsPrimaryKey =true,IsDbGenerated =true)]
        public int _id
        {
            get { return id; }
            set { id = value; }
        }




        private string name;
        [Column(Name ="name")]
        public string _name
        {
            get { return name; }
            set { name = value; }
        }




        private string adress;
        [Column(Name ="adress")]
        public string _adress
        {
            get { return adress; }
            set { adress = value; }
        }



        private string lus;
        [Column(Name ="lastupdate")]
        public string _lus
        {
            get { return lus; }
            set { lus = value; }
        }



        private string contact;
        [Column(Name ="contact")]
        public string _contact
        {
            get { return contact; }
            set { contact = value; }
        }

    }
}
