using System.Drawing;
using System.Windows.Forms;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        using var main = new Form { Text = "Учебная нагрузка", ClientSize = new Size(460, 210) };
        var title = new Label { Text = "Распределение нагрузки преподавателей", AutoSize = true, Location = new Point(20, 24) };
        main.Controls.Add(title);
        Application.Run(main);
    }
}
