
namespace Test
{
    partial class Apparatenlijst
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toevoeg = new System.Windows.Forms.Button();
            this.toevoegtext = new System.Windows.Forms.TextBox();
            this.verwijdertext = new System.Windows.Forms.TextBox();
            this.verwijder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-6, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 59);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uitleensregistratiesysteem";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // toevoeg
            // 
            this.toevoeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.toevoeg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toevoeg.Location = new System.Drawing.Point(20, 357);
            this.toevoeg.Name = "toevoeg";
            this.toevoeg.Size = new System.Drawing.Size(99, 45);
            this.toevoeg.TabIndex = 9;
            this.toevoeg.Text = "Toevoegen";
            this.toevoeg.UseVisualStyleBackColor = true;
            this.toevoeg.Click += new System.EventHandler(this.button1_Click);
            // 
            // toevoegtext
            // 
            this.toevoegtext.Location = new System.Drawing.Point(12, 331);
            this.toevoegtext.Name = "toevoegtext";
            this.toevoegtext.Size = new System.Drawing.Size(126, 20);
            this.toevoegtext.TabIndex = 12;
            this.toevoegtext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // verwijdertext
            // 
            this.verwijdertext.Location = new System.Drawing.Point(246, 331);
            this.verwijdertext.Name = "verwijdertext";
            this.verwijdertext.Size = new System.Drawing.Size(126, 20);
            this.verwijdertext.TabIndex = 14;
            this.verwijdertext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // verwijder
            // 
            this.verwijder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.verwijder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.verwijder.Location = new System.Drawing.Point(256, 357);
            this.verwijder.Name = "verwijder";
            this.verwijder.Size = new System.Drawing.Size(99, 45);
            this.verwijder.TabIndex = 13;
            this.verwijder.Text = "Verwijderen";
            this.verwijder.UseVisualStyleBackColor = true;
            this.verwijder.Click += new System.EventHandler(this.verwijder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Apparaat Toevoegen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apparaat Verwijderen";
            // 
            // Apparatenlijst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 427);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verwijdertext);
            this.Controls.Add(this.verwijder);
            this.Controls.Add(this.toevoegtext);
            this.Controls.Add(this.toevoeg);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Apparatenlijst";
            this.Text = "Apparatenlijst";
            this.Load += new System.EventHandler(this.Apparatenlijst_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toevoeg;
        private System.Windows.Forms.TextBox toevoegtext;
        private System.Windows.Forms.TextBox verwijdertext;
        private System.Windows.Forms.Button verwijder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}