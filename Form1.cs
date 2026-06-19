namespace Rechteckprojekt
    {
    public partial class FrmRechteck : Form
    {
        Rechteck meinRechteck;

        public FrmRechteck()
        {
            InitializeComponent();
            lblFehlermeldung.Text = "";
        }

        private void chkIstQuadrat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIstQuadrat.Checked == true)
            {
                txtHoehe.Enabled = false;
                txtHoehe.Text = txtBreite.Text;
            }
            else
            {
                txtHoehe.Enabled = true;
            }

        }

        private void btnErstellen_Click(object sender, EventArgs e)
        {
            try
            {
                lblFehlermeldung.Text = "";

                double b = Convert.ToDouble(txtBreite.Text);

                if (chkIstQuadrat.Checked == true)
                {
                    meinRechteck = new Rechteck(b);
                    txtHoehe.Text = txtBreite.Text;
                }
                else
                {
                    double h = Convert.ToDouble(txtHoehe.Text);
                    meinRechteck = new Rechteck(b, h);

                }

                lblFlaecheAusgabe.Text = meinRechteck.Flaeche.ToString() + " cm^2";
                lblUmfangAusgabe.Text = meinRechteck.Umfang.ToString() + " cm";
                lblDiagonaleAusgabe.Text = meinRechteck.Diagonale.ToString() + " cm";
            }
            catch (Exception ex)
            {
                lblFehlermeldung.Text = "Fehler: " + ex.Message;
            }
        }

        private void btnDrehen_Click(object sender, EventArgs e)
        {
            try
            {
                lblFehlermeldung.Text = "";

                if (meinRechteck != null)
                {
                    meinRechteck.Rechtsdrehung();

                    txtBreite.Text = meinRechteck.Breite.ToString();
                    txtHoehe.Text = meinRechteck.Hoehe.ToString();

                    lblFlaecheAusgabe.Text = meinRechteck.Flaeche.ToString() + " cm^2";
                    lblUmfangAusgabe.Text = meinRechteck.Umfang.ToString() + " cm";
                    lblDiagonaleAusgabe.Text = meinRechteck.Diagonale.ToString() + " cm";
                }
                else
                {
                    lblFehlermeldung.Text = "Fehler: Bitte zuerst ein Rechteck erstellen!";
                }
            }
            catch (Exception ex)
            {
                lblFehlermeldung.Text = "Fehler: " + ex.Message;
            }
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            try
            {
                lblFehlermeldung.Text = "";

                if (meinRechteck != null)
                {
                    double f = Convert.ToDouble(txtZoomFaktor.Text);

                    meinRechteck.Zoom(f);

                    txtBreite.Text = meinRechteck.Breite.ToString();
                    txtHoehe.Text = meinRechteck.Hoehe.ToString();

                    lblFlaecheAusgabe.Text = meinRechteck.Flaeche.ToString() + " cm^2";
                    lblUmfangAusgabe.Text = meinRechteck.Umfang.ToString() + " cm";
                    lblDiagonaleAusgabe.Text = meinRechteck.Diagonale.ToString() + " cm";
                }
                else
                {
                    lblFehlermeldung.Text = "Fehler: Bitte zuerst ein Rechteck erstellen!";
                }
            }
            catch (Exception ex)
            {
                lblFehlermeldung.Text = "Fehler: " + ex.Message;
            }
        }
    }
}