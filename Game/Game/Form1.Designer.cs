namespace Game
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Yellow;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_start.ForeColor = System.Drawing.Color.Red;
            this.btn_start.Location = new System.Drawing.Point(501, 136);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(131, 57);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Yellow;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_close.ForeColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(501, 219);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(131, 57);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // t1
            // 
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(127, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Yellow;
            this.pb1.Location = new System.Drawing.Point(21, 298);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(691, 23);
            this.pb1.TabIndex = 5;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 30.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(122, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 120);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome to \r\nOZ-Game\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(733, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Oz-Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.Label label2;
    }
}

