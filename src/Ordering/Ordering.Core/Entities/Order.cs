using Ordering.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Core.Entities
{
    public class Order : Entity
    {
        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }

        //billing address
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        //payment
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiration { get; set; }
        public string CardCVV { get; set; }
        public int PaymentMethod { get; set; }
    }
}
