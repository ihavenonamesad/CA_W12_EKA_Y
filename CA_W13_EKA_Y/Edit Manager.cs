using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_W13_EKA_Y
{
    public partial class Edit_Manager : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dtdelete = new DataTable();
        MySqlDataReader reader;
        DataTable dttman = new DataTable();
        DataTable dtavman = new DataTable();
        public Edit_Manager()
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

        private void Edit_Manager_Load(object sender, EventArgs e)
        {
            DataTable dtteams = new DataTable();
            string command = "select team_name as 'Team Name', team_id as 'Team ID' from team;";
            cmd = new MySqlCommand(command, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtteams);
            comb_team.DataSource = dtteams;
            comb_team.ValueMember = "Team ID";
            comb_team.DisplayMember = "Team Name";

            updateunemployed();
        }
        private void updateunemployed()
        {
            dtavman.Clear();
            string command = "select m.manager_name as 'Name', n.nation as 'Nationality', m.birthdate from manager m inner join nationality n on m.nationality_id = n.nationality_id and m.working = 0;";
            cmd = new MySqlCommand(command, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtavman);
            dgv_unemployed.DataSource = dtavman;
        }
        private void comb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            updateman();
            string managername = dgv_working.SelectedCells[0].Value.ToString();
            string teamid = comb_team.SelectedValue.ToString();
            DataTable dtunavman = new DataTable();
            string command = $"select manager_id from manager where working = 0; "; 
            //string command = $"update manager set working = 0 where manager_name = '{managername}';";
            cmd = new MySqlCommand(command, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtunavman);

            DataTable dtteams = new DataTable();
            command = $"select manager_id from team where team_id = '{teamid}'";
            cmd = new MySqlCommand(command, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtteams);

            string oldman = dtteams.Rows[0][0].ToString();
            string newman = dtunavman.Rows[0][0].ToString();
            try
            {
                conn.Open();
                command = $"update team set manager_id = '{newman}' where team_id = '{teamid}'";
                cmd = new MySqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                conn.Close();
                conn.Open();
                command = $"update manager set working = 0 where manager_id = '{oldman}';";
                cmd = new MySqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                conn.Close();
                conn.Open();
                command = $"update manager set working = 1 where manager_id = '{newman}';";
                cmd = new MySqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                conn.Close();
                conn.Open();
            } catch  (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                updateunemployed();
                updateman();
            }
        }
        private void updateman()
        {
            dttman.Clear();
            string teamid = comb_team.SelectedValue.ToString();
            string command = $"select m.manager_name as 'Name', t.team_name as 'Team Name', m.birthdate, n.nation as 'Nationality' from manager m inner join team t on t.manager_id = m.manager_id and t.team_id = '{teamid}' inner join nationality n on m.nationality_id = n.nationality_id;";
            cmd = new MySqlCommand(command, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dttman);
            dgv_working.DataSource = dttman;
        }
        private void comb_team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateman();
        }
    }
}
