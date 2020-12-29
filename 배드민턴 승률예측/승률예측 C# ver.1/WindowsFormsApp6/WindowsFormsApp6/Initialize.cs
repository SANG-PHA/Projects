using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Initialize : Form
    {
        public Initialize()
        {
            InitializeComponent();
        }

        //단식 선택 시
        private void Solo_CheckedChanged(object sender, EventArgs e)
        {
            //복식 입력 내용 안보이게
            team1.Visible = false;
            team1_p1.Visible = false;
            team1_p2.Visible = false;
            team1_player1_name.Visible = false;
            team1_player1_nation.Visible = false;
            team1_player2_name.Visible = false;
            team1_player2_nation.Visible = false;
            team1_rate.Visible = false;

            team2.Visible = false;
            team2_p1.Visible = false;
            team2_p2.Visible = false;
            team2_player1_name.Visible = false;
            team2_player1_nation.Visible = false;
            team2_player2_name.Visible = false;
            team2_player2_nation.Visible = false;
            team2_rate.Visible = false;

            team_input.Visible = false;
            team_name.Visible = false;
            team_nation.Visible = false;
            team_rate.Visible = false;

            //단식 입력 내용 보이게
            solo_input.Visible = true;
            solo_name.Visible = true;
            solo_nation.Visible = true;
            solo_rate.Visible = true;
            solo_p1.Visible = true;
            solo_p2.Visible = true;
            solo_player1_name.Visible = true;
            solo_player1_nation.Visible = true;
            solo_player1_rate.Visible = true;
            solo_player2_name.Visible = true;
            solo_player2_nation.Visible = true;
            solo_player2_rate.Visible = true;
        }

        //복식 선택 시
        private void Team_CheckedChanged(object sender, EventArgs e)
        {
            //단식 입력 내용 안보이게
            solo_input.Visible = false;
            solo_name.Visible = false;
            solo_nation.Visible = false;
            solo_rate.Visible = false;
            solo_p1.Visible = false;
            solo_p2.Visible = false;
            solo_player1_name.Visible = false;
            solo_player1_nation.Visible = false;
            solo_player1_rate.Visible = false;
            solo_player2_name.Visible = false;
            solo_player2_nation.Visible = false;
            solo_player2_rate.Visible = false;

            //복식 입력 내용 보이게
            team1.Visible = true;
            team1_p1.Visible = true;
            team1_p2.Visible = true;
            team1_player1_name.Visible = true;
            team1_player1_nation.Visible = true;
            team1_player2_name.Visible = true;
            team1_player2_nation.Visible = true;
            team1_rate.Visible = true;

            team2.Visible = true;
            team2_p1.Visible = true;
            team2_p2.Visible = true;
            team2_player1_name.Visible = true;
            team2_player1_nation.Visible = true;
            team2_player2_name.Visible = true;
            team2_player2_nation.Visible = true;
            team2_rate.Visible = true;

            team_input.Visible = true;
            team_name.Visible = true;
            team_nation.Visible = true;
            team_rate.Visible = true;
        }

        private void Initialize_Load(object sender, EventArgs e)
        {
            //복식 입력 내용 안보이게
            team1.Visible = false;
            team1_p1.Visible = false;
            team1_p2.Visible = false;
            team1_player1_name.Visible = false;
            team1_player1_nation.Visible = false;
            team1_player2_name.Visible = false;
            team1_player2_nation.Visible = false;
            team1_rate.Visible = false;

            team2.Visible = false;
            team2_p1.Visible = false;
            team2_p2.Visible = false;
            team2_player1_name.Visible = false;
            team2_player1_nation.Visible = false;
            team2_player2_name.Visible = false;
            team2_player2_nation.Visible = false;
            team2_rate.Visible = false;

            team_input.Visible = false;
            team_name.Visible = false;
            team_nation.Visible = false;
            team_rate.Visible = false;
        }

        // 입력 버튼 클릭 시
        private void solo_input_Click(object sender, EventArgs e)
        {
            // Solo_Input 폼
            Solo_Input solo = new Solo_Input();
            solo.player1Name = solo_player1_name.Text;
            solo.player1Nation = solo_player1_nation.Text;
            solo.player2Name = solo_player2_name.Text;
            solo.player2Nation = solo_player2_nation.Text;
            solo.player1Winrate = int.Parse(solo_player1_rate.Text);
            solo.Show();
        }

        private void team_input_Click(object sender, EventArgs e)
        {
           Team team = new Team();
            team.Show();
        }

        private void solo_player1_rate_TextChanged(object sender, EventArgs e)
        {
            if(solo_player1_rate.TextLength != 0)
                solo_player2_rate.Text = (100 - int.Parse(solo_player1_rate.Text)).ToString();
        }

        private void solo_player2_rate_TextChanged(object sender, EventArgs e)
        {
            if (solo_player2_rate.TextLength != 0)
                solo_player1_rate.Text = (100 - int.Parse(solo_player2_rate.Text)).ToString();
        }
    }
}
