namespace button.ornek._45
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYazili1 = new System.Windows.Forms.TextBox();
            this.txtYazili2 = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazılı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazılı 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ortalama";
            // 
            // txtYazili1
            // 
            this.txtYazili1.Location = new System.Drawing.Point(106, 54);
            this.txtYazili1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYazili1.Name = "txtYazili1";
            this.txtYazili1.Size = new System.Drawing.Size(148, 26);
            this.txtYazili1.TabIndex = 3;
            // 
            // txtYazili2
            // 
            this.txtYazili2.Location = new System.Drawing.Point(106, 97);
            this.txtYazili2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYazili2.Name = "txtYazili2";
            this.txtYazili2.Size = new System.Drawing.Size(148, 26);
            this.txtYazili2.TabIndex = 4;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(106, 145);
            this.txtOrtalama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(148, 26);
            this.txtOrtalama.TabIndex = 5;
            this.txtOrtalama.TextChanged += new System.EventHandler(this.txtOrtalama_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.txtYazili2);
            this.Controls.Add(this.txtYazili1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYazili1;
        private System.Windows.Forms.TextBox txtYazili2;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Button button1;
    }
}

