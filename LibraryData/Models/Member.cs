using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBIrth { get; set; }
        public string TelephoneNumber { get; set; }

        public virtual LibraryCard Librarycard { get; set; }
        public virtual LibraryBranch HomeLibraryBranch { get; set; }
    }
}
