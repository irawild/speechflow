using System;
using System.Net.Http;
namespace speechflow.Models
{
    public class Expense
    {
        public string id { get; set; }
        public string categoria { get; set; }
        public decimal valor { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }

        public Expense()
        {
            
        }
    }
}
