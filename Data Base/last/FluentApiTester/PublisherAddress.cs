using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApiTester
{
    public class PublisherAddress
    {
      
        public PublisherAddress(string address1, string city,int code,string country)
        {
            Address1 = address1;
            City = city;
            Zipcode = code;
            Country = country;
        }
        public int PublisherId { get; set; }

        public string Address1 { get; set; }

        public string City { get; set; }

        public int Zipcode { get; set; }

        public string Country { get; set; }

        public virtual Publisher Publisherp
        {
            get;
            set;
        }

    }
}
