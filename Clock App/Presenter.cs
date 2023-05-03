/*
Файл: Presenter.cs
Лабораторная робота № 6
Автор: Положий А. С.
Тема: Розробка та дослідження програми побудови годинника
Дата створення: 20.04.2023
*/

namespace Clock_App
{
    internal class Presenter
    {
        private readonly IView form;
        Bitmap bmp;
        Graphics gr;
        readonly float WIDTH, HEIGHT, CY, CX;
        AboutForm aboutForm;
        SettingsForm settingsForm;
        Settings settings;
        Settings defaultSettings = new Settings();
        bool useCustomSettings = true;
        public Presenter(IView form)
        {
            this.form = form;

            this.form.Tick += Tick;
            this.form.AboutAttempted += OpenAbout;
            this.form.SetAttempted += OpenSettings;

            WIDTH = this.form.PicBox.Width;
            HEIGHT = this.form.PicBox.Height;
            bmp = new Bitmap((int)WIDTH, (int)HEIGHT);
            CX = WIDTH / 2;
            CY = HEIGHT / 2;

            settings = new Settings();
        }

        private void OpenAbout(object? sender, EventArgs e)
        {
            aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void OpenSettings(object? sender, EventArgs e)
        {
            settingsForm = new SettingsForm(settings, useCustomSettings);
            settingsForm.ShowDialog();

            settings = settingsForm.Settings;
            useCustomSettings = settingsForm.CheckBox.Checked;
        }

        private void Tick(object? sender, EventArgs e)
        {
            gr = Graphics.FromImage(bmp);
            gr.Clear(Color.Transparent);

            /*++++++++++++++++++++ Settings zone ++++++++++++++++++++*/

            // Clock colors.
            Color hrColor;
            Color minColor;
            Color secColor;
            Color circleColor;
            Color ticksColor;
            Color numColor;

            if (useCustomSettings)
            {
                hrColor = settings.HourColor;
                minColor = settings.MinuteColor;
                secColor = settings.SecondColor;
                circleColor = settings.BackgroundColor;
                ticksColor = settings.TicksColor;
                numColor = settings.NumColor;
            }
            else
            {
                hrColor = defaultSettings.HourColor;
                minColor = defaultSettings.MinuteColor;
                secColor = defaultSettings.SecondColor;
                circleColor = defaultSettings.BackgroundColor;
                ticksColor = defaultSettings.TicksColor;
                numColor = defaultSettings.NumColor;
            }

            // Hand lengths.
            float hourLength = settings.HourLength;
            float minLength = settings.MinLength;
            float secLength = settings.SecLength;

            // Hand thicknesses
            float hourThickness = settings.HourThickness;
            float minThickness = settings.MinThickness;
            float secThickness = settings.SecThickness;
            float ticksThickness = settings.TicksThickness;

            // Time offset.
            TimeSpan offset;

            if (useCustomSettings)
                offset = settings.Offset;
            else
                offset = defaultSettings.Offset;

            DateTime dateTime = DateTime.UtcNow + offset;

            /*+++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

            float hour = dateTime.Hour % 12 + (float)dateTime.Minute / 60; // convert 24hrs to 12hrs format
            float minute = dateTime.Minute + (float)dateTime.Second / 60;
            float sec = dateTime.Second + (float)dateTime.Millisecond / 1000;

            float hourRadian = (float)(hour * 360 / 12 * Math.PI / 180);
            float minRadian = (float)(minute * 360 / 60 * Math.PI / 180);
            float secRadian = (float)(sec * 360 / 60 * Math.PI / 180);

            float secStartPointX = (float)(secLength / 9 * System.Math.Sin(secRadian));
            float secStartPointY = (float)(secLength / 9 * System.Math.Cos(secRadian));
                                                     
            float minStartPointX = (float)(minLength / 120 * System.Math.Sin(minRadian));
            float minStartPointY = (float)(minLength / 120 * System.Math.Cos(minRadian));

            float hourStartPointX = (float)(hourLength / 100 * System.Math.Sin(hourRadian));
            float hourStartPointY = (float)(hourLength / 100 * System.Math.Cos(hourRadian));

            float secEndPointX = (float)(secLength * System.Math.Sin(secRadian));
            float secEndPointY = (float)(secLength * System.Math.Cos(secRadian));

            float minEndPointX = (float)(minLength * System.Math.Sin(minRadian));
            float minEndPointY = (float)(minLength * System.Math.Cos(minRadian));

            float hourEndPointX = (float)(hourLength * System.Math.Sin(hourRadian));
            float hourEndPointY = (float)(hourLength * System.Math.Cos(hourRadian));

            gr.FillEllipse(new SolidBrush(circleColor), 0, 0, WIDTH, HEIGHT);

            for (int i = 0; i < 60; i++)
            {
                int temp = 88;
                if (i % 5 == 0) // Draw 5 minute ticks.
                {
                    gr.DrawLine(new Pen(ticksColor, ticksThickness+2),
                      CX +
                      (float)((WIDTH - temp) / 1.50F * System.Math.Sin(i * 6 * Math.PI / 180)),
                      CY -
                      (float)((WIDTH - temp) / 1.50F * System.Math.Cos(i * 6 * Math.PI / 180)),
                      CX +
                      (float)((WIDTH - temp) / 1.62F * System.Math.Sin(i * 6 * Math.PI / 180)),
                      CY -
                      (float)((WIDTH - temp) / 1.62F * System.Math.Cos(i * 6 * Math.PI / 180)));

                    gr.DrawString($"{12 - i/5}".ToString(), new Font("Montserrat", 20), new SolidBrush(numColor),
                      CX - 15 +
                      (float)((WIDTH - temp) / 1.85F * System.Math.Sin((60 - i) * 6 * Math.PI / 180)),
                      CY - 19 -
                      (float)((WIDTH - temp) / 1.85F * System.Math.Cos((60 - i) * 6 * Math.PI / 180)));
                }
                else // draw 1 minute ticks.
                {
                    gr.DrawLine(new Pen(ticksColor, ticksThickness),
                      CX-1 +
                      (float)((WIDTH - temp) / 1.50F * System.Math.Sin(i * 6 * Math.PI / 180)),
                      CY-1 -
                      (float)((WIDTH - temp) / 1.50F * System.Math.Cos(i * 6 * Math.PI / 180)),
                      CX-1 +
                      (float)((WIDTH - temp) / 1.60F * System.Math.Sin(i * 6 * Math.PI / 180)),
                      CY-1 -
                      (float)((WIDTH - temp) / 1.60F * System.Math.Cos(i * 6 * Math.PI / 180)));
                }
            }

            // Draw hour hand.
            gr.DrawLine(new Pen(hrColor, hourThickness),
                        CX - hourStartPointX,
                        CY + hourStartPointY,
                        CX + hourEndPointX,
                        CY - hourEndPointY);
            // Draw minute hand.
            gr.DrawLine(new Pen(minColor, minThickness),
                        CX - minStartPointX,
                        CY + minStartPointY,
                        CX + minEndPointX,
                        CY - minEndPointY);
            // Draw second hand.
            gr.DrawLine(new Pen(secColor, secThickness),
                        CX - secStartPointX,
                        CY + secStartPointY,
                        CX + secEndPointX,
                        CY - secEndPointY);
            // Draw circle of second hand.
            gr.FillEllipse(new SolidBrush(secColor), CX-6, CY-6, 12, 12);
            gr.DrawEllipse(new Pen(ticksColor, 3), 1, 1, WIDTH-3, HEIGHT-3);

            this.form.PicBox.Image = bmp;
            gr.Dispose();
        }

    }
}
