using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace EA_.View
{
    public partial class frmMapa : Form
    {
        internal readonly GMapOverlay routeslayer = new GMapOverlay("routeslayer");
        internal readonly GMapOverlay marklayer = new GMapOverlay("marklayer");

        public frmMapa()
        {
            InitializeComponent();
        }

        private void frmMapa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is Form1) formAberto.Show();
                }

            MainMap.Dispose();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e){
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e){
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e){
            frmMapa mapa = new frmMapa();
            mapa.Show();
            this.Hide();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e){
            frmSobre Sobre = new frmSobre();
            Sobre.Show();
            this.Hide();
        }

        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoaFisica cadastroPessoaFisica = new frmCadastroPessoaFisica();
            cadastroPessoaFisica.Show();
            this.Hide();
        }

        private void pessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoaJuridica cadastroPessoaJuridica = new frmCadastroPessoaJuridica();
            cadastroPessoaJuridica.Show();
            this.Hide();
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void pessoaFisicaToolStripMenuItem_Click_1(object sender, EventArgs e){
            frmCadastroPessoaFisica cadastroPessoaFisica = new frmCadastroPessoaFisica();
            cadastroPessoaFisica.Show();
            this.Hide();
        }

        private void pessoaJuridicaToolStripMenuItem_Click_1(object sender, EventArgs e){
            frmCadastroPessoaJuridica cadastroPessoaJuridica = new frmCadastroPessoaJuridica();
            cadastroPessoaJuridica.Show();
            this.Hide();
        }

        private void entrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

        private void mapaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMapa Mapa = new frmMapa();
            Mapa.Show();
            this.Hide();
        }

        private void sobreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSobre Sobre = new frmSobre();
            Sobre.Show();
            this.Hide();
        }

        private void frmMapa_Load(object sender, EventArgs e)
        {
            //antigo
            // webBrowser1.Navigate("https://www.google.com.br/maps/@-22.9118278,-47.0751451,14.32z");

            //define o tipo/fonte do mapa (google, bing, openstreet...)
            MainMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;

            //Acessa os tiles do mapa e faz um cache local
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;


            //seta a posição inicial do mapa (IFSP - Campinas)
            //MainMap.Position = new PointLatLng(-22.8514283, -47.1272867);
            //MainMap.SetPositionByKeywords("Av. Comendador Aladino Selmi, 2298 - Recanto Fortuna, Campinas -SP, Brazil, CEP: 13082");
            MainMap.SetPositionByKeywords("Instituto Federal de São Paulo campus campinas");

            //mostra uma cruz no centro do mapa
            MainMap.ShowCenter = true;

            //define o menor e maior valor de zoom permitido
            MainMap.MinZoom = 2;
            MainMap.MaxZoom = 22;

            //seta o zoom inicial
            MainMap.Zoom = 15;
            //seta o botão esquerdo do mouse e o clique-arraste para executar a operação de pan do mapa
            MainMap.DragButton = MouseButtons.Left;
            MainMap.CanDragMap = true;

            //??????????
            MainMap.AutoScroll = true;

            //inicializa o checkbox com os provedores de mapa
            cbxProvedorMapas.ValueMember = "Name";
            cbxProvedorMapas.DataSource = GMapProviders.List;
            cbxProvedorMapas.SelectedItem = MainMap.MapProvider;

            //adiciona as layer de rotas e marcações no mapa
            MainMap.Overlays.Add(routeslayer);
            MainMap.Overlays.Add(marklayer);
        }

        private void MainMap_OnPositionChanged(PointLatLng point)
        {
            txbLatitude.Text = point.Lat.ToString();
            txbLongitude.Text = point.Lng.ToString();
        }

        private void MainMap_OnMapZoomChanged()
        {
            txbZoom.Text = MainMap.Zoom.ToString();
        }

        private void cbxProvedorMapas_DropDownClosed(object sender, EventArgs e)
        {
            //recupera o provedor de mapa selecionado e seta ele como corrente
            MainMap.MapProvider = cbxProvedorMapas.SelectedItem as GMapProvider;
        }

        private void btnRota_Click(object sender, EventArgs e)
        {
            //RoutingProvider rp = MainMap.MapProvider as RoutingProvider;
            RoutingProvider rp = GMapProviders.OpenStreetMap as RoutingProvider;

            if (rp == null)
            {
                MessageBox.Show("O tipo de mapa escolhido não possui \num serviço de rotas !!!");
                return;
            }


            //string start = "shopping dom pedro";
            //string end = "supermercado taquaral";

            PointLatLng start = new PointLatLng(-22.8514283, -47.1272867); // ifsp-campinas
            PointLatLng end = new PointLatLng(-22.8812658, -47.0501531); // mercado


            MapRoute route = rp.GetRoute(start, end, false, false, (int)MainMap.Zoom);
            if (route == null)
            {
                MessageBox.Show("Não foi possível calcular a rota !!!");
                return;
            }

            string strpoints = "";
            foreach (PointLatLng p in route.Points)
            {
                strpoints += p.Lat + ", " + p.Lng + "\n";
            }

            String strmsg = "";
            strmsg += String.Format("Total de pontos da rota: {0}\n", route.Points.Count.ToString());
            strmsg += String.Format("Tamanho da Rota (km): {0:F2}", route.Distance);
            MessageBox.Show(strmsg);

            // add route
            GMapRoute r = new GMapRoute(route.Points, route.Name);
            r.IsHitTestVisible = true;
            routeslayer.Routes.Add(r);

            // add route start/end marks
            GMapMarker m1 = new GMarkerGoogle(start, GMarkerGoogleType.green_big_go);
            //m1.ToolTipText = "Start: " + route.Name;
            m1.ToolTipText = "Start";
            m1.ToolTipMode = MarkerTooltipMode.Always;

            GMapMarker m2 = new GMarkerGoogle(end, GMarkerGoogleType.red_big_stop);
            //m2.ToolTipText = "End: " + end.ToString();
            m2.ToolTipText = "End";
            m2.ToolTipMode = MarkerTooltipMode.Always;

            marklayer.Markers.Add(m1);
            marklayer.Markers.Add(m2);


            MainMap.ZoomAndCenterRoute(r);
        }

        private void btnApagaRota_Click(object sender, EventArgs e)
        {
            routeslayer.Routes.Clear();
            marklayer.Markers.Clear();  
        }

        private void btnEndLatLon_Click(object sender, EventArgs e)
        {
            List<Placemark> plc = null;

            string endereco = "";

            GeocodingProvider geocode = MainMap.MapProvider as GeocodingProvider;
            if (geocode == null)
            {
                MessageBox.Show("O tipo de mapa escolhido não possui \n serviço de geocoding !!!");
                return;
            }


            /*GeoCoderStatusCode st = geocode.GetPlacemarks(MainMap.Position, out plc);
            //GeoCoderStatusCode st = GMapProviders.GoogleMap.GetPlacemarks(MainMap.Position, out plc);

            if (st == GeoCoderStatusCode.G_GEO_SUCCESS && plc != null)
            {
                foreach (var pl in plc)
                {
                    if (!string.IsNullOrEmpty(pl.PostalCodeNumber))
                    {
                        endereco += "Acurácia: " + pl.Accuracy + ", | Endereço: " + pl.Address + " | CEP: " + pl.PostalCodeNumber + "\n";
                    }
                }

                MessageBox.Show(endereco);
            }*/


            GeoCoderStatusCode st;
            Placemark? place = geocode.GetPlacemark(MainMap.Position, out st);

            if (st != GeoCoderStatusCode.G_GEO_SUCCESS || place == null)
            {
                MessageBox.Show("Não foi possivel retornar o endereço da localização!");
                return;
            }

            endereco += "Acurácia: " + place.Value.Accuracy + ", | Endereço: " + place.Value.Address + " | CEP: " + place.Value.PostalCodeNumber + "\n";
            endereco += "\nAdministrativeAreaName: " + place.Value.AdministrativeAreaName;
            endereco += "\nCountryName: " + place.Value.CountryName;
            endereco += "\nCountryNameCode: " + place.Value.CountryNameCode;
            endereco += "\nDistrictName: " + place.Value.DistrictName;
            endereco += "\nHouseNo: " + place.Value.HouseNo;
            endereco += "\nLocalityName: " + place.Value.LocalityName;
            endereco += "\nNeighborhood: " + place.Value.Neighborhood;
            endereco += "\nPostalCodeNumber: " + place.Value.PostalCodeNumber;
            endereco += "\nStreetNumber: " + place.Value.StreetNumber;
            endereco += "\nSubAdministrativeAreaName: " + place.Value.SubAdministrativeAreaName;
            endereco += "\nSubAdministrativeAreaName: " + place.Value.ThoroughfareName;
            MessageBox.Show(endereco);
        }

        private void btnPesquisarEndereco_Click(object sender, EventArgs e)
        {
            string address = tbxEndereço.Text;
            GeoCoderStatusCode status;

            GeocodingProvider geocode = MainMap.MapProvider as GeocodingProvider;
            if (geocode == null)
            {
                MessageBox.Show("O tipo de mapa escolhido não possui \n serviço de geocoding !!!");
                return;
            }

            PointLatLng? point = geocode.GetPoint(address, out status);
            //PointLatLng? point = GMapProviders.GoogleMap.GetPoint(address, out status);



            if (status == GeoCoderStatusCode.G_GEO_SUCCESS && point != null)
            {
                //MessageBox.Show(point.ToString());
                MainMap.Position = point.Value;
                MainMap.Zoom = 18;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
