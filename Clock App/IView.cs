/*
Файл: IView.cs
Лабораторная робота № 6
Автор: Положий А. С.
Тема: Розробка та дослідження програми побудови годинника
Дата створення: 20.04.2023
*/

using Timer = System.Windows.Forms.Timer;

namespace Clock_App
{
    internal interface IView
    {
        // Timer control.
        Timer Timer { get; set; }

        // Picture box control.
        PictureBox PicBox { get; set; }

        // Buttons.
        event EventHandler SetAttempted;
        event EventHandler AboutAttempted;

        // Other events.
        event EventHandler Tick;
    }
}
