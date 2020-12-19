using System;
using System.Windows.Forms;
using DemoSimpleControls.Model;
using DemoSimpleControls.Repositories;

namespace DemoSimpleControls
{
  public partial class MainForm : Form
  {
    private FuelRepository _fuelRepository;
    public MainForm()
    {
      InitializeComponent();
      _fuelRepository = new FuelRepository();
    }

    private void cbFuels_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cbFuels.SelectedItem != null)
      {
        if (cbFuels.SelectedItem is FuelInfo fuelInfo)
        {
          lbSelectedFuel.Text = fuelInfo.Price.ToString("N2");
        }
      }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      cbFuels.DataSource = _fuelRepository.Get();
    }

    private void checkBox5_Click(object sender, EventArgs e)
    {
      SetReadOnlyByCheckbox(sender as CheckBox);
    }

    private void SetReadOnlyByCheckbox(CheckBox checkBox)
    {
      var controlName =  checkBox.Tag.ToString();
      var textBox = Controls[controlName] as TextBox;
      textBox.ReadOnly = !checkBox.Checked;
    }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
