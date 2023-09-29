namespace VideoGame
{
    partial class frmPlataforma
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
            txtNomePlataforma = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 42);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 10;
            label1.Text = "Nome Plataforma";
            // 
            // txtNomePlataforma
            // 
            txtNomePlataforma.Location = new Point(59, 66);
            txtNomePlataforma.Margin = new Padding(3, 4, 3, 4);
            txtNomePlataforma.Name = "txtNomePlataforma";
            txtNomePlataforma.Size = new Size(223, 27);
            txtNomePlataforma.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(207, 101);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 29);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(59, 101);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmPlataforma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 226);
            Controls.Add(label1);
            Controls.Add(txtNomePlataforma);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Name = "frmPlataforma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPlataforma";
            Activated += frmPlataforma_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox txtNomePlataforma;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}