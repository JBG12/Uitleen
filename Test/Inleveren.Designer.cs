﻿
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apparaatt = new System.Windows.Forms.TextBox();
            this.leerlingnummert = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.opmerkingt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.terugg = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apparaat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Leerlingnummer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // apparaatt
            // 
            this.apparaatt.AccessibleName = "apparaat";
            this.apparaatt.Location = new System.Drawing.Point(279, 111);
            this.apparaatt.Name = "apparaatt";
            this.apparaatt.Size = new System.Drawing.Size(100, 20);
            this.apparaatt.TabIndex = 4;
            this.apparaatt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // leerlingnummert
            // 
            this.leerlingnummert.AccessibleName = "leerlingnummer";
            this.leerlingnummert.Location = new System.Drawing.Point(279, 164);
            this.leerlingnummert.Name = "leerlingnummert";
            this.leerlingnummert.Size = new System.Drawing.Size(100, 20);
            this.leerlingnummert.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.terugg);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 386);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Inleveren apparaten";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 88);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inleveren apparaat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 88);
            this.button2.TabIndex = 8;
            this.button2.Text = "exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AccessibleName = "opmerking";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Opmerkingen";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // opmerkingt
            // 
            this.opmerkingt.AccessibleName = "opmerking";
            this.opmerkingt.Location = new System.Drawing.Point(278, 234);
            this.opmerkingt.Multiline = true;
            this.opmerkingt.Name = "opmerkingt";
            this.opmerkingt.Size = new System.Drawing.Size(101, 73);
            this.opmerkingt.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 56);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uitleensregistratiesysteem";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // terugg
            // 
            this.terugg.AutoEllipsis = true;
            this.terugg.Location = new System.Drawing.Point(9, 324);
            this.terugg.Name = "terugg";
            this.terugg.Size = new System.Drawing.Size(101, 55);
            this.terugg.TabIndex = 13;
            this.terugg.Text = "terug naar beginscherm";
            this.terugg.UseVisualStyleBackColor = true;
            this.terugg.Click += new System.EventHandler(this.terugg_Click);
            // 
            // Inleveren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.opmerkingt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leerlingnummert);
            this.Controls.Add(this.apparaatt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Inleveren";
            this.Text = "inleveren";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apparaatt;
        private System.Windows.Forms.TextBox leerlingnummert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox opmerkingt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button terugg;
    }
}

