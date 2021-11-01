namespace Project_Tetris
{
    partial class Tetris
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Spustanje = new System.Windows.Forms.Timer(this.components);
            this.Tetris_Box = new System.Windows.Forms.PictureBox();
            this.Restart = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.PictureBox();
            this.Rezultat = new System.Windows.Forms.Timer(this.components);
            this.Rezultati = new System.Windows.Forms.ListBox();
            this.PrikazRezultata = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PodesavanjeBrzine = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tetris_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PodesavanjeBrzine)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 10);
            this.Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(149, 50);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(12, 66);
            this.Stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(149, 50);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Spustanje
            // 
            this.Spustanje.Interval = 400;
            this.Spustanje.Tick += new System.EventHandler(this.Spustanje_Tick);
            // 
            // Tetris_Box
            // 
            this.Tetris_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Tetris_Box.Location = new System.Drawing.Point(175, 10);
            this.Tetris_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tetris_Box.Name = "Tetris_Box";
            this.Tetris_Box.Size = new System.Drawing.Size(349, 700);
            this.Tetris_Box.TabIndex = 2;
            this.Tetris_Box.TabStop = false;
            this.Tetris_Box.Paint += new System.Windows.Forms.PaintEventHandler(this.Tetris_Box_Paint);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(12, 122);
            this.Restart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(149, 50);
            this.Restart.TabIndex = 3;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Next.Location = new System.Drawing.Point(531, 12);
            this.Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(140, 140);
            this.Next.TabIndex = 4;
            this.Next.TabStop = false;
            this.Next.Paint += new System.Windows.Forms.PaintEventHandler(this.Next_Paint);
            // 
            // Rezultat
            // 
            this.Rezultat.Interval = 500;
            this.Rezultat.Tick += new System.EventHandler(this.Rezultat_Tick);
            // 
            // Rezultati
            // 
            this.Rezultati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rezultati.FormattingEnabled = true;
            this.Rezultati.ItemHeight = 20;
            this.Rezultati.Location = new System.Drawing.Point(531, 375);
            this.Rezultati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rezultati.Name = "Rezultati";
            this.Rezultati.Size = new System.Drawing.Size(289, 104);
            this.Rezultati.TabIndex = 5;
            // 
            // PrikazRezultata
            // 
            this.PrikazRezultata.AutoSize = true;
            this.PrikazRezultata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrikazRezultata.Location = new System.Drawing.Point(531, 199);
            this.PrikazRezultata.Name = "PrikazRezultata";
            this.PrikazRezultata.Size = new System.Drawing.Size(81, 29);
            this.PrikazRezultata.TabIndex = 6;
            this.PrikazRezultata.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rezultat";
            // 
            // PodesavanjeBrzine
            // 
            this.PodesavanjeBrzine.Location = new System.Drawing.Point(733, 369);
            this.PodesavanjeBrzine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PodesavanjeBrzine.Maximum = 600;
            this.PodesavanjeBrzine.Minimum = 300;
            this.PodesavanjeBrzine.Name = "PodesavanjeBrzine";
            this.PodesavanjeBrzine.Size = new System.Drawing.Size(239, 56);
            this.PodesavanjeBrzine.TabIndex = 8;
            this.PodesavanjeBrzine.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PodesavanjeBrzine.Value = 450;
            this.PodesavanjeBrzine.ValueChanged += new System.EventHandler(this.PodesavanjeBrzine_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(733, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Brzina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(733, 738);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 140);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kontrole:\r\nSpace - Start\r\nEsc - Pauza\r\na - Pomeranje levo\r\nd - Pomeranje desno\r\ns" +
    " - Padanje na najdalju mogucu poziciju\r\nw - Rotacija";
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(12, 198);
            this.Ime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(120, 22);
            this.Ime.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ime";
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1107, 725);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PodesavanjeBrzine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrikazRezultata);
            this.Controls.Add(this.Rezultati);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Tetris_Box);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tetris";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tetris_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Tetris_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PodesavanjeBrzine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer Spustanje;
        private System.Windows.Forms.PictureBox Tetris_Box;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.PictureBox Next;
        private System.Windows.Forms.Timer Rezultat;
        private System.Windows.Forms.ListBox Rezultati;
        private System.Windows.Forms.Label PrikazRezultata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar PodesavanjeBrzine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.Label label4;
    }
}

