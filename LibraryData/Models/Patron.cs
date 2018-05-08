using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class Patron{
        public int Id {get; set;}
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string address {get; set;}
        public DateTime dateOfBirth {get; set;}
        public string telephoneNumber {get; set;}
    }
}