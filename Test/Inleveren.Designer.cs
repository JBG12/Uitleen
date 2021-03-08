
namespace uitleen
{
    partial class inleveren
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apparaat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Leerlingnummer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // apparaatt
            // 
            this.apparaatt.AccessibleName = "apparaat";
            this.apparaatt.Location = new System.Drawing.Point(555, 222);
            this.apparaatt.Name = "apparaatt";
            this.apparaatt.Size = new System.Drawing.Size(100, 20);
            this.apparaatt.TabIndex = 4;
            this.apparaatt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // leerlingnummert
            // 
            this.leerlingnummert.AccessibleName = "leerlingnummer";
            this.leerlingnummert.Location = new System.Drawing.Point(555, 275);
            this.leerlingnummert.Name = "leerlingnummert";
            this.leerlingnummert.Size = new System.Drawing.Size(100, 20);
            this.leerlingnummert.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 425);
            this.panel1.TabIndex = 6;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 88);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inleveren apparaat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 332);
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
            this.label5.Location = new System.Drawing.Point(692, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Opmerkingen";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // opmerkingt
            // 
            this.opmerkingt.AccessibleName = "opmerking";
            this.opmerkingt.Location = new System.Drawing.Point(677, 222);
            this.opmerkingt.Multiline = true;
            this.opmerkingt.Name = "opmerkingt";
            this.opmerkingt.Size = new System.Drawing.Size(101, 73);
            this.opmerkingt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opmerkingt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leerlingnummert);
            this.Controls.Add(this.apparaatt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "inleveren";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

