namespace Hangman
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSlutResultat = new System.Windows.Forms.Label();
            this.txtGuessTheWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShowLetters = new System.Windows.Forms.Label();
            this.btnGissaHelaOrdet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTheWord = new System.Windows.Forms.TextBox();
            this.btnNyttOrd = new System.Windows.Forms.Button();
            this.btnGissa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSlutResultat
            // 
            this.lblSlutResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSlutResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlutResultat.Location = new System.Drawing.Point(500, 74);
            this.lblSlutResultat.Name = "lblSlutResultat";
            this.lblSlutResultat.Size = new System.Drawing.Size(444, 29);
            this.lblSlutResultat.TabIndex = 2;
            // 
            // txtGuessTheWord
            // 
            this.txtGuessTheWord.Location = new System.Drawing.Point(500, 203);
            this.txtGuessTheWord.Name = "txtGuessTheWord";
            this.txtGuessTheWord.Size = new System.Drawing.Size(100, 20);
            this.txtGuessTheWord.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gissa hela ordet";
            // 
            // lblShowLetters
            // 
            this.lblShowLetters.AutoSize = true;
            this.lblShowLetters.Location = new System.Drawing.Point(836, 171);
            this.lblShowLetters.Name = "lblShowLetters";
            this.lblShowLetters.Size = new System.Drawing.Size(87, 13);
            this.lblShowLetters.TabIndex = 5;
            this.lblShowLetters.Text = "Bokstäver i ordet";
            // 
            // btnGissaHelaOrdet
            // 
            this.btnGissaHelaOrdet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGissaHelaOrdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGissaHelaOrdet.Location = new System.Drawing.Point(500, 278);
            this.btnGissaHelaOrdet.Name = "btnGissaHelaOrdet";
            this.btnGissaHelaOrdet.Size = new System.Drawing.Size(164, 39);
            this.btnGissaHelaOrdet.TabIndex = 6;
            this.btnGissaHelaOrdet.Text = "Gissa hela ordet";
            this.btnGissaHelaOrdet.UseVisualStyleBackColor = false;
       
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(836, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Skriv bokstav:";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(927, 287);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(51, 20);
            this.txtGuess.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "skriv ord att gissa:";
            // 
            // txtTheWord
            // 
            this.txtTheWord.Location = new System.Drawing.Point(633, 453);
            this.txtTheWord.Name = "txtTheWord";
            this.txtTheWord.Size = new System.Drawing.Size(185, 20);
            this.txtTheWord.TabIndex = 10;
            // 
            // btnNyttOrd
            // 
            this.btnNyttOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNyttOrd.Location = new System.Drawing.Point(870, 431);
            this.btnNyttOrd.Name = "btnNyttOrd";
            this.btnNyttOrd.Size = new System.Drawing.Size(108, 42);
            this.btnNyttOrd.TabIndex = 11;
            this.btnNyttOrd.Text = "Registera";
            this.btnNyttOrd.UseVisualStyleBackColor = true;
            this.btnNyttOrd.Click += new System.EventHandler(this.btnNyttOrd_Click);
            // 
            // btnGissa
            // 
            this.btnGissa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGissa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGissa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGissa.Location = new System.Drawing.Point(1039, 282);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(70, 28);
            this.btnGissa.TabIndex = 12;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = false;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hangman.Properties.Resources.Galge;
            this.pictureBox1.Location = new System.Drawing.Point(118, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 259);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGissa);
            this.Controls.Add(this.btnNyttOrd);
            this.Controls.Add(this.txtTheWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGissaHelaOrdet);
            this.Controls.Add(this.lblShowLetters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGuessTheWord);
            this.Controls.Add(this.lblSlutResultat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSlutResultat;
        private System.Windows.Forms.TextBox txtGuessTheWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShowLetters;
        private System.Windows.Forms.Button btnGissaHelaOrdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTheWord;
        private System.Windows.Forms.Button btnNyttOrd;
        private System.Windows.Forms.Button btnGissa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

