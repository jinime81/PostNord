using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_4_8
{
    public class Mail
    {
        //public string MailID { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string Locality { get; set; }
        public string County { get; set; }
        public DateTime Arrived { get; set; }
        public DateTime Delivered { get; set; }
        public string DeliveryType { get; set; }

        public Mail()
        {
            //RandomMailID();
        }

        //Uppgift 6
        //private void RandomMailID()
        //{
        //    Random r = new Random();
        //    string randomID = r.Next(0, 10000000).ToString("D7") + "SE";
        //    MailID = randomID;
        //}

        public override string ToString()
        {
            return Name + " " + PostalCode + " " + Locality + " " + DeliveryType;
        }
    }
}
