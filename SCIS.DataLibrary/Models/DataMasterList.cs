using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIS.DataLibrary.Models
{
    public class DataMasterList
    {
        public int id { get; set; }
        public string socpen_id { get; set; }
        public string uct_id { get; set; }
        public string lname { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string ext_name { get; set; }
        public string citizenship { get; set; }
        public string mothers_maiden { get; set; }
        public int psgc_region { get; set; }
        public int psgc_province { get; set; }
        public int psgc_city_mun { get; set; }
        public int psgc_brgy { get; set; }
        public string address { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime bdate { get; set; }
        public int sex { get; set; }
        public int marital_status { get; set; }
        public string religion { get; set; }
        public string bplace { get; set; }
        public string educ_attain { get; set; }
        public string household_id { get; set; }
        public string pantawid_id { get; set; }
        public string indigenous_id { get; set; }
        public string other { get; set; }
        public string contact_num { get; set; }
        public int health_status { get; set; }
        public string health_status_remarks { get; set; }
        public DateTime entry_datetime { get; set; }
        public string entry_by { get; set; }
        public int status { get; set; }
    }
}
