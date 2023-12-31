﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.BIT.Models
{
  public class UsersList
    {
        public int Id { get; set; }
        public string First_Name { get; set; } = string.Empty;
        public string Last_Name { get; set; } = string.Empty;
        public string Email { get; set;} = string.Empty;
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public List<Transaction> Transactions { get; set; } 
    }
}
