namespace Exemplo_1_WF_IDE;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label label1; // Criação de um atributo com tipo de uma classe especifica para texto
    private System.Windows.Forms.TextBox textBox1; // Criação de um atributo com tipo de uma classe especifica para entrada de texto (input)
    private System.Windows.Forms.Button button1; // Criação de um atributo com tipo de uma classe especifica para botão


    private System.Windows.Forms.TextBox textBox2;





    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Calculadora";

        // Inicializar as variaveis criadas com instâncias de suas classes
        this.label1 = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.button1 = new System.Windows.Forms.Button();
        this.textBox2 = new System.Windows.Forms.TextBox();

        // Configuração do label1
        this.label1.AutoSize = true; // Ajusta o tamanho do label de acordo com o texto
        this.label1.Location = new System.Drawing.Point(30, 30); // Define a posição do label
        this.label1.Name = "label1"; // Define o nome do label
        this.label1.Size = new System.Drawing.Size(90, 20); // Define o tamanho do label
        this.label1.Text = "Digite um numero: "; // Define o texto do label

        this.Controls.Add(label1);

        // Configuração do textBox1
        this.textBox1.Location = new System.Drawing.Point(30, 60); // Define a posição do text box
        this.textBox1.Name = "textBox1"; // Define o nome do text box
        this.textBox1.Size = new System.Drawing.Size(100, 20); // Define o tamanho do text box

        this.Controls.Add(textBox1);

        // Configuração do botão
        this.button1.Location = new System.Drawing.Point(115, 100); // Define a posição do button1
        this.button1.Name = "button1"; // Define o nome do button1
        this.button1.Size = new System.Drawing.Size(100, 30); // Define o tamanho do button1
        this.button1.Text = "Clique aqui"; // Define o texto do button
        this.button1.Click += new System.EventHandler(this.button1_Click); // Define o evento de clique do botão, esse button1_Click é um metodo que será criado para tratar o evento de clique do botão.

        this.Controls.Add(button1);





        // Configuração textBox2
        this.textBox2.Location = new System.Drawing.Point(200, 60); // Define a posição do text box
        this.textBox2.Name = "textBox2"; // Define o nome do text box
        this.textBox2.Size = new System.Drawing.Size(100, 20); // Define o tamanho do text box

        this.Controls.Add(textBox2);

    }

    #endregion
}
