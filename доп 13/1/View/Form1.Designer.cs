namespace _1.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ILes = new System.Windows.Forms.Label();
            this.IFactory = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lExit = new System.Windows.Forms.Label();
            this.lnfo = new System.Windows.Forms.Label();
            this.lStart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 561);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.ILes);
            this.panel1.Controls.Add(this.IFactory);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 2;
            // 
            // ILes
            // 
            this.ILes.AutoSize = true;
            this.ILes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ILes.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ILes.Location = new System.Drawing.Point(12, 9);
            this.ILes.Name = "ILes";
            this.ILes.Size = new System.Drawing.Size(167, 13);
            this.ILes.TabIndex = 3;
            this.ILes.Text = "\"OOO\" ЛесСтройКомплекс";
            // 
            // IFactory
            // 
            this.IFactory.AutoSize = true;
            this.IFactory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.IFactory.Font = new System.Drawing.Font("Constantia", 33.75F, System.Drawing.FontStyle.Bold);
            this.IFactory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IFactory.Location = new System.Drawing.Point(448, 24);
            this.IFactory.Name = "IFactory";
            this.IFactory.Size = new System.Drawing.Size(152, 55);
            this.IFactory.TabIndex = 1;
            this.IFactory.Text = "Завод";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lExit);
            this.panel2.Controls.Add(this.lnfo);
            this.panel2.Controls.Add(this.lStart);
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 66);
            this.panel2.TabIndex = 3;
            // 
            // lExit
            // 
            this.lExit.AutoSize = true;
            this.lExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lExit.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lExit.Location = new System.Drawing.Point(830, 12);
            this.lExit.Name = "lExit";
            this.lExit.Size = new System.Drawing.Size(98, 33);
            this.lExit.TabIndex = 6;
            this.lExit.Text = "Выход\r\n";
            this.lExit.Click += new System.EventHandler(this.lExit_Click);
            this.lExit.MouseLeave += new System.EventHandler(this.lExit_MouseLeave);
            this.lExit.MouseHover += new System.EventHandler(this.lExit_MouseHover);
            // 
            // lnfo
            // 
            this.lnfo.AutoSize = true;
            this.lnfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lnfo.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnfo.Location = new System.Drawing.Point(428, 12);
            this.lnfo.Name = "lnfo";
            this.lnfo.Size = new System.Drawing.Size(194, 33);
            this.lnfo.TabIndex = 5;
            this.lnfo.Text = "Информация";
            this.lnfo.Click += new System.EventHandler(this.lnfo_Click);
            this.lnfo.MouseLeave += new System.EventHandler(this.lnfo_MouseLeave);
            this.lnfo.MouseHover += new System.EventHandler(this.lnfo_MouseHover);
            // 
            // lStart
            // 
            this.lStart.AutoSize = true;
            this.lStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lStart.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStart.Location = new System.Drawing.Point(44, 12);
            this.lStart.Name = "lStart";
            this.lStart.Size = new System.Drawing.Size(105, 33);
            this.lStart.TabIndex = 4;
            this.lStart.Text = "Запуск\r\n";
            this.lStart.Click += new System.EventHandler(this.lStart_Click);
            this.lStart.MouseLeave += new System.EventHandler(this.lStart_MouseLeave);
            this.lStart.MouseHover += new System.EventHandler(this.lStart_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Завод";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ILes;
        private System.Windows.Forms.Label IFactory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lExit;
        private System.Windows.Forms.Label lnfo;
        private System.Windows.Forms.Label lStart;
    }
}