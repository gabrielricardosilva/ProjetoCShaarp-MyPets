
namespace Controle_de_Fluxo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFolhaDePagamento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.rdbPlanoDeSaude = new System.Windows.Forms.CheckBox();
            this.lblClubeDeLazer = new System.Windows.Forms.Label();
            this.cbbClubeDeLazer = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblImpostoRenda = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFolhaDePagamento
            // 
            this.lblFolhaDePagamento.AutoSize = true;
            this.lblFolhaDePagamento.Location = new System.Drawing.Point(86, 62);
            this.lblFolhaDePagamento.Name = "lblFolhaDePagamento";
            this.lblFolhaDePagamento.Size = new System.Drawing.Size(79, 15);
            this.lblFolhaDePagamento.TabIndex = 0;
            this.lblFolhaDePagamento.Text = "Data da Folha";
            this.lblFolhaDePagamento.Click += new System.EventHandler(this.lblFolhaDePagamento_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(86, 126);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 15);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário";
            this.lblSalario.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(86, 144);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 23);
            this.txtSalario.TabIndex = 2;
            this.txtSalario.TextChanged += new System.EventHandler(this.S);
            this.txtSalario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalario_KeyDown);
            // 
            // rdbPlanoDeSaude
            // 
            this.rdbPlanoDeSaude.AutoSize = true;
            this.rdbPlanoDeSaude.Location = new System.Drawing.Point(86, 189);
            this.rdbPlanoDeSaude.Name = "rdbPlanoDeSaude";
            this.rdbPlanoDeSaude.Size = new System.Drawing.Size(107, 19);
            this.rdbPlanoDeSaude.TabIndex = 3;
            this.rdbPlanoDeSaude.Text = "Plano de Saude";
            this.rdbPlanoDeSaude.UseVisualStyleBackColor = true;
            // 
            // lblClubeDeLazer
            // 
            this.lblClubeDeLazer.AutoSize = true;
            this.lblClubeDeLazer.Location = new System.Drawing.Point(86, 229);
            this.lblClubeDeLazer.Name = "lblClubeDeLazer";
            this.lblClubeDeLazer.Size = new System.Drawing.Size(84, 15);
            this.lblClubeDeLazer.TabIndex = 5;
            this.lblClubeDeLazer.Text = "Clube de Lazer";
            // 
            // cbbClubeDeLazer
            // 
            this.cbbClubeDeLazer.FormattingEnabled = true;
            this.cbbClubeDeLazer.Items.AddRange(new object[] {
            "Clube A",
            "Clube B",
            "Clube c"});
            this.cbbClubeDeLazer.Location = new System.Drawing.Point(86, 247);
            this.cbbClubeDeLazer.Name = "cbbClubeDeLazer";
            this.cbbClubeDeLazer.Size = new System.Drawing.Size(145, 23);
            this.cbbClubeDeLazer.TabIndex = 4;
            this.cbbClubeDeLazer.SelectedIndexChanged += new System.EventHandler(this.cbbClubeDeLazer_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(440, 49);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(130, 41);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Location = new System.Drawing.Point(440, 125);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(74, 15);
            this.lblSalarioFolha.TabIndex = 8;
            this.lblSalarioFolha.Text = "Salario Folha";
            // 
            // lblImpostoRenda
            // 
            this.lblImpostoRenda.AutoSize = true;
            this.lblImpostoRenda.Location = new System.Drawing.Point(440, 177);
            this.lblImpostoRenda.Name = "lblImpostoRenda";
            this.lblImpostoRenda.Size = new System.Drawing.Size(103, 15);
            this.lblImpostoRenda.TabIndex = 9;
            this.lblImpostoRenda.Text = "Imposto de Renda";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(440, 224);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(85, 15);
            this.lblSalarioLiquido.TabIndex = 10;
            this.lblSalarioLiquido.Text = "Salario Liquido";
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Location = new System.Drawing.Point(549, 122);
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(145, 23);
            this.txtSalarioFolha.TabIndex = 5;
            this.txtSalarioFolha.TextChanged += new System.EventHandler(this.txtSalarioFolha_TextChanged);
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Location = new System.Drawing.Point(549, 174);
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(145, 23);
            this.txtImpostoRenda.TabIndex = 6;
            this.txtImpostoRenda.TextChanged += new System.EventHandler(this.txtImpostoRenda_TextChanged);
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(549, 221);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(145, 23);
            this.txtSalarioLiquido.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtImpostoRenda);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblImpostoRenda);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbbClubeDeLazer);
            this.Controls.Add(this.lblClubeDeLazer);
            this.Controls.Add(this.rdbPlanoDeSaude);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFolhaDePagamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolhaDePagamento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.CheckBox rdbPlanoDeSaude;
        private System.Windows.Forms.Label lblClubeDeLazer;
        private System.Windows.Forms.ComboBox cbbClubeDeLazer;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblImpostoRenda;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
    }
}

