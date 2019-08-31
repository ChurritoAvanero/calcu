namespace WindowsFormsApp1
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
            this.uno = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Divi = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Porce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uno
            // 
            this.uno.Location = new System.Drawing.Point(49, 293);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(64, 50);
            this.uno.TabIndex = 0;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.Uno_Click);
            // 
            // dos
            // 
            this.dos.Location = new System.Drawing.Point(140, 293);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(65, 52);
            this.dos.TabIndex = 1;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.Dos_Click);
            // 
            // tres
            // 
            this.tres.Location = new System.Drawing.Point(244, 293);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(66, 52);
            this.tres.TabIndex = 2;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.Button3_Click);
            // 
            // cuatro
            // 
            this.cuatro.Location = new System.Drawing.Point(49, 230);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(60, 47);
            this.cuatro.TabIndex = 3;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.Cuatro_Click);
            // 
            // cinco
            // 
            this.cinco.Location = new System.Drawing.Point(140, 231);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(65, 46);
            this.cinco.TabIndex = 4;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.Cinco_Click);
            // 
            // seis
            // 
            this.seis.Location = new System.Drawing.Point(244, 232);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(66, 45);
            this.seis.TabIndex = 5;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.Seis_Click);
            // 
            // siete
            // 
            this.siete.Location = new System.Drawing.Point(49, 161);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(58, 49);
            this.siete.TabIndex = 6;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = true;
            this.siete.Click += new System.EventHandler(this.Button7_Click);
            // 
            // ocho
            // 
            this.ocho.Location = new System.Drawing.Point(140, 161);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(65, 49);
            this.ocho.TabIndex = 7;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.Button8_Click);
            // 
            // nueve
            // 
            this.nueve.Location = new System.Drawing.Point(244, 161);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(66, 49);
            this.nueve.TabIndex = 8;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = true;
            this.nueve.Click += new System.EventHandler(this.Nueve_Click);
            // 
            // Pantalla
            // 
            this.Pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Pantalla.Location = new System.Drawing.Point(49, 48);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(440, 38);
            this.Pantalla.TabIndex = 9;
            this.Pantalla.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(348, 161);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(66, 49);
            this.Plus.TabIndex = 10;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Multi
            // 
            this.Multi.Location = new System.Drawing.Point(348, 296);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(66, 49);
            this.Multi.TabIndex = 11;
            this.Multi.Text = "X";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Divi
            // 
            this.Divi.Location = new System.Drawing.Point(348, 232);
            this.Divi.Name = "Divi";
            this.Divi.Size = new System.Drawing.Size(66, 51);
            this.Divi.TabIndex = 12;
            this.Divi.Text = "/";
            this.Divi.UseVisualStyleBackColor = true;
            this.Divi.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(348, 372);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(66, 49);
            this.Minus.TabIndex = 13;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Button4_Click);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(437, 161);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(66, 49);
            this.CE.TabIndex = 14;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(437, 296);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(66, 126);
            this.Result.TabIndex = 15;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(437, 239);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(66, 49);
            this.C.TabIndex = 16;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.Button7_Click_1);
            // 
            // cero
            // 
            this.cero.Location = new System.Drawing.Point(49, 370);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(66, 49);
            this.cero.TabIndex = 17;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.Cero_Click);
            // 
            // Point
            // 
            this.Point.Location = new System.Drawing.Point(140, 370);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(65, 52);
            this.Point.TabIndex = 18;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Porce
            // 
            this.Porce.Location = new System.Drawing.Point(244, 372);
            this.Porce.Name = "Porce";
            this.Porce.Size = new System.Drawing.Size(66, 50);
            this.Porce.TabIndex = 19;
            this.Porce.Text = "%";
            this.Porce.UseVisualStyleBackColor = true;
            this.Porce.Click += new System.EventHandler(this.Porce_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.Porce);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Divi);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.uno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button Divi;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Porce;
    }
}

