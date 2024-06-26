namespace reloginho
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
            components = new System.ComponentModel.Container();
            lblHoras = new Label();
            lblMinutos = new Label();
            lblSegundos = new Label();
            label4 = new Label();
            label5 = new Label();
            btnConfigurar = new Button();
            btnOk = new Button();
            btnHorasMais = new Button();
            btnHorasMenos = new Button();
            btnMinutosMenos = new Button();
            btnMinutosMais = new Button();
            btnSegundosMenos = new Button();
            btnSegundosMais = new Button();
            RelóginhodasKengas = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoras.Location = new Point(42, 84);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(137, 112);
            lblHoras.TabIndex = 0;
            lblHoras.Text = "00";
            lblHoras.Click += lblHoras_Click;
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMinutos.Location = new Point(226, 84);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(137, 112);
            lblMinutos.TabIndex = 1;
            lblMinutos.Text = "00";
            lblMinutos.Click += label2_Click;
            // 
            // lblSegundos
            // 
            lblSegundos.AutoSize = true;
            lblSegundos.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSegundos.Location = new Point(416, 84);
            lblSegundos.Name = "lblSegundos";
            lblSegundos.Size = new Size(137, 112);
            lblSegundos.TabIndex = 2;
            lblSegundos.Text = "00";
            lblSegundos.Click += lblSegundos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(166, 84);
            label4.Name = "label4";
            label4.Size = new Size(65, 112);
            label4.TabIndex = 3;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(358, 84);
            label5.Name = "label5";
            label5.Size = new Size(65, 112);
            label5.TabIndex = 4;
            label5.Text = ":";
            // 
            // btnConfigurar
            // 
            btnConfigurar.Location = new Point(191, 263);
            btnConfigurar.Name = "btnConfigurar";
            btnConfigurar.Size = new Size(94, 29);
            btnConfigurar.TabIndex = 5;
            btnConfigurar.Text = "Configurar";
            btnConfigurar.UseVisualStyleBackColor = true;
            btnConfigurar.Click += btnConfigurar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(291, 263);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Visible = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnHorasMais
            // 
            btnHorasMais.Location = new Point(114, 199);
            btnHorasMais.Name = "btnHorasMais";
            btnHorasMais.Size = new Size(42, 29);
            btnHorasMais.TabIndex = 7;
            btnHorasMais.Text = "+";
            btnHorasMais.UseVisualStyleBackColor = true;
            btnHorasMais.Visible = false;
            btnHorasMais.Click += btnHorasMais_Click;
            // 
            // btnHorasMenos
            // 
            btnHorasMenos.Location = new Point(57, 199);
            btnHorasMenos.Name = "btnHorasMenos";
            btnHorasMenos.Size = new Size(42, 29);
            btnHorasMenos.TabIndex = 8;
            btnHorasMenos.Text = "-";
            btnHorasMenos.UseVisualStyleBackColor = true;
            btnHorasMenos.Visible = false;
            btnHorasMenos.Click += button4_Click;
            // 
            // btnMinutosMenos
            // 
            btnMinutosMenos.Location = new Point(243, 199);
            btnMinutosMenos.Name = "btnMinutosMenos";
            btnMinutosMenos.Size = new Size(42, 29);
            btnMinutosMenos.TabIndex = 10;
            btnMinutosMenos.Text = "-";
            btnMinutosMenos.UseVisualStyleBackColor = true;
            btnMinutosMenos.Visible = false;
            btnMinutosMenos.Click += button5_Click;
            // 
            // btnMinutosMais
            // 
            btnMinutosMais.Location = new Point(291, 199);
            btnMinutosMais.Name = "btnMinutosMais";
            btnMinutosMais.Size = new Size(42, 29);
            btnMinutosMais.TabIndex = 9;
            btnMinutosMais.Text = "+";
            btnMinutosMais.UseVisualStyleBackColor = true;
            btnMinutosMais.Visible = false;
            btnMinutosMais.Click += button6_Click;
            // 
            // btnSegundosMenos
            // 
            btnSegundosMenos.Location = new Point(433, 199);
            btnSegundosMenos.Name = "btnSegundosMenos";
            btnSegundosMenos.Size = new Size(42, 29);
            btnSegundosMenos.TabIndex = 12;
            btnSegundosMenos.Text = "-";
            btnSegundosMenos.UseVisualStyleBackColor = true;
            btnSegundosMenos.Visible = false;
            btnSegundosMenos.Click += btnSegundosMenos_Click;
            // 
            // btnSegundosMais
            // 
            btnSegundosMais.Location = new Point(490, 199);
            btnSegundosMais.Name = "btnSegundosMais";
            btnSegundosMais.Size = new Size(42, 29);
            btnSegundosMais.TabIndex = 11;
            btnSegundosMais.Text = "+";
            btnSegundosMais.UseVisualStyleBackColor = true;
            btnSegundosMais.Visible = false;
            btnSegundosMais.Click += btnSegundosMais_Click;
            // 
            // RelóginhodasKengas
            // 
            RelóginhodasKengas.Enabled = true;
            RelóginhodasKengas.Interval = 1000;
            RelóginhodasKengas.Tick += RelóginhodasKengas_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 362);
            Controls.Add(btnSegundosMenos);
            Controls.Add(btnSegundosMais);
            Controls.Add(btnMinutosMenos);
            Controls.Add(btnMinutosMais);
            Controls.Add(btnHorasMenos);
            Controls.Add(btnHorasMais);
            Controls.Add(btnOk);
            Controls.Add(btnConfigurar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblSegundos);
            Controls.Add(lblMinutos);
            Controls.Add(lblHoras);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reloginho das Kengas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoras;
        private Label lblMinutos;
        private Label lblSegundos;
        private Label label4;
        private Label label5;
        private Button btnConfigurar;
        private Button btnOk;
        private Button btnHorasMais;
        private Button btnHorasMenos;
        private Button btnMinutosMenos;
        private Button btnMinutosMais;
        private Button btnSegundosMenos;
        private Button btnSegundosMais;
        private System.Windows.Forms.Timer RelóginhodasKengas;
    }
}
