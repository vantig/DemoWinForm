namespace DemoWindowsFormsApp
{
  partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label label1;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.tbLogin = new System.Windows.Forms.TextBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.btnLoout = new System.Windows.Forms.Button();
      this.timer = new System.Windows.Forms.Timer(this.components);
      label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.BackColor = System.Drawing.Color.Transparent;
      label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      label1.ForeColor = System.Drawing.Color.White;
      label1.Location = new System.Drawing.Point(215, 32);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(73, 29);
      label1.TabIndex = 0;
      label1.Text = "Login";
      // 
      // tbLogin
      // 
      this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.tbLogin.Location = new System.Drawing.Point(132, 76);
      this.tbLogin.Name = "tbLogin";
      this.tbLogin.Size = new System.Drawing.Size(198, 30);
      this.tbLogin.TabIndex = 1;
      // 
      // btnLogin
      // 
      this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.btnLogin.Location = new System.Drawing.Point(132, 112);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(198, 39);
      this.btnLogin.TabIndex = 2;
      this.btnLogin.Text = "Log IN";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnLoout
      // 
      this.btnLoout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnLoout.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.btnLoout.Location = new System.Drawing.Point(132, 157);
      this.btnLoout.Name = "btnLoout";
      this.btnLoout.Size = new System.Drawing.Size(198, 39);
      this.btnLoout.TabIndex = 3;
      this.btnLoout.Text = "LogOut";
      this.btnLoout.UseVisualStyleBackColor = true;
      this.btnLoout.Click += new System.EventHandler(this.button2_Click);
      // 
      // timer
      // 
      this.timer.Interval = 1000;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(452, 320);
      this.Controls.Add(this.btnLoout);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.tbLogin);
      this.Controls.Add(label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Demo";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox tbLogin;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnLoout;
    private System.Windows.Forms.Timer timer;
  }
}

