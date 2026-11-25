using System.Drawing;
using System.Windows.Forms;

internal sealed class WorkloadForm : Form
{
    public WorkloadForm()
    {
        Text = "Пример нагрузки";
        ClientSize = new Size(440, 190);
        Controls.Add(new Label
        {
            Location = new Point(20, 20),
            AutoSize = true,
            Text = "2025/2026 учебный год\nБазы данных · группа ИС-31\nЛекции: 24 часа. Практика: 36 часов."
        });
        var close = new Button { Text = "Назад", Location = new Point(20, 120), AutoSize = true };
        close.Click += (_, _) => Close();
        Controls.Add(close);
    }
}
