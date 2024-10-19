namespace MegaDesk_Bohman
{
    partial class AddQuote
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
            this.CustomerNameInput = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DeskWidthLabel = new System.Windows.Forms.Label();
            this.DeskDepthLabel = new System.Windows.Forms.Label();
            this.NumberOfDrawersLabel = new System.Windows.Forms.Label();
            this.DeskWidthInput = new System.Windows.Forms.NumericUpDown();
            this.DeskDepthInput = new System.Windows.Forms.NumericUpDown();
            this.NumberOfDrawersInput = new System.Windows.Forms.NumericUpDown();
            this.DeskMaterialSelectionInput = new System.Windows.Forms.ComboBox();
            this.DeskMaterialLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeRushOrderOptionsLabel = new System.Windows.Forms.Label();
            this.RushOrderOptionsInput = new System.Windows.Forms.ComboBox();
            this.PleaseEnterOrderDetailsTitle = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SubmitQuoteRequestBtn = new System.Windows.Forms.Button();
            this.DeskWidthErrorMsg = new System.Windows.Forms.Label();
            this.DeskDepthErrorMsg = new System.Windows.Forms.Label();
            this.CustomerNameInputErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeskWidthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDepthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDrawersInput)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerNameInput
            // 
            this.CustomerNameInput.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameInput.Location = new System.Drawing.Point(49, 78);
            this.CustomerNameInput.Name = "CustomerNameInput";
            this.CustomerNameInput.Size = new System.Drawing.Size(339, 29);
            this.CustomerNameInput.TabIndex = 0;
            this.CustomerNameInput.TextChanged += new System.EventHandler(this.CustomerNameInput_TextChanged);
            this.CustomerNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.CustomerNameInput_Validating);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(46, 55);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(138, 23);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // DeskWidthLabel
            // 
            this.DeskWidthLabel.AutoSize = true;
            this.DeskWidthLabel.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthLabel.Location = new System.Drawing.Point(46, 114);
            this.DeskWidthLabel.Name = "DeskWidthLabel";
            this.DeskWidthLabel.Size = new System.Drawing.Size(418, 23);
            this.DeskWidthLabel.TabIndex = 2;
            this.DeskWidthLabel.Text = "Desk Width (in inches) (*Must be between 24 and 96)";
            // 
            // DeskDepthLabel
            // 
            this.DeskDepthLabel.AutoSize = true;
            this.DeskDepthLabel.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthLabel.Location = new System.Drawing.Point(46, 174);
            this.DeskDepthLabel.Name = "DeskDepthLabel";
            this.DeskDepthLabel.Size = new System.Drawing.Size(419, 23);
            this.DeskDepthLabel.TabIndex = 4;
            this.DeskDepthLabel.Text = "Desk Depth (in inches) (*Must be between 12 and 48)";
            // 
            // NumberOfDrawersLabel
            // 
            this.NumberOfDrawersLabel.AutoSize = true;
            this.NumberOfDrawersLabel.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDrawersLabel.Location = new System.Drawing.Point(46, 231);
            this.NumberOfDrawersLabel.Name = "NumberOfDrawersLabel";
            this.NumberOfDrawersLabel.Size = new System.Drawing.Size(376, 23);
            this.NumberOfDrawersLabel.TabIndex = 6;
            this.NumberOfDrawersLabel.Text = "Number of Drawers (*Must be between 0 and 7)";
            // 
            // DeskWidthInput
            // 
            this.DeskWidthInput.DecimalPlaces = 1;
            this.DeskWidthInput.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthInput.Location = new System.Drawing.Point(49, 137);
            this.DeskWidthInput.Name = "DeskWidthInput";
            this.DeskWidthInput.Size = new System.Drawing.Size(100, 29);
            this.DeskWidthInput.TabIndex = 8;
            this.DeskWidthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.DeskWidthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DeskWidthInput_Validating);
            // 
            // DeskDepthInput
            // 
            this.DeskDepthInput.DecimalPlaces = 1;
            this.DeskDepthInput.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthInput.Location = new System.Drawing.Point(49, 197);
            this.DeskDepthInput.Name = "DeskDepthInput";
            this.DeskDepthInput.Size = new System.Drawing.Size(100, 29);
            this.DeskDepthInput.TabIndex = 9;
            this.DeskDepthInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DeskDepthInput.ValueChanged += new System.EventHandler(this.DeskDepthInput_ValueChanged);
            this.DeskDepthInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DeskDepthInput_KeyUp);
            // 
            // NumberOfDrawersInput
            // 
            this.NumberOfDrawersInput.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDrawersInput.Location = new System.Drawing.Point(49, 254);
            this.NumberOfDrawersInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumberOfDrawersInput.Name = "NumberOfDrawersInput";
            this.NumberOfDrawersInput.Size = new System.Drawing.Size(100, 29);
            this.NumberOfDrawersInput.TabIndex = 10;
            // 
            // DeskMaterialSelectionInput
            // 
            this.DeskMaterialSelectionInput.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskMaterialSelectionInput.FormattingEnabled = true;
            this.DeskMaterialSelectionInput.Items.AddRange(new object[] {
            "Oak ($200)",
            "Laminate ($100)",
            "Pine ($50)",
            "Rosewood ($300)",
            "Veneer ($125)"});
            this.DeskMaterialSelectionInput.Location = new System.Drawing.Point(49, 312);
            this.DeskMaterialSelectionInput.Name = "DeskMaterialSelectionInput";
            this.DeskMaterialSelectionInput.Size = new System.Drawing.Size(187, 30);
            this.DeskMaterialSelectionInput.TabIndex = 11;
            // 
            // DeskMaterialLabel
            // 
            this.DeskMaterialLabel.AutoSize = true;
            this.DeskMaterialLabel.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskMaterialLabel.Location = new System.Drawing.Point(46, 289);
            this.DeskMaterialLabel.Name = "DeskMaterialLabel";
            this.DeskMaterialLabel.Size = new System.Drawing.Size(143, 23);
            this.DeskMaterialLabel.TabIndex = 12;
            this.DeskMaterialLabel.Text = "Desktop Material";
            // 
            // DeliveryTimeRushOrderOptionsLabel
            // 
            this.DeliveryTimeRushOrderOptionsLabel.AutoSize = true;
            this.DeliveryTimeRushOrderOptionsLabel.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryTimeRushOrderOptionsLabel.Location = new System.Drawing.Point(46, 347);
            this.DeliveryTimeRushOrderOptionsLabel.Name = "DeliveryTimeRushOrderOptionsLabel";
            this.DeliveryTimeRushOrderOptionsLabel.Size = new System.Drawing.Size(280, 23);
            this.DeliveryTimeRushOrderOptionsLabel.TabIndex = 14;
            this.DeliveryTimeRushOrderOptionsLabel.Text = "Delivery Time (Rush Order Options)";
            // 
            // RushOrderOptionsInput
            // 
            this.RushOrderOptionsInput.DisplayMember = "14 Days (No Fee)";
            this.RushOrderOptionsInput.Font = new System.Drawing.Font("Aptos", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderOptionsInput.FormattingEnabled = true;
            this.RushOrderOptionsInput.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days",
            "14 Days (No Fee)"});
            this.RushOrderOptionsInput.Location = new System.Drawing.Point(50, 373);
            this.RushOrderOptionsInput.Name = "RushOrderOptionsInput";
            this.RushOrderOptionsInput.Size = new System.Drawing.Size(186, 30);
            this.RushOrderOptionsInput.TabIndex = 13;
            this.RushOrderOptionsInput.ValueMember = "14 Days (No Fee)";
            // 
            // PleaseEnterOrderDetailsTitle
            // 
            this.PleaseEnterOrderDetailsTitle.AutoSize = true;
            this.PleaseEnterOrderDetailsTitle.Font = new System.Drawing.Font("Aptos", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PleaseEnterOrderDetailsTitle.Location = new System.Drawing.Point(79, 9);
            this.PleaseEnterOrderDetailsTitle.Name = "PleaseEnterOrderDetailsTitle";
            this.PleaseEnterOrderDetailsTitle.Size = new System.Drawing.Size(326, 31);
            this.PleaseEnterOrderDetailsTitle.TabIndex = 15;
            this.PleaseEnterOrderDetailsTitle.Text = "Please enter the order details.";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Aptos", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(298, 428);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(165, 42);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // SubmitQuoteRequestBtn
            // 
            this.SubmitQuoteRequestBtn.Font = new System.Drawing.Font("Aptos", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitQuoteRequestBtn.Location = new System.Drawing.Point(50, 428);
            this.SubmitQuoteRequestBtn.Name = "SubmitQuoteRequestBtn";
            this.SubmitQuoteRequestBtn.Size = new System.Drawing.Size(165, 42);
            this.SubmitQuoteRequestBtn.TabIndex = 16;
            this.SubmitQuoteRequestBtn.Text = "Submit Quote";
            this.SubmitQuoteRequestBtn.UseVisualStyleBackColor = true;
            this.SubmitQuoteRequestBtn.Click += new System.EventHandler(this.SubmitQuoteRequestBtn_Click);
            // 
            // DeskWidthErrorMsg
            // 
            this.DeskWidthErrorMsg.AutoSize = true;
            this.DeskWidthErrorMsg.Font = new System.Drawing.Font("Aptos Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthErrorMsg.ForeColor = System.Drawing.Color.Crimson;
            this.DeskWidthErrorMsg.Location = new System.Drawing.Point(155, 139);
            this.DeskWidthErrorMsg.Name = "DeskWidthErrorMsg";
            this.DeskWidthErrorMsg.Size = new System.Drawing.Size(153, 23);
            this.DeskWidthErrorMsg.TabIndex = 18;
            this.DeskWidthErrorMsg.Text = "DeskWidthErrorMsg";
            this.DeskWidthErrorMsg.Visible = false;
            // 
            // DeskDepthErrorMsg
            // 
            this.DeskDepthErrorMsg.AutoSize = true;
            this.DeskDepthErrorMsg.Font = new System.Drawing.Font("Aptos Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthErrorMsg.ForeColor = System.Drawing.Color.Crimson;
            this.DeskDepthErrorMsg.Location = new System.Drawing.Point(155, 199);
            this.DeskDepthErrorMsg.Name = "DeskDepthErrorMsg";
            this.DeskDepthErrorMsg.Size = new System.Drawing.Size(154, 23);
            this.DeskDepthErrorMsg.TabIndex = 19;
            this.DeskDepthErrorMsg.Text = "DeskDepthErrorMsg";
            this.DeskDepthErrorMsg.Visible = false;
            // 
            // CustomerNameInputErrorMsg
            // 
            this.CustomerNameInputErrorMsg.AutoSize = true;
            this.CustomerNameInputErrorMsg.Font = new System.Drawing.Font("Aptos Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameInputErrorMsg.ForeColor = System.Drawing.Color.Crimson;
            this.CustomerNameInputErrorMsg.Location = new System.Drawing.Point(190, 55);
            this.CustomerNameInputErrorMsg.Name = "CustomerNameInputErrorMsg";
            this.CustomerNameInputErrorMsg.Size = new System.Drawing.Size(226, 23);
            this.CustomerNameInputErrorMsg.TabIndex = 20;
            this.CustomerNameInputErrorMsg.Text = "CustomerNameInputErrorMsg";
            this.CustomerNameInputErrorMsg.Visible = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 493);
            this.Controls.Add(this.CustomerNameInputErrorMsg);
            this.Controls.Add(this.DeskDepthErrorMsg);
            this.Controls.Add(this.DeskWidthErrorMsg);
            this.Controls.Add(this.SubmitQuoteRequestBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.PleaseEnterOrderDetailsTitle);
            this.Controls.Add(this.DeliveryTimeRushOrderOptionsLabel);
            this.Controls.Add(this.RushOrderOptionsInput);
            this.Controls.Add(this.DeskMaterialLabel);
            this.Controls.Add(this.DeskMaterialSelectionInput);
            this.Controls.Add(this.NumberOfDrawersInput);
            this.Controls.Add(this.DeskDepthInput);
            this.Controls.Add(this.DeskWidthInput);
            this.Controls.Add(this.NumberOfDrawersLabel);
            this.Controls.Add(this.DeskDepthLabel);
            this.Controls.Add(this.DeskWidthLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerNameInput);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk - Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.DeskWidthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDepthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDrawersInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerNameInput;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label DeskWidthLabel;
        private System.Windows.Forms.Label DeskDepthLabel;
        private System.Windows.Forms.Label NumberOfDrawersLabel;
        private System.Windows.Forms.NumericUpDown DeskWidthInput;
        private System.Windows.Forms.NumericUpDown DeskDepthInput;
        private System.Windows.Forms.NumericUpDown NumberOfDrawersInput;
        private System.Windows.Forms.ComboBox DeskMaterialSelectionInput;
        private System.Windows.Forms.Label DeskMaterialLabel;
        private System.Windows.Forms.Label DeliveryTimeRushOrderOptionsLabel;
        private System.Windows.Forms.ComboBox RushOrderOptionsInput;
        private System.Windows.Forms.Label PleaseEnterOrderDetailsTitle;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button SubmitQuoteRequestBtn;
        private System.Windows.Forms.Label DeskWidthErrorMsg;
        private System.Windows.Forms.Label DeskDepthErrorMsg;
        private System.Windows.Forms.Label CustomerNameInputErrorMsg;
    }
}