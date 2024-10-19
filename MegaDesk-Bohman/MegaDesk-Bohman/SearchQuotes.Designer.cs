namespace MegaDesk_Bohman
{
    partial class SearchQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReturnToMenuBtn = new System.Windows.Forms.Button();
            this.DesktopMaterialSelection = new System.Windows.Forms.ComboBox();
            this.ChooseAMaterialLabel = new System.Windows.Forms.Label();
            this.SearchResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchQuotesMaterialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnToMenuBtn
            // 
            this.ReturnToMenuBtn.Font = new System.Drawing.Font("Aptos", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToMenuBtn.Location = new System.Drawing.Point(705, 591);
            this.ReturnToMenuBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ReturnToMenuBtn.Name = "ReturnToMenuBtn";
            this.ReturnToMenuBtn.Size = new System.Drawing.Size(165, 42);
            this.ReturnToMenuBtn.TabIndex = 2;
            this.ReturnToMenuBtn.Text = "Return to menu";
            this.ReturnToMenuBtn.UseVisualStyleBackColor = true;
            this.ReturnToMenuBtn.Click += new System.EventHandler(this.ReturnToMenuBtn_Click);
            // 
            // DesktopMaterialSelection
            // 
            this.DesktopMaterialSelection.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesktopMaterialSelection.FormattingEnabled = true;
            this.DesktopMaterialSelection.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.DesktopMaterialSelection.Location = new System.Drawing.Point(269, 599);
            this.DesktopMaterialSelection.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DesktopMaterialSelection.Name = "DesktopMaterialSelection";
            this.DesktopMaterialSelection.Size = new System.Drawing.Size(159, 30);
            this.DesktopMaterialSelection.TabIndex = 4;
            this.DesktopMaterialSelection.SelectedValueChanged += new System.EventHandler(this.SearchQuotes_SelectedValueChanged);
            // 
            // ChooseAMaterialLabel
            // 
            this.ChooseAMaterialLabel.AutoSize = true;
            this.ChooseAMaterialLabel.Font = new System.Drawing.Font("Aptos", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseAMaterialLabel.Location = new System.Drawing.Point(119, 23);
            this.ChooseAMaterialLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ChooseAMaterialLabel.Name = "ChooseAMaterialLabel";
            this.ChooseAMaterialLabel.Size = new System.Drawing.Size(647, 31);
            this.ChooseAMaterialLabel.TabIndex = 5;
            this.ChooseAMaterialLabel.Text = "Choose a desktop material below to see all matching quotes.";
            // 
            // SearchResultsDataGridView
            // 
            this.SearchResultsDataGridView.AllowUserToAddRows = false;
            this.SearchResultsDataGridView.AllowUserToDeleteRows = false;
            this.SearchResultsDataGridView.AllowUserToResizeColumns = false;
            this.SearchResultsDataGridView.AllowUserToResizeRows = false;
            this.SearchResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SearchResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultsDataGridView.Location = new System.Drawing.Point(12, 72);
            this.SearchResultsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchResultsDataGridView.Name = "SearchResultsDataGridView";
            this.SearchResultsDataGridView.ReadOnly = true;
            this.SearchResultsDataGridView.RowHeadersVisible = false;
            this.SearchResultsDataGridView.Size = new System.Drawing.Size(860, 490);
            this.SearchResultsDataGridView.TabIndex = 6;
            // 
            // SearchQuotesMaterialLabel
            // 
            this.SearchQuotesMaterialLabel.AutoSize = true;
            this.SearchQuotesMaterialLabel.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesMaterialLabel.Location = new System.Drawing.Point(265, 572);
            this.SearchQuotesMaterialLabel.Name = "SearchQuotesMaterialLabel";
            this.SearchQuotesMaterialLabel.Size = new System.Drawing.Size(83, 23);
            this.SearchQuotesMaterialLabel.TabIndex = 7;
            this.SearchQuotesMaterialLabel.Text = "Material:";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 646);
            this.Controls.Add(this.SearchQuotesMaterialLabel);
            this.Controls.Add(this.SearchResultsDataGridView);
            this.Controls.Add(this.ChooseAMaterialLabel);
            this.Controls.Add(this.DesktopMaterialSelection);
            this.Controls.Add(this.ReturnToMenuBtn);
            this.Font = new System.Drawing.Font("Aptos", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk - Search Quotes by Desktop Material";
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnToMenuBtn;
        private System.Windows.Forms.ComboBox DesktopMaterialSelection;
        private System.Windows.Forms.Label ChooseAMaterialLabel;
        private System.Windows.Forms.DataGridView SearchResultsDataGridView;
        private System.Windows.Forms.Label SearchQuotesMaterialLabel;
    }
}