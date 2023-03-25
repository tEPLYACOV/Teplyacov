
namespace subd
{
    partial class fAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPol = new System.Windows.Forms.ComboBox();
            this.cbDolj = new System.Windows.Forms.ComboBox();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lDolj = new System.Windows.Forms.Label();
            this.lPol = new System.Windows.Forms.Label();
            this.lOtch = new System.Windows.Forms.Label();
            this.lFam = new System.Windows.Forms.Label();
            this.baDD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 100);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "СУБД Кадры";
            // 
            // cbPol
            // 
            this.cbPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPol.FormattingEnabled = true;
            this.cbPol.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.cbPol.Location = new System.Drawing.Point(144, 237);
            this.cbPol.Name = "cbPol";
            this.cbPol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbPol.Size = new System.Drawing.Size(209, 24);
            this.cbPol.TabIndex = 37;
            // 
            // cbDolj
            // 
            this.cbDolj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDolj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDolj.FormattingEnabled = true;
            this.cbDolj.Location = new System.Drawing.Point(144, 207);
            this.cbDolj.Name = "cbDolj";
            this.cbDolj.Size = new System.Drawing.Size(209, 24);
            this.cbDolj.TabIndex = 36;
            // 
            // tbFam
            // 
            this.tbFam.Location = new System.Drawing.Point(144, 123);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(209, 22);
            this.tbFam.TabIndex = 35;
            // 
            // tbOtch
            // 
            this.tbOtch.Location = new System.Drawing.Point(144, 179);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(209, 22);
            this.tbOtch.TabIndex = 34;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(144, 151);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(209, 22);
            this.tbName.TabIndex = 31;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(46, 154);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 17);
            this.lName.TabIndex = 29;
            this.lName.Text = "Имя";
            // 
            // lDolj
            // 
            this.lDolj.AutoSize = true;
            this.lDolj.Location = new System.Drawing.Point(47, 210);
            this.lDolj.Name = "lDolj";
            this.lDolj.Size = new System.Drawing.Size(81, 17);
            this.lDolj.TabIndex = 28;
            this.lDolj.Text = "Должность";
            // 
            // lPol
            // 
            this.lPol.AutoSize = true;
            this.lPol.Location = new System.Drawing.Point(47, 237);
            this.lPol.Name = "lPol";
            this.lPol.Size = new System.Drawing.Size(34, 17);
            this.lPol.TabIndex = 26;
            this.lPol.Text = "Пол";
            // 
            // lOtch
            // 
            this.lOtch.AutoSize = true;
            this.lOtch.Location = new System.Drawing.Point(47, 177);
            this.lOtch.Name = "lOtch";
            this.lOtch.Size = new System.Drawing.Size(71, 17);
            this.lOtch.TabIndex = 24;
            this.lOtch.Text = "Отчество";
            // 
            // lFam
            // 
            this.lFam.AutoSize = true;
            this.lFam.Location = new System.Drawing.Point(47, 128);
            this.lFam.Name = "lFam";
            this.lFam.Size = new System.Drawing.Size(70, 17);
            this.lFam.TabIndex = 25;
            this.lFam.Text = "Фамилия";
            // 
            // baDD
            // 
            this.baDD.BackColor = System.Drawing.Color.Tomato;
            this.baDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baDD.Location = new System.Drawing.Point(114, 304);
            this.baDD.Name = "baDD";
            this.baDD.Size = new System.Drawing.Size(125, 38);
            this.baDD.TabIndex = 38;
            this.baDD.Text = "добавить";
            this.baDD.UseVisualStyleBackColor = false;
            this.baDD.Click += new System.EventHandler(this.baDD_Click);
            // 
            // fAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 365);
            this.Controls.Add(this.baDD);
            this.Controls.Add(this.cbPol);
            this.Controls.Add(this.cbDolj);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lDolj);
            this.Controls.Add(this.lPol);
            this.Controls.Add(this.lOtch);
            this.Controls.Add(this.lFam);
            this.Controls.Add(this.panel1);
            this.Name = "fAdd";
            this.Text = "fAdd";
            this.Load += new System.EventHandler(this.fAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPol;
        private System.Windows.Forms.ComboBox cbDolj;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lDolj;
        private System.Windows.Forms.Label lPol;
        private System.Windows.Forms.Label lOtch;
        private System.Windows.Forms.Label lFam;
        private System.Windows.Forms.Button baDD;
    }
}