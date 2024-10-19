using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Bohman
{
    public class DeskQuoteDTO
    {
        public string customerName;
        public Desk deskDetails;
        public OrderTimeFrame orderTimeFrame;
        public int quotePrice;
        public DateTime quoteDate;
    }
}
