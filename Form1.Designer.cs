
namespace subd
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbFind = new System.Windows.Forms.ComboBox();
            this.TbxFind = new System.Windows.Forms.TextBox();
            this.baDD = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Location = new System.Drawing.Point(12, 163);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(693, 259);
            this.MainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(625, 0);
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
            // CmbFind
            // 
            this.CmbFind.FormattingEnabled = true;
            this.CmbFind.Items.AddRange(new object[] {
            "фамилии",
            "имени",
            "отчеству"});
            this.CmbFind.Location = new System.Drawing.Point(13, 125);
            this.CmbFind.Name = "CmbFind";
            this.CmbFind.Size = new System.Drawing.Size(153, 24);
            this.CmbFind.TabIndex = 2;
            this.CmbFind.SelectedIndexChanged += new System.EventHandler(this.CmbFind_SelectedIndexChanged);
            // 
            // TbxFind
            // 
            this.TbxFind.Location = new System.Drawing.Point(187, 126);
            this.TbxFind.Name = "TbxFind";
            this.TbxFind.Size = new System.Drawing.Size(200, 22);
            this.TbxFind.TabIndex = 3;
            this.TbxFind.TextChanged += new System.EventHandler(this.TbxFind_TextChanged);
            // 
            // baDD
            // 
            this.baDD.BackColor = System.Drawing.Color.Tomato;
            this.baDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baDD.Location = new System.Drawing.Point(20, 440);
            this.baDD.Name = "baDD";
            this.baDD.Size = new System.Drawing.Size(125, 38);
            this.baDD.TabIndex = 4;
            this.baDD.Text = "добавить";
            this.baDD.UseVisualStyleBackColor = false;
            this.baDD.Click += new System.EventHandler(this.baDD_Click);
            // 
            // bDel
            // 
            this.bDel.BackColor = System.Drawing.Color.Tomato;
            this.bDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDel.Location = new System.Drawing.Point(163, 440);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(125, 38);
            this.bDel.TabIndex = 5;
            this.bDel.Text = "удалить";
            this.bDel.UseVisualStyleBackColor = false;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 490);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.baDD);
            this.Controls.Add(this.TbxFind);
            this.Controls.Add(this.CmbFind);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Кадры";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbFind;
        private System.Windows.Forms.TextBox TbxFind;
        private System.Windows.Forms.Button baDD;
        private System.Windows.Forms.Button bDel;
    }
}

