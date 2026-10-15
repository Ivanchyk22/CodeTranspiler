namespace TRANSPILER_FORM_APP;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
        // 1. Створення об'єктів
        this.Button1 = new System.Windows.Forms.Button();
        this.Combobox1 = new System.Windows.Forms.ComboBox();
        this.Combobox2 = new System.Windows.Forms.ComboBox();
        this.SuspendLayout();

        // 
        // Button1
        // 
        this.Button1.Location = new System.Drawing.Point(50, 50);
        this.Button1.Name = "TranspileButton";
        this.Button1.Size = new System.Drawing.Size(120, 30);
        this.Button1.Text = "Transpile";

        // 
        // Combobox1 (Вихідна мова)
        // 
        this.Combobox1.Location = new System.Drawing.Point(50, 100);
        this.Combobox1.Name = "SourceLanguageCombo";
        this.Combobox1.Size = new System.Drawing.Size(150, 23);

        // 
        // Combobox2 (Цільова мова)
        // 
        this.Combobox2.Location = new System.Drawing.Point(400, 100);
        this.Combobox2.Name = "TargetLanguageCombo";
        this.Combobox2.Size = new System.Drawing.Size(150, 23);

        // 
        // Form1
        // 
        this.MinimumSize = new System.Drawing.Size(400, 300);
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        // 1. Поле для вставки коду
        TextBox txtInputCode = new TextBox();
        txtInputCode.Location = new Point(20, 20);
        txtInputCode.Size = new Size(300, 200);
        txtInputCode.Multiline = true; // Робимо багаторядковим
        txtInputCode.ScrollBars = ScrollBars.Vertical; // Додаємо вертикальну прокрутку

        // 2. Поле для виведення перекладу
        txtInputCode.Location = new Point(50, 130);
        TextBox txtOutputTranslation = new TextBox();
        txtOutputTranslation.Location = new Point(400, 130);
        txtOutputTranslation.Size = new Size(300, 200);
        txtOutputTranslation.Multiline = true;
        txtOutputTranslation.ScrollBars = ScrollBars.Vertical;
        txtOutputTranslation.ReadOnly = true; // Тільки для читання

        // 3. Додаємо обидва поля на форму
        this.Controls.Add(txtInputCode);
        this.Controls.Add(txtOutputTranslation);
        
        // Обов'язкове додавання елементів на форму
        this.Controls.Add(this.Button1);
        this.Controls.Add(this.Combobox1);
        this.Controls.Add(this.Combobox2);

        this.Name = "Form1";
        this.Text = "Transpiler Form";
        this.ResumeLayout(false);
    }
    #endregion

    // Оголошення полів елементів
    private System.Windows.Forms.Button Button1;
    private System.Windows.Forms.ComboBox Combobox1;
    private System.Windows.Forms.ComboBox Combobox2; 
}