namespace WinFormsApp1
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
            this.comboBoxFromCurrency = new System.Windows.Forms.ComboBox();
            this.comboBoxToCurrency = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.convertedCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxFromCurrency
            // 
            this.comboBoxFromCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFromCurrency.FormattingEnabled = true;
            this.comboBoxFromCurrency.Location = new System.Drawing.Point(50, 50);
            this.comboBoxFromCurrency.Name = "comboBoxFromCurrency";
            this.comboBoxFromCurrency.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFromCurrency.TabIndex = 0;
            this.comboBoxFromCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxFromCurrency_SelectedIndexChanged);
            // 
            // comboBoxToCurrency
            // 
            this.comboBoxToCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToCurrency.FormattingEnabled = true;
            this.comboBoxToCurrency.Location = new System.Drawing.Point(200, 50);
            this.comboBoxToCurrency.Name = "comboBoxToCurrency";
            this.comboBoxToCurrency.Size = new System.Drawing.Size(100, 21);
            this.comboBoxToCurrency.TabIndex = 1;
            this.comboBoxToCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxToCurrency_SelectedIndexChanged);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(50, 100);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 2;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // convertedCurrencyTextBox
            // 
            this.convertedCurrencyTextBox.Location = new System.Drawing.Point(200, 100);
            this.convertedCurrencyTextBox.Name = "convertedCurrencyTextBox";
            this.convertedCurrencyTextBox.ReadOnly = true;
            this.convertedCurrencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.convertedCurrencyTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 164);
            this.Controls.Add(this.convertedCurrencyTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.comboBoxToCurrency);
            this.Controls.Add(this.comboBoxFromCurrency);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFromCurrency;
        private System.Windows.Forms.ComboBox comboBoxToCurrency;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox convertedCurrencyTextBox;
    }
}
