namespace Rechteckprojekt
{
    partial class FrmRechteck
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
            txtBreite = new TextBox();
            lblBreite = new Label();
            lblHoehe = new Label();
            txtHoehe = new TextBox();
            btnErstellen = new Button();
            btnDrehen = new Button();
            lblZoom = new Label();
            txtZoomFaktor = new TextBox();
            btnZoom = new Button();
            lblEingabe = new Label();
            lblAktionen = new Label();
            lblErgebnisse = new Label();
            label1 = new Label();
            lblFlaeche = new Label();
            lblUmfang = new Label();
            lblDiagonale = new Label();
            lblFlaecheAusgabe = new Label();
            lblUmfangAusgabe = new Label();
            lblDiagonaleAusgabe = new Label();
            lblFehlermeldung = new Label();
            chkIstQuadrat = new CheckBox();
            SuspendLayout();
            // 
            // txtBreite
            // 
            txtBreite.Location = new Point(149, 140);
            txtBreite.Name = "txtBreite";
            txtBreite.Size = new Size(163, 23);
            txtBreite.TabIndex = 0;
            // 
            // lblBreite
            // 
            lblBreite.Location = new Point(64, 137);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(79, 26);
            lblBreite.TabIndex = 0;
            lblBreite.Text = "Breite (cm):";
            lblBreite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoehe
            // 
            lblHoehe.Location = new Point(64, 178);
            lblHoehe.Name = "lblHoehe";
            lblHoehe.Size = new Size(79, 26);
            lblHoehe.TabIndex = 1;
            lblHoehe.Text = "Höhe (cm):";
            lblHoehe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtHoehe
            // 
            txtHoehe.Location = new Point(149, 181);
            txtHoehe.Name = "txtHoehe";
            txtHoehe.Size = new Size(163, 23);
            txtHoehe.TabIndex = 2;
            // 
            // btnErstellen
            // 
            btnErstellen.Location = new Point(68, 231);
            btnErstellen.Name = "btnErstellen";
            btnErstellen.Size = new Size(253, 44);
            btnErstellen.TabIndex = 3;
            btnErstellen.Text = "Rechteck erstellen";
            btnErstellen.UseVisualStyleBackColor = true;
            btnErstellen.Click += btnErstellen_Click;
            // 
            // btnDrehen
            // 
            btnDrehen.Location = new Point(64, 359);
            btnDrehen.Name = "btnDrehen";
            btnDrehen.Size = new Size(253, 44);
            btnDrehen.TabIndex = 4;
            btnDrehen.Text = "90 Grad Drehen";
            btnDrehen.UseVisualStyleBackColor = true;
            btnDrehen.Click += btnDrehen_Click;
            // 
            // lblZoom
            // 
            lblZoom.Location = new Point(64, 419);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(79, 26);
            lblZoom.TabIndex = 5;
            lblZoom.Text = "Faktor:";
            lblZoom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtZoomFaktor
            // 
            txtZoomFaktor.Location = new Point(149, 422);
            txtZoomFaktor.Name = "txtZoomFaktor";
            txtZoomFaktor.Size = new Size(163, 23);
            txtZoomFaktor.TabIndex = 6;
            // 
            // btnZoom
            // 
            btnZoom.Location = new Point(328, 410);
            btnZoom.Name = "btnZoom";
            btnZoom.Size = new Size(93, 44);
            btnZoom.TabIndex = 7;
            btnZoom.Text = "Zoomen";
            btnZoom.UseVisualStyleBackColor = true;
            btnZoom.Click += btnZoom_Click;
            // 
            // lblEingabe
            // 
            lblEingabe.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEingabe.Location = new Point(30, 86);
            lblEingabe.Name = "lblEingabe";
            lblEingabe.Size = new Size(104, 37);
            lblEingabe.TabIndex = 8;
            lblEingabe.Text = "Eingabe";
            lblEingabe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAktionen
            // 
            lblAktionen.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblAktionen.Location = new Point(30, 298);
            lblAktionen.Name = "lblAktionen";
            lblAktionen.Size = new Size(104, 37);
            lblAktionen.TabIndex = 9;
            lblAktionen.Text = "Aktionen";
            lblAktionen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblErgebnisse
            // 
            lblErgebnisse.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblErgebnisse.Location = new Point(30, 475);
            lblErgebnisse.Name = "lblErgebnisse";
            lblErgebnisse.Size = new Size(126, 37);
            lblErgebnisse.TabIndex = 10;
            lblErgebnisse.Text = "Ergebnisse";
            lblErgebnisse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dutch801 XBd BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 19);
            label1.Name = "label1";
            label1.Size = new Size(293, 39);
            label1.TabIndex = 11;
            label1.Text = "Rechteck Manager";
            // 
            // lblFlaeche
            // 
            lblFlaeche.Location = new Point(103, 531);
            lblFlaeche.Name = "lblFlaeche";
            lblFlaeche.Size = new Size(79, 26);
            lblFlaeche.TabIndex = 12;
            lblFlaeche.Text = "Fläche:";
            lblFlaeche.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUmfang
            // 
            lblUmfang.Location = new Point(103, 570);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(79, 26);
            lblUmfang.TabIndex = 13;
            lblUmfang.Text = "Umfang:";
            lblUmfang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiagonale
            // 
            lblDiagonale.Location = new Point(107, 607);
            lblDiagonale.Name = "lblDiagonale";
            lblDiagonale.Size = new Size(79, 26);
            lblDiagonale.TabIndex = 14;
            lblDiagonale.Text = "Diagonale:";
            lblDiagonale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFlaecheAusgabe
            // 
            lblFlaecheAusgabe.Location = new Point(188, 531);
            lblFlaecheAusgabe.Name = "lblFlaecheAusgabe";
            lblFlaecheAusgabe.Size = new Size(79, 26);
            lblFlaecheAusgabe.TabIndex = 15;
            lblFlaecheAusgabe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUmfangAusgabe
            // 
            lblUmfangAusgabe.Location = new Point(188, 570);
            lblUmfangAusgabe.Name = "lblUmfangAusgabe";
            lblUmfangAusgabe.Size = new Size(79, 26);
            lblUmfangAusgabe.TabIndex = 16;
            lblUmfangAusgabe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiagonaleAusgabe
            // 
            lblDiagonaleAusgabe.Location = new Point(188, 607);
            lblDiagonaleAusgabe.Name = "lblDiagonaleAusgabe";
            lblDiagonaleAusgabe.Size = new Size(79, 26);
            lblDiagonaleAusgabe.TabIndex = 17;
            lblDiagonaleAusgabe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFehlermeldung
            // 
            lblFehlermeldung.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblFehlermeldung.ForeColor = Color.Red;
            lblFehlermeldung.Location = new Point(30, 645);
            lblFehlermeldung.Name = "lblFehlermeldung";
            lblFehlermeldung.Size = new Size(487, 26);
            lblFehlermeldung.TabIndex = 18;
            lblFehlermeldung.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkIstQuadrat
            // 
            chkIstQuadrat.AutoSize = true;
            chkIstQuadrat.Location = new Point(352, 141);
            chkIstQuadrat.Name = "chkIstQuadrat";
            chkIstQuadrat.Size = new Size(84, 19);
            chkIstQuadrat.TabIndex = 19;
            chkIstQuadrat.Text = "Ist Quadrat";
            chkIstQuadrat.UseVisualStyleBackColor = true;
            chkIstQuadrat.Click += chkIstQuadrat_CheckedChanged;
            // 
            // FrmRechteck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 680);
            Controls.Add(chkIstQuadrat);
            Controls.Add(lblFehlermeldung);
            Controls.Add(lblDiagonaleAusgabe);
            Controls.Add(lblUmfangAusgabe);
            Controls.Add(lblFlaecheAusgabe);
            Controls.Add(lblDiagonale);
            Controls.Add(lblUmfang);
            Controls.Add(lblFlaeche);
            Controls.Add(label1);
            Controls.Add(lblErgebnisse);
            Controls.Add(lblAktionen);
            Controls.Add(lblEingabe);
            Controls.Add(btnZoom);
            Controls.Add(lblZoom);
            Controls.Add(txtZoomFaktor);
            Controls.Add(btnDrehen);
            Controls.Add(btnErstellen);
            Controls.Add(lblHoehe);
            Controls.Add(txtHoehe);
            Controls.Add(lblBreite);
            Controls.Add(txtBreite);
            Name = "FrmRechteck";
            Text = "Rechteck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBreite;
        private Label lblBreite;
        private Label lblHoehe;
        private TextBox txtHoehe;
        private Button btnErstellen;
        private Button btnDrehen;
        private Label lblZoom;
        private TextBox txtZoomFaktor;
        private Button btnZoom;
        private Label lblEingabe;
        private Label lblAktionen;
        private Label lblErgebnisse;
        private Label label1;
        private Label lblFlaeche;
        private Label lblUmfang;
        private Label lblDiagonale;
        private Label lblFlaecheAusgabe;
        private Label lblUmfangAusgabe;
        private Label lblDiagonaleAusgabe;
        private Label lblFehlermeldung;
        private CheckBox chkIstQuadrat;
    }
}
