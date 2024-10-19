using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Bohman
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote deskQuote;

        public DisplayQuote(DeskQuote submittedQuote)
        {
            InitializeComponent();
            this.deskQuote = submittedQuote;
            string customerName;
            Desk deskDetails;
            string deliveryTime;
            int quotePrice;
            DateTime quoteDate;
            this.deskQuote.GetQuoteDetails(out customerName, out deskDetails, out deliveryTime, out quotePrice, out quoteDate);
            CustomerName.Text = customerName;
            DeskWidth.Text = deskDetails.width.ToString() + Desk.APPENDED_MEASUREMENT_UNIT;
            DeskDepth.Text = deskDetails.depth.ToString() + Desk.APPENDED_MEASUREMENT_UNIT;
            NumberOfDrawers.Text = deskDetails.numDrawers.ToString();
            DeskMaterial.Text = deskDetails.material.ToString();
            DeliveryTime.Text = deliveryTime;
            PriceQuote.Text = DeskQuote.PREPENDED_PRICE_UNIT + quotePrice;
            QuoteDate.Text = quoteDate.ToString("MMM d, yyyy");

            
            
        }

        // Return to menu button reopens the main menu.
        private void ReturnToMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu ReturnToMainMenu = (MainMenu)Tag;
            ReturnToMainMenu.Show();
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
