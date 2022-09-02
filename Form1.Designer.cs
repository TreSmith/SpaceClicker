namespace SpaceClicker
{
    partial class SpaceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.moneyButton = new System.Windows.Forms.Button();
            this.creditsTxtBox = new System.Windows.Forms.TextBox();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.gamerTime = new System.Windows.Forms.Timer(this.components);
            this.shuttleButton = new System.Windows.Forms.Button();
            this.shuttleLabel = new System.Windows.Forms.Label();
            this.fighterButton = new System.Windows.Forms.Button();
            this.fighterLabel = new System.Windows.Forms.Label();
            this.haulerButton = new System.Windows.Forms.Button();
            this.haulerLabel = new System.Windows.Forms.Label();
            this.shipButton = new System.Windows.Forms.Button();
            this.shipLabel = new System.Windows.Forms.Label();
            this.shipPicture = new System.Windows.Forms.PictureBox();
            this.planetPicture = new System.Windows.Forms.PictureBox();
            this.exoticButton = new System.Windows.Forms.Button();
            this.exoticLabel = new System.Windows.Forms.Label();
            this.freighterLabel = new System.Windows.Forms.Label();
            this.freighterButton = new System.Windows.Forms.Button();
            this.planetButton = new System.Windows.Forms.Button();
            this.planetLabel = new System.Windows.Forms.Label();
            this.shuttleTimer = new System.Windows.Forms.Timer(this.components);
            this.fighterTimer = new System.Windows.Forms.Timer(this.components);
            this.haulerTimer = new System.Windows.Forms.Timer(this.components);
            this.exoticShipTimer = new System.Windows.Forms.Timer(this.components);
            this.freighterTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.shipPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // moneyButton
            // 
            this.moneyButton.Location = new System.Drawing.Point(32, 25);
            this.moneyButton.Name = "moneyButton";
            this.moneyButton.Size = new System.Drawing.Size(172, 73);
            this.moneyButton.TabIndex = 0;
            this.moneyButton.Text = "Click Me!!!!";
            this.moneyButton.UseVisualStyleBackColor = true;
            this.moneyButton.Click += new System.EventHandler(this.moneyButton_Click);
            // 
            // creditsTxtBox
            // 
            this.creditsTxtBox.Location = new System.Drawing.Point(624, 75);
            this.creditsTxtBox.Name = "creditsTxtBox";
            this.creditsTxtBox.ReadOnly = true;
            this.creditsTxtBox.Size = new System.Drawing.Size(264, 23);
            this.creditsTxtBox.TabIndex = 1;
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(625, 44);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(47, 15);
            this.creditsLabel.TabIndex = 2;
            this.creditsLabel.Text = "Credits:";
            // 
            // gameTime
            // 
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // gamerTime
            // 
            this.gamerTime.Interval = 10;
            this.gamerTime.Tick += new System.EventHandler(this.gamerTime_Tick);
            // 
            // shuttleButton
            // 
            this.shuttleButton.Location = new System.Drawing.Point(36, 131);
            this.shuttleButton.Name = "shuttleButton";
            this.shuttleButton.Size = new System.Drawing.Size(75, 23);
            this.shuttleButton.TabIndex = 3;
            this.shuttleButton.Text = "button1";
            this.shuttleButton.UseVisualStyleBackColor = true;
            this.shuttleButton.Click += new System.EventHandler(this.shuttleButton_Click);
            // 
            // shuttleLabel
            // 
            this.shuttleLabel.AutoSize = true;
            this.shuttleLabel.Location = new System.Drawing.Point(128, 135);
            this.shuttleLabel.Name = "shuttleLabel";
            this.shuttleLabel.Size = new System.Drawing.Size(38, 15);
            this.shuttleLabel.TabIndex = 4;
            this.shuttleLabel.Text = "label1";
            // 
            // fighterButton
            // 
            this.fighterButton.Location = new System.Drawing.Point(36, 176);
            this.fighterButton.Name = "fighterButton";
            this.fighterButton.Size = new System.Drawing.Size(75, 23);
            this.fighterButton.TabIndex = 5;
            this.fighterButton.Text = "button2";
            this.fighterButton.UseVisualStyleBackColor = true;
            this.fighterButton.Click += new System.EventHandler(this.fighterButton_Click);
            // 
            // fighterLabel
            // 
            this.fighterLabel.AutoSize = true;
            this.fighterLabel.Location = new System.Drawing.Point(129, 181);
            this.fighterLabel.Name = "fighterLabel";
            this.fighterLabel.Size = new System.Drawing.Size(38, 15);
            this.fighterLabel.TabIndex = 6;
            this.fighterLabel.Text = "label2";
            // 
            // haulerButton
            // 
            this.haulerButton.Location = new System.Drawing.Point(36, 220);
            this.haulerButton.Name = "haulerButton";
            this.haulerButton.Size = new System.Drawing.Size(75, 23);
            this.haulerButton.TabIndex = 7;
            this.haulerButton.Text = "button3";
            this.haulerButton.UseVisualStyleBackColor = true;
            this.haulerButton.Click += new System.EventHandler(this.haulerButton_Click);
            // 
            // haulerLabel
            // 
            this.haulerLabel.AutoSize = true;
            this.haulerLabel.Location = new System.Drawing.Point(128, 225);
            this.haulerLabel.Name = "haulerLabel";
            this.haulerLabel.Size = new System.Drawing.Size(38, 15);
            this.haulerLabel.TabIndex = 8;
            this.haulerLabel.Text = "label3";
            // 
            // shipButton
            // 
            this.shipButton.Location = new System.Drawing.Point(715, 203);
            this.shipButton.Name = "shipButton";
            this.shipButton.Size = new System.Drawing.Size(75, 23);
            this.shipButton.TabIndex = 9;
            this.shipButton.Text = "button4";
            this.shipButton.UseVisualStyleBackColor = true;
            this.shipButton.Click += new System.EventHandler(this.shipButton_Click);
            // 
            // shipLabel
            // 
            this.shipLabel.AutoSize = true;
            this.shipLabel.Location = new System.Drawing.Point(726, 504);
            this.shipLabel.Name = "shipLabel";
            this.shipLabel.Size = new System.Drawing.Size(38, 15);
            this.shipLabel.TabIndex = 10;
            this.shipLabel.Text = "label4";
            // 
            // shipPicture
            // 
            this.shipPicture.Location = new System.Drawing.Point(625, 241);
            this.shipPicture.Name = "shipPicture";
            this.shipPicture.Size = new System.Drawing.Size(250, 250);
            this.shipPicture.TabIndex = 11;
            this.shipPicture.TabStop = false;
            // 
            // planetPicture
            // 
            this.planetPicture.Location = new System.Drawing.Point(351, 241);
            this.planetPicture.Name = "planetPicture";
            this.planetPicture.Size = new System.Drawing.Size(250, 250);
            this.planetPicture.TabIndex = 12;
            this.planetPicture.TabStop = false;
            // 
            // exoticButton
            // 
            this.exoticButton.Location = new System.Drawing.Point(36, 268);
            this.exoticButton.Name = "exoticButton";
            this.exoticButton.Size = new System.Drawing.Size(75, 23);
            this.exoticButton.TabIndex = 13;
            this.exoticButton.Text = "button5";
            this.exoticButton.UseVisualStyleBackColor = true;
            this.exoticButton.Click += new System.EventHandler(this.exoticButton_Click);
            // 
            // exoticLabel
            // 
            this.exoticLabel.AutoSize = true;
            this.exoticLabel.Location = new System.Drawing.Point(127, 272);
            this.exoticLabel.Name = "exoticLabel";
            this.exoticLabel.Size = new System.Drawing.Size(38, 15);
            this.exoticLabel.TabIndex = 14;
            this.exoticLabel.Text = "label5";
            // 
            // freighterLabel
            // 
            this.freighterLabel.AutoSize = true;
            this.freighterLabel.Location = new System.Drawing.Point(127, 322);
            this.freighterLabel.Name = "freighterLabel";
            this.freighterLabel.Size = new System.Drawing.Size(38, 15);
            this.freighterLabel.TabIndex = 16;
            this.freighterLabel.Text = "label6";
            // 
            // freighterButton
            // 
            this.freighterButton.Location = new System.Drawing.Point(36, 318);
            this.freighterButton.Name = "freighterButton";
            this.freighterButton.Size = new System.Drawing.Size(75, 23);
            this.freighterButton.TabIndex = 15;
            this.freighterButton.Text = "button6";
            this.freighterButton.UseVisualStyleBackColor = true;
            this.freighterButton.Click += new System.EventHandler(this.freighterButton_Click);
            // 
            // planetButton
            // 
            this.planetButton.Location = new System.Drawing.Point(436, 203);
            this.planetButton.Name = "planetButton";
            this.planetButton.Size = new System.Drawing.Size(75, 23);
            this.planetButton.TabIndex = 17;
            this.planetButton.Text = "button1";
            this.planetButton.UseVisualStyleBackColor = true;
            this.planetButton.Click += new System.EventHandler(this.planetButton_Click);
            // 
            // planetLabel
            // 
            this.planetLabel.AutoSize = true;
            this.planetLabel.Location = new System.Drawing.Point(451, 501);
            this.planetLabel.Name = "planetLabel";
            this.planetLabel.Size = new System.Drawing.Size(38, 15);
            this.planetLabel.TabIndex = 18;
            this.planetLabel.Text = "label1";
            // 
            // shuttleTimer
            // 
            this.shuttleTimer.Interval = 2000;
            this.shuttleTimer.Tick += new System.EventHandler(this.shuttleTimer_Tick);
            // 
            // fighterTimer
            // 
            this.fighterTimer.Interval = 5000;
            this.fighterTimer.Tick += new System.EventHandler(this.fighterTimer_Tick);
            // 
            // haulerTimer
            // 
            this.haulerTimer.Interval = 10000;
            this.haulerTimer.Tick += new System.EventHandler(this.haulerTimer_Tick);
            // 
            // exoticShipTimer
            // 
            this.exoticShipTimer.Interval = 15000;
            this.exoticShipTimer.Tick += new System.EventHandler(this.exoticShipTimer_Tick);
            // 
            // freighterTimer
            // 
            this.freighterTimer.Interval = 20000;
            this.freighterTimer.Tick += new System.EventHandler(this.freighterTimer_Tick);
            // 
            // SpaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 576);
            this.Controls.Add(this.planetLabel);
            this.Controls.Add(this.planetButton);
            this.Controls.Add(this.freighterLabel);
            this.Controls.Add(this.freighterButton);
            this.Controls.Add(this.exoticLabel);
            this.Controls.Add(this.exoticButton);
            this.Controls.Add(this.planetPicture);
            this.Controls.Add(this.shipPicture);
            this.Controls.Add(this.shipLabel);
            this.Controls.Add(this.shipButton);
            this.Controls.Add(this.haulerLabel);
            this.Controls.Add(this.haulerButton);
            this.Controls.Add(this.fighterLabel);
            this.Controls.Add(this.fighterButton);
            this.Controls.Add(this.shuttleLabel);
            this.Controls.Add(this.shuttleButton);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.creditsTxtBox);
            this.Controls.Add(this.moneyButton);
            this.Name = "SpaceForm";
            this.Text = "SpaceClicker!";
            this.Load += new System.EventHandler(this.SpaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shipPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button moneyButton;
        private TextBox creditsTxtBox;
        private Label creditsLabel;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Timer gamerTime;
        private Button shuttleButton;
        private Label shuttleLabel;
        private Button fighterButton;
        private Label fighterLabel;
        private Button haulerButton;
        private Label haulerLabel;
        private Button shipButton;
        private Label shipLabel;
        private PictureBox shipPicture;
        private PictureBox planetPicture;
        private Button exoticButton;
        private Label exoticLabel;
        private Label freighterLabel;
        private Button freighterButton;
        private Button planetButton;
        private Label planetLabel;
        private System.Windows.Forms.Timer shuttleTimer;
        private System.Windows.Forms.Timer fighterTimer;
        private System.Windows.Forms.Timer haulerTimer;
        private System.Windows.Forms.Timer exoticShipTimer;
        private System.Windows.Forms.Timer freighterTimer;
    }
}