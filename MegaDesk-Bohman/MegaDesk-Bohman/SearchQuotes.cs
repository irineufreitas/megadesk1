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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            DesktopMaterialSelection.DataSource = Desk.materials;
        }

        // Return to menu button reopens the main menu.
        private void ReturnToMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu ReturnToMainMenu = (MainMenu)Tag;
            ReturnToMainMenu.Show();
            Close();
        }

        // Update the DataGridView when a new desktop material has been selected from the combobox.
        private void SearchQuotes_SelectedValueChanged(System.Object sender, System.EventArgs e)
        {
            ClearDataGridView();
            SetUpDataGridView();
            PopulateDataGridView();
        }

        // Set up the DataGridView with column headers and some basic settings.
        private void SetUpDataGridView()
        {
            this.Controls.Add(SearchResultsDataGridView);
            SearchResultsDataGridView.ColumnCount = 8;
            SearchResultsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(SearchResultsDataGridView.Font, FontStyle.Bold);
            SearchResultsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set the column header names.
            SearchResultsDataGridView.Columns[0].Name = "Customer";
            SearchResultsDataGridView.Columns[1].Name = "Width";
            SearchResultsDataGridView.Columns[2].Name = "Depth";
            SearchResultsDataGridView.Columns[3].Name = "Drawers";
            SearchResultsDataGridView.Columns[4].Name = "Material";
            SearchResultsDataGridView.Columns[5].Name = "Delivery";
            SearchResultsDataGridView.Columns[6].Name = "Price";
            SearchResultsDataGridView.Columns[7].Name = "Date";
        }

        // Fill in the DataGridView with saved quotes that match the selected desktop material.
        private void PopulateDataGridView()
        {
            DesktopMaterial selectedMaterial = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), DesktopMaterialSelection.Text);
            List<DeskQuote> deskQuoteSearchResults = DeskQuote.FilterAllQuotesByMaterial(selectedMaterial);

            for (int i = 0; i < deskQuoteSearchResults.Count; i++)
            {
                string customerName;
                Desk deskDetails;
                string orderTimeFrame;
                int quotePrice;
                DateTime quoteDate;

                deskQuoteSearchResults[i].GetQuoteDetails(out customerName, out deskDetails, out orderTimeFrame, out quotePrice, out quoteDate);
                SearchResultsDataGridView.Rows.Add(customerName, deskDetails.width + Desk.APPENDED_MEASUREMENT_UNIT, deskDetails.depth + Desk.APPENDED_MEASUREMENT_UNIT, deskDetails.numDrawers, deskDetails.material.ToString(), orderTimeFrame, DeskQuote.PREPENDED_PRICE_UNIT + quotePrice, quoteDate);
            }
        }

        // Clear all data from the DataGridView.
        private void ClearDataGridView()
        {
            int rowCount = SearchResultsDataGridView.Rows.GetRowCount(includeFilter: DataGridViewElementStates.Displayed);

            for (int i = rowCount - 1; i >= 0; i--)
            {
                SearchResultsDataGridView.Rows.RemoveAt(i);
            }
        }
    }
}
