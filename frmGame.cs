using VideoGame.Models;

namespace VideoGame
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();

            using (var db = new DataContext())
            {
                AtualizaCmbGeneros(db);
                AtualizaCmbPlataformas(db);
            }
        }

        private void AtualizaCmbGeneros(DataContext db)
        {
            cmbGameGeneros.DataSource = db.Generos.ToList();
            cmbGameGeneros.DisplayMember = "genre_name";
            cmbGameGeneros.ValueMember = "id";
        }

        private void AtualizaCmbPlataformas(DataContext db)
        {
            cmbGamePlataforma.DataSource = db.Plataformas.ToList();
            cmbGamePlataforma.DisplayMember = "NomePlataforma";
            cmbGamePlataforma.ValueMember = "Id";
        }
    }
}
