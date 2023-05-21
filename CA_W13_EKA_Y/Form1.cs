using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CA_W13_EKA_Y
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        MySqlDataReader reader;
        public Form1()
        {
            try
            {
                string connection = "server=localhost;user=root;pwd=;database=premier_league;Convert Zero Datetime=True";
                conn = new MySqlConnection(connection);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            InitializeComponent();
        }

        private void update()
        {
            dt.Clear();
            try
            {
                //string command = "select p.player_name as 'Player Name', p.team_number as 'Team Number', p.nationality_id as 'Nationality', p.height, p.weight, p.birthdate, p.team_id as 'Team ID' from player p";
                string command = "select * from player;";
                cmd = new MySqlCommand(command, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            update();
            DataTable dtnat = new DataTable();
            DataTable dtpos = new DataTable();
            DataTable dttnames = new DataTable();
            string command = "select nation as 'Nationality', nationality_id as 'ID' from nationality n;";
            cmd = new MySqlCommand(command, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtnat);
            comb_nat.DataSource = dtnat;
            comb_nat.ValueMember = "ID";
            comb_nat.DisplayMember = "Nationality";
            
     
            command = "select team_name as 'Team Name', team_id as 'Team ID' from team;";
            cmd = new MySqlCommand(command, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dttnames);
            comb_team.DataSource = dttnames;
            comb_team.ValueMember = "Team ID";
            comb_team.DisplayMember = "Team Name";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pname = txt_name.Text;
            string number = txt_numb.Text;
            string nation = comb_nat.SelectedValue.ToString();
            string pos = comb_pos.Text;
            int height = Convert.ToInt32(txt_height.Text);
            int weight = Convert.ToInt32(txt_height.Text);
            string tname = comb_team.SelectedValue.ToString();
            string birth = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            

            string command = $"insert into player values ('{id}','{number}','{pname}','{nation}','{pos}',{height},{weight},'{birth}','{tname}',1,0);";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(command, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                update();
            }
        }

        private void editManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Manager edit = new Edit_Manager();
            edit.Show();
        }

        private void removePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
            //this.Close();
        }
    }
}

