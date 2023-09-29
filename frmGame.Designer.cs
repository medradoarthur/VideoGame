namespace VideoGame
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbGameGeneros = new ComboBox();
            label2 = new Label();
            txtGameNome = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            cmbGamePlataforma = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 12;
            label1.Text = "Gêneros";
            // 
            // cmbGameGeneros
            // 
            cmbGameGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGameGeneros.FormattingEnabled = true;
            cmbGameGeneros.Location = new Point(12, 127);
            cmbGameGeneros.Margin = new Padding(3, 4, 3, 4);
            cmbGameGeneros.Name = "cmbGameGeneros";
            cmbGameGeneros.Size = new Size(259, 28);
            cmbGameGeneros.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 13;
            label2.Text = "Nome Game";
            // 
            // txtGameNome
            // 
            txtGameNome.Location = new Point(12, 65);
            txtGameNome.Name = "txtGameNome";
            txtGameNome.Size = new Size(259, 27);
            txtGameNome.TabIndex = 14;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(111, 248);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 29);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(12, 248);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 164);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 21;
            label3.Text = "Plataforma";
            // 
            // cmbGamePlataforma
            // 
            cmbGamePlataforma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGamePlataforma.FormattingEnabled = true;
            cmbGamePlataforma.Location = new Point(12, 193);
            cmbGamePlataforma.Margin = new Padding(3, 4, 3, 4);
            cmbGamePlataforma.Name = "cmbGamePlataforma";
            cmbGamePlataforma.Size = new Size(259, 28);
            cmbGamePlataforma.TabIndex = 20;
            // 
            // frmGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 350);
            Controls.Add(label3);
            Controls.Add(cmbGamePlataforma);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(txtGameNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbGameGeneros);
            Name = "frmGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVideoGames";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSalvar;
        private Button btnCancelar;
        public ComboBox cmbGameGeneros;
        public TextBox txtGameNome;
        private Label label3;
        public ComboBox cmbGamePlataforma;
    }
}