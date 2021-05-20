using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entities
{
    public class Sale
    {
        public DateTime SaleTime { get; set; }
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public string GameName { get; set; }
        public string CustomerName { get; set; }
        
    }
}
