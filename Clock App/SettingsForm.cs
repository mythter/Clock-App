/*
Файл: SettingsForm.cs
Лабораторная робота № 6
Автор: Положий А. С.
Тема: Розробка та дослідження програми побудови годинника
Дата створення: 20.04.2023
*/

namespace Clock_App
{
    public partial class SettingsForm : Form
    {
        public Settings Settings { get; set; }
        public SettingsForm(Settings settings, bool useCustomSettings)
        {
            InitializeComponent();
            Settings = settings;
            OffsetUpDown.Value = Settings.Offset.Hours;
            CheckBox.Checked = useCustomSettings;
        }

        private void BackColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                Settings.BackgroundColor = color.Color;
            }
        }

        private void NumColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                Settings.NumColor = color.Color;
            }
        }

        private void TicksColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                Settings.TicksColor = color.Color;
            }
        }

        private void HourColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                Settings.HourColor = color.Color;
            }
        }

        private void MinuteColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                Settings.MinuteColor = color.Color;
            }
        }

        private void SecondColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                Settings.SecondColor = color.Color;
            }
        }

        private void Offset_Changed(object sender, EventArgs e)
        {
            Settings.Offset = TimeSpan.FromHours((double)OffsetUpDown.Value);
        }

        private void SaveDefBtn_Click(object sender, EventArgs e)
        {
            SaveSettings(new Settings(), false);

        }

        private void SaveCustBtn_Click(object sender, EventArgs e)
        {
            SaveSettings(Settings, true);
        }

        private void SaveSettings(Settings settings, bool isCustom)
        {
            save = new SaveFileDialog();
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FilterIndex = 1;
            save.Title = "Save file";

            save.FileName = isCustom ? "settings_custom" : "settings_default";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string fname = save.FileName;
                using (FileStream fs = new FileStream(fname, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        string color = settings.BackgroundColor.ToString();
                        sw.WriteLine($"Background color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        color = settings.NumColor.ToString();
                        sw.WriteLine($"Numbers color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        color = settings.TicksColor.ToString();
                        sw.WriteLine($"Ticks and bezel color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        color = settings.HourColor.ToString();
                        sw.WriteLine($"Hour color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        color = settings.MinuteColor.ToString();
                        sw.WriteLine($"Minute color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        color = settings.SecondColor.ToString();
                        sw.WriteLine($"Second color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        sw.WriteLine($"Offset: {settings.Offset.Hours}");
                    }
                }
            }
        }
    }
}
