using System;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApp.Model;
using WindowsFormsApp.Repositories;

namespace WindowsFormsApp
{

    public partial class MainForm : Form
    {
        private FuelRepository _fuelRepository;
        public MainForm()
        {
            InitializeComponent();
            _fuelRepository = new FuelRepository();
        }

        private void comboBoxFuelTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFuelTypes.SelectedItem != null)
            {
                if (comboBoxFuelTypes.SelectedItem is FuelInfo fuelInfo)
                {
                    textBoxPriceFuel.Text = fuelInfo.Price.ToString(CultureInfo.CurrentCulture);
                }

                textBoxLitersFuel.Text = "";
                textBoxMoneyFuel.Text = "";
                CalculateLiters();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxFuelTypes.DataSource = _fuelRepository.Get();
        }



        private void CalculateLiters()
        {
            if (double.TryParse(textBoxMoneyFuel.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var money))
            {
                textBoxLitersFuel.Text =
                    (money / double.Parse(textBoxPriceFuel.Text, CultureInfo.CurrentCulture)).ToString(CultureInfo
                        .InvariantCulture);
                textBoxToPayFuel.Text = textBoxMoneyFuel.Text;
            }
            else
            {
                textBoxLitersFuel.Text = string.Empty;
                textBoxToPayFuel.Text = "0";
            }
        }

        private void CalculateMoney()
        {
            if (double.TryParse(textBoxLitersFuel.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var liters))
            {
                textBoxMoneyFuel.Text =
                    (liters * double.Parse(textBoxPriceFuel.Text, CultureInfo.CurrentCulture)).ToString(CultureInfo
                        .InvariantCulture);
                textBoxToPayFuel.Text = textBoxMoneyFuel.Text;
            }
            else
            {
                textBoxMoneyFuel.Text = string.Empty;
                textBoxToPayFuel.Text = "0";
            }
        }
        private void textBoxLitersFuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {

                return;
            }

            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }
            if (e.KeyChar == '.')
            {
                if (textBoxLitersFuel.Text.IndexOf('.') != -1)
                {
                    e.Handled = true;
                }

                return;
            }

            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    buttonTotal.Focus();
                }
                return;
            }

            e.Handled = true;

        }

        private void textBoxMoneyFuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (textBoxMoneyFuel.Text.IndexOf('.') > 0 && textBoxMoneyFuel.Text.IndexOf('.') + 3 == textBoxMoneyFuel.Text.Length)
                {
                    e.Handled = true;
                }


                return;
            }

            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }
            if (e.KeyChar == '.')
            {
                if (textBoxMoneyFuel.Text.IndexOf('.') != -1)
                {
                    e.Handled = true;
                }

                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    buttonTotal.Focus();
                }
                return;
            }
            e.Handled = true;

        }

        private void textBoxLitersFuel_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateMoney();
        }

        private void textBoxMoneyFuel_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateLiters();
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = (double.Parse(textBoxToPayFuel.Text, CultureInfo.InvariantCulture) + double.Parse(textBoxToPayCaffe.Text, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);
        }



        private void checkBoxHotDog_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxHotDog.CheckState == CheckState.Checked && textBoxHotDogCount.Text.Length > 0)
            {
                textBoxToPayCaffe.Text = (double.Parse(textBoxHotDogPrice.Text, CultureInfo.InvariantCulture) * double.Parse(textBoxHotDogCount.Text, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);


            }
            else
            {
                textBoxToPayCaffe.Text = "0";
            }
        }

        private void textBoxHotDogCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (textBoxMoneyFuel.Text.IndexOf('.') > 0 && textBoxMoneyFuel.Text.IndexOf('.') + 3 == textBoxMoneyFuel.Text.Length)
                {
                    e.Handled = true;
                }


                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    buttonTotal.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void textBoxHotDogCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (checkBoxHotDog.CheckState == CheckState.Checked && textBoxHotDogCount.Text.Length > 0)
            {
                textBoxToPayCaffe.Text = (double.Parse(textBoxHotDogPrice.Text, CultureInfo.InvariantCulture) * double.Parse(textBoxHotDogCount.Text, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);


            }
            else
            {
                textBoxToPayCaffe.Text = "0";
            }
        }

        private void textBoxHotDogPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (checkBoxHotDog.CheckState == CheckState.Checked && textBoxHotDogCount.Text.Length > 0 && textBoxHotDogPrice.Text.Length > 0)
            {
                textBoxToPayCaffe.Text = (double.Parse(textBoxHotDogPrice.Text, CultureInfo.InvariantCulture) * double.Parse(textBoxHotDogCount.Text, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);


            }
            else
            {
                textBoxToPayCaffe.Text = "0";
            }
        }

        private void textBoxHotDogPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (textBoxMoneyFuel.Text.IndexOf('.') > 0 && textBoxMoneyFuel.Text.IndexOf('.') + 3 == textBoxMoneyFuel.Text.Length)
                {
                    e.Handled = true;
                }


                return;
            }

            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }
            if (e.KeyChar == '.')
            {
                if (textBoxMoneyFuel.Text.IndexOf('.') != -1)
                {
                    e.Handled = true;
                }

                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    buttonTotal.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void buttonHotDogMinus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBoxHotDogCount.Text, CultureInfo.CurrentCulture) - 1) > -1)
            {
                textBoxHotDogCount.Text = (int.Parse(textBoxHotDogCount.Text, CultureInfo.CurrentCulture) - 1).ToString(CultureInfo.CurrentCulture);
            }
            if (checkBoxHotDog.CheckState == CheckState.Checked && textBoxHotDogCount.Text.Length > 0 && textBoxHotDogPrice.Text.Length > 0)
            {
                textBoxToPayCaffe.Text = (double.Parse(textBoxHotDogPrice.Text, CultureInfo.InvariantCulture) * double.Parse(textBoxHotDogCount.Text, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);


            }
            else
            {
                textBoxToPayCaffe.Text = "0";
            }


        }

        private void buttonHotDogPlus_Click(object sender, EventArgs e)
        {
            if (textBoxHotDogCount.Text.Length==0)
            {
                textBoxHotDogCount.Text =1.ToString(CultureInfo.CurrentCulture);
            }
            else
            {
                textBoxHotDogCount.Text = (int.Parse(textBoxHotDogCount.Text, CultureInfo.CurrentCulture) + 1).ToString(CultureInfo.CurrentCulture);
            }
            if (checkBoxHotDog.CheckState == CheckState.Checked && textBoxHotDogCount.Text.Length > 0 && textBoxHotDogPrice.Text.Length > 0)
            {
                textBoxToPayCaffe.Text = (double.Parse(textBoxHotDogPrice.Text, CultureInfo.InvariantCulture) * double.Parse(textBoxHotDogCount.Text, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);


            }
            else
            {
                textBoxToPayCaffe.Text = "0";
            }
        }
    }
}
