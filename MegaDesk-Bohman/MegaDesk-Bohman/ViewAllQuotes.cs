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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            SetupDataGridView();
            PopulateDataGridView();

        }




        // Return to menu button reopens the main menu.
        private void ReturnToMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu ReturnToMainMenu = (MainMenu)Tag;
            ReturnToMainMenu.Show();
            Close();
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(ViewAllDataGridView);
            ViewAllDataGridView.ColumnCount = 8;
            ViewAllDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(ViewAllDataGridView.Font, FontStyle.Bold);
            ViewAllDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set the column header names
            ViewAllDataGridView.Columns[0].Name = "Customer";
            ViewAllDataGridView.Columns[1].Name = "Width";
            ViewAllDataGridView.Columns[2].Name = "Depth";
            ViewAllDataGridView.Columns[3].Name = "Drawers";
            ViewAllDataGridView.Columns[4].Name = "Material";
            ViewAllDataGridView.Columns[5].Name = "Delivery";
            ViewAllDataGridView.Columns[6].Name = "Price";
            ViewAllDataGridView.Columns[7].Name = "Date";
        }

        // Fill in the data grid with saved quotes that match the selected desktop material
        private void PopulateDataGridView()
        {
            List<DeskQuote> deskQuotes = DeskQuote.LoadAllQuotes();

            for (int i = 0; i < deskQuotes.Count; i++)
            {
                string customerName;
                Desk deskDetails;
                string orderTimeFrame;
                int quotePrice;
                DateTime quoteDate;

                deskQuotes[i].GetQuoteDetails(out customerName, out deskDetails, out orderTimeFrame, out quotePrice, out quoteDate);
                ViewAllDataGridView.Rows.Add(customerName, deskDetails.width + Desk.APPENDED_MEASUREMENT_UNIT, deskDetails.depth + Desk.APPENDED_MEASUREMENT_UNIT, deskDetails.numDrawers, deskDetails.material.ToString(), orderTimeFrame, DeskQuote.PREPENDED_PRICE_UNIT + quotePrice, quoteDate);
            }
        }
    }
}
