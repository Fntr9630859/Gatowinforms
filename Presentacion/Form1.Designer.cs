namespace Gato
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textpun1 = new System.Windows.Forms.TextBox();
            this.textpun2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.x3y1 = new System.Windows.Forms.Button();
            this.x2y1 = new System.Windows.Forms.Button();
            this.x1y1 = new System.Windows.Forms.Button();
            this.x3y2 = new System.Windows.Forms.Button();
            this.x2y2 = new System.Windows.Forms.Button();
            this.x1y2 = new System.Windows.Forms.Button();
            this.x3y3 = new System.Windows.Forms.Button();
            this.x2y3 = new System.Windows.Forms.Button();
            this.x1y3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jugador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jugador 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(363, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textpun1
            // 
            this.textpun1.Enabled = false;
            this.textpun1.Location = new System.Drawing.Point(454, 28);
            this.textpun1.Name = "textpun1";
            this.textpun1.ReadOnly = true;
            this.textpun1.Size = new System.Drawing.Size(27, 20);
            this.textpun1.TabIndex = 12;
            this.textpun1.Text = "0";
            this.textpun1.TextChanged += new System.EventHandler(this.textpun1_TextChanged);
            // 
            // textpun2
            // 
            this.textpun2.Enabled = false;
            this.textpun2.Location = new System.Drawing.Point(454, 132);
            this.textpun2.Name = "textpun2";
            this.textpun2.ReadOnly = true;
            this.textpun2.Size = new System.Drawing.Size(27, 20);
            this.textpun2.TabIndex = 13;
            this.textpun2.Text = "0";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Gato.Properties.Resources.circulo_jugador;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(363, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImage = global::Gato.Properties.Resources.tache_jugador;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(363, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // x3y1
            // 
            this.x3y1.BackColor = System.Drawing.Color.Transparent;
            this.x3y1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x3y1.BackgroundImage")));
            this.x3y1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x3y1.Location = new System.Drawing.Point(224, 240);
            this.x3y1.Name = "x3y1";
            this.x3y1.Size = new System.Drawing.Size(100, 100);
            this.x3y1.TabIndex = 8;
            this.x3y1.Text = "\r\n";
            this.x3y1.UseVisualStyleBackColor = false;
            this.x3y1.Click += new System.EventHandler(this.x3y1_Click);
            // 
            // x2y1
            // 
            this.x2y1.BackColor = System.Drawing.Color.Transparent;
            this.x2y1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x2y1.BackgroundImage")));
            this.x2y1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x2y1.Location = new System.Drawing.Point(118, 240);
            this.x2y1.Name = "x2y1";
            this.x2y1.Size = new System.Drawing.Size(100, 100);
            this.x2y1.TabIndex = 7;
            this.x2y1.Text = "\r\n";
            this.x2y1.UseVisualStyleBackColor = false;
            this.x2y1.Click += new System.EventHandler(this.x2y1_Click);
            // 
            // x1y1
            // 
            this.x1y1.BackColor = System.Drawing.Color.Transparent;
            this.x1y1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x1y1.BackgroundImage")));
            this.x1y1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x1y1.Location = new System.Drawing.Point(12, 240);
            this.x1y1.Name = "x1y1";
            this.x1y1.Size = new System.Drawing.Size(100, 100);
            this.x1y1.TabIndex = 6;
            this.x1y1.Text = "\r\n";
            this.x1y1.UseVisualStyleBackColor = false;
            this.x1y1.Click += new System.EventHandler(this.x1y1_Click);
            // 
            // x3y2
            // 
            this.x3y2.BackColor = System.Drawing.Color.Transparent;
            this.x3y2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x3y2.BackgroundImage")));
            this.x3y2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x3y2.Location = new System.Drawing.Point(224, 134);
            this.x3y2.Name = "x3y2";
            this.x3y2.Size = new System.Drawing.Size(100, 100);
            this.x3y2.TabIndex = 5;
            this.x3y2.Text = "\r\n";
            this.x3y2.UseVisualStyleBackColor = false;
            this.x3y2.Click += new System.EventHandler(this.x3y2_Click);
            // 
            // x2y2
            // 
            this.x2y2.BackColor = System.Drawing.Color.Transparent;
            this.x2y2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x2y2.BackgroundImage")));
            this.x2y2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x2y2.Location = new System.Drawing.Point(118, 134);
            this.x2y2.Name = "x2y2";
            this.x2y2.Size = new System.Drawing.Size(100, 100);
            this.x2y2.TabIndex = 4;
            this.x2y2.Text = "\r\n";
            this.x2y2.UseVisualStyleBackColor = false;
            this.x2y2.Click += new System.EventHandler(this.x2y2_Click);
            // 
            // x1y2
            // 
            this.x1y2.BackColor = System.Drawing.Color.Transparent;
            this.x1y2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x1y2.BackgroundImage")));
            this.x1y2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x1y2.Location = new System.Drawing.Point(12, 134);
            this.x1y2.Name = "x1y2";
            this.x1y2.Size = new System.Drawing.Size(100, 100);
            this.x1y2.TabIndex = 3;
            this.x1y2.Text = "\r\n";
            this.x1y2.UseVisualStyleBackColor = false;
            this.x1y2.Click += new System.EventHandler(this.x1y2_Click);
            // 
            // x3y3
            // 
            this.x3y3.BackColor = System.Drawing.Color.Transparent;
            this.x3y3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x3y3.BackgroundImage")));
            this.x3y3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x3y3.Location = new System.Drawing.Point(224, 28);
            this.x3y3.Name = "x3y3";
            this.x3y3.Size = new System.Drawing.Size(100, 100);
            this.x3y3.TabIndex = 2;
            this.x3y3.Text = "\r\n";
            this.x3y3.UseVisualStyleBackColor = false;
            this.x3y3.Click += new System.EventHandler(this.x3y3_Click);
            // 
            // x2y3
            // 
            this.x2y3.BackColor = System.Drawing.Color.Transparent;
            this.x2y3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x2y3.BackgroundImage")));
            this.x2y3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x2y3.Location = new System.Drawing.Point(118, 28);
            this.x2y3.Name = "x2y3";
            this.x2y3.Size = new System.Drawing.Size(100, 100);
            this.x2y3.TabIndex = 1;
            this.x2y3.Text = "\r\n";
            this.x2y3.UseVisualStyleBackColor = false;
            this.x2y3.Click += new System.EventHandler(this.x2y3_Click);
            // 
            // x1y3
            // 
            this.x1y3.BackColor = System.Drawing.Color.Transparent;
            this.x1y3.BackgroundImage = global::Gato.Properties.Resources.Cuadro_negro;
            this.x1y3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.x1y3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x1y3.Location = new System.Drawing.Point(12, 28);
            this.x1y3.Name = "x1y3";
            this.x1y3.Size = new System.Drawing.Size(100, 100);
            this.x1y3.TabIndex = 0;
            this.x1y3.Text = "\r\n";
            this.x1y3.UseVisualStyleBackColor = false;
            this.x1y3.Click += new System.EventHandler(this.x1y3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 352);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textpun2);
            this.Controls.Add(this.textpun1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x3y1);
            this.Controls.Add(this.x2y1);
            this.Controls.Add(this.x1y1);
            this.Controls.Add(this.x3y2);
            this.Controls.Add(this.x2y2);
            this.Controls.Add(this.x1y2);
            this.Controls.Add(this.x3y3);
            this.Controls.Add(this.x2y3);
            this.Controls.Add(this.x1y3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button x1y3;
        private System.Windows.Forms.Button x2y3;
        private System.Windows.Forms.Button x3y3;
        private System.Windows.Forms.Button x1y2;
        private System.Windows.Forms.Button x2y2;
        private System.Windows.Forms.Button x3y2;
        private System.Windows.Forms.Button x1y1;
        private System.Windows.Forms.Button x2y1;
        private System.Windows.Forms.Button x3y1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textpun1;
        private System.Windows.Forms.TextBox textpun2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

