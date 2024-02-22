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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace random
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void btnListele_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-AHLHO0S\\SQLEXPRESS ; Initial Catalog=RandomAtamaDB;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT ad FROM TblRandom";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["ad"]);
            }
            con.Close();
        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            string[] veriler1 = new string[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                veriler1[i] = listBox1.Items[i].ToString();
            }

            List<string> veriler2 = new List<string>();
            foreach (var item in listBox1.Items)
            {
                veriler2.Add(item.ToString());
            }

            Random rand = new Random();
            int rastgele = rand.Next(0, 35);
            textBox1.Text = veriler2[rastgele];
            veriler2.Remove(textBox1.Text);

            Random rand1 = new Random();
            int rastgele1 = rand1.Next(0, 34);
            textBox2.Text = veriler2[rastgele1];
            veriler2.Remove(textBox2.Text);

            Random rand2 = new Random();
            int rastgele2 = rand2.Next(0, 33);
            textBox3.Text = veriler2[rastgele2];
            veriler2.Remove(textBox3.Text);

            Random rand3 = new Random();
            int rastgele3 = rand3.Next(0, 32);
            textBox4.Text = veriler2[rastgele3];
            veriler2.Remove(textBox4.Text);

            Random rand4 = new Random();
            int rastgele4 = rand4.Next(0, 31);
            textBox5.Text = veriler2[rastgele4];
            veriler2.Remove(textBox5.Text);

            Random rand5 = new Random();
            int rastgele5 = rand5.Next(0, 30);
            textBox6.Text = veriler2[rastgele5];
            veriler2.Remove(textBox6.Text);

            Random rand6 = new Random();
            int rastgele6 = rand6.Next(0, 29);
            textBox7.Text = veriler2[rastgele6];
            veriler2.Remove(textBox7.Text);

            Random rand7 = new Random();
            int rastgele7 = rand7.Next(0, 28);
            textBox8.Text = veriler2[rastgele7];
            veriler2.Remove(textBox8.Text);

            Random rand8 = new Random();
            int rastgele8 = rand8.Next(0, 27);
            textBox9.Text = veriler2[rastgele8];
            veriler2.Remove(textBox9.Text);

            Random rand9 = new Random();
            int rastgele9 = rand9.Next(0, 26);
            textBox10.Text = veriler2[rastgele9];
            veriler2.Remove(textBox10.Text);

            Random rand10 = new Random();
            int rastgele10 = rand10.Next(0, 25);
            textBox11.Text = veriler2[rastgele10];
            veriler2.Remove(textBox11.Text);

            Random rand11 = new Random();
            int rastgele11 = rand11.Next(0, 24);
            textBox12.Text = veriler2[rastgele11];
            veriler2.Remove(textBox12.Text);

            Random rand12 = new Random();
            int rastgele12 = rand12.Next(0, 23);
            textBox13.Text = veriler2[rastgele12];
            veriler2.Remove(textBox13.Text);

            Random rand13 = new Random();
            int rastgele13 = rand13.Next(0, 22);
            textBox14.Text = veriler2[rastgele13];
            veriler2.Remove(textBox14.Text);

            Random rand14 = new Random();
            int rastgele14 = rand14.Next(0, 21);
            textBox15.Text = veriler2[rastgele14];
            veriler2.Remove(textBox15.Text);

            Random rand15 = new Random();
            int rastgele15 = rand15.Next(0, 20);
            textBox16.Text = veriler2[rastgele15];
            veriler2.Remove(textBox16.Text);

            Random rand16 = new Random();
            int rastgele16 = rand16.Next(0, 19);
            textBox17.Text = veriler2[rastgele16];
            veriler2.Remove(textBox17.Text);

            Random rand17 = new Random();
            int rastgele17 = rand17.Next(0, 18);
            textBox18.Text = veriler2[rastgele17];
            veriler2.Remove(textBox18.Text);

            Random rand18 = new Random();
            int rastgele18 = rand18.Next(0, 17);
            textBox19.Text = veriler2[rastgele18];
            veriler2.Remove(textBox19.Text);

            Random rand19 = new Random();
            int rastgele19 = rand19.Next(0, 16);
            textBox20.Text = veriler2[rastgele19];
            veriler2.Remove(textBox20.Text);

            Random rand20 = new Random();
            int rastgele20 = rand20.Next(0, 15);
            textBox21.Text = veriler2[rastgele20];
            veriler2.Remove(textBox21.Text);

            Random rand21 = new Random();
            int rastgele21 = rand21.Next(0, 14);
            textBox22.Text = veriler2[rastgele21];
            veriler2.Remove(textBox22.Text);

            Random rand22 = new Random();
            int rastgele22 = rand22.Next(0, 13);
            textBox23.Text = veriler2[rastgele22];
            veriler2.Remove(textBox23.Text);

            Random rand23 = new Random();
            int rastgele23 = rand23.Next(0, 12);
            textBox24.Text = veriler2[rastgele23];
            veriler2.Remove(textBox24.Text);

            Random rand24 = new Random();
            int rastgele24 = rand24.Next(0, 11);
            textBox25.Text = veriler2[rastgele24];
            veriler2.Remove(textBox25.Text);

            Random rand25 = new Random();
            int rastgele25 = rand25.Next(0, 10);
            textBox26.Text = veriler2[rastgele25];
            veriler2.Remove(textBox26.Text);

            Random rand26 = new Random();
            int rastgele26 = rand26.Next(0, 9);
            textBox27.Text = veriler2[rastgele26];
            veriler2.Remove(textBox27.Text);

            Random rand27 = new Random();
            int rastgele27 = rand27.Next(0, 8);
            textBox28.Text = veriler2[rastgele27];
            veriler2.Remove(textBox28.Text);

            Random rand28 = new Random();
            int rastgele28 = rand28.Next(0, 7);
            textBox29.Text = veriler2[rastgele28];
            veriler2.Remove(textBox29.Text);

            Random rand29 = new Random();
            int rastgele29 = rand28.Next(0, 6);
            textBox30.Text = veriler2[rastgele29];
            veriler2.Remove(textBox30.Text);

            Random rand30 = new Random();
            int rastgele30 = rand30.Next(0, 5);
            textBox31.Text = veriler2[rastgele30];
            veriler2.Remove(textBox31.Text);

            Random rand31 = new Random();
            int rastgele31 = rand31.Next(0, 4);
            textBox32.Text = veriler2[rastgele31];
            veriler2.Remove(textBox32.Text);

            Random rand32 = new Random();
            int rastgele32 = rand32.Next(0, 3);
            textBox33.Text = veriler2[rastgele32];
            veriler2.Remove(textBox33.Text);

            Random rand33 = new Random();
            int rastgele33 = rand33.Next(0, 2);
            textBox34.Text = veriler2[rastgele33];
            veriler2.Remove(textBox34.Text);

            Random rand34 = new Random();
            int rastgele34 = rand34.Next(0, 1);
            textBox35.Text = veriler2[rastgele34];
            veriler2.Remove(textBox35.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
