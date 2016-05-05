﻿using GoldChallenge.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoldChallenge.DAL
{
    public class FranchiseContext : DbContext
    {
        public FranchiseContext() : base("FranchiseContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<FranchiseContact> FranchiseContacts { get; set; }
        public DbSet<CustomerBackground> CustomerBackgrounds { get; set; }
        public DbSet<CustomerPreference> CustomerPreferences { get; set; }
        public DbSet<NetWorthCalculator> NetWorthCalculators { get; set; }
    }
}