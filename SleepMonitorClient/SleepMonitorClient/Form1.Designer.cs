namespace SleepMonitorClient
{
    partial class Form1
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.numQuality = new System.Windows.Forms.NumericUpDown();
            this.dtWakeTime = new System.Windows.Forms.DateTimePicker();
            this.dtBedTime = new System.Windows.Forms.DateTimePicker();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.tab.SuspendLayout();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).BeginInit();
            this.tabLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabAdd);
            this.tab.Controls.Add(this.tabLog);
            this.tab.Controls.Add(this.tabChart);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1176, 655);
            this.tab.TabIndex = 1;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.PowderBlue;
            this.tabAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabAdd.BackgroundImage")));
            this.tabAdd.Controls.Add(this.cmbCategory);
            this.tabAdd.Controls.Add(this.label5);
            this.tabAdd.Controls.Add(this.label4);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Controls.Add(this.label1);
            this.tabAdd.Controls.Add(this.btnAdd);
            this.tabAdd.Controls.Add(this.txtNotes);
            this.tabAdd.Controls.Add(this.numQuality);
            this.tabAdd.Controls.Add(this.dtWakeTime);
            this.tabAdd.Controls.Add(this.dtBedTime);
            this.tabAdd.Controls.Add(this.lblSuggestion);
            this.tabAdd.Location = new System.Drawing.Point(4, 25);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(1168, 626);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Adăugare Noapte";
            this.tabAdd.Click += new System.EventHandler(this.tabAdd_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(166, 185);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 24);
            this.cmbCategory.TabIndex = 10;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(115, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adauga intervalul de somn ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(105, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Acorda o nota somnului:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(693, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Noteaza-ti visele ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ora trezire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ora culcare";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(306, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 102);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Adaugă";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtNotes.Location = new System.Drawing.Point(634, 185);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(431, 285);
            this.txtNotes.TabIndex = 3;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // numQuality
            // 
            this.numQuality.Location = new System.Drawing.Point(166, 265);
            this.numQuality.Name = "numQuality";
            this.numQuality.Size = new System.Drawing.Size(120, 22);
            this.numQuality.TabIndex = 2;
            this.numQuality.ValueChanged += new System.EventHandler(this.numQuality_ValueChanged);
            // 
            // dtWakeTime
            // 
            this.dtWakeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtWakeTime.Location = new System.Drawing.Point(381, 135);
            this.dtWakeTime.Name = "dtWakeTime";
            this.dtWakeTime.Size = new System.Drawing.Size(200, 22);
            this.dtWakeTime.TabIndex = 1;
            this.dtWakeTime.ValueChanged += new System.EventHandler(this.dtWakeTime_ValueChanged);
            // 
            // dtBedTime
            // 
            this.dtBedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtBedTime.Location = new System.Drawing.Point(96, 135);
            this.dtBedTime.Name = "dtBedTime";
            this.dtBedTime.Size = new System.Drawing.Size(200, 22);
            this.dtBedTime.TabIndex = 0;
            this.dtBedTime.ValueChanged += new System.EventHandler(this.dtBedTime_ValueChanged);
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.lblSuggestion.Location = new System.Drawing.Point(166, 300);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(0, 24);
            this.lblSuggestion.TabIndex = 11;
            // 
            // tabLog
            // 
            this.tabLog.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabLog.Controls.Add(this.btnRefresh);
            this.tabLog.Controls.Add(this.dataGridView1);
            this.tabLog.Location = new System.Drawing.Point(4, 25);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(1168, 626);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Jurnalul Somnului";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(50, 50);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(226, 50);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Reîmprospătează";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tabChart
            // 
            this.tabChart.BackColor = System.Drawing.Color.PowderBlue;
            this.tabChart.Location = new System.Drawing.Point(4, 25);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(1168, 626);
            this.tabChart.TabIndex = 2;
            this.tabChart.Text = "Grafic Somn";
            this.tabChart.Click += new System.EventHandler(this.tabChart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 655);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Monitorizarea Somnului";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).EndInit();
            this.tabLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.NumericUpDown numQuality;
        private System.Windows.Forms.DateTimePicker dtWakeTime;
        private System.Windows.Forms.DateTimePicker dtBedTime;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabChart;
    }
}
