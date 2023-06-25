//3
using System.Data;
using System.Data.SqlClient;

namespace tes
{
    public partial class Form1 : Form
    {
        //4
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        //5
        Koneksi Konn = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = Konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("select * from TBL_KASIR where KodeKasir='" + textBox1.Text + "' and PasswordKasir='" + textBox2.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();  
                if (reader.Read())
                {
                    FormMenuUtama.menu.loginToolStripMenuItem.Enabled = false;
                    FormMenuUtama.menu.logoutToolStripMenuItem.Enabled = true;
                    FormMenuUtama.menu.masterToolStripMenuItem.Enabled = true;
                    FormMenuUtama.menu.transaksiToolStripMenuItem.Enabled = true;
                    FormMenuUtama.menu.laporanToolStripMenuItem.Enabled = true;
                    FormMenuUtama.menu.utilityToolStripMenuItem.Enabled = true;
                    this.Close();

                    //FormMenuUtama frmMenuUtama = new FormMenuUtama();
                    //frmMenuUtama.Show();
                    //this.Hide();

                    //MessageBox.Show("BERHASIL");
                }
                else
                {
                    MessageBox.Show("Salah Bro");
                } 
            }



            /*
            if (textBox1.Text == "KSR001" && textBox2.Text == "admin")
            {
                FormMenuUtama frmMenuUtama = new FormMenuUtama();
                frmMenuUtama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Salah Bro");
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}