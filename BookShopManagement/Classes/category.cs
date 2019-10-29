using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
namespace BookShopManagement.Classes
{
    [Table(Name = "category")]
    class category
    {
        private int id;
        [Column(Name ="id",IsPrimaryKey =true, IsDbGenerated =true)]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string cname;
        [Column(Name = "cname")]
        public String Cname
        {
            get { return cname; }
            set { cname = value; }
        }
        private string datetime;
        [Column(Name = "datetime")]
        public string Datetime
        {
            get { return datetime; }
            set { datetime = value; }
        }
        private string lastupdatestatus;
        [Column(Name = "lastupdatestatus")]
        public string Lastupdatestatus
        {
            get { return lastupdatestatus; }
            set { lastupdatestatus = value; }
        }

    }
}
