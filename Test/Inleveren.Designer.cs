
namespace Test
{
    partial class Inleveren
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
            this.opmerking = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.leerlingnummer = new System.Windows.Forms.TextBox();
            this.apparaat = new System.Windows.Forms.TextBox();
            this.naamr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // opmerking
            // 
            this.opmerking.AccessibleName = "opmerking";
            this.opmerking.Location = new System.Drawing.Point(671, 165);
            this.opmerking.Multiline = true;
            this.opmerking.Name = "opmerking";
            this.opmerking.Size = new System.Drawing.Size(101, 128);
            this.opmerking.TabIndex = 21;
            this.opmerking.TextChanged += new System.EventHandler(this.opmerking_TextChanged);
            // 
            // label5
            // 
            this.label5.AccessibleName = "opmerking";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Opmerkingen";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 88);
            this.button2.TabIndex = 19;
            this.button2.Text = "exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 88);
            this.button1.TabIndex = 18;
            this.button1.Text = "Inleveren apparaat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(7, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 425);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Inleveren apparaten";
            // 
            // leerlingnummer
            // 
            this.leerlingnummer.AccessibleName = "leerlingnummer";
            this.leerlingnummer.Location = new System.Drawing.Point(549, 273);
            this.leerlingnummer.Name = "leerlingnummer";
            this.leerlingnummer.Size = new System.Drawing.Size(100, 20);
            this.leerlingnummer.TabIndex = 16;
            this.leerlingnummer.TextChanged += new System.EventHandler(this.leerlingnummer_TextChanged);
            // 
            // apparaat
            // 
            this.apparaat.AccessibleName = "apparaat";
            this.apparaat.Location = new System.Drawing.Point(549, 220);
            this.apparaat.Name = "apparaat";
            this.apparaat.Size = new System.Drawing.Size(100, 20);
            this.apparaat.TabIndex = 15;
            this.apparaat.TextChanged += new System.EventHandler(this.apparaat_TextChanged);
            // 
            // naamr
            // 
            this.naamr.AccessibleName = "naamr";
            this.naamr.Location = new System.Drawing.Point(549, 165);
            this.naamr.Name = "naamr";
            this.naamr.Size = new System.Drawing.Size(100, 20);
            this.naamr.TabIndex = 14;
            this.naamr.TextChanged += new System.EventHandler(this.naamr_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Leerlingnummer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apparaat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Naam";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Inleveren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 447);
            this.Controls.Add(this.opmerking);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leerlingnummer);
            this.Controls.Add(this.apparaat);
            this.Controls.Add(this.naamr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Inleveren";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Inleveren_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox opmerking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox leerlingnummer;
        private System.Windows.Forms.TextBox apparaat;
        private System.Windows.Forms.TextBox naamr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}