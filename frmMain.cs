using MessageUtils;
using Microsoft.EntityFrameworkCore;
using VideoGame.Models;

namespace VideoGame
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            using (var form = new frmGenero())
            {
                form.Text = "Adição Gênero";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new DataContext())
                    {
                        Genero genero = new Genero();
                        genero.genre_name = form.txtNomeGenero.Text;
                        db.Generos.Add(genero);
                        db.SaveChanges();

                        AtualizaCmbGeneros(db);
                        SimpleMessage.Inform("Salvo com Sucesso!", "Informação");
                    }
                }

            }
        }

        private void AtualizaCmbGeneros(DataContext db)
        {
            cmbGeneros.DataSource = db.Generos.ToList();
            cmbGeneros.DisplayMember = "genre_name";
            cmbGeneros.ValueMember = "id";
        }

        private void AtualizaCmbPlataformas(DataContext db)
        {
            cmbPlataforma.DataSource = db.Plataformas.ToList();
            cmbPlataforma.DisplayMember = "NomePlataforma";
            cmbPlataforma.ValueMember = "Id";
        }

        private void AtualizarGames(DataContext db)
        {
            if (cmbGeneros.Items.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                int idGenero = (cmbGeneros.SelectedItem as Genero).id;
                dvgGames.DataSource = db.VideoGames.Where(x => x.IdGenero == idGenero).
                    Include(x => x.Genero).ToList();

                dvgGames.Columns.Remove(dvgGames.Columns["IdGenero"]);
                dvgGames.Columns.Remove(dvgGames.Columns["Genero"]);
                this.Cursor = Cursors.Default;
            }
        }

        private void btnAltGenero_Click(object sender, EventArgs e)
        {
            using (var form = new frmGenero())
            {
                form.Text = "Alterar Gênero";
                form.txtNomeGenero.Text = cmbGeneros.Text;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new DataContext())
                    {
                        Genero genero = (cmbGeneros.SelectedItem as Genero);
                        genero.genre_name = form.txtNomeGenero.Text;
                        db.Generos.Attach(genero);
                        db.Entry(genero).State = EntityState.Modified;
                        db.SaveChanges();

                        AtualizaCmbGeneros(db);
                        cmbGeneros.SelectedItem = genero;
                        SimpleMessage.Inform("Alterado com Sucesso!", "Informação");
                    }
                }

            }
        }

        private void btnExcluirGenero_Click(object sender, EventArgs e)
        {
            if (SimpleMessage.Confirm("Deseja realmente excluir o Gênero selecionado?",
                "Exclusão de Gênero"))
            {
                using (var db = new DataContext())
                {
                    int idGenero = (cmbGeneros.SelectedItem as Genero).id;
                    int qtdGames = db.VideoGames.Where(x => x.id == idGenero).Count();

                    if (qtdGames == 0)
                    {
                        Genero gen = db.Generos.Find(idGenero);
                        db.Remove(gen);
                        db.SaveChanges();
                        AtualizaCmbGeneros(db);

                        SimpleMessage.Inform("Exclusão realizada com sucesso", "Informação");
                    }
                    else
                    {
                        SimpleMessage.Inform("Não é possível excluir um gênero vinculado" +
                            " a um game!", "Erro");
                    }
                }
            }

        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            using (var form = new frmGame())
            {
                form.Text = "Adicionando novo Game!";
                form.cmbGameGeneros.SelectedIndex = cmbGeneros.SelectedIndex;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new DataContext())
                    {
                        Game game = new Game();
                        game.Nome = form.txtGameNome.Text;
                        game.IdGenero = (form.cmbGameGeneros.SelectedItem as Genero).id;
                        game.NomePlataforma = (form.cmbGamePlataforma.SelectedItem as Plataforma).NomePlataforma;
                        game.NomeGenero = (form.cmbGameGeneros.SelectedItem as Genero).genre_name;
                        db.VideoGames.Add(game);
                        db.SaveChanges();

                        AtualizarGames(db);
                        SimpleMessage.Inform("Adicionado com Sucesso!", "Informação");

                    }
                }
            }
        }

        private void btnAddPlataforma_Click(object sender, EventArgs e)
        {
            using (var form = new frmPlataforma())
            {
                form.Text = "Adição Plataforma";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new DataContext())
                    {
                        Plataforma plataforma = new Plataforma();
                        plataforma.NomePlataforma = form.txtNomePlataforma.Text;

                        db.Plataformas.Add(plataforma);
                        db.SaveChanges();

                        AtualizaCmbPlataformas(db);
                        SimpleMessage.Inform("Salvo com Sucesso!", "Informação");
                    }

                }

            }
        }

        private void btnAlterarPlataforma_Click(object sender, EventArgs e)
        {
            using (var form = new frmPlataforma())
            {
                form.Text = "Alterar Plataforma";
                form.txtNomePlataforma.Text = cmbPlataforma.Text;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new DataContext())
                    {
                        Plataforma plataforma = (cmbPlataforma.SelectedItem as Plataforma);
                        plataforma.NomePlataforma = form.txtNomePlataforma.Text;

                        db.Plataformas.Attach(plataforma);
                        db.Entry(plataforma).State = EntityState.Modified;
                        db.SaveChanges();

                        AtualizaCmbPlataformas(db);
                        cmbPlataforma.SelectedItem = plataforma;
                        SimpleMessage.Inform("Alterado com Sucesso!", "Informação");
                    }
                }

            }
        }

        private void btnExcluirPlataforma_Click(object sender, EventArgs e)
        {
            if (SimpleMessage.Confirm("Deseja realmente excluir a Plataforma selecionada?",
                "Exclusão de Plataforma"))
            {
                using (var db = new DataContext())
                {
                    int idPlataforma = (cmbPlataforma.SelectedItem as Plataforma).Id;
                    int qtdGames = db.VideoGames.Where(x => x.id == idPlataforma).Count();

                    if (qtdGames == 0)
                    {
                        Plataforma pla = db.Plataformas.Find(idPlataforma);
                        db.Remove(pla);
                        db.SaveChanges();
                        AtualizaCmbPlataformas(db);

                        SimpleMessage.Inform("Exclusão realizada com sucesso", "Informação");
                    }
                    else
                    {
                        SimpleMessage.Inform("Não é possível excluir uma plataforma vinculada" +
                            " a um game!", "Erro");
                    }
                }
            }

        }

        private void cmbGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                AtualizarGames(db);
            }
        }

        private void cmbPlataforma_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                AtualizarGames(db);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                AtualizaCmbGeneros(db);
                AtualizaCmbPlataformas(db);

                AtualizarGames(db);
            }
        }

        private void btnAltGame_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (dvgGames.SelectedRows.Count > 0)
            {
                linhaSelecionada = dvgGames.SelectedRows[0];
                Game game = linhaSelecionada.DataBoundItem as Game;
                using (var form = new frmGame())
                {
                    form.Text = "Alteração do Game";
                    form.txtGameNome.Text = game.Nome;
                    form.cmbGameGeneros.SelectedIndex = cmbGeneros.FindString(game.NomeGenero);
                    form.cmbGamePlataforma.SelectedIndex = cmbPlataforma.FindString(game.NomePlataforma);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        using (var db = new DataContext())
                        {
                            game.Nome = form.txtGameNome.Text;
                            game.NomeGenero = form.cmbGameGeneros.Text;
                            game.NomePlataforma = form.cmbGamePlataforma.Text;

                            db.VideoGames.Attach(game);
                            db.Entry(game).State = EntityState.Modified;
                            db.SaveChanges();

                            AtualizarGames(db);
                            SimpleMessage.Inform("Alteração realizada com sucesso!", "Informação");
                        }
                    }
                }
            }
        }

        private void btnExcluirGame_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (dvgGames.SelectedRows.Count > 0)
            {
                linhaSelecionada = dvgGames.SelectedRows[0];
                Game game = linhaSelecionada.DataBoundItem as Game;

                if (SimpleMessage.Confirm("Tem certeza que deseja excluir o item selecionado?", "Exclusão do Game"))
                {
                    using (var db = new DataContext())
                    {
                        db.VideoGames.Attach(game);
                        db.Entry(game).State = EntityState.Deleted;
                        db.SaveChanges();

                        SimpleMessage.Inform("Game excluído com sucesso!", "Informação");
                    }
                }
            }
        }

        private void dvgGames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAltGame_Click(null, null);
        }
    }
}