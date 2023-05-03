/*
Файл: Form1.cs
Лабораторная робота № 6
Автор: Положий А. С.
Тема: Розробка та дослідження програми побудови годинника
Дата створення: 20.04.2023
*/

using Timer = System.Windows.Forms.Timer;

namespace Clock_App
{
    public partial class Form1 : Form, IView
    {
        Presenter presenter;
        public Form1()
        {
            InitializeComponent();

            presenter = new Presenter(this);

            Timer.Interval = 1;
            Timer.Start();
        }

        public Timer Timer { get => Timer1; set => Timer1 = value; }
        public PictureBox PicBox { get => PictureBox; set => PictureBox = value; }

        public event EventHandler Tick;
        public event EventHandler SetAttempted;
        public event EventHandler AboutAttempted;

        private void Timer_Tick(object sender, EventArgs e)
        {
            Tick?.Invoke(sender, e);
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutAttempted?.Invoke(sender, e);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SetAttempted?.Invoke(sender, e);
        }
    }
}