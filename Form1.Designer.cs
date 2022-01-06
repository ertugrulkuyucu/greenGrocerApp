
namespace GreenGrocerApp
{
    partial class Form1
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
            this.entryPanel = new System.Windows.Forms.GroupBox();
            this.productTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.stockRadioButton = new System.Windows.Forms.RadioButton();
            this.salesRadioButton = new System.Windows.Forms.RadioButton();
            this.stockEntryButton = new System.Windows.Forms.Button();
            this.sweepingsEntryButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.entryPanel.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryPanel
            // 
            this.entryPanel.BackColor = System.Drawing.Color.Transparent;
            this.entryPanel.Controls.Add(this.productTypeComboBox);
            this.entryPanel.Controls.Add(this.label3);
            this.entryPanel.Controls.Add(this.label2);
            this.entryPanel.Controls.Add(this.label1);
            this.entryPanel.Controls.Add(this.saveButton);
            this.entryPanel.Controls.Add(this.quantityTextBox);
            this.entryPanel.Controls.Add(this.productNameComboBox);
            this.entryPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryPanel.Location = new System.Drawing.Point(79, 90);
            this.entryPanel.Name = "entryPanel";
            this.entryPanel.Size = new System.Drawing.Size(273, 220);
            this.entryPanel.TabIndex = 11;
            this.entryPanel.TabStop = false;
            this.entryPanel.Text = "Stock";
            this.entryPanel.Visible = false;
            // 
            // productTypeComboBox
            // 
            this.productTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productTypeComboBox.FormattingEnabled = true;
            this.productTypeComboBox.Items.AddRange(new object[] {
            "Fruit",
            "Vegetable"});
            this.productTypeComboBox.Location = new System.Drawing.Point(136, 26);
            this.productTypeComboBox.Name = "productTypeComboBox";
            this.productTypeComboBox.Size = new System.Drawing.Size(103, 24);
            this.productTypeComboBox.TabIndex = 9;
            this.productTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.productTypeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(36, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(99, 160);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 50);
            this.saveButton.TabIndex = 5;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveStock_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(136, 107);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(103, 22);
            this.quantityTextBox.TabIndex = 4;
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(136, 65);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(103, 24);
            this.productNameComboBox.TabIndex = 3;
            // 
            // stockRadioButton
            // 
            this.stockRadioButton.AutoSize = true;
            this.stockRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.stockRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockRadioButton.ForeColor = System.Drawing.Color.Aqua;
            this.stockRadioButton.Location = new System.Drawing.Point(158, 11);
            this.stockRadioButton.Name = "stockRadioButton";
            this.stockRadioButton.Size = new System.Drawing.Size(79, 28);
            this.stockRadioButton.TabIndex = 13;
            this.stockRadioButton.TabStop = true;
            this.stockRadioButton.Text = "Stock";
            this.stockRadioButton.UseVisualStyleBackColor = false;
            this.stockRadioButton.CheckedChanged += new System.EventHandler(this.stockRadioButton_CheckedChanged);
            // 
            // salesRadioButton
            // 
            this.salesRadioButton.AutoSize = true;
            this.salesRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.salesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salesRadioButton.ForeColor = System.Drawing.Color.Lime;
            this.salesRadioButton.Location = new System.Drawing.Point(327, 11);
            this.salesRadioButton.Name = "salesRadioButton";
            this.salesRadioButton.Size = new System.Drawing.Size(79, 28);
            this.salesRadioButton.TabIndex = 14;
            this.salesRadioButton.TabStop = true;
            this.salesRadioButton.Text = "Sales";
            this.salesRadioButton.UseVisualStyleBackColor = false;
            this.salesRadioButton.CheckedChanged += new System.EventHandler(this.salesRadioButton_CheckedChanged);
            // 
            // stockEntryButton
            // 
            this.stockEntryButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.stockEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockEntryButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.stockEntryButton.Location = new System.Drawing.Point(7, 23);
            this.stockEntryButton.Name = "stockEntryButton";
            this.stockEntryButton.Size = new System.Drawing.Size(200, 30);
            this.stockEntryButton.TabIndex = 15;
            this.stockEntryButton.Text = "Stock Entry";
            this.stockEntryButton.UseVisualStyleBackColor = false;
            this.stockEntryButton.Visible = false;
            this.stockEntryButton.Click += new System.EventHandler(this.stockEntryButton_Click);
            // 
            // sweepingsEntryButton
            // 
            this.sweepingsEntryButton.BackColor = System.Drawing.Color.Red;
            this.sweepingsEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sweepingsEntryButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sweepingsEntryButton.Location = new System.Drawing.Point(229, 23);
            this.sweepingsEntryButton.Name = "sweepingsEntryButton";
            this.sweepingsEntryButton.Size = new System.Drawing.Size(200, 30);
            this.sweepingsEntryButton.TabIndex = 16;
            this.sweepingsEntryButton.Text = "Sweepings Entry";
            this.sweepingsEntryButton.UseVisualStyleBackColor = false;
            this.sweepingsEntryButton.Visible = false;
            this.sweepingsEntryButton.Click += new System.EventHandler(this.sweepingsEntryButton_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel.Controls.Add(this.entryPanel);
            this.panel.Controls.Add(this.sweepingsEntryButton);
            this.panel.Controls.Add(this.stockEntryButton);
            this.panel.Location = new System.Drawing.Point(54, 45);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(441, 361);
            this.panel.TabIndex = 17;
            // 
            // productListBox
            // 
            this.productListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 18;
            this.productListBox.Location = new System.Drawing.Point(511, 135);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(224, 148);
            this.productListBox.TabIndex = 12;
            this.productListBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GreenGrocerApp.Properties.Resources.bgg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 457);
            this.Controls.Add(this.productListBox);
            this.Controls.Add(this.salesRadioButton);
            this.Controls.Add(this.stockRadioButton);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.entryPanel.ResumeLayout(false);
            this.entryPanel.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox entryPanel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox productNameComboBox;
        private System.Windows.Forms.RadioButton stockRadioButton;
        private System.Windows.Forms.RadioButton salesRadioButton;
        private System.Windows.Forms.Button stockEntryButton;
        private System.Windows.Forms.Button sweepingsEntryButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productTypeComboBox;
        private System.Windows.Forms.Label label3;
    }
}

