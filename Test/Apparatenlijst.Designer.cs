
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
            this.toevoegg = new System.Windows.Forms.TextBox();
            this.verwijderr = new System.Windows.Forms.TextBox();
            this.verwijder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lijst = new System.Windows.Forms.ListView();
            this.apparaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uitgeleend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uitlener = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.terugg = new System.Windows.Forms.Button();
            this.opmerkingen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-12, -8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 113);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(40, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(750, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uitleensregistratiesysteem";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // toevoeg
            // 
            this.toevoeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.toevoeg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toevoeg.Location = new System.Drawing.Point(40, 687);
            this.toevoeg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.toevoeg.Name = "toevoeg";
            this.toevoeg.Size = new System.Drawing.Size(198, 87);
            this.toevoeg.TabIndex = 9;
            this.toevoeg.Text = "Toevoegen";
            this.toevoeg.UseVisualStyleBackColor = true;
            this.toevoeg.Click += new System.EventHandler(this.button1_Click);
            // 
            // toevoegg
            // 
            this.toevoegg.Location = new System.Drawing.Point(24, 637);
            this.toevoegg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.toevoegg.Name = "toevoegg";
            this.toevoegg.Size = new System.Drawing.Size(248, 31);
            this.toevoegg.TabIndex = 12;
            this.toevoegg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // verwijderr
            // 
            this.verwijderr.Location = new System.Drawing.Point(492, 637);
            this.verwijderr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.verwijderr.Name = "verwijderr";
            this.verwijderr.Size = new System.Drawing.Size(248, 31);
            this.verwijderr.TabIndex = 14;
            this.verwijderr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // verwijder
            // 
            this.verwijder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.verwijder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.verwijder.Location = new System.Drawing.Point(512, 687);
            this.verwijder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.verwijder.Name = "verwijder";
            this.verwijder.Size = new System.Drawing.Size(198, 87);
            this.verwijder.TabIndex = 13;
            this.verwijder.Text = "Verwijderen";
            this.verwijder.UseVisualStyleBackColor = true;
            this.verwijder.Click += new System.EventHandler(this.verwijder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 606);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Apparaat Toevoegen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 606);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apparaat Verwijderen";
            // 
            // Lijst
            // 
            this.Lijst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.apparaat,
            this.uitgeleend,
            this.uitlener,
            this.opmerkingen});
            this.Lijst.FullRowSelect = true;
            this.Lijst.HideSelection = false;
            this.Lijst.Location = new System.Drawing.Point(24, 217);
            this.Lijst.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Lijst.Name = "Lijst";
            this.Lijst.Size = new System.Drawing.Size(738, 356);
            this.Lijst.TabIndex = 17;
            this.Lijst.UseCompatibleStateImageBehavior = false;
            this.Lijst.View = System.Windows.Forms.View.Details;
            this.Lijst.SelectedIndexChanged += new System.EventHandler(this.Lijst_SelectedIndexChanged);
            // 
            // apparaat
            // 
            this.apparaat.Text = " Apparaat";
            this.apparaat.Width = 150;
            // 
            // uitgeleend
            // 
            this.uitgeleend.Text = "Status";
            this.uitgeleend.Width = 150;
            // 
            // uitlener
            // 
            this.uitlener.Text = "Uitlener";
            this.uitlener.Width = 163;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 58);
            this.button1.TabIndex = 18;
            this.button1.Text = "Verschoon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // terugg
            // 
            this.terugg.AutoEllipsis = true;
            this.terugg.Location = new System.Drawing.Point(296, 748);
            this.terugg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.terugg.Name = "terugg";
            this.terugg.Size = new System.Drawing.Size(174, 77);
            this.terugg.TabIndex = 19;
            this.terugg.Text = "terug naar beginscherm";
            this.terugg.UseVisualStyleBackColor = true;
            this.terugg.Click += new System.EventHandler(this.terugg_Click);
            // 
            // opmerkingen
            // 
            this.opmerkingen.Text = "Opmerkingen";
            // 
            // Apparatenlijst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 821);
            this.Controls.Add(this.terugg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lijst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verwijderr);
            this.Controls.Add(this.verwijder);
            this.Controls.Add(this.toevoegg);
            this.Controls.Add(this.toevoeg);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox toevoegg;
        private System.Windows.Forms.TextBox verwijderr;
        private System.Windows.Forms.Button verwijder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView Lijst;
        private System.Windows.Forms.ColumnHeader apparaat;
        private System.Windows.Forms.ColumnHeader uitgeleend;
        private System.Windows.Forms.ColumnHeader uitlener;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button terugg;
        private System.Windows.Forms.ColumnHeader opmerkingen;
    }
}