using System;
using System.Drawing;
using System.Windows.Forms;

public class MainForm : Form
{
    private Panel menuPanel;
    private Button btnHome, btnConfig, btnSobre;
    private Panel contentPanel;

    public MainForm()
    {
        // Configuração da Janela Principal
        this.Text = "Navegação";
        this.Size = new Size(800, 500);

        // Painel Lateral (Menu)
        menuPanel = new Panel();
        menuPanel.Size = new Size(200, this.ClientSize.Height);
        menuPanel.BackColor = Color.LightGray;
        this.Controls.Add(menuPanel);

        // Painel de Conteúdo (Onde as "telas" aparecerão)
        contentPanel = new Panel();
        contentPanel.Size = new Size(600, this.ClientSize.Height);
        contentPanel.Location = new Point(200, 0);
        this.Controls.Add(contentPanel);



        // Botão Home
        btnHome = new Button();
        btnHome.Text = "🏠 Home";
        btnHome.Size = new Size(180, 40);
        btnHome.Location = new Point(10, 20);
        btnHome.Click += (s, e) => ShowScreen(new HomeScreen());
        menuPanel.Controls.Add(btnHome);

        // Botão Configurações
        btnConfig = new Button();
        btnConfig.Text = "⚙️ Configurações";
        btnConfig.Size = new Size(180, 40);
        btnConfig.Location = new Point(10, 70);
        btnConfig.Click += (s, e) => ShowScreen(new ConfigScreen());
        menuPanel.Controls.Add(btnConfig);

        // Botão Sobre
        btnSobre = new Button();
        btnSobre.Text = "ℹ️ Sobre";
        btnSobre.Size = new Size(180, 40);
        btnSobre.Location = new Point(10, 120);
        btnSobre.Click += (s, e) => ShowScreen(new SobreScreen());
        menuPanel.Controls.Add(btnSobre);

        // Exibe a tela inicial (Home)
        ShowScreen(new HomeScreen());
    }

    private void ShowScreen(UserControl screen)
    {
        contentPanel.Controls.Clear();
        screen.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(screen);
    }

    // Tela "Home"
    private class HomeScreen : UserControl
    {
        private Panel panelPai;
        private Label label1;
        private TextBox textBox1, textBox2;
        private Button button1;

        public HomeScreen()
        {
            this.BackColor = Color.White;

            // Criando o Panel (Container Pai)
            this.panelPai = new Panel();
            this.panelPai.Size = new Size(300, 200);
            this.panelPai.BackColor = Color.Red;
            this.panelPai.Location = new Point(50, 50);
            this.Controls.Add(panelPai);

            // Configurando os controles dentro do Panel
            this.label1 = new Label();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(30, 20);
            this.label1.Text = "Digite os números:";
            this.panelPai.Controls.Add(label1);

            this.textBox1 = new TextBox();
            this.textBox1.Location = new Point(30, 50);
            this.textBox1.Size = new Size(200, 27);
            this.panelPai.Controls.Add(textBox1);

            this.textBox2 = new TextBox();
            this.textBox2.Location = new Point(30, 80);
            this.textBox2.Size = new Size(200, 27);
            this.panelPai.Controls.Add(textBox2);

            this.button1 = new Button();
            this.button1.Location = new Point(30, 110);
            this.button1.Size = new Size(100, 30);
            this.button1.Text = "Calcular";
            this.button1.BackColor = Color.Blue;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.panelPai.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;

            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);

                MessageBox.Show("A soma dos numeros é: " + (num1 + num2)
                + "\nA subtração dos números é: " + (num1 - num2)
                + "\nA multiplicação dos números é: " + (num1 * num2)
                + "\nA divisão dos números é: " + (num1 / num2)
                );
            }
            catch (System.Exception)
            {
                MessageBox.Show("Digite apenas numeros inteiros");
                return;
            }
        }
    }


    // Tela "Configurações"
    private class ConfigScreen : UserControl
    {
        public ConfigScreen()
        {
            this.BackColor = Color.LightBlue;
            Label lbl = new Label { Text = "⚙️ Configurações", AutoSize = true, Location = new Point(20, 20) };
            this.Controls.Add(lbl);
        }
    }

    // Tela "Sobre"
    private class SobreScreen : UserControl
    {
        public SobreScreen()
        {
            this.BackColor = Color.LightGreen;
            Label lbl = new Label { Text = "ℹ️ Sobre", AutoSize = true, Location = new Point(20, 20) };
            this.Controls.Add(lbl);
        }
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MainForm());
    }
}
