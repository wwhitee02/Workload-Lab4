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
        var open = new Button { Text = "Открыть нагрузку", Location = new Point(20, 65), AutoSize = true };
        open.Click += (_, _) =>
        {
            using var workload = new WorkloadForm();
            workload.ShowDialog(main);
        };
        main.Controls.Add(open);
        Application.Run(main);
    }
}

