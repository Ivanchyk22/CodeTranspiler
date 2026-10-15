namespace TRANSPILER_FORM_APP;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        // Додаємо елементи у випадаючі списки
        Combobox1.Items.AddRange(new string[] { "C#", "Python", "JavaScript" });
        Combobox2.Items.AddRange(new string[] { "Python", "C#", "C++" });

        // Встановлюємо значення за замовчуванням (перший елемент зі списку)
        Combobox1.SelectedIndex = 0;
        Combobox2.SelectedIndex = 0;
    }
}