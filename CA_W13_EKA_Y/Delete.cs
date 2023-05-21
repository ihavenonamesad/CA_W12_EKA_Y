using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CA_W13_EKA_Y
{
    public partial class Delete : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dtdelete = new DataTable();
        MySqlDataReader reader;
        public Delete()
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
            dtdelete.Clear();
            string teamid = comb_team.SelectedValue.ToString();
            try
            {
                string command = $"SELECT p.player_name as 'Player Name', n.nation as 'Nationality' , p.playing_pos as 'Position', p.team_number as 'Team Number', p.height as 'Height', p.weight as 'Weight', p.birthdate from player p inner join team t on t.team_id = '{teamid}' and p.team_id = '{teamid}' and p.`status` = 1 inner join nationality n on p.nationality_id = n.nationality_id;";
                cmd = new MySqlCommand(command, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtdelete);
                dataGridView1.DataSource = dtdelete;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            
            DataTable dtteams = new DataTable();
            string command = "select team_name as 'Team Name', team_id as 'Team ID' from team;";
            cmd = new MySqlCommand(command, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtteams);
            comb_team.DataSource = dtteams;
            comb_team.ValueMember = "Team ID";
            comb_team.DisplayMember = "Team Name";
            dtdelete.Clear();
            update();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string playername = dataGridView1.SelectedCells[0].Value.ToString();
            if (dataGridView1.Rows.Count <= 11)
            {
                MessageBox.Show("Team less than 11");
            } else
            {
                string command = $"update player set `status` = 0 where player_name = '{playername}';";
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
        }

        private void comb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
