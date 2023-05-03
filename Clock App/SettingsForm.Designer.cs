namespace Clock_App
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            BackColor = new Label();
            NumColor = new Label();
            TicksColor = new Label();
            HourColor = new Label();
            MinuteColor = new Label();
            SecondColor = new Label();
            OffsetLabel = new Label();
            BackColorBtn = new Button();
            NumColorBtn = new Button();
            TicksColorBtn = new Button();
            HourColorBtn = new Button();
            MinuteColorBtn = new Button();
            SecondColorBtn = new Button();
            OffsetUpDown = new NumericUpDown();
            ColorDialog = new ColorDialog();
            SaveDefBtn = new Button();
            SaveCustBtn = new Button();
            save = new SaveFileDialog();
            CheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)OffsetUpDown).BeginInit();
            SuspendLayout();
            // 
            // BackColor
            // 
            BackColor.AutoSize = true;
            BackColor.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BackColor.Location = new Point(25, 70);
            BackColor.Name = "BackColor";
            BackColor.Size = new Size(166, 24);
            BackColor.TabIndex = 0;
            BackColor.Text = "Background color";
            // 
            // NumColor
            // 
            NumColor.AutoSize = true;
            NumColor.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            NumColor.Location = new Point(25, 120);
            NumColor.Name = "NumColor";
            NumColor.Size = new Size(138, 24);
            NumColor.TabIndex = 1;
            NumColor.Text = "Numbers color";
            // 
            // TicksColor
            // 
            TicksColor.AutoSize = true;
            TicksColor.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TicksColor.Location = new Point(25, 170);
            TicksColor.Name = "TicksColor";
            TicksColor.Size = new Size(189, 24);
            TicksColor.TabIndex = 2;
            TicksColor.Text = "Ticks and bezel color";
            // 
            // HourColor
            // 
            HourColor.AutoSize = true;
            HourColor.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            HourColor.Location = new Point(25, 220);
            HourColor.Name = "HourColor";
            HourColor.Size = new Size(151, 24);
            HourColor.TabIndex = 3;
            HourColor.Text = "Hour hand color";
            // 
            // MinuteColor
            // 
            MinuteColor.AutoSize = true;
            MinuteColor.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MinuteColor.Location = new Point(25, 270);
            MinuteColor.Name = "MinuteColor";
            MinuteColor.Size = new Size(169, 24);
            MinuteColor.TabIndex = 4;
            MinuteColor.Text = "Minute hand color";
            // 
            // SecondColor
            // 
            SecondColor.AutoSize = true;
            SecondColor.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SecondColor.Location = new Point(25, 320);
            SecondColor.Name = "SecondColor";
            SecondColor.Size = new Size(173, 24);
            SecondColor.TabIndex = 5;
            SecondColor.Text = "Second hand color";
            // 
            // OffsetLabel
            // 
            OffsetLabel.AutoSize = true;
            OffsetLabel.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            OffsetLabel.Location = new Point(25, 370);
            OffsetLabel.Name = "OffsetLabel";
            OffsetLabel.Size = new Size(61, 24);
            OffsetLabel.TabIndex = 6;
            OffsetLabel.Text = "Offset";
            // 
            // BackColorBtn
            // 
            BackColorBtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BackColorBtn.Location = new Point(227, 65);
            BackColorBtn.Name = "BackColorBtn";
            BackColorBtn.Size = new Size(120, 35);
            BackColorBtn.TabIndex = 7;
            BackColorBtn.Text = "Select";
            BackColorBtn.UseVisualStyleBackColor = true;
            BackColorBtn.Click += BackColorBtn_Click;
            // 
            // NumColorBtn
            // 
            NumColorBtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            NumColorBtn.Location = new Point(227, 115);
            NumColorBtn.Name = "NumColorBtn";
            NumColorBtn.Size = new Size(120, 35);
            NumColorBtn.TabIndex = 8;
            NumColorBtn.Text = "Select";
            NumColorBtn.UseVisualStyleBackColor = true;
            NumColorBtn.Click += NumColorBtn_Click;
            // 
            // TicksColorBtn
            // 
            TicksColorBtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TicksColorBtn.Location = new Point(227, 165);
            TicksColorBtn.Name = "TicksColorBtn";
            TicksColorBtn.Size = new Size(120, 35);
            TicksColorBtn.TabIndex = 9;
            TicksColorBtn.Text = "Select";
            TicksColorBtn.UseVisualStyleBackColor = true;
            TicksColorBtn.Click += TicksColorBtn_Click;
            // 
            // HourColorBtn
            // 
            HourColorBtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            HourColorBtn.Location = new Point(227, 215);
            HourColorBtn.Name = "HourColorBtn";
            HourColorBtn.Size = new Size(120, 35);
            HourColorBtn.TabIndex = 10;
            HourColorBtn.Text = "Select";
            HourColorBtn.UseVisualStyleBackColor = true;
            HourColorBtn.Click += HourColorBtn_Click;
            // 
            // MinuteColorBtn
            // 
            MinuteColorBtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MinuteColorBtn.Location = new Point(227, 265);
            MinuteColorBtn.Name = "MinuteColorBtn";
            MinuteColorBtn.Size = new Size(120, 35);
            MinuteColorBtn.TabIndex = 11;
            MinuteColorBtn.Text = "Select";
            MinuteColorBtn.UseVisualStyleBackColor = true;
            MinuteColorBtn.Click += MinuteColorBtn_Click;
            // 
            // SecondColorBtn
            // 
            SecondColorBtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SecondColorBtn.Location = new Point(227, 315);
            SecondColorBtn.Name = "SecondColorBtn";
            SecondColorBtn.Size = new Size(120, 35);
            SecondColorBtn.TabIndex = 12;
            SecondColorBtn.Text = "Select";
            SecondColorBtn.UseVisualStyleBackColor = true;
            SecondColorBtn.Click += SecondColorBtn_Click;
            // 
            // OffsetUpDown
            // 
            OffsetUpDown.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            OffsetUpDown.Location = new Point(227, 368);
            OffsetUpDown.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            OffsetUpDown.Minimum = new decimal(new int[] { 12, 0, 0, int.MinValue });
            OffsetUpDown.Name = "OffsetUpDown";
            OffsetUpDown.Size = new Size(120, 28);
            OffsetUpDown.TabIndex = 13;
            OffsetUpDown.ValueChanged += Offset_Changed;
            // 
            // SaveDefBtn
            // 
            SaveDefBtn.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDefBtn.Location = new Point(25, 423);
            SaveDefBtn.Name = "SaveDefBtn";
            SaveDefBtn.Size = new Size(138, 56);
            SaveDefBtn.TabIndex = 14;
            SaveDefBtn.Text = "Save default settings";
            SaveDefBtn.UseVisualStyleBackColor = true;
            SaveDefBtn.Click += SaveDefBtn_Click;
            // 
            // SaveCustBtn
            // 
            SaveCustBtn.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCustBtn.Location = new Point(209, 423);
            SaveCustBtn.Name = "SaveCustBtn";
            SaveCustBtn.Size = new Size(138, 56);
            SaveCustBtn.TabIndex = 15;
            SaveCustBtn.Text = "Save custom settings";
            SaveCustBtn.UseVisualStyleBackColor = true;
            SaveCustBtn.Click += SaveCustBtn_Click;
            // 
            // CheckBox
            // 
            CheckBox.AutoSize = true;
            CheckBox.Checked = true;
            CheckBox.CheckState = CheckState.Checked;
            CheckBox.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBox.Location = new Point(25, 20);
            CheckBox.Name = "CheckBox";
            CheckBox.Size = new Size(188, 28);
            CheckBox.TabIndex = 16;
            CheckBox.Text = "Use custom colors";
            CheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 499);
            Controls.Add(CheckBox);
            Controls.Add(SaveCustBtn);
            Controls.Add(SaveDefBtn);
            Controls.Add(OffsetUpDown);
            Controls.Add(SecondColorBtn);
            Controls.Add(MinuteColorBtn);
            Controls.Add(HourColorBtn);
            Controls.Add(TicksColorBtn);
            Controls.Add(NumColorBtn);
            Controls.Add(BackColorBtn);
            Controls.Add(OffsetLabel);
            Controls.Add(SecondColor);
            Controls.Add(MinuteColor);
            Controls.Add(HourColor);
            Controls.Add(TicksColor);
            Controls.Add(NumColor);
            Controls.Add(BackColor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SettingsForm";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)OffsetUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BackColor;
        private Label NumColor;
        private Label TicksColor;
        private Label HourColor;
        private Label MinuteColor;
        private Label SecondColor;
        private Label OffsetLabel;
        private Button BackColorBtn;
        private Button NumColorBtn;
        private Button TicksColorBtn;
        private Button HourColorBtn;
        private Button MinuteColorBtn;
        private Button SecondColorBtn;
        private NumericUpDown OffsetUpDown;
        private ColorDialog ColorDialog;
        private Button SaveDefBtn;
        private Button SaveCustBtn;
        private SaveFileDialog save;
        public CheckBox CheckBox;
    }
}