﻿using Budgeteer.Constants;

namespace Budgeteer.Helpers
{
    public class Address
    {
        public int id { get; set; }
        public string Street { get; set; } = string.Empty;
        public string UnitNumber { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = BTStrings.AddressStrings.USA;
    }
}
