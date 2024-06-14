using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Populate the ComboBoxes with currency options
            comboBoxFromCurrency.Items.Add("USD");
            comboBoxFromCurrency.Items.Add("SAR"); // Saudi Riyal
            comboBoxToCurrency.Items.Add("PKR");
            comboBoxToCurrency.Items.Add("INR"); // Indian Rupee
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            // Call conversion function when amount changes
            ConvertCurrency();
        }

        private void comboBoxFromCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call conversion function when from currency changes
            ConvertCurrency();
        }

        private void comboBoxToCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call conversion function when to currency changes
            ConvertCurrency();
        }

        private void ConvertCurrency()
        {
            // Get the amount to convert
            if (decimal.TryParse(amountTextBox.Text, out decimal amount))
            {
                // Define the conversion rates
                decimal usdToPkrRate = 275;  // 1 USD = 275 PKR
                decimal sarToPkrRate = 72;   // 1 SAR = 72 PKR
                decimal usdToInrRate = 83;   // 1 USD = 83 INR
                decimal sarToInrRate = 22;   // 1 SAR = 22 INR

                decimal convertedAmount = 0;

                // Perform conversion based on selected currencies
                string fromCurrency = comboBoxFromCurrency.SelectedItem.ToString();
                string toCurrency = comboBoxToCurrency.SelectedItem.ToString();

                if (fromCurrency == "USD" && toCurrency == "PKR")
                {
                    convertedAmount = amount * usdToPkrRate;
                }
                else if (fromCurrency == "SAR" && toCurrency == "PKR")
                {
                    convertedAmount = amount * sarToPkrRate;
                }
                else if (fromCurrency == "USD" && toCurrency == "INR")
                {
                    convertedAmount = amount * usdToInrRate;
                }
                else if (fromCurrency == "SAR" && toCurrency == "INR")
                {
                    convertedAmount = amount * sarToInrRate;
                }
                else if (fromCurrency == "PKR" && toCurrency == "USD")
                {
                    convertedAmount = amount / usdToPkrRate;
                }
                else if (fromCurrency == "PKR" && toCurrency == "SAR")
                {
                    convertedAmount = amount / sarToPkrRate;
                }
                else if (fromCurrency == "USD" && toCurrency == "SAR")
                {
                    convertedAmount = amount * (usdToPkrRate / sarToPkrRate);
                }
                else if (fromCurrency == "INR" && toCurrency == "USD")
                {
                    convertedAmount = amount * (sarToInrRate / usdToInrRate);
                }
                else if (fromCurrency == "INR" && toCurrency == "SAR")
                {
                    convertedAmount = amount * (sarToInrRate / usdToInrRate);
                }

                // Display the converted amount in the appropriate TextBox
                convertedCurrencyTextBox.Text = convertedAmount.ToString("0.##"); // Format to two decimal places
            }
            else
            {
                // Handle invalid input in amountTextBox
                convertedCurrencyTextBox.Text = "Invalid amount";
            }
        }
    }
}
