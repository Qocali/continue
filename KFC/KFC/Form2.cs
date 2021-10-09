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

namespace KFC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP - 556F0IG\\SQLEXPRESS; Initial Catalog = asoiu; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into orders values(@name,@surname,@value)", con);
            cmd.Parameters.AddWithValue("@name", Form1.ad);
            cmd.Parameters.AddWithValue("@surname", Form1.soyad);
            cmd.Parameters.AddWithValue("@value", Convert.ToInt32(label3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("doing insert succesfully");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
