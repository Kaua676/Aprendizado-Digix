// using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Drawing.Drawing2D;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exemplo_2_CF
// {
//     public class Program
//     {
//         [STAThread] // é um atributo que indica que o método Main é um método de thread de nível de aplicativo que é executado em um único thread de aplicativo
//         static void Main()
//         {
//             // Aplication é uma classe que gerencia a execução de um aplicativo Windows Forms
//             Application.EnableVisualStyles(); // Habilita o estilo visual do Windows Forms
//             Application.SetCompatibleTextRenderingDefault(false); // Define o valor padrão para a propriedade TextRenderingDefault de todos os controles do aplicativo, ele faz com que o texto seja renderizado de forma mais nitida
//             Application.Run(new Calculadora()); // Executa o aplicativo Windows Forms com o formulário Form
//         }
//     }

//     public class MeuFormulario : Form
//     {
//         public MeuFormulario()
//         {
//             this.Text = "Meu formulário";
//             this.Size = new Size(300, 300);

//             Label label = new Label();
//             label.Text = "Olá Mundo";
//             label.Location = new Point(100, 100);
//             this.AutoSize = true;

//             this.Controls.Add(label);
//         }
//     }

//     public class Calculadora : Form
//     {
//         private IContainer components = null;
//         private Label label1;
//         private TextBox textBox1;
//         private TextBox textBox2;
//         private Button button1;
//         private RoundedPanel panelPai; // Usando um Panel personalizado

//         public Calculadora()
//         {
//             this.components = new Container();
//             this.AutoScaleMode = AutoScaleMode.Font;
//             this.ClientSize = new Size(800, 450);
//             this.Text = "Calculadora";

//             // Criando o Panel (Container Pai)
//             this.panelPai = new RoundedPanel();
//             this.panelPai.Size = new Size(300, 200);
//             this.panelPai.BackColor = Color.Red;
//             this.Controls.Add(panelPai);

//             // Configurando os controles dentro do Panel
//             this.label1 = new Label();
//             this.label1.AutoSize = true;
//             this.label1.Location = new Point(30, 20);
//             this.label1.Text = "Digite os números:";
//             this.panelPai.Controls.Add(label1);

//             this.textBox1 = new TextBox();
//             this.textBox1.Location = new Point(30, 50);
//             this.textBox1.Size = new Size(200, 27);
//             this.panelPai.Controls.Add(textBox1);

//             this.textBox2 = new TextBox();
//             this.textBox2.Location = new Point(30, 80);
//             this.textBox2.Size = new Size(200, 27);
//             this.panelPai.Controls.Add(textBox2);

//             this.button1 = new Button();
//             this.button1.Location = new Point(30, 110);
//             this.button1.Size = new Size(100, 30);
//             this.button1.Text = "Calcular";
//             this.button1.BackColor = Color.Blue;
//             this.button1.Click += new EventHandler(this.button1_Click);
//             this.panelPai.Controls.Add(button1);

//             // Centraliza o Panel no meio do Form
//             this.panelPai.Location = new Point(
//                 (this.ClientSize.Width - this.panelPai.Width) / 2,
//                 (this.ClientSize.Height - this.panelPai.Height) / 2
//             );

//             // Faz a centralização ser ajustada ao redimensionar a tela
//             this.Resize += new EventHandler(this.Form_Resize);
//         }

//         // Evento para manter o Panel centralizado ao redimensionar o Form
//         private void Form_Resize(object sender, EventArgs e)
//         {
//             this.panelPai.Location = new Point(
//                 (this.ClientSize.Width - this.panelPai.Width) / 2,
//                 (this.ClientSize.Height - this.panelPai.Height) / 2
//             );
//         }

//         public class RoundedPanel : Panel
//         {
//             private int _borderRadius = 30; // Defina o raio da borda

//             protected override void OnPaint(PaintEventArgs e)
//             {
//                 base.OnPaint(e);
//                 GraphicsPath path = new GraphicsPath();
//                 path.AddArc(0, 0, _borderRadius, _borderRadius, 180, 90);
//                 path.AddArc(Width - _borderRadius, 0, _borderRadius, _borderRadius, 270, 90);
//                 path.AddArc(Width - _borderRadius, Height - _borderRadius, _borderRadius, _borderRadius, 0, 90);
//                 path.AddArc(0, Height - _borderRadius, _borderRadius, _borderRadius, 90, 90);
//                 path.CloseFigure();
//                 this.Region = new Region(path);
//             }
//         }

//         private void button1_Click(object sender, EventArgs e)
//         {
//             int num1 = 0;
//             int num2 = 0;

//             try
//             {
//                 num1 = Convert.ToInt32(textBox1.Text);
//                 num2 = Convert.ToInt32(textBox2.Text);

//                 MessageBox.Show("A soma dos numeros é: " + (num1 + num2)
//                 + "\nA subtração dos números é: " + (num1 - num2)
//                 + "\nA multiplicação dos números é: " + (num1 * num2)
//                 + "\nA divisão dos números é: " + (num1 / num2)
//                 );
//             }
//             catch (System.Exception)
//             {
//                 MessageBox.Show("Digite apenas numeros inteiros");
//                 return;
//             }
//         }
//     }
// }