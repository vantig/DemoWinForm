using System;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApp.Model;
using WindowsFormsApp.Repositories;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp
{

    public partial class MainForm : Form
    {
        private FuelRepository _fuelRepository;
        Microsoft.Office.Interop.Word.Application wordapp;
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
            textBoxTotal.Text =
                (double.Parse(textBoxToPayFuel.Text, CultureInfo.InvariantCulture) +
                 double.Parse(textBoxToPayCaffe.Text, CultureInfo.InvariantCulture))
                .ToString(CultureInfo.InvariantCulture);
            MakeCheckWord();

        }

        private void MakeCheckWord()
        {
            wordapp = new Microsoft.Office.Interop.Word.Application();
            wordapp.Visible = true;
            Microsoft.Office.Interop.Word.Paragraph wordparagraph;
            Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();
            object MyTemplate = Type.Missing;
            object NewTemplate = false;
            object DocumentType = Microsoft.Office.Interop.Word.WdNewDocumentType.wdNewBlankDocument;
            object pargf = Type.Missing;
            wordparagraph = doc.Content.Paragraphs.Add(ref pargf);
            // применение полужирного начертания к тексту 
            wordparagraph.Range.Font.Bold = 1;
            // установка размера текста
            wordparagraph.Range.Font.Size = 14;
            // добавление текста
            wordparagraph.Range.Text = "Check:";
            // выравнивание текста по центру 
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            // вставка параграфа
            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 12;
            if (textBoxToPayFuel.Text.Length>0)
            {
                wordparagraph.Range.Text = $"{comboBoxFuelTypes.SelectedItem} liters:{textBoxLitersFuel.Text} cost:{textBoxToPayFuel.Text}";
                wordparagraph.Format.SpaceAfter = 10;
                wordparagraph.Range.InsertParagraphAfter();
            }
          
            if (checkBoxHotDog.Checked)
            {
                wordparagraph.Range.Text = $"Hot Dog {textBoxHotDogCount.Text}*{textBoxHotDogPrice.Text} { (double.Parse(textBoxHotDogPrice.Text, CultureInfo.InvariantCulture) * double.Parse(textBoxHotDogPrice.Text, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture)}";
            }
         

            //wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            //wordparagraph.Range.InsertParagraphAfter();
            //wordparagraph.Range.Font.Size = 20;
            //wordparagraph.Range.Text = "РАЗРАБОТКА ПРИЛОЖЕНИЙ  ДЛЯ ПРОГРАММНОГО  ОБМЕНА ИНФОРМАЦИЕЙ  МЕЖДУ СУБД  И ОФИСНЫМИ ПРИЛОЖЕНИЯМИ ";
            //// отступ от параграфа


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
