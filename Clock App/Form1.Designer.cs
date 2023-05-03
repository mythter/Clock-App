namespace Clock_App
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SettingsBtn = new Button();
            PictureBox = new PictureBox();
            Timer1 = new System.Windows.Forms.Timer(components);
            AboutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // SettingsBtn
            // 
            SettingsBtn.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsBtn.Location = new Point(41, 380);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(150, 60);
            SettingsBtn.TabIndex = 0;
            SettingsBtn.Text = "Settings";
            SettingsBtn.UseVisualStyleBackColor = true;
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // PictureBox
            // 
            PictureBox.Location = new Point(66, 12);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(350, 350);
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            // 
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 1000;
            Timer1.Tick += Timer_Tick;
            // 
            // AboutBtn
            // 
            AboutBtn.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AboutBtn.Location = new Point(292, 380);
            AboutBtn.Name = "AboutBtn";
            AboutBtn.Size = new Size(150, 60);
            AboutBtn.TabIndex = 2;
            AboutBtn.Text = "About";
            AboutBtn.UseVisualStyleBackColor = true;
            AboutBtn.Click += AboutBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(AboutBtn);
            Controls.Add(PictureBox);
            Controls.Add(SettingsBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Clock App";
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SettingsBtn;
        private PictureBox PictureBox;
        private System.Windows.Forms.Timer Timer1;
        private Button AboutBtn;
    }
}