using System;
using System.Data;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;


namespace SleepMonitorClient
{
    public partial class Form1 : Form
    {
        // Declarați componentele controlului
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.Label lblQualityNote;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSleep;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inițializare ComboBox pentru categorii
            cmbCategory.Items.AddRange(new string[] { "Somn ușor", "Somn profund", "Somn cu întreruperi" });
            cmbCategory.SelectedIndex = 0;  // Setează prima opțiune ca selecționată

            // Inițializare etichete
            lblQualityNote = new Label();
            lblSuggestion = new Label();

            lblQualityNote.AutoSize = true;
            lblQualityNote.Location = new System.Drawing.Point(166, 290);
            lblQualityNote.Name = "lblQualityNote";
            lblQualityNote.Size = new System.Drawing.Size(0, 25);
            this.Controls.Add(lblQualityNote);

            lblSuggestion.AutoSize = true;
            lblSuggestion.Location = new System.Drawing.Point(166, 330);
            lblSuggestion.Name = "lblSuggestion";
            lblSuggestion.Size = new System.Drawing.Size(0, 25);
            this.Controls.Add(lblSuggestion);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem.ToString();
            string notes = txtNotes.Text;  // Textul introdus în TextBox pentru notițe
            DateTime bedTime = dtBedTime.Value;  // Ora culcare
            DateTime wakeTime = dtWakeTime.Value;  // Ora trezire
            int quality = (int)numQuality.Value;  // Nota pentru somn


            var sleepRecord = new
            {
                BedTime = bedTime,
                WakeTime = wakeTime,
                Category = selectedCategory,
                Notes = notes,
                Quality = quality
            };

            string apiUrl = "https://localhost:7123/api/sleeplogs";  

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json");

                    HttpResponseMessage response = await client.PostAsJsonAsync(apiUrl, sleepRecord);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Adăugat cu succes! Categoria: {selectedCategory}, Calitatea somnului: {quality}");
                    }
                    else
                    {
                        MessageBox.Show("A apărut o eroare la salvarea datelor. Te rugăm să încerci din nou.");
                    }
                }
            }
            catch (Exception ex)
            {
                // În cazul în care apar erori de rețea sau alte erori
                MessageBox.Show($"Eroare: {ex.Message}");
            }
        }

        private void tabAdd_Click(object sender, EventArgs e)
        {
            // Resetăm câmpurile de input la valorile implicite
            txtNotes.Clear();  // Golește câmpul de notițe
            numQuality.Value = 5;  // Resetează nota la 5
            dtBedTime.Value = DateTime.Now;  // Setează ora de culcare la ora curentă
            dtWakeTime.Value = DateTime.Now.AddHours(8);  // Setează ora de trezire la 8 ore mai târziu
            cmbCategory.SelectedIndex = 0;  // Setează categoria implicită pe primul element

            // Confirmare adăugare
            MessageBox.Show($"Adăugat cu succes!\nCategorie: {cmbCategory.SelectedItem.ToString()}\nOra de culcare: {dtBedTime.Value}\nOra de trezire: {dtWakeTime.Value}\nCalitatea somnului: {numQuality.Value}\nNote: {txtNotes.Text}");

            // Poți adăuga aici logica de salvare a datelor sau alte acțiuni specifice
        }

        private void dtBedTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime bedTime = dtBedTime.Value;

            // Verificăm dacă ora de culcare este mai târziu decât ora de trezire
            if (dtWakeTime.Value <= bedTime)
            {
                MessageBox.Show("Ora de trezire trebuie să fie după ora de culcare. Te rugăm să ajustezi unul dintre câmpuri.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtWakeTime.Value = bedTime.AddHours(8);  // Setează ora de trezire la 8 ore după ora de culcare
            }
            else
            {
                dtWakeTime.Value = bedTime.AddHours(8);  // Setează ora de trezire la 8 ore după ora de culcare
            }
        }

        private void dtWakeTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime wakeTime = dtWakeTime.Value;

            if (wakeTime <= dtBedTime.Value)
            {
                MessageBox.Show("Ora de trezire trebuie să fie după ora de culcare. Te rugăm să ajustezi unul dintre câmpuri.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtBedTime.Value = wakeTime.AddHours(-8);  // Setează ora de culcare la 8 ore înainte de ora de trezire
            }
        }

        private void numQuality_ValueChanged(object sender, EventArgs e)
        {
            int quality = (int)numQuality.Value;

            // Actualizăm eticheta pentru a arăta nota curentă
            if (lblQualityNote != null)
            {
                lblQualityNote.Text = $"Nota curentă: {quality}";
            }

            // Modificăm textul etichetei pentru sugestii
            if (lblSuggestion != null)
            {
                if (quality >= 8)
                {
                    lblSuggestion.Text = "Somn excelent! Continuă așa!";
                }
                else if (quality >= 5)
                {
                    lblSuggestion.Text = "Somn bun, dar ai putea îmbunătăți.";
                }
                else
                {
                    lblSuggestion.Text = "Somn insuficient. Încearcă să îmbunătățești rutina de somn.";
                }
            }

            // Verificăm dacă valoarea este validă
            if (quality < 1 || quality > 10)
            {
                MessageBox.Show("Valoarea notei trebuie să fie între 1 și 10.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            string notes = txtNotes.Text;
            // Exemplu: validare simplă
            if (notes.Length > 500)
            {
                MessageBox.Show("Ai introdus prea mult text. Limita este de 500 de caractere.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Exemplu de date temporare
            var logs = new List<SleepLog>
    {
        new SleepLog
        {
            BedTime = DateTime.Today.AddHours(22),
            WakeTime = DateTime.Today.AddDays(1).AddHours(6),
            Quality = 8,
            Category = "Normal",
            Notes = "Somn odihnitor"
        },
        new SleepLog
        {
            BedTime = DateTime.Today.AddHours(0),
            WakeTime = DateTime.Today.AddHours(7),
            Quality = 5,
            Category = "Fragmentat",
            Notes = "M-am trezit de câteva ori"
        }
    };

            dataGridView1.DataSource = logs;
        }

        private void tabChart_Click(object sender, EventArgs e)
        {
            // Exemplu: date simulate
            var logs = new List<SleepLog>
    {
        new SleepLog { BedTime = DateTime.Today.AddDays(-3), Quality = 7 },
        new SleepLog { BedTime = DateTime.Today.AddDays(-2), Quality = 6 },
        new SleepLog { BedTime = DateTime.Today.AddDays(-1), Quality = 8 },
        new SleepLog { BedTime = DateTime.Today, Quality = 5 }
    };

            chartSleep.Series["CalitateSomn"].Points.Clear();

            foreach (var log in logs)
            {
                chartSleep.Series["CalitateSomn"].Points.AddXY(log.BedTime.ToShortDateString(), log.Quality);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbCategory.SelectedItem.ToString();

            switch (selected)
            {
                case "Somn ușor":
                    lblSuggestion.Text = "Ai avut un somn ușor. Încearcă o rutină mai relaxantă înainte de culcare.";
                    break;
                case "Somn profund":
                    lblSuggestion.Text = "Excelent! Somnul profund ajută la regenerarea completă a corpului.";
                    break;
                case "Somn cu întreruperi":
                    lblSuggestion.Text = "Poate ar fi bine să investighezi cauzele întreruperilor din somn.";
                    break;
                default:
                    lblSuggestion.Text = "";
                    break;
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verifică dacă utilizatorul a dat clic pe un rând valid
            if (e.RowIndex >= 0)
            {
                // Obține datele din rândul selectat
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                // Exemplu de obținere a valorilor din celule
                DateTime bedTime = (DateTime)selectedRow.Cells["BedTime"].Value;
                DateTime wakeTime = (DateTime)selectedRow.Cells["WakeTime"].Value;
                int quality = (int)selectedRow.Cells["Quality"].Value;
                string category = (string)selectedRow.Cells["Category"].Value;
                string notes = (string)selectedRow.Cells["Notes"].Value;

                // Afișează informațiile în etichete sau alte controale
                lblSuggestion.Text = $"Categorie: {category}, Calitate: {quality}\nNote: {notes}";
                lblQualityNote.Text = $"Somn începând cu: {bedTime.ToShortTimeString()} și terminând la: {wakeTime.ToShortTimeString()}";
            }
        }

    }
}
