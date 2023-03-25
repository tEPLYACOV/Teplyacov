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
    public partial class fAdd : Form
    {
        public fAdd()
        {
            InitializeComponent();
        }
        void GetRole()
        {
            lstId.Clear();
            cbDolj.Items.Clear();
            SqlConnection con = new SqlConnection(Form1.txtcon);
            con.Open();
            string txt = "select * from RolesUser";
            SqlCommand com = new SqlCommand(txt, con);
            SqlDataReader rez = com.ExecuteReader();
            while (rez.Read())
            {
                lstId.Add(rez["IdRole"].ToString());
                cbDolj.Items.Add(rez["NameRole"].ToString());
            }
            con.Close();
        }
            List<string> lstId = new List<string>();

        private void fAdd_Load(object sender, EventArgs e)
        {
            GetRole();
        }

        private void baDD_Click(object sender, EventArgs e)
        {
            if (tbFam.Text != "" && tbName.Text != "" && tbOtch.Text != "" && cbPol.Text != "" && cbDolj.Text != "")
            {
                SqlConnection con = new SqlConnection(Form1.txtcon);
                con.Open();
                string txt = $@"insert into Users(NameUser, FamUser, OtchUser, pol, IdRole)
    values (N'{tbName.Text}', N'{tbFam.Text}', N'{tbOtch.Text}',N'{cbPol.Text}',N'{lstId[cbDolj.SelectedIndex]}')";
                SqlCommand com = new SqlCommand(txt, con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("добавлено");
            }
            else
            {
                MessageBox.Show("вы не ввели все данные");
            }
        }
    }
}
