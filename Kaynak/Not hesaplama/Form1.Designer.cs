namespace Not_hesaplama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Vize = new TextBox();
            Final = new TextBox();
            VizeNot = new Label();
            FinalNot = new Label();
            button1 = new Button();
            Ortalamalabel = new Label();
            Durumlabel = new Label();
            tortalama = new Label();
            tdurum = new Label();
            SuspendLayout();
            // 
            // Vize
            // 
            Vize.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Vize.Location = new Point(94, 38);
            Vize.Name = "Vize";
            Vize.Size = new Size(103, 26);
            Vize.TabIndex = 1;
            // 
            // Final
            // 
            Final.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Final.ForeColor = SystemColors.WindowText;
            Final.Location = new Point(94, 86);
            Final.Name = "Final";
            Final.Size = new Size(103, 26);
            Final.TabIndex = 2;
            // 
            // VizeNot
            // 
            VizeNot.AutoSize = true;
            VizeNot.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            VizeNot.ForeColor = Color.Red;
            VizeNot.Location = new Point(31, 38);
            VizeNot.Name = "VizeNot";
            VizeNot.Size = new Size(57, 22);
            VizeNot.TabIndex = 3;
            VizeNot.Text = "Vize: ";
            // 
            // FinalNot
            // 
            FinalNot.AutoSize = true;
            FinalNot.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FinalNot.ForeColor = Color.Red;
            FinalNot.Location = new Point(31, 86);
            FinalNot.Name = "FinalNot";
            FinalNot.Size = new Size(60, 22);
            FinalNot.TabIndex = 4;
            FinalNot.Text = "Final: ";
            FinalNot.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 0, 64);
            button1.Location = new Point(31, 133);
            button1.Name = "button1";
            button1.Size = new Size(166, 44);
            button1.TabIndex = 5;
            button1.Text = "Notunu hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ortalamalabel
            // 
            Ortalamalabel.AutoSize = true;
            Ortalamalabel.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Ortalamalabel.ForeColor = Color.Red;
            Ortalamalabel.Location = new Point(254, 38);
            Ortalamalabel.Name = "Ortalamalabel";
            Ortalamalabel.Size = new Size(91, 22);
            Ortalamalabel.TabIndex = 6;
            Ortalamalabel.Text = "Ortalama:";
            Ortalamalabel.Click += label3_Click;
            // 
            // Durumlabel
            // 
            Durumlabel.AutoSize = true;
            Durumlabel.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Durumlabel.ForeColor = Color.Red;
            Durumlabel.Location = new Point(254, 86);
            Durumlabel.Name = "Durumlabel";
            Durumlabel.Size = new Size(71, 22);
            Durumlabel.TabIndex = 7;
            Durumlabel.Text = "Durum:";
            // 
            // tortalama
            // 
            tortalama.AutoSize = true;
            tortalama.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tortalama.Location = new Point(351, 38);
            tortalama.Name = "tortalama";
            tortalama.Size = new Size(15, 22);
            tortalama.TabIndex = 8;
            tortalama.Text = " ";
            // 
            // tdurum
            // 
            tdurum.AutoSize = true;
            tdurum.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tdurum.Location = new Point(351, 86);
            tdurum.Name = "tdurum";
            tdurum.Size = new Size(15, 22);
            tdurum.TabIndex = 9;
            tdurum.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(600, 213);
            Controls.Add(tdurum);
            Controls.Add(tortalama);
            Controls.Add(Durumlabel);
            Controls.Add(Ortalamalabel);
            Controls.Add(button1);
            Controls.Add(FinalNot);
            Controls.Add(VizeNot);
            Controls.Add(Final);
            Controls.Add(Vize);
            Name = "Form1";
            Text = "Not ortalaması hesaplama";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Vize;
        private TextBox Final;
        private Label VizeNot;
        private Label FinalNot;
        private Button button1;
        private Label Ortalamalabel;
        private Label Durumlabel;
        private Label tortalama;
        private Label tdurum;
    }
}