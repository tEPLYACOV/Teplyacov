using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subd
{
    public partial class Form1 : Form
    {
        public static string txtcon = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tepl.mdf;Integrated Security = True; Connect Timeout = 30";
        public Form1()
        {
            InitializeComponent();
        }
        class ItemPanel : Panel
        {
            public System.Windows.Forms.Label lName;
            public System.Windows.Forms.Label label3;
            public System.Windows.Forms.Label lFam;
            public System.Windows.Forms.Label label1;
            public System.Windows.Forms.Label label2;
            public System.Windows.Forms.Label label5;
            public System.Windows.Forms.Label lRole;
            public System.Windows.Forms.Label label8;
            public System.Windows.Forms.Label lPol;
            public System.Windows.Forms.Label label4;
            public System.Windows.Forms.Label lOtch;
            public System.Windows.Forms.Label label6;

            public ItemPanel()
            {
              
                this.label1 = new System.Windows.Forms.Label();
                this.lFam = new System.Windows.Forms.Label();
                this.lName = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.lPol = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.lOtch = new System.Windows.Forms.Label();
                this.label6 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.label5 = new System.Windows.Forms.Label();
                this.lRole = new System.Windows.Forms.Label();
                this.label8 = new System.Windows.Forms.Label();
                // 
                // panel1
                // 
                this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Controls.Add(this.label2);
                this.Controls.Add(this.label5);
                this.Controls.Add(this.lRole);
                this.Controls.Add(this.label8);
                this.Controls.Add(this.lPol);
                this.Controls.Add(this.label4);
                this.Controls.Add(this.lOtch);
                this.Controls.Add(this.label6);
                this.Controls.Add(this.lName);
                this.Controls.Add(this.label3);
                this.Controls.Add(this.lFam);
                this.Controls.Add(this.label1);
                this.Location = new System.Drawing.Point(13, 13);
                this.Name = "panel1";
                this.Size = new System.Drawing.Size(235, 205);
                this.TabIndex = 0;
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(3, 9);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(78, 17);
                this.label1.TabIndex = 0;
                this.label1.Text = "Фамилия: ";
                // 
                // lFam
                // 
                this.lFam.AutoSize = true;
                this.lFam.Location = new System.Drawing.Point(115, 9);
                this.lFam.Name = "lFam";
                this.lFam.Size = new System.Drawing.Size(46, 17);
                this.lFam.TabIndex = 1;
                this.lFam.Text = "label2";
                // 
                // lName
                // 
                this.lName.AutoSize = true;
                this.lName.Location = new System.Drawing.Point(115, 41);
                this.lName.Name = "lName";
                this.lName.Size = new System.Drawing.Size(46, 17);
                this.lName.TabIndex = 3;
                this.lName.Text = "label2";
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(3, 41);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(43, 17);
                this.label3.TabIndex = 2;
                this.label3.Text = "Имя: ";
                // 
                // lPol
                // 
                this.lPol.AutoSize = true;
                this.lPol.Location = new System.Drawing.Point(115, 101);
                this.lPol.Name = "lPol";
                this.lPol.Size = new System.Drawing.Size(46, 17);
                this.lPol.TabIndex = 7;
                this.lPol.Text = "label2";
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(3, 101);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(42, 17);
                this.label4.TabIndex = 6;
                this.label4.Text = "Пол: ";
                // 
                // lOtch
                // 
                this.lOtch.AutoSize = true;
                this.lOtch.Location = new System.Drawing.Point(115, 69);
                this.lOtch.Name = "lOtch";
                this.lOtch.Size = new System.Drawing.Size(46, 17);
                this.lOtch.TabIndex = 5;
                this.lOtch.Text = "label2";
                // 
                // label6
                // 
                this.label6.AutoSize = true;
                this.label6.Location = new System.Drawing.Point(3, 69);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(79, 17);
                this.label6.TabIndex = 4;
                this.label6.Text = "Отчество: ";
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(115, 163);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(22, 17);
                this.label2.TabIndex = 11;
                this.label2.Text = "lid";
                // 
                // label5
                // 
                this.label5.AutoSize = true;
                this.label5.Location = new System.Drawing.Point(3, 163);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(106, 17);
                this.label5.TabIndex = 10;
                this.label5.Text = "Служебный id: ";
                // 
                // lRole
                // 
                this.lRole.AutoSize = true;
                this.lRole.Location = new System.Drawing.Point(115, 131);
                this.lRole.Name = "lRole";
                this.lRole.Size = new System.Drawing.Size(46, 17);
                this.lRole.TabIndex = 9;
                this.lRole.Text = "label2";
                // 
                // label8
                // 
                this.label8.AutoSize = true;
                this.label8.Location = new System.Drawing.Point(3, 131);
                this.label8.Name = "label8";
                this.label8.Size = new System.Drawing.Size(89, 17);
                this.label8.TabIndex = 8;
                this.label8.Text = "Должность: ";
            }
        }
        struct Agent
        {
            public string ID, Fam, NameRab, Otch, pol, NameDolj;
        }
        List<Agent> lstAgent = new List<Agent>();
        ItemPanel CurrentItem;

        void GetData()
        {
            string usl = "";
            if (CmbFind.Text == "фамилии" && TbxFind.Text != "")
                usl += $" and FamUser Like N'{TbxFind.Text}%'";
            if (CmbFind.Text == "имени" && TbxFind.Text != "")
                usl += $" and NameUser Like N'{TbxFind.Text}%'";
            if (CmbFind.Text == "отчеству" && TbxFind.Text != "")
                usl += $" and OtchUser Like N'{TbxFind.Text}%'";
            lstAgent.Clear();
            SqlConnection con = new SqlConnection(txtcon);
            con.Open();
            string txt = $@"select IDUser, FamUser, NameUser, OtchUser, pol, NameRole
from Users, RolesUser
where Users.IdRole=RolesUser.IdRole {usl}";
            SqlCommand com = new SqlCommand(txt, con);
            SqlDataReader rez = com.ExecuteReader();
            while (rez.Read())
            {
                Agent agent1 = new Agent();
                agent1.ID = rez["IdUser"].ToString();
                agent1.Fam = rez["FamUser"].ToString();
                agent1.NameRab = rez["NameUser"].ToString();
                agent1.Otch = rez["OtchUser"].ToString();
                agent1.pol = rez["pol"].ToString();
                agent1.NameDolj = rez["NameRole"].ToString();
                lstAgent.Add(agent1);
            }
            con.Close();
        }

        void FillPanel()
        {
            MainPanel.Controls.Clear();
            foreach (Agent agent1 in lstAgent)
            {
                ItemPanel item = new ItemPanel();
                item.lFam.Text = agent1.Fam;
                item.label2.Text = agent1.ID;
                item.lName.Text = agent1.NameRab;
                item.lOtch.Text = agent1.Otch;
                item.lPol.Text = agent1.pol;
                item.lRole.Text = agent1.NameDolj;


                MainPanel.Controls.Add(item);

                item.Click += Item_Click;
                if (MainPanel.Controls.Count == 1)
                {
                    CurrentItem = item;
                    CurrentItem.BackColor = Color.LightGreen;
                }
            }
        }
        string idselect = "";
        private void Item_Click(object sender, EventArgs e)
        {
            CurrentItem.BackColor = Color.White;
            CurrentItem = sender as ItemPanel;
            CurrentItem.BackColor = Color.LightGreen;
            idselect = CurrentItem.label2.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
            FillPanel();
        }

        private void CmbFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
            FillPanel();
        }

        private void TbxFind_TextChanged(object sender, EventArgs e)
        {
            GetData();
            FillPanel();
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (idselect != "")
            { 
            SqlConnection con = new SqlConnection(txtcon);
            con.Open();
            string txt = $"delete from Users where idUser={idselect}";
            SqlCommand com = new SqlCommand(txt, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Вы удалили пользователя", "Внимание");
            GetData();
            FillPanel();
            }
        }

        private void baDD_Click(object sender, EventArgs e)
        {
            fAdd F = new fAdd();
            F.ShowDialog();

            GetData();
            FillPanel();
        }
    }
}
