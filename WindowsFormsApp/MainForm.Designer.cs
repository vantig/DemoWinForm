
namespace WindowsFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonTotal = new System.Windows.Forms.Button();
            this.textBoxPriceFuel = new System.Windows.Forms.TextBox();
            this.textBoxMoneyFuel = new System.Windows.Forms.TextBox();
            this.panelFuel = new System.Windows.Forms.Panel();
            this.labelLitersFuel = new System.Windows.Forms.Label();
            this.labelMoneyFuel = new System.Windows.Forms.Label();
            this.labelPriceFuel = new System.Windows.Forms.Label();
            this.textBoxLitersFuel = new System.Windows.Forms.TextBox();
            this.labelToPayFuel = new System.Windows.Forms.Label();
            this.labelFuelTypes = new System.Windows.Forms.Label();
            this.textBoxToPayFuel = new System.Windows.Forms.TextBox();
            this.comboBoxFuelTypes = new System.Windows.Forms.ComboBox();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelCaffe = new System.Windows.Forms.Panel();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelCaffePrice = new System.Windows.Forms.Label();
            this.buttonHotDogMinus = new System.Windows.Forms.Button();
            this.buttonHotDogPlus = new System.Windows.Forms.Button();
            this.textBoxHotDogCount = new System.Windows.Forms.TextBox();
            this.textBoxHotDogPrice = new System.Windows.Forms.TextBox();
            this.checkBoxHotDog = new System.Windows.Forms.CheckBox();
            this.textBoxToPayCaffe = new System.Windows.Forms.TextBox();
            this.labelToPayCaffe = new System.Windows.Forms.Label();
            this.panelFuel.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelCaffe.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTotal
            // 
            this.buttonTotal.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTotal.Location = new System.Drawing.Point(30, 395);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(216, 51);
            this.buttonTotal.TabIndex = 0;
            this.buttonTotal.Text = "Сalculate";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // textBoxPriceFuel
            // 
            this.textBoxPriceFuel.Enabled = false;
            this.textBoxPriceFuel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPriceFuel.Location = new System.Drawing.Point(38, 73);
            this.textBoxPriceFuel.Name = "textBoxPriceFuel";
            this.textBoxPriceFuel.ReadOnly = true;
            this.textBoxPriceFuel.Size = new System.Drawing.Size(130, 20);
            this.textBoxPriceFuel.TabIndex = 1;
            // 
            // textBoxMoneyFuel
            // 
            this.textBoxMoneyFuel.Location = new System.Drawing.Point(124, 183);
            this.textBoxMoneyFuel.Name = "textBoxMoneyFuel";
            this.textBoxMoneyFuel.Size = new System.Drawing.Size(130, 20);
            this.textBoxMoneyFuel.TabIndex = 2;
            this.textBoxMoneyFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMoneyFuel_KeyPress);
            this.textBoxMoneyFuel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMoneyFuel_KeyUp);
            // 
            // panelFuel
            // 
            this.panelFuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(191)))));
            this.panelFuel.Controls.Add(this.labelLitersFuel);
            this.panelFuel.Controls.Add(this.labelMoneyFuel);
            this.panelFuel.Controls.Add(this.labelPriceFuel);
            this.panelFuel.Controls.Add(this.textBoxLitersFuel);
            this.panelFuel.Controls.Add(this.labelToPayFuel);
            this.panelFuel.Controls.Add(this.labelFuelTypes);
            this.panelFuel.Controls.Add(this.textBoxToPayFuel);
            this.panelFuel.Controls.Add(this.comboBoxFuelTypes);
            this.panelFuel.Controls.Add(this.panelTotal);
            this.panelFuel.Controls.Add(this.panelCaffe);
            this.panelFuel.Controls.Add(this.textBoxPriceFuel);
            this.panelFuel.Controls.Add(this.buttonTotal);
            this.panelFuel.Controls.Add(this.textBoxMoneyFuel);
            this.panelFuel.Location = new System.Drawing.Point(1, 0);
            this.panelFuel.Name = "panelFuel";
            this.panelFuel.Size = new System.Drawing.Size(618, 510);
            this.panelFuel.TabIndex = 3;
            // 
            // labelLitersFuel
            // 
            this.labelLitersFuel.AutoSize = true;
            this.labelLitersFuel.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLitersFuel.Location = new System.Drawing.Point(62, 132);
            this.labelLitersFuel.Name = "labelLitersFuel";
            this.labelLitersFuel.Size = new System.Drawing.Size(55, 24);
            this.labelLitersFuel.TabIndex = 13;
            this.labelLitersFuel.Text = "liters";
            // 
            // labelMoneyFuel
            // 
            this.labelMoneyFuel.AutoSize = true;
            this.labelMoneyFuel.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoneyFuel.Location = new System.Drawing.Point(45, 178);
            this.labelMoneyFuel.Name = "labelMoneyFuel";
            this.labelMoneyFuel.Size = new System.Drawing.Size(73, 24);
            this.labelMoneyFuel.TabIndex = 13;
            this.labelMoneyFuel.Text = "money";
            // 
            // labelPriceFuel
            // 
            this.labelPriceFuel.AutoSize = true;
            this.labelPriceFuel.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceFuel.Location = new System.Drawing.Point(174, 73);
            this.labelPriceFuel.Name = "labelPriceFuel";
            this.labelPriceFuel.Size = new System.Drawing.Size(56, 24);
            this.labelPriceFuel.TabIndex = 12;
            this.labelPriceFuel.Text = "price";
            // 
            // textBoxLitersFuel
            // 
            this.textBoxLitersFuel.Location = new System.Drawing.Point(124, 136);
            this.textBoxLitersFuel.Name = "textBoxLitersFuel";
            this.textBoxLitersFuel.Size = new System.Drawing.Size(130, 20);
            this.textBoxLitersFuel.TabIndex = 11;
            this.textBoxLitersFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLitersFuel_KeyPress);
            this.textBoxLitersFuel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxLitersFuel_KeyUp);
            // 
            // labelToPayFuel
            // 
            this.labelToPayFuel.AutoSize = true;
            this.labelToPayFuel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToPayFuel.Location = new System.Drawing.Point(175, 206);
            this.labelToPayFuel.Name = "labelToPayFuel";
            this.labelToPayFuel.Size = new System.Drawing.Size(79, 28);
            this.labelToPayFuel.TabIndex = 10;
            this.labelToPayFuel.Text = "To pay";
            // 
            // labelFuelTypes
            // 
            this.labelFuelTypes.AutoSize = true;
            this.labelFuelTypes.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFuelTypes.Location = new System.Drawing.Point(141, 15);
            this.labelFuelTypes.Name = "labelFuelTypes";
            this.labelFuelTypes.Size = new System.Drawing.Size(113, 28);
            this.labelFuelTypes.TabIndex = 8;
            this.labelFuelTypes.Text = "Fuel types";
            // 
            // textBoxToPayFuel
            // 
            this.textBoxToPayFuel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxToPayFuel.Enabled = false;
            this.textBoxToPayFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxToPayFuel.Location = new System.Drawing.Point(38, 237);
            this.textBoxToPayFuel.Multiline = true;
            this.textBoxToPayFuel.Name = "textBoxToPayFuel";
            this.textBoxToPayFuel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxToPayFuel.Size = new System.Drawing.Size(216, 51);
            this.textBoxToPayFuel.TabIndex = 7;
            this.textBoxToPayFuel.Text = "0";
            // 
            // comboBoxFuelTypes
            // 
            this.comboBoxFuelTypes.FormattingEnabled = true;
            this.comboBoxFuelTypes.Location = new System.Drawing.Point(38, 46);
            this.comboBoxFuelTypes.Name = "comboBoxFuelTypes";
            this.comboBoxFuelTypes.Size = new System.Drawing.Size(216, 21);
            this.comboBoxFuelTypes.TabIndex = 6;
            this.comboBoxFuelTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuelTypes_SelectedIndexChanged);
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelTotal.Controls.Add(this.textBoxTotal);
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Location = new System.Drawing.Point(291, 320);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(340, 201);
            this.panelTotal.TabIndex = 5;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotal.Location = new System.Drawing.Point(62, 75);
            this.textBoxTotal.Multiline = true;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTotal.Size = new System.Drawing.Size(216, 51);
            this.textBoxTotal.TabIndex = 12;
            this.textBoxTotal.Text = "0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotal.Location = new System.Drawing.Point(215, 44);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(63, 28);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "Total";
            // 
            // panelCaffe
            // 
            this.panelCaffe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(191)))), ((int)(((byte)(33)))));
            this.panelCaffe.Controls.Add(this.labelCount);
            this.panelCaffe.Controls.Add(this.labelCaffePrice);
            this.panelCaffe.Controls.Add(this.buttonHotDogMinus);
            this.panelCaffe.Controls.Add(this.buttonHotDogPlus);
            this.panelCaffe.Controls.Add(this.textBoxHotDogCount);
            this.panelCaffe.Controls.Add(this.textBoxHotDogPrice);
            this.panelCaffe.Controls.Add(this.checkBoxHotDog);
            this.panelCaffe.Controls.Add(this.textBoxToPayCaffe);
            this.panelCaffe.Controls.Add(this.labelToPayCaffe);
            this.panelCaffe.Location = new System.Drawing.Point(291, 0);
            this.panelCaffe.Name = "panelCaffe";
            this.panelCaffe.Size = new System.Drawing.Size(327, 512);
            this.panelCaffe.TabIndex = 4;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(258, 28);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(55, 19);
            this.labelCount.TabIndex = 27;
            this.labelCount.Text = "Count";
            // 
            // labelCaffePrice
            // 
            this.labelCaffePrice.AutoSize = true;
            this.labelCaffePrice.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaffePrice.Location = new System.Drawing.Point(162, 28);
            this.labelCaffePrice.Name = "labelCaffePrice";
            this.labelCaffePrice.Size = new System.Drawing.Size(46, 19);
            this.labelCaffePrice.TabIndex = 26;
            this.labelCaffePrice.Text = "Price";
            // 
            // buttonHotDogMinus
            // 
            this.buttonHotDogMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHotDogMinus.BackgroundImage")));
            this.buttonHotDogMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHotDogMinus.Location = new System.Drawing.Point(220, 49);
            this.buttonHotDogMinus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHotDogMinus.Name = "buttonHotDogMinus";
            this.buttonHotDogMinus.Size = new System.Drawing.Size(18, 22);
            this.buttonHotDogMinus.TabIndex = 25;
            this.buttonHotDogMinus.UseVisualStyleBackColor = true;
            this.buttonHotDogMinus.Click += new System.EventHandler(this.buttonHotDogMinus_Click);
            // 
            // buttonHotDogPlus
            // 
            this.buttonHotDogPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHotDogPlus.BackgroundImage")));
            this.buttonHotDogPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHotDogPlus.Location = new System.Drawing.Point(299, 49);
            this.buttonHotDogPlus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHotDogPlus.Name = "buttonHotDogPlus";
            this.buttonHotDogPlus.Size = new System.Drawing.Size(18, 22);
            this.buttonHotDogPlus.TabIndex = 24;
            this.buttonHotDogPlus.UseVisualStyleBackColor = true;
            this.buttonHotDogPlus.Click += new System.EventHandler(this.buttonHotDogPlus_Click);
            // 
            // textBoxHotDogCount
            // 
            this.textBoxHotDogCount.Location = new System.Drawing.Point(241, 50);
            this.textBoxHotDogCount.Name = "textBoxHotDogCount";
            this.textBoxHotDogCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxHotDogCount.Size = new System.Drawing.Size(55, 20);
            this.textBoxHotDogCount.TabIndex = 20;
            this.textBoxHotDogCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHotDogCount_KeyPress);
            this.textBoxHotDogCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxHotDogCount_KeyUp);
            // 
            // textBoxHotDogPrice
            // 
            this.textBoxHotDogPrice.Location = new System.Drawing.Point(108, 50);
            this.textBoxHotDogPrice.Name = "textBoxHotDogPrice";
            this.textBoxHotDogPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxHotDogPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxHotDogPrice.TabIndex = 16;
            this.textBoxHotDogPrice.Text = "5";
            this.textBoxHotDogPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHotDogPrice_KeyPress);
            this.textBoxHotDogPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxHotDogPrice_KeyUp);
            // 
            // checkBoxHotDog
            // 
            this.checkBoxHotDog.AutoSize = true;
            this.checkBoxHotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHotDog.Location = new System.Drawing.Point(3, 48);
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.Size = new System.Drawing.Size(73, 17);
            this.checkBoxHotDog.TabIndex = 12;
            this.checkBoxHotDog.Text = "Hot Dog";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            this.checkBoxHotDog.CheckStateChanged += new System.EventHandler(this.checkBoxHotDog_CheckStateChanged);
            // 
            // textBoxToPayCaffe
            // 
            this.textBoxToPayCaffe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxToPayCaffe.Enabled = false;
            this.textBoxToPayCaffe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxToPayCaffe.Location = new System.Drawing.Point(62, 237);
            this.textBoxToPayCaffe.Multiline = true;
            this.textBoxToPayCaffe.Name = "textBoxToPayCaffe";
            this.textBoxToPayCaffe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxToPayCaffe.Size = new System.Drawing.Size(216, 51);
            this.textBoxToPayCaffe.TabIndex = 11;
            this.textBoxToPayCaffe.Text = "0";
            // 
            // labelToPayCaffe
            // 
            this.labelToPayCaffe.AutoSize = true;
            this.labelToPayCaffe.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToPayCaffe.Location = new System.Drawing.Point(199, 206);
            this.labelToPayCaffe.Name = "labelToPayCaffe";
            this.labelToPayCaffe.Size = new System.Drawing.Size(79, 28);
            this.labelToPayCaffe.TabIndex = 10;
            this.labelToPayCaffe.Text = "To pay";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 507);
            this.Controls.Add(this.panelFuel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Gas Station";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelFuel.ResumeLayout(false);
            this.panelFuel.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelCaffe.ResumeLayout(false);
            this.panelCaffe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.TextBox textBoxPriceFuel;
        private System.Windows.Forms.TextBox textBoxMoneyFuel;
        private System.Windows.Forms.Panel panelFuel;
        private System.Windows.Forms.TextBox textBoxToPayFuel;
        private System.Windows.Forms.ComboBox comboBoxFuelTypes;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panelCaffe;
        private System.Windows.Forms.Label labelFuelTypes;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelToPayCaffe;
        private System.Windows.Forms.Label labelToPayFuel;
        private System.Windows.Forms.Label labelLitersFuel;
        private System.Windows.Forms.Label labelMoneyFuel;
        private System.Windows.Forms.Label labelPriceFuel;
        private System.Windows.Forms.TextBox textBoxLitersFuel;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxToPayCaffe;
        private System.Windows.Forms.Button buttonHotDogMinus;
        private System.Windows.Forms.Button buttonHotDogPlus;
        private System.Windows.Forms.TextBox textBoxHotDogCount;
        private System.Windows.Forms.TextBox textBoxHotDogPrice;
        private System.Windows.Forms.CheckBox checkBoxHotDog;
        private System.Windows.Forms.Label labelCaffePrice;
        private System.Windows.Forms.Label labelCount;
    }
}

