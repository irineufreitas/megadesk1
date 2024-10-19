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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        // Add New Quote button opens Add Quote window, with a tag referring back to the main menu.
        private void AddNewQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuote openAddQuoteForm = new AddQuote();
            openAddQuoteForm.Tag = this;
            openAddQuoteForm.Show(this);
            Hide();
        }

        // View Quotes button opens View Quotes window, with a tag referring back to the main menu.
        private void ViewQuotesBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes openViewQuotesForm = new ViewAllQuotes();
            openViewQuotesForm.Tag = this;
            openViewQuotesForm.Show(this);
            Hide();
        }

        // Search Quotes button opens Search Quotes window, with a tag referring back to the main menu.
        private void SearchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes openSearchQuotesForm = new SearchQuotes();
            openSearchQuotesForm.Tag = this;
            openSearchQuotesForm.Show(this);
            Hide();
        }

        // Exit the program.
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
