
namespace Song
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_song = new System.Windows.Forms.DataGridView();
            this.dgv_coda = new System.Windows.Forms.DataGridView();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_aggiungi_song = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Durata = new System.Windows.Forms.Label();
            this.txt_durata = new System.Windows.Forms.TextBox();
            this.txt_titolo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_play = new System.Windows.Forms.Button();
            this.lbl_quale_canzone = new System.Windows.Forms.Label();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_song)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_song
            // 
            this.dgv_song.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_song.Location = new System.Drawing.Point(426, 46);
            this.dgv_song.Name = "dgv_song";
            this.dgv_song.Size = new System.Drawing.Size(240, 150);
            this.dgv_song.TabIndex = 0;
            // 
            // dgv_coda
            // 
            this.dgv_coda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_coda.Location = new System.Drawing.Point(426, 250);
            this.dgv_coda.Name = "dgv_coda";
            this.dgv_coda.ReadOnly = true;
            this.dgv_coda.Size = new System.Drawing.Size(240, 150);
            this.dgv_coda.TabIndex = 1;
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(426, 203);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(240, 23);
            this.btn_aggiungi.TabIndex = 2;
            this.btn_aggiungi.Text = "Aggiungi alla coda";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_aggiungi_song);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Durata);
            this.groupBox1.Controls.Add(this.txt_durata);
            this.groupBox1.Controls.Add(this.txt_titolo);
            this.groupBox1.Location = new System.Drawing.Point(59, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 214);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_aggiungi_song
            // 
            this.btn_aggiungi_song.Location = new System.Drawing.Point(69, 167);
            this.btn_aggiungi_song.Name = "btn_aggiungi_song";
            this.btn_aggiungi_song.Size = new System.Drawing.Size(100, 23);
            this.btn_aggiungi_song.TabIndex = 4;
            this.btn_aggiungi_song.Text = "Aggiungi canzone";
            this.btn_aggiungi_song.UseVisualStyleBackColor = true;
            this.btn_aggiungi_song.Click += new System.EventHandler(this.btn_aggiungi_song_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titolo";
            // 
            // Durata
            // 
            this.Durata.AutoSize = true;
            this.Durata.Location = new System.Drawing.Point(7, 107);
            this.Durata.Name = "Durata";
            this.Durata.Size = new System.Drawing.Size(47, 13);
            this.Durata.TabIndex = 2;
            this.Durata.Text = "Duration";
            // 
            // txt_durata
            // 
            this.txt_durata.Location = new System.Drawing.Point(69, 104);
            this.txt_durata.Name = "txt_durata";
            this.txt_durata.Size = new System.Drawing.Size(100, 20);
            this.txt_durata.TabIndex = 1;
            // 
            // txt_titolo
            // 
            this.txt_titolo.Location = new System.Drawing.Point(69, 36);
            this.txt_titolo.Name = "txt_titolo";
            this.txt_titolo.Size = new System.Drawing.Size(100, 20);
            this.txt_titolo.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(117, 312);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(123, 42);
            this.btn_play.TabIndex = 4;
            this.btn_play.Text = "| >";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // lbl_quale_canzone
            // 
            this.lbl_quale_canzone.AutoSize = true;
            this.lbl_quale_canzone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quale_canzone.Location = new System.Drawing.Point(125, 407);
            this.lbl_quale_canzone.Name = "lbl_quale_canzone";
            this.lbl_quale_canzone.Size = new System.Drawing.Size(0, 16);
            this.lbl_quale_canzone.TabIndex = 5;
            this.lbl_quale_canzone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempo.Location = new System.Drawing.Point(171, 369);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(18, 20);
            this.lbl_tempo.TabIndex = 6;
            this.lbl_tempo.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.lbl_quale_canzone);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_aggiungi);
            this.Controls.Add(this.dgv_coda);
            this.Controls.Add(this.dgv_song);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_song)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_song;
        private System.Windows.Forms.DataGridView dgv_coda;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Durata;
        private System.Windows.Forms.TextBox txt_durata;
        private System.Windows.Forms.TextBox txt_titolo;
        private System.Windows.Forms.Button btn_aggiungi_song;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label lbl_quale_canzone;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.Button button1;
    }
}

