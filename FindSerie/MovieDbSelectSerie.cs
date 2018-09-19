using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDbLib;
using TMDbLib.Objects;
using TMDbLib.Utilities;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.TvShows;
using TMDbLib.Objects.Search;

namespace FindSerie
{
    public partial class MovieDbSelectSerie : Form
    {
        public int idSerie { get; set; }
        static string api = "e9b7597c5703d825bcbd7504ffee209a";
        static SearchContainer<SearchTv> MDBresults;
        static TMDbClient client = new TMDbClient(api);
         
        public MovieDbSelectSerie(string NameSerie = null)
        {
            InitializeComponent();
            if(NameSerie != null)
            {
                TB_Search.Text = NameSerie;
                search();       
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void CB_Result_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow selectedDataRow = ((DataRowView)CB_Result.SelectedItem).Row;
                int serieId = Convert.ToInt32(selectedDataRow["Id"]);
                label_Sysnopsis.Text = serieId.ToString();
                var SelectSerie = from Result in MDBresults.Results where Result.Id == serieId select Result;
                foreach (var Result in SelectSerie)
                {
                    label_NameSerie.Text = Result.Name.ToString();
                    label_nbSeason.Text = "Nombre(s) de Saison(s) : " + MovieDB.getNBSeason(Result.Id);
                    label_Resallisateur.Text = Result.BackdropPath;
                    label_Year.Text = "Annee : " + Result.FirstAirDate.Value.Year;
                    img_Serie.Load(@"https://image.tmdb.org/t/p/w300" + Result.PosterPath);
                    TB_Synopsis.Text = Result.Overview;
                    break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite");
            }
            
        }

        private void search()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            MDBresults = MovieDB.getSearchTv(TB_Search.Text);
            MDBresults.Results.ForEach(Serie => {
                DataRow Row = dt.NewRow();
                Row["ID"] = Serie.Id;
                Row["Name"] = Serie.Name;
                dt.Rows.Add(Row);
            });
            CB_Result.DataSource = dt;
            CB_Result.DisplayMember = "Name";
            CB_Result.ValueMember = "Id";
        }

        private void btn_Validation_Click(object sender, EventArgs e)
        {
            this.idSerie = int.Parse(CB_Result.SelectedValue.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
