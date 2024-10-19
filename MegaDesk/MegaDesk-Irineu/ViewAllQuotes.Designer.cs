namespace MegaDesk_Bohman
{
    partial class ViewAllQuotes
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
            this.ChooseAMaterialLabel = new System.Windows.Forms.Label();
            this.ViewAllDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnToMenuBtn
            // 
            this.ReturnToMenuBtn.Font = new System.Drawing.Font("Aptos", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToMenuBtn.Location = new System.Drawing.Point(706, 583);
            this.ReturnToMenuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnToMenuBtn.Name = "ReturnToMenuBtn";
            this.ReturnToMenuBtn.Size = new System.Drawing.Size(165, 45);
            this.ReturnToMenuBtn.TabIndex = 2;
            this.ReturnToMenuBtn.Text = "Return to menu";
            this.ReturnToMenuBtn.UseVisualStyleBackColor = true;
            this.ReturnToMenuBtn.Click += new System.EventHandler(this.ReturnToMenuBtn_Click);
            // 
            // ChooseAMaterialLabel
            // 
            this.ChooseAMaterialLabel.AutoSize = true;
            this.ChooseAMaterialLabel.Font = new System.Drawing.Font("Aptos", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseAMaterialLabel.Location = new System.Drawing.Point(381, 23);
            this.ChooseAMaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseAMaterialLabel.Name = "ChooseAMaterialLabel";
            this.ChooseAMaterialLabel.Size = new System.Drawing.Size(122, 31);
            this.ChooseAMaterialLabel.TabIndex = 6;
            this.ChooseAMaterialLabel.Text = "All Quotes";
            // 
            // ViewAllDataGridView
            // 
            this.ViewAllDataGridView.AllowUserToAddRows = false;
            this.ViewAllDataGridView.AllowUserToDeleteRows = false;
            this.ViewAllDataGridView.AllowUserToResizeColumns = false;
            this.ViewAllDataGridView.AllowUserToResizeRows = false;
            this.ViewAllDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ViewAllDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewAllDataGridView.Location = new System.Drawing.Point(12, 72);
            this.ViewAllDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewAllDataGridView.Name = "ViewAllDataGridView";
            this.ViewAllDataGridView.ReadOnly = true;
            this.ViewAllDataGridView.RowHeadersVisible = false;
            this.ViewAllDataGridView.Size = new System.Drawing.Size(860, 491);
            this.ViewAllDataGridView.TabIndex = 7;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.ViewAllDataGridView);
            this.Controls.Add(this.ChooseAMaterialLabel);
            this.Controls.Add(this.ReturnToMenuBtn);
            this.Font = new System.Drawing.Font("Aptos", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk - View All Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnToMenuBtn;
        private System.Windows.Forms.Label ChooseAMaterialLabel;
        private System.Windows.Forms.DataGridView ViewAllDataGridView;
    }
}