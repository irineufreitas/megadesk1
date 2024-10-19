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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        // Cancel button returns to main menu.
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainMenu cancelAndReturnToMainMenu = (MainMenu)Tag;
            cancelAndReturnToMainMenu.Show();
            Close();
        }

        // Submit Quote button opens Display Quote window.
        private void SubmitQuoteRequestBtn_Click(object sender, EventArgs e)
        {
            // If error messages are visible, play an error sound and don't submit the form.
            if (CustomerNameInputErrorMsg.Visible || DeskWidthErrorMsg.Visible || DeskDepthErrorMsg.Visible)
            {
                System.Media.SystemSounds.Asterisk.Play();
            }
            else
            {
                int quoteDeskWidth = (int)DeskWidthInput.Value;
                int quoteDeskDepth = (int)DeskDepthInput.Value;
                int quoteNumDrawers = (int)NumberOfDrawersInput.Value;
                DesktopMaterial quoteDeskMaterial;
                OrderTimeFrame quoteOrderTimeFrame;

                // Get the enum value from the Desktop Material combobox
                switch (DeskMaterialSelectionInput.SelectedItem)
                {
                    case string x when x == DesktopMaterial.Oak.ToString() + $" (${DeskQuote.materialPrices[(int)DesktopMaterial.Oak]})":
                        quoteDeskMaterial = DesktopMaterial.Oak;
                        break;
                    case string x when x == DesktopMaterial.Laminate.ToString() + $" (${DeskQuote.materialPrices[(int)DesktopMaterial.Laminate]})":
                        quoteDeskMaterial = DesktopMaterial.Laminate;
                        break;
                    case string x when x == DesktopMaterial.Pine.ToString() + $" (${DeskQuote.materialPrices[(int)DesktopMaterial.Pine]})":
                        quoteDeskMaterial = DesktopMaterial.Pine;
                        break;
                    case string x when x == DesktopMaterial.Rosewood.ToString() + $" (${DeskQuote.materialPrices[(int)DesktopMaterial.Rosewood]})":
                        quoteDeskMaterial = DesktopMaterial.Rosewood;
                        break;
                    default: // Only other option is Veneer
                        quoteDeskMaterial = DesktopMaterial.Veneer;
                        break;
                }
                // Get the enum value from the "Delivery Time (Rush Order Options)" combobox
                switch (RushOrderOptionsInput.SelectedItem)
                {
                    case "3 Days":
                        quoteOrderTimeFrame = OrderTimeFrame._3days;
                        break;
                    case "5 Days":
                        quoteOrderTimeFrame = OrderTimeFrame._5days;
                        break;
                    case "7 Days":
                        quoteOrderTimeFrame = OrderTimeFrame._7days;
                        break;
                    default: // Only other option is 14 days, which is the default time frame
                        quoteOrderTimeFrame = OrderTimeFrame._14days;
                        break;
                }
                // Put all data entered into a new DeskQuote object.
                DeskQuote submittedQuote = new DeskQuote(
                    customerName: CustomerNameInput.Text,
                    width: quoteDeskWidth,
                    depth: quoteDeskDepth,
                    numDrawers: quoteNumDrawers,
                    material: quoteDeskMaterial,
                    orderTimeFrame: quoteOrderTimeFrame);
                try
                {
                    submittedQuote.SaveQuoteToJsonFile();
                    DisplayQuote openDisplayQuote = new DisplayQuote(submittedQuote);
                    // Pass the tag on to the Display Quote window. This tag refers back to the main menu.
                    openDisplayQuote.Tag = Tag;
                    openDisplayQuote.Show();
                }
                catch
                {
                    Application.Exit();
                }
                Close();
            }
        }

        // Validate Customer Name field - Must not be blank
        private void CustomerNameInput_Validating(object sender, CancelEventArgs e)
        {
            // Set background color to default white background.
            CustomerNameInput.BackColor = Color.White;
            // Set error message to be invisible.
            CustomerNameInputErrorMsg.Visible = false;
            if (CustomerNameInput.Text == "")
            {
                CustomerNameInput.BackColor = Color.FromArgb(255, 128, 128);
                CustomerNameInputErrorMsg.Text = "Name cannot be blank.";
                CustomerNameInputErrorMsg.Visible = true;
            }
        }

        // Clear error message from Customer Name field when text has been entered.
        private void CustomerNameInput_TextChanged(object sender, EventArgs e)
        {
            if (CustomerNameInput.Text != "")
            {
                // Set background color to default white background.
                CustomerNameInput.BackColor = Color.White;
                // Set error message to be invisible.
                CustomerNameInputErrorMsg.Visible = false;
            }
        }

        // Validate the value in the DeskWidth field when the field loses focus.
        private void DeskWidthInput_Validating(object sender, CancelEventArgs e)
        {
            // Set background color to default white background.
            DeskWidthInput.BackColor = Color.White;
            // Set error message to be invisible.
            DeskWidthErrorMsg.Visible = false;
            float inputValueFloat = (float)DeskWidthInput.Value;
            
            // If input value is not an integer, show an error message
            if (inputValueFloat % 1 > 0)
            {
                // Change input field background color to red to indicate an error
                DeskWidthInput.BackColor = Color.FromArgb(255, 128, 128);
                DeskWidthErrorMsg.Text = "Value must be an integer (whole number).";
                DeskWidthErrorMsg.Visible = true;
            }
            // If value is outside of allowed range, show an error message.
            if ((DeskWidthInput.Value < Desk.MIN_WIDTH) || (DeskWidthInput.Value > Desk.MAX_WIDTH))
            {
                // Change input field background color to red to indicate an error
                DeskWidthInput.BackColor = Color.FromArgb(255, 128, 128);
                DeskWidthErrorMsg.Text = "Value is outside of allowed range.";
                DeskWidthErrorMsg.Visible = true;
            }
        }

        // Validate the key and the value in the DeskWidth field when a key is pressed while in the field.
        private void DeskDepthInput_KeyUp(object sender, KeyEventArgs e)
        {
            // Set background color to default white background.
            DeskDepthInput.BackColor = Color.White;
            // Set error message to be invisible.
            DeskDepthErrorMsg.Visible = false;

            // If key pressed is not a control character, and not a digit (including the NumPad), and not an arrow key, and not the delete key, show an error message.
            if (((!char.IsControl((char)e.KeyCode)) && (!char.IsDigit((char)e.KeyCode))) && !((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9)) && !((e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Down) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right)) && !(e.KeyCode == Keys.Delete))
            {
                // Change input field background color to red to indicate an error
                DeskDepthInput.BackColor = Color.FromArgb(255, 128, 128);
                DeskDepthErrorMsg.Text = "Input must be a numerical digit.";
                DeskDepthErrorMsg.Visible = true;
            }
            else
            {
                float inputValueFloat = (float)DeskDepthInput.Value;

                // If input value is not an integer, show an error message
                if (inputValueFloat % 1 > 0)
                {
                    // Change input field background color to red to indicate an error
                    DeskDepthInput.BackColor = Color.FromArgb(255, 128, 128);
                    DeskDepthErrorMsg.Text = "Value must be an integer (whole number).";
                    DeskDepthErrorMsg.Visible = true;
                }

            }
            // If value is outside of allowed range, show an error message.
            if ((DeskDepthInput.Value < Desk.MIN_DEPTH) || (DeskDepthInput.Value > Desk.MAX_DEPTH))
            {
                // Change input field background color to red to indicate an error
                DeskDepthInput.BackColor = Color.FromArgb(255, 128, 128);
                DeskDepthErrorMsg.Text = "Value is outside of allowed range.";
                DeskDepthErrorMsg.Visible = true;
            }
        }

        // Simulate keypress in Desk Depth input field to trigger input validation when the input value has changed.
        private void DeskDepthInput_ValueChanged(object sender, EventArgs e)
        {
            DeskDepthInput.Focus();
            SendKeys.Send("{LEFT}");
        }
    }
}
