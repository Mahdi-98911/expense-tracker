using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using NUlid;

namespace ExpenseTracker.Console.Models
{
    internal class Expense
    {
        public Ulid ExpenseId { get; init; } = Ulid.NewUlid();
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
