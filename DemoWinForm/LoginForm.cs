using System;
using System.Drawing;
using System.Windows.Forms;


namespace DemoWinForm
{
  internal class LoginForm : Form
  {

    private TextBox _textBox;
    private Label _label;

    public LoginForm()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      _label = new Label();
      _label.Text = "Login:";
      _label.ForeColor = Color.DarkRed;
      _label.Location = new Point(30, 50);
      this.Controls.Add(_label);


      _textBox = new TextBox()
      {
        Location = new Point(30, 80),
        Font = new Font("Arial", 14),
        Size = new Size(100, 30)
      };
      this.Controls.Add(_textBox);

      Button buttonIn = new Button();
      buttonIn.Location = new Point(30, 110);
      buttonIn.Size = new Size(100, 30);
      buttonIn.Text = "Log IN";
      buttonIn.Click += new EventHandler(Button_Click);
      this.Controls.Add(buttonIn);

      Button buttonOut = new Button();
      buttonOut.Location = new Point(30, 150);
      buttonOut.Size = new Size(100, 30);
      buttonOut.Text = "Log OUT";

      // buttonOut.Click += (os, ea) => textBox.Text = "Log OUT";
      buttonOut.Click += ButtonOut_Click;
     

      this.Controls.Add(buttonOut);



    }

    private void ButtonOut_Click(object sender, EventArgs e)
    {
      _textBox.Text = "Log OUT";
    }

    private void Button_Click(object sender, EventArgs e)
    {
      if (sender is Button button)
      {
        Text = button.Text;
      }
    }


  }


}
