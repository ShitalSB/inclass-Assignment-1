﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class House
    {
        // Added properties of House
        public int Id { get; set; }
        public int Value { get; set; }
        public float LotSize { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}