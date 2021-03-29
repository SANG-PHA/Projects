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
    public partial class Display_ : Form
    {
        public Display_()
        {
            InitializeComponent();
        }

        public Initialize init_;

        // Initialize에서 전달받을 선수이름, 국적 저장 변수
        public string player1Name;
        public string player1Nation;
        public string player1Age;
        public string player1Ranking;
        public string player2Name;
        public string player2Nation;
        public string player2Age;
        public string player2Ranking;
        public int player1Winrate;
        public int player2Winrate;

        // Solo_Input에서 전달받을 변수
        public int p1_score;
        public int p2_score;

        private void Solo_Display_Load(object sender, EventArgs e)
        {
            // Initialize에서 전달받은 선수 이름과 국적
            player1_name.Text = player1Name;
            player1_name2.Text = player1Name;
            player1_nation.Text = player1Nation;
            player1_age.Text = player1Age;
            player1_ranking.Text = player1Ranking;
            player1_winrate.Text = player1Winrate.ToString();
            p1_winrate.Text = player1Winrate.ToString();

            player2_name.Text = player2Name;
            player2_name2.Text = player2Name;
            player2_nation.Text = player2Nation;
            player2_age.Text = player2Age;
            player2_ranking.Text = player2Ranking;
            player2_winrate.Text = player2Winrate.ToString();
            p2_winrate.Text = player2Winrate.ToString();

            change_winrate(player1Winrate, player2Winrate);

        }

        //선수 이미지 설정
        private void player1_Click(object sender, EventArgs e)
        {
            //파일로부터 이미지 로드
            openFileDialog1.ShowDialog();
            Image img = Image.FromFile(openFileDialog1.FileName);

            //이미지 리사이즈 및 설정
            player1.Image = ReSizeImg(img);
        }

        private void player2_Click(object sender, EventArgs e)
        {
            //파일로부터 이미지 로드
            openFileDialog1.ShowDialog();
            Image img = Image.FromFile(openFileDialog1.FileName);

            //이미지 리사이즈 및 설정
            player2.Image = ReSizeImg(img);
        }

        private Bitmap ReSizeImg(Image source)
        {
            int W = source.Width, H = source.Height;
            //이미지 리사이즈
            while (W > 100)
                W = (int)(W * 0.9);
            while (H > 133)
                H = (int)(H * 0.9);

            //리사이즈 된 이미지를 버튼의 이미지로 설정
            Size resize = new Size(W, H);
            Bitmap ResizeImg = new Bitmap(source, resize);

            return ResizeImg;
        }

        public void change_winrate(int player1, int player2)
        {
            player1Winrate = player1;
            player2Winrate = player2;

            p1_winrate.Width = player1Winrate * 5;
            p1_winrate.SetBounds(p1_winrate.Location.X, p1_winrate.Location.Y, p1_winrate.Width, p1_winrate.Height);

            if (player2Winrate > 50)
            {
                p2_winrate.Width = player2Winrate * 5;
                int X = p1_winrate.Location.X + p1_winrate.Width;
                p2_winrate.SetBounds(X, p2_winrate.Location.Y, p2_winrate.Width, p2_winrate.Height);
            }
            else
            {
                p2_winrate.Width = player2Winrate * 5;
                int X = p1_winrate.Location.X + p1_winrate.Width;
                p2_winrate.SetBounds(X, p2_winrate.Location.Y, p2_winrate.Width, p2_winrate.Height);
            }

            p1_winrate.Text = player1Winrate.ToString() + "%";
            p2_winrate.Text = (100 - player1Winrate).ToString() + "%";
        }

        public void click_set_over_send(int player1, int player2)
        {
            change_winrate(player1, player2);
            player1_winrate.Text = player1 + "%";
            player2_winrate.Text = player2 + "%";
        }

        public void set_eval_text(string p1, string p2)
        {
            p1_eval.Text = p1;
            p2_eval.Text = p2;
        }

        public void setting_score(int p1, int p2)
        {
            p1_score_label.Text = p1.ToString();
            p2_score_label.Text = p2.ToString();
        }

        public void set_winrate(int p1, int p2)
        {
            p1_winrate.Text = p1.ToString();
            p2_winrate.Text = p2.ToString();
        }

        public void set_currentset(int set, int p1_score, int p2_score)
        {
            set_number.Text = set.ToString() + "SET";

            if(set == 2)
            {
                p1_set1.Text = p1_score.ToString();
                p2_set1.Text = p2_score.ToString();
            }
            else if(set == 3)
            {
                p1_set2.Text = p1_score.ToString();
                p2_set2.Text = p2_score.ToString();
            }
            else if(set == 4)
            {
                p1_set3.Text = p1_score.ToString();
                p2_set3.Text = p2_score.ToString();
            }
        }

        private void Team_Display_FormClosing(object sender, FormClosingEventArgs e)
        {
            init_.display_form_closed();
        }
    }
}
