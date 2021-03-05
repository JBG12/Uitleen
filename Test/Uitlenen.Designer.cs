
namespace Test
{
    partial class Uitlenen
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
            this.label1 = new System.Windows.Forms.Label();
            this.nummert = new System.Windows.Forms.TextBox();
            this.uitleen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apparaatr = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 59);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uitleensregistratiesysteem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(142, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Uitlenen";
            // 
            // nummert
            // 
            this.nummert.Location = new System.Drawing.Point(123, 140);
            this.nummert.Multiline = true;
            this.nummert.Name = "nummert";
            this.nummert.Size = new System.Drawing.Size(126, 20);
            this.nummert.TabIndex = 17;
            // 
            // uitleen
            // 
            this.uitleen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.uitleen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uitleen.Location = new System.Drawing.Point(136, 223);
            this.uitleen.Name = "uitleen";
            this.uitleen.Size = new System.Drawing.Size(99, 28);
            this.uitleen.TabIndex = 16;
            this.uitleen.Text = "Uitlenen";
            this.uitleen.UseVisualStyleBackColor = true;
            this.uitleen.Click += new System.EventHandler(this.uitleen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Leerlingnummer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Apparaat";
            // 
            // apparaatr
            // 
            this.apparaatr.Location = new System.Drawing.Point(123, 188);
            this.apparaatr.Multiline = true;
            this.apparaatr.Name = "apparaatr";
            this.apparaatr.Size = new System.Drawing.Size(126, 20);
            this.apparaatr.TabIndex = 20;
            // 
            // Uitlenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 377);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apparaatr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nummert);
            this.Controls.Add(this.uitleen);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Uitlenen";
            this.Text = "Uilenen";
            this.Load += new System.EventHandler(this.Uitlenen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nummert;
        private System.Windows.Forms.Button uitleen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox apparaatr;
    }
}