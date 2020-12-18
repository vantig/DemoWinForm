
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DemoWindowsFormsApp
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();

    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      var dialogResult = MessageBox.Show("Войти в систему ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

      if (dialogResult == DialogResult.Yes)
      {
        MessageBox.Show("LogIN");

      }

    }

    private void button2_Click(object sender, System.EventArgs e)
    {

    }

    private void timer_Tick(object sender, System.EventArgs e)
    {
      Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      timer.Start();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      //var dialogResult = MessageBox.Show("Выйти из программы ?", "Внимание", MessageBoxButtons.YesNo);

      //if (dialogResult == DialogResult.No)
      //{
      //  e.Cancel = true;
      //}

    }

    private void MainForm_MouseMove(object sender, MouseEventArgs e)
    {
      tbLogin.Text = $"X={e.X}, Y={e.Y}";
    }

    private void MainForm_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
         BackColor = Color.Blue;

      }

      if (e.Button == MouseButtons.Middle)
      {
        BackColor = Color.Orange;

      }

      if (e.Button == MouseButtons.Right)
      {
        BackColor = Color.Red;

      }
    }
  }
}
