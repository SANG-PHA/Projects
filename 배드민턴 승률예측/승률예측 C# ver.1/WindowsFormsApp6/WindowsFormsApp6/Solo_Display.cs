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
    public partial class Solo_Display : Form
    {
        public Solo_Display()
        {
            InitializeComponent();
        }

        // Initialize에서 전달받을 선수이름, 국적 저장 변수
        public string player1Name;
        public string player1Nation;
        public string player2Name;
        public string player2Nation;
        public int player1Winrate;

        // Solo_Input에서 전달받을 변수
        public int p1_score;
        public int p2_score;
        public string p1_99_text, p1_95_text, p1_90_text, p1_70_text;
        public string p2_99_text, p2_95_text, p2_90_text, p2_70_text;
        public string hitting_player, tech, who_get_score, getting_player;

        private void Solo_Display_Load(object sender, EventArgs e)
        {
            // Initialize에서 전달받은 선수 이름과 국적
            player1_name.Text = player1Name;
            player1_nation.Text = player1Nation;
            player2_name.Text = player2Name;
            player2_nation.Text = player2Nation;

            //초반 승률 display
            if (player1Winrate > 50)
            {
                int X = p1_winrate.Location.X;
                X = X - (player1Winrate - 50);
                p1_winrate.Width = player1Winrate;
                p1_winrate.SetBounds(X, p1_winrate.Location.Y, p1_winrate.Width, p1_winrate.Height);
            }
            else
            {
                int X = p1_winrate.Location.X;
                X = X + (50 - player1Winrate);
                p1_winrate.Width = player1Winrate;
                p1_winrate.SetBounds(X, p1_winrate.Location.Y, p1_winrate.Width, p1_winrate.Height);
            }

            p2_winrate.Width = 100 - player1Winrate;
            p1_winrate_text.Text = player1Winrate.ToString() + "%";
            p2_winrate_text.Text = (100 - player1Winrate).ToString() + "%";
        }

        //선수 이미지 설정
        public void player1_img_set(Image img)
        {
            player1.Image = img;
        }
        public void player2_img_set(Image img)
        {
            player2.Image = img;
        }

        public void refresh_form()
        {

        }
    }
}
