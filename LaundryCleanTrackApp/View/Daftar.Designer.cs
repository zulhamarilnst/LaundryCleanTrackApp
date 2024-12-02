namespace LaundryCleanTrackApp.View
{
    partial class Daftar
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
            this.groupBox_Daftar = new System.Windows.Forms.GroupBox();
            this.button_Berikutnya = new System.Windows.Forms.Button();
            this.textBox_phone_number = new System.Windows.Forms.TextBox();
            this.groupBox_Daftar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Daftar
            // 
            this.groupBox_Daftar.Controls.Add(this.textBox_phone_number);
            this.groupBox_Daftar.Controls.Add(this.button_Berikutnya);
            this.groupBox_Daftar.Location = new System.Drawing.Point(176, 177);
            this.groupBox_Daftar.Name = "groupBox_Daftar";
            this.groupBox_Daftar.Size = new System.Drawing.Size(413, 180);
            this.groupBox_Daftar.TabIndex = 0;
            this.groupBox_Daftar.TabStop = false;
            this.groupBox_Daftar.Text = "Daftar";
            this.groupBox_Daftar.Enter += new System.EventHandler(this.groupBox_Daftar_Enter);
            // 
            // button_Berikutnya
            // 
            this.button_Berikutnya.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Berikutnya.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Berikutnya.Location = new System.Drawing.Point(18, 104);
            this.button_Berikutnya.Name = "button_Berikutnya";
            this.button_Berikutnya.Size = new System.Drawing.Size(380, 58);
            this.button_Berikutnya.TabIndex = 0;
            this.button_Berikutnya.Text = "Berikutnya";
            this.button_Berikutnya.UseVisualStyleBackColor = false;
            this.button_Berikutnya.Click += new System.EventHandler(this.button_Berikutnya_Click);
            // 
            // textBox_phone_number
            // 
            this.textBox_phone_number.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_phone_number.Location = new System.Drawing.Point(18, 55);
            this.textBox_phone_number.Name = "textBox_phone_number";
            this.textBox_phone_number.Size = new System.Drawing.Size(380, 26);
            this.textBox_phone_number.TabIndex = 1;
            this.textBox_phone_number.Text = "No.Handphone";
            this.textBox_phone_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_phone_number.TextChanged += new System.EventHandler(this.textBox_phone_number_TextChanged);
            // 
            // Daftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Daftar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Daftar";
            this.Text = "Form1";
            this.groupBox_Daftar.ResumeLayout(false);
            this.groupBox_Daftar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Daftar;
        private System.Windows.Forms.TextBox textBox_phone_number;
        private System.Windows.Forms.Button button_Berikutnya;
    }
}