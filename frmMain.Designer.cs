namespace VideoGame
{
    partial class frmMain
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
            dvgGames = new DataGridView();
            clmCodigo = new DataGridViewTextBoxColumn();
            clmGame = new DataGridViewTextBoxColumn();
            clmGenero = new DataGridViewTextBoxColumn();
            clmPlataforma = new DataGridViewTextBoxColumn();
            btnAltGenero = new Button();
            btnAddGenero = new Button();
            cmbGeneros = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            btnExcluirGenero = new Button();
            btnAddGame = new Button();
            btnAltGame = new Button();
            btnExcluirGame = new Button();
            btnExcluirPlataforma = new Button();
            label2 = new Label();
            btnAlterarPlataforma = new Button();
            btnAddPlataforma = new Button();
            cmbPlataforma = new ComboBox();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgGames).BeginInit();
            SuspendLayout();
            // 
            // dvgGames
            // 
            dvgGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgGames.Columns.AddRange(new DataGridViewColumn[] { clmCodigo, clmGame, clmGenero, clmPlataforma });
            dvgGames.Location = new Point(12, 234);
            dvgGames.Margin = new Padding(3, 4, 3, 4);
            dvgGames.Name = "dvgGames";
            dvgGames.RowHeadersWidth = 51;
            dvgGames.RowTemplate.Height = 24;
            dvgGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgGames.Size = new Size(747, 303);
            dvgGames.TabIndex = 9;
            dvgGames.CellDoubleClick += dvgGames_CellDoubleClick;
            // 
            // clmCodigo
            // 
            clmCodigo.DataPropertyName = "id";
            clmCodigo.HeaderText = "Código";
            clmCodigo.MinimumWidth = 6;
            clmCodigo.Name = "clmCodigo";
            clmCodigo.Width = 125;
            // 
            // clmGame
            // 
            clmGame.DataPropertyName = "Nome";
            clmGame.HeaderText = "Game";
            clmGame.MinimumWidth = 6;
            clmGame.Name = "clmGame";
            clmGame.Width = 125;
            // 
            // clmGenero
            // 
            clmGenero.DataPropertyName = "NomeGenero";
            clmGenero.HeaderText = "Gênero";
            clmGenero.MinimumWidth = 6;
            clmGenero.Name = "clmGenero";
            clmGenero.Width = 125;
            // 
            // clmPlataforma
            // 
            clmPlataforma.DataPropertyName = "NomePlataforma";
            clmPlataforma.HeaderText = "Plataforma";
            clmPlataforma.MinimumWidth = 6;
            clmPlataforma.Name = "clmPlataforma";
            clmPlataforma.Width = 125;
            // 
            // btnAltGenero
            // 
            btnAltGenero.Location = new Point(373, 37);
            btnAltGenero.Margin = new Padding(3, 4, 3, 4);
            btnAltGenero.Name = "btnAltGenero";
            btnAltGenero.Size = new Size(158, 28);
            btnAltGenero.TabIndex = 7;
            btnAltGenero.Text = "Alterar Gênero";
            btnAltGenero.UseVisualStyleBackColor = true;
            btnAltGenero.Click += btnAltGenero_Click;
            // 
            // btnAddGenero
            // 
            btnAddGenero.Location = new Point(209, 36);
            btnAddGenero.Margin = new Padding(3, 4, 3, 4);
            btnAddGenero.Name = "btnAddGenero";
            btnAddGenero.Size = new Size(158, 29);
            btnAddGenero.TabIndex = 6;
            btnAddGenero.Text = "Adicionar Gêneros";
            btnAddGenero.UseVisualStyleBackColor = true;
            btnAddGenero.Click += btnGenero_Click;
            // 
            // cmbGeneros
            // 
            cmbGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGeneros.FormattingEnabled = true;
            cmbGeneros.Location = new Point(12, 37);
            cmbGeneros.Margin = new Padding(3, 4, 3, 4);
            cmbGeneros.Name = "cmbGeneros";
            cmbGeneros.Size = new Size(179, 28);
            cmbGeneros.TabIndex = 5;
            cmbGeneros.SelectedIndexChanged += cmbGeneros_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 10;
            label1.Text = "Gêneros";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(2, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 3);
            panel1.TabIndex = 11;
            // 
            // btnExcluirGenero
            // 
            btnExcluirGenero.Location = new Point(537, 37);
            btnExcluirGenero.Name = "btnExcluirGenero";
            btnExcluirGenero.Size = new Size(158, 28);
            btnExcluirGenero.TabIndex = 12;
            btnExcluirGenero.Text = "Excluir Gênero";
            btnExcluirGenero.UseVisualStyleBackColor = true;
            btnExcluirGenero.Click += btnExcluirGenero_Click;
            // 
            // btnAddGame
            // 
            btnAddGame.Location = new Point(12, 198);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(158, 29);
            btnAddGame.TabIndex = 13;
            btnAddGame.Text = "Adicionar Game";
            btnAddGame.UseVisualStyleBackColor = true;
            btnAddGame.Click += btnAddGame_Click;
            // 
            // btnAltGame
            // 
            btnAltGame.Location = new Point(185, 198);
            btnAltGame.Name = "btnAltGame";
            btnAltGame.Size = new Size(158, 29);
            btnAltGame.TabIndex = 14;
            btnAltGame.Text = "Alterar Game";
            btnAltGame.UseVisualStyleBackColor = true;
            btnAltGame.Click += btnAltGame_Click;
            // 
            // btnExcluirGame
            // 
            btnExcluirGame.Location = new Point(349, 198);
            btnExcluirGame.Name = "btnExcluirGame";
            btnExcluirGame.Size = new Size(158, 29);
            btnExcluirGame.TabIndex = 15;
            btnExcluirGame.Text = "Excluir Game";
            btnExcluirGame.UseVisualStyleBackColor = true;
            btnExcluirGame.Click += btnExcluirGame_Click;
            // 
            // btnExcluirPlataforma
            // 
            btnExcluirPlataforma.Location = new Point(537, 108);
            btnExcluirPlataforma.Name = "btnExcluirPlataforma";
            btnExcluirPlataforma.Size = new Size(158, 28);
            btnExcluirPlataforma.TabIndex = 20;
            btnExcluirPlataforma.Text = "Excluir Plataforma";
            btnExcluirPlataforma.UseVisualStyleBackColor = true;
            btnExcluirPlataforma.Click += btnExcluirPlataforma_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 19;
            label2.Text = "Plataforma";
            // 
            // btnAlterarPlataforma
            // 
            btnAlterarPlataforma.Location = new Point(373, 108);
            btnAlterarPlataforma.Margin = new Padding(3, 4, 3, 4);
            btnAlterarPlataforma.Name = "btnAlterarPlataforma";
            btnAlterarPlataforma.Size = new Size(158, 28);
            btnAlterarPlataforma.TabIndex = 18;
            btnAlterarPlataforma.Text = "Alterar Plataforma";
            btnAlterarPlataforma.UseVisualStyleBackColor = true;
            btnAlterarPlataforma.Click += btnAlterarPlataforma_Click;
            // 
            // btnAddPlataforma
            // 
            btnAddPlataforma.Location = new Point(209, 108);
            btnAddPlataforma.Margin = new Padding(3, 4, 3, 4);
            btnAddPlataforma.Name = "btnAddPlataforma";
            btnAddPlataforma.Size = new Size(158, 29);
            btnAddPlataforma.TabIndex = 17;
            btnAddPlataforma.Text = "Adicionar Plataforma";
            btnAddPlataforma.UseVisualStyleBackColor = true;
            btnAddPlataforma.Click += btnAddPlataforma_Click;
            // 
            // cmbPlataforma
            // 
            cmbPlataforma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlataforma.FormattingEnabled = true;
            cmbPlataforma.Location = new Point(12, 109);
            cmbPlataforma.Margin = new Padding(3, 4, 3, 4);
            cmbPlataforma.Name = "cmbPlataforma";
            cmbPlataforma.Size = new Size(179, 28);
            cmbPlataforma.TabIndex = 16;
            cmbPlataforma.SelectedIndexChanged += cmbPlataforma_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(2, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(826, 3);
            panel2.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 22;
            label3.Text = "Games:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 159);
            label4.Name = "label4";
            label4.Size = new Size(496, 20);
            label4.TabIndex = 23;
            label4.Text = "A exibição no grid, é feita de acordo com o filtro selecionado no gêneros";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 538);
            label5.Name = "label5";
            label5.Size = new Size(242, 20);
            label5.TabIndex = 24;
            label5.Text = "Dois click no registro, para editá-lo";
            label5.Visible = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 567);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(btnExcluirPlataforma);
            Controls.Add(label2);
            Controls.Add(btnAlterarPlataforma);
            Controls.Add(btnAddPlataforma);
            Controls.Add(cmbPlataforma);
            Controls.Add(btnExcluirGame);
            Controls.Add(btnAltGame);
            Controls.Add(btnAddGame);
            Controls.Add(btnExcluirGenero);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dvgGames);
            Controls.Add(btnAltGenero);
            Controls.Add(btnAddGenero);
            Controls.Add(cmbGeneros);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Video Games";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dvgGames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgGames;
        private Button btnAltGenero;
        private Button btnAddGenero;
        private ComboBox cmbGeneros;
        private Label label1;
        private Panel panel1;
        private Button btnExcluirGenero;
        private Button btnAddGame;
        private Button btnAltGame;
        private Button btnExcluirGame;
        private Button btnExcluirPlataforma;
        private Label label2;
        private Button btnAlterarPlataforma;
        private Button btnAddPlataforma;
        private ComboBox cmbPlataforma;
        private Panel panel2;
        private Label label3;
        private DataGridViewTextBoxColumn clmCodigo;
        private DataGridViewTextBoxColumn clmGame;
        private DataGridViewTextBoxColumn clmGenero;
        private DataGridViewTextBoxColumn clmPlataforma;
        private Label label4;
        private Label label5;
    }
}