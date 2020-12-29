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


        private void Initialize_Load(object sender, EventArgs e)
        {
            // 패널 안보이게
            info_panel.Visible = false;
            guess_panel.Visible = false;
            picture.Visible = true;

            //복식 입력 내용 안보이게
            team1.Visible = false;
            team1_p1.Visible = false;
            team1_p2.Visible = false;
            team1_player1_name.Visible = false;
            team1_player1_nation.Visible = false;
            team1_player1_age.Visible = false;
            team1_player2_name.Visible = false;
            team1_player2_nation.Visible = false;
            team1_player2_age.Visible = false;
            team1_rate.Visible = false;
            team1_ranking.Visible = false;

            team2.Visible = false;
            team2_p1.Visible = false;
            team2_p2.Visible = false;
            team2_player1_name.Visible = false;
            team2_player1_nation.Visible = false;
            team2_player1_age.Visible = false;
            team2_player2_name.Visible = false;
            team2_player2_nation.Visible = false;
            team2_player2_age.Visible = false;
            team2_rate.Visible = false;
            team2_ranking.Visible = false;

            team_input.Visible = false;
            team_name.Visible = false;
            team_nation.Visible = false;
            team_rate.Visible = false;
            team_age.Visible = false;
            team_ranking.Visible = false;
        }

        // 전역 변수들
        Display_ sd = new Display_();

        // 계산
        int selected_player = 1, who_get_score = 1;
        bool selected_miss = false, selected_ferror = false, selected_notouch = false, selected_etc = false;
        int p1_score = 0, p2_score = 0, score_gap = 0, highest_score = 0;
        double denominator = 0, numerator = 0, p1_Winrate = 0, p1_Loserate = 0, p2_Winrate = 0, p2_Loserate = 0, AfterRate = 0, PreNumer = 0, PreDenomi = 0;
        double[] alpha = new double[4] { 2.33, 9, 19, 99 };
        double[] beta = new double[4] { 0.43, 0.11, 0.05, 0.01 };

        int current_set = 1;

        // 리스트뷰 추가를 위한
        string playername, skill, timing, adapt, thirty, ten, five, one;

        // 단식
        public string solo_player1Name, solo_player1Nation, solo_player1Ranking, solo_player1Age;
        public int player1Winrate;
        public string solo_player2Name, solo_player2Nation, solo_player2Ranking, solo_player2Age;
        public int player2Winrate;

        public int firstWinrate1, firstWinrate2;

        // 복식
        public string team1_player1Name, team1_player1Nation, team1_Ranking, team1_player1Age;
        public string team1_player2Name, team1_player2Nation, team1_player2Age;
        public int team1Winrate;

        public string team2_player1Name, team2_player1Nation, team2_Ranking, team2_player1Age;
        public string team2_player2Name, team2_player2Nation, team2_player2Age;
        public int team2Winrate;

        // 기술에 대한 세타값 -> theta, 1-theta, theta1, 1-theta1
        public double[] miss = new double[4] {0.59, 0.41,0.41 ,0.59 };
        public double[] miss0_5 = new double[4] {0.67,0.33,0.33,0.67};
        public double[] miss6_10 = new double[4] {0.82,0.18,0.18,0.82};
        public double[] miss11_15 = new double[4] {0.89,0.11,0.11,0.89};
        public double[] miss16_20 = new double[4] {0.96,0.04,0.04,0.96};
        public double[] miss21_ = new double[4] {0.99,0.01,0.01,0.99};

        public double[] f_error = new double[4] {0.59,0.41,0.41,0.59};
        public double[] f_error0_5 = new double[4] {0.72,0.28,0.28,0.72};
        public double[] f_error6_10 = new double[4] {0.8,0.2,0.2,0.8};
        public double[] f_error11_15 = new double[4] {0.89,0.11,0.11,0.89};
        public double[] f_error16_20 = new double[4] {0.96,0.04,0.04,0.96};
        public double[] f_error21_ = new double[4] {0.96,0.04,0.04,0.96};

        public double[] notouch = new double[4] {0.61,0.39,0.39,0.61};
        public double[] notouch0_5 = new double[4] {0.72,0.28,0.28,0.72};
        public double[] notouch6_10 = new double[4] {0.81,0.19,0.19,0.81};
        public double[] notouch11_15 = new double[4] {0.88,0.12,0.12,0.88};
        public double[] notouch16_20 = new double[4] {0.95,0.05,0.05,0.95};
        public double[] notouch21_ = new double[4] {0.99,0.01,0.01,0.99};

        public double[] etc = new double[4] {0.57,0.43,0.43,0.57};
        public double[] etc0_5 = new double[4] {0.62,0.38,0.38,0.62};
        public double[] etc6_10 = new double[4] {0.87,0.13,0.13,0.87};
        public double[] etc11_15 = new double[4] {0.95,0.05,0.05,0.95};
        public double[] etc16_20 = new double[4] {0.94,0.06,0.06,0.94};
        public double[] etc21_ = new double[4] { 0.94, 0.06, 0.06, 0.94 };

        public double[] just_score0_5 = new double[4] {0.68,0.32,0.32,0.68 };
        public double[] just_score6_10 = new double[4] {0.82,0.18,0.18,0.82 };
        public double[] just_score11_15 = new double[4] {0.89,0.11,0.11,0.89 };
        public double[] just_score16_20 = new double[4] {0.95,0.05,0.95,0.05 };
        public double[] just_score21_ = new double[4] {1,0,1,0 };

        // ------------------------------------------- 기본 정보 ------------------------------------------- //
        private void info_Click(object sender, EventArgs e)
        {
            info_panel.Visible = true;
            picture.Visible = false;
            guess_panel.Visible = false;
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
            team1_player1_age.Visible = false;
            team1_player2_age.Visible = false;
            team1_rate.Visible = false;
            team1_ranking.Visible = false;

            team2.Visible = false;
            team2_p1.Visible = false;
            team2_p2.Visible = false;
            team2_player1_name.Visible = false;
            team2_player1_nation.Visible = false;
            team2_player2_name.Visible = false;
            team2_player2_nation.Visible = false;
            team2_player1_age.Visible = false;
            team2_player2_age.Visible = false;
            team2_rate.Visible = false;
            team2_ranking.Visible = false;

            team_input.Visible = false;
            team_name.Visible = false;
            team_nation.Visible = false;
            team_rate.Visible = false;
            team_age.Visible = false;
            team_ranking.Visible = false;

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
            solo_player1_age.Visible = true;
            solo_player1_ranking.Visible = true;
            solo_player2_name.Visible = true;
            solo_player2_nation.Visible = true;
            solo_player2_age.Visible = true;
            solo_player2_ranking.Visible = true;
            solo_player2_rate.Visible = true;
            solo_age.Visible = true;
            solo_ranking.Visible = true;
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
            solo_player1_age.Visible = false;
            solo_player1_ranking.Visible = false;
            solo_player2_name.Visible = false;
            solo_player2_nation.Visible = false;
            solo_player2_rate.Visible = false;
            solo_player2_age.Visible = false;
            solo_player2_ranking.Visible = false;
            solo_age.Visible = false;
            solo_ranking.Visible = false;

            //복식 입력 내용 보이게
            team1.Visible = true;
            team1_p1.Visible = true;
            team1_p2.Visible = true;
            team1_player1_name.Visible = true;
            team1_player1_nation.Visible = true;
            team1_player1_age.Visible = true;
            team1_player2_name.Visible = true;
            team1_player2_nation.Visible = true;
            team1_player2_age.Visible = true;
            team1_rate.Visible = true;
            team1_ranking.Visible = true;

            team2.Visible = true;
            team2_p1.Visible = true;
            team2_p2.Visible = true;
            team2_player1_name.Visible = true;
            team2_player1_nation.Visible = true;
            team2_player1_age.Visible = true;
            team2_player2_name.Visible = true;
            team2_player2_nation.Visible = true;
            team2_player2_age.Visible = true;
            team2_rate.Visible = true;
            team2_ranking.Visible = true;

            team_input.Visible = true;
            team_name.Visible = true;
            team_nation.Visible = true;
            team_rate.Visible = true;
            team_age.Visible = true;
            team_ranking.Visible = true;
        }


        // 단식 입력 버튼 클릭 시
        private void solo_input_Click(object sender, EventArgs e)
        {
            // Solo 정보 입력
            solo_player1Name = solo_player1_name.Text;
            solo_player1Nation = solo_player1_nation.Text;
            solo_player1Age = solo_player1_age.Text;
            solo_player1Ranking = solo_player1_ranking.Text;

            solo_player2Name = solo_player2_name.Text;
            solo_player2Nation = solo_player2_nation.Text;
            solo_player2Age = solo_player2_age.Text;
            solo_player2Ranking = solo_player2_ranking.Text;

            player1Winrate = int.Parse(solo_player1_rate.Text);
            player2Winrate = 100 - player1Winrate;

            firstWinrate1 = player1Winrate;
            firstWinrate2 = 100 - player1Winrate;

            // 승률 예측 정보 변경
            p1_name_.Text = solo_player1Name;
            p2_name_.Text = solo_player2Name;
            log.Columns[3].Text = solo_player1Name;
            log.Columns[5].Text = solo_player2Name;

            // 텍스트박스 초기화
            solo_player1_name.Text = " ";
            solo_player1_nation.Text = " ";
            solo_player1_age.Text = " ";
            solo_player1_ranking.Text = " ";

            solo_player2_name.Text = " ";
            solo_player2_nation.Text = " ";
            solo_player2_age.Text = " ";
            solo_player2_ranking.Text = " ";

            MessageBox.Show("입력되었습니다.");

            p1_Winrate = (double)player1Winrate;
            p1_Loserate = (double)(100 - player1Winrate);
            p2_Winrate = (double)player2Winrate;
            p2_Loserate = (double)(100 - player2Winrate);

            sd.Text = "단식";

            sd.init_ = this;
        }

        // 복식 입력 버튼 클릭 시
        private void team_input_Click(object sender, EventArgs e)
        {
            // Team 정보 입력
            solo_player1Name = team1_player1_name.Text + "," + team1_player2_name.Text;
            solo_player1Nation = team1_player1_nation.Text + "," + team1_player2_nation.Text;
            solo_player1Age = team1_player1_age.Text + "," + team1_player2_age.Text;
            solo_player1Ranking = team1_ranking.Text;

            solo_player2Name = team2_player1_name.Text + "," + team2_player2_name.Text;
            solo_player2Nation = team2_player1_nation.Text + "," + team2_player2_nation.Text;
            solo_player2Age = team2_player1_age.Text + "," + team2_player2_age.Text;
            solo_player2Ranking = team2_ranking.Text;

            player1Winrate = int.Parse(team1_rate.Text);
            player2Winrate = 100 - player1Winrate;

            firstWinrate1 = player1Winrate;
            firstWinrate2 = 100 - player1Winrate;

            // 승률 예측 정보 변경
            p1_name_.Text = solo_player1Name;
            p2_name_.Text = solo_player2Name;
            log.Columns[3].Text = "Team1";
            log.Columns[5].Text = "Team2";

            // 텍스트 박스 초기화
            team1_player1_name.Text = " ";
            team1_player1_nation.Text = " ";
            team1_player1_age.Text = " ";
            team1_ranking.Text = " ";
            team1_player2_name.Text = " ";
            team1_player2_nation.Text = " ";
            team1_player2_age.Text = " ";

            team2_player1_name.Text = " ";
            team2_player1_nation.Text = " ";
            team2_player1_age.Text = " ";
            team2_ranking.Text = " ";
            team2_player2_name.Text = " ";
            team2_player2_nation.Text = " ";
            team2_player2_age.Text = " ";

            MessageBox.Show("입력되었습니다.");

            p1_Winrate = (double)player1Winrate;
            p1_Loserate = (double)(100 - player1Winrate);
            p2_Winrate = (double)player2Winrate;
            p2_Loserate = (double)(100 - player2Winrate);

            sd.Text = "복식";

            sd.init_ = this;
        }

        // 사전 승률
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

        private void team1_rate_TextChanged(object sender, EventArgs e)
        {
            if (team1_rate.TextLength != 0)
                team2_rate.Text = (100 - int.Parse(team1_rate.Text)).ToString();
        }

        private void team2_rate_TextChanged(object sender, EventArgs e)
        {
            if (team2_rate.TextLength != 0)
                team1_rate.Text = (100 - int.Parse(team2_rate.Text)).ToString();
        }


        // ------------------------------------------- 승률 예측 ------------------------------------------- //
        private void guess_Click(object sender, EventArgs e)
        {
            info_panel.Visible = false;
            picture.Visible = false;
            guess_panel.Visible = true;
        }

        private void p1_name__Click(object sender, EventArgs e)
        {
            selected_player = 1;
        }

        private void p2_name__Click(object sender, EventArgs e)
        {
            selected_player = 2;
        }

        private void MISS_botton_Click(object sender, EventArgs e)
        {
            selected_miss = true;
            selected_ferror = false;
            selected_notouch = false;
            selected_etc = false;
        }

        private void F_ERROR_button_Click(object sender, EventArgs e)
        {
            selected_miss = false;
            selected_ferror = true;
            selected_notouch = false;
            selected_etc = false;
        }

        private void NONTOUCH_button_Click(object sender, EventArgs e)
        {
            selected_miss = false;
            selected_ferror = false;
            selected_notouch = true;
            selected_etc = false;
        }

        private void ETC_button_Click(object sender, EventArgs e)
        {
            selected_miss = false;
            selected_ferror = false;
            selected_notouch = false;
            selected_etc = true;
        }

        private void get_Click(object sender, EventArgs e)
        {
            if (selected_player == 1)
            {
                who_get_score = 1;
                p1_score++;
                playername = solo_player1Name;
            }
            else
            {
                who_get_score = 2;
                p2_score++;
                playername = solo_player2Name;
            }

            score_gap = Math.Abs(p1_score - p2_score);
            if (p1_score >= p2_score) // 가장 높은 점수 계산
                highest_score = p1_score;
            else highest_score = p2_score;

            calculate(); // 승률, 사후확률 계산
            evaluate(); // Alpha, Beta에 기초한 평가

            Console.WriteLine(p1_Winrate);
            // 디스플레이 창 변경
            sd.change_winrate((p1_Winrate * 100), ((1 - p1_Winrate) * 100));
            sd.setting_score(p1_score, p2_score);
            add_listview();
        }

        private void lose_Click(object sender, EventArgs e)
        {
            if (selected_player == 1)
            {
                who_get_score = 2;
                p2_score++;
                playername = solo_player2Name;
            }
            else
            {
                who_get_score = 1;
                p1_score++;
                playername = solo_player1Name;
            }

            score_gap = Math.Abs(p1_score - p2_score); // 스코어 차이 계산
            if (p1_score >= p2_score) // 가장 높은 점수 계산
                highest_score = p1_score;
            else highest_score = p2_score;

            calculate(); // 승률, 사후확률 계산
            evaluate(); // Alpha, Beta에 기초한 평가

            // 디스플레이 창 변경
            sd.change_winrate((p1_Winrate * 100), ((1 - p1_Winrate)  * 100)); 
            sd.setting_score(p1_score, p2_score);
            add_listview();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if(log.Items.Count > 1)
            {
                log.Items.RemoveAt(log.Items.Count - 1);
                p1_score = int.Parse(log.Items[log.Items.Count - 1].SubItems[3].Text);
                p2_score = int.Parse(log.Items[log.Items.Count - 1].SubItems[5].Text);
                p1_Winrate = double.Parse(log.Items[log.Items.Count - 1].SubItems[8].Text) / 100;
                p1_Loserate = double.Parse(log.Items[log.Items.Count - 1].SubItems[9].Text) / 100;
                p2_Winrate = double.Parse(log.Items[log.Items.Count - 1].SubItems[9].Text) / 100;
                AfterRate = double.Parse(log.Items[log.Items.Count - 1].SubItems[10].Text);
                numerator = PreNumer;
                denominator = PreDenomi;

                sd.change_winrate((p1_Winrate * 100), ((1 - p1_Winrate) * 100)); // 승률 설정
                sd.setting_score(p1_score, p2_score); // 스코어 설정
                sd.set_eval_text(sd.p1_WinEval, sd.p2_WinEval); // 승패 평가 설정
            }
            else
            {
                log.Items.Clear();
                p1_score = 0;
                p2_score = 0;
                p1_Winrate = (double)((double)firstWinrate1 / 100);
                p1_Loserate = (double)(1 - firstWinrate1) / 100;
                p2_Winrate = (double)firstWinrate2 / 100;
                AfterRate = 0;
                numerator = PreNumer;
                denominator = PreDenomi;

                sd.change_winrate((p1_Winrate * 100), ((1 - p1_Winrate) * 100)); // 승률 설정
                sd.setting_score(p1_score, p2_score); // 스코어 설정
                sd.set_eval_text(" ", " "); // 승패 평가 설정
            }
        }

        private void calculate()
        {
            if(selected_miss)
            {
                skill = "MISS";
                if(highest_score < 6)
                {
                    timing = "0-5";
                    if (score_gap >= 2)
                    {
                        adapt = "MISS0-5";
                        calculate2(miss0_5);
                    }
                    else
                    {
                        adapt = "MISS";
                        calculate2(miss);
                    }
                }
                else if(highest_score < 11)
                {
                    timing = "6-10";
                    if (score_gap >= 2)
                    {
                        adapt = "MISS6-10";
                        calculate2(miss6_10);
                    }
                    else
                    {
                        adapt = "MISS";
                        calculate2(miss);
                    }
                }
                else if(highest_score < 16)
                {
                    timing = "11-15";
                    if (score_gap >= 2)
                    {
                        adapt = "MISS11-15";
                        calculate2(miss11_15);
                    }
                    else
                    {
                        adapt = "MISS";
                        calculate2(miss);
                    }
                }
                else if(highest_score < 21)
                {
                    timing = "16-20";
                    if (score_gap >= 2)
                    {
                        adapt = "MISS16-20";
                        calculate2(miss16_20);
                    }
                    else
                    {
                        adapt = "MISS";
                        calculate2(miss);
                    }
                }
                else
                {
                    timing = "21-";
                    if (score_gap >= 2)
                    {
                        adapt = "MISS21-";
                        calculate2(miss21_);
                    }
                    else
                    {
                        adapt = "MISS";
                        calculate2(miss);
                    }
                }
            }

            else if(selected_ferror)
            {
                skill = "F_ERROR";
                if (highest_score < 6)
                {
                    timing = "0-5";
                    if (score_gap >= 2)
                    {
                        adapt = "F_ERROR0-5";
                        calculate2(f_error0_5);
                    }
                    else
                    {
                        adapt = "F_ERROR";
                        calculate2(f_error);
                    }
                }
                else if (highest_score < 11)
                {
                    timing = "6-10";
                    if (score_gap >= 2)
                    {
                        adapt = "F_ERROR6-10";
                        calculate2(f_error6_10);
                    }
                    else
                    {
                        adapt = "F_ERROR";
                        calculate2(f_error);
                    }
                }
                else if (highest_score < 16)
                {
                    timing = "11-15";
                    if (score_gap >= 2)
                    {
                        adapt = "F_ERROR11-15";
                        calculate2(f_error11_15);
                    }
                    else
                    {
                        adapt = "F_ERROR";
                        calculate2(f_error);
                    }
                }
                else if (highest_score < 21)
                {
                    timing = "16-20";
                    if (score_gap >= 2)
                    {
                        adapt = "F_ERROR16-20";
                        calculate2(f_error16_20);
                    }
                    else
                    {
                        adapt = "F_ERROR";
                        calculate2(f_error);
                    }
                }
                else
                {
                    timing = "21-";
                    if (score_gap >= 2)
                    {
                        adapt = "F_ERROR21-";
                        calculate2(f_error21_);
                    }
                    else
                    {
                        adapt = "F_ERROR";
                        calculate2(f_error);
                    }
                }
            }

            else if(selected_notouch)
            {
                skill = "NOTOUCH";
                if (highest_score < 6)
                {
                    timing = "0-5";
                    if (score_gap >= 2)
                    {
                        adapt = "NOTOUCH0-5";
                        calculate2(notouch0_5);
                    }
                    else
                    {
                        adapt = "NOTOUCH";
                        calculate2(notouch);
                    }
                }
                else if (highest_score < 11)
                {
                    timing = "6-10";
                    if (score_gap >= 2)
                    {
                        adapt = "NOTOUCH6-10";
                        calculate2(notouch6_10);
                    }
                    else
                    {
                        adapt = "NOTOUCH";
                        calculate2(notouch);
                    }
                }
                else if (highest_score < 16)
                {
                    timing = "11-15";
                    if (score_gap >= 2)
                    {
                        adapt = "NOTOUCH11-15";
                        calculate2(notouch11_15);
                    }
                    else
                    {
                        adapt = "NOTOUCH";
                        calculate2(notouch);
                    }
                }
                else if (highest_score < 21)
                {
                    timing = "16-20";
                    if (score_gap >= 2)
                    {
                        adapt = "NOTOUCH16-20";
                        calculate2(notouch16_20);
                    }
                    else
                    {
                        adapt = "NOTOUCH";
                        calculate2(notouch);
                    }
                }
                else
                {
                    timing = "21-";
                    if (score_gap >= 2)
                    {
                        adapt = "NOTOUCH21-";
                        calculate2(notouch21_);
                    }
                    else
                    {
                        adapt = "NOTOUCH";
                        calculate2(notouch);
                    }
                }
            }

            else if(selected_etc)
            {
                skill = "ETC";
                if (highest_score < 6)
                {
                    timing = "0-5";
                    if (score_gap >= 2)
                    {
                        adapt = "ETC0-5";
                        calculate2(etc0_5);
                    }
                    else
                    {
                        adapt = "ETC";
                        calculate2(etc);
                    }
                }
                else if (highest_score < 11)
                {
                    timing = "6-10";
                    if (score_gap >= 2)
                    {
                        adapt = "ETC6-10";
                        calculate2(etc6_10);
                    }
                    else
                    {
                        adapt = "ETC";
                        calculate2(etc);
                    }
                }
                else if (highest_score < 16)
                {
                    timing = "11-15";
                    if (score_gap >= 2)
                    {
                        adapt = "ETC11-15";
                        calculate2(etc11_15);
                    }
                    else
                    {
                        adapt = "ETC";
                        calculate2(etc);
                    }
                }
                else if (highest_score < 21)
                {
                    timing = "16-20";
                    if (score_gap >= 2)
                    {
                        adapt = "ETC16-20";
                        calculate2(etc16_20);
                    }
                    else
                    {
                        adapt = "ETC";
                        calculate2(etc);
                    }
                }
                else
                {
                    timing = "21-";
                    if (score_gap >= 2)
                    {
                        adapt = "ETC21-";
                        calculate2(etc21_);
                    }
                    else
                    {
                        adapt = "ETC";
                        calculate2(etc);
                    }
                }
            }
        }

        private void calculate2(double[] tmp)
        {
            PreNumer = numerator;
            PreDenomi = denominator;

            if (who_get_score == 1)
            {
                if (highest_score == 1)
                {
                    numerator = (p1_Winrate / 100) * (Math.Pow(tmp[0], 1) * Math.Pow(tmp[1], 0));
                    denominator = (p2_Winrate / 100) * (Math.Pow(tmp[2], 1) * Math.Pow(tmp[3], 0));
                }
                else
                {
                    numerator = numerator * (Math.Pow(tmp[0], 1) * Math.Pow(tmp[1], 0));
                    denominator = denominator * (Math.Pow(tmp[2], 1) * Math.Pow(tmp[3], 0));
                }

                p1_Winrate = numerator / (numerator + denominator);

                if (p1_Winrate > 0.99) // 승률 99이하 1이상으로
                    p1_Winrate = 0.99;
                else if (p1_Winrate < 0.01)
                    p1_Winrate = 0.01;


                p2_Winrate = 1 - p1_Winrate; //추가된거
                p1_Winrate = (double)Math.Truncate(p1_Winrate * 10000) / 10000;
                p1_Loserate = denominator / (numerator + denominator);
                p1_Loserate = (double)Math.Truncate(p1_Loserate * 10000) / 10000;


                AfterRate = numerator / denominator;
                AfterRate = (double)Math.Truncate(AfterRate * 10000) / 10000;
            }

            else if(who_get_score == 2)
            {
                if (highest_score == 1)
                {
                    numerator = (p1_Winrate / 100) * (Math.Pow(tmp[0], 0) * Math.Pow(tmp[1], 1));
                    denominator = (p2_Winrate / 100) * (Math.Pow(tmp[2], 0) * Math.Pow(tmp[3], 1));
                }
                else
                {
                    numerator = numerator * (Math.Pow(tmp[0], 0) * Math.Pow(tmp[1], 1));
                    denominator = denominator * (Math.Pow(tmp[2], 0) * Math.Pow(tmp[3], 1));
                }

                p1_Winrate = numerator / (numerator + denominator);

                if (p1_Winrate > 0.99) // 승률 99이하 1이상으로
                    p1_Winrate = 0.99;
                else if (p1_Winrate < 0.01)
                    p1_Winrate = 0.01;

                p2_Winrate = 1 - p1_Winrate; //추가된거
                p1_Winrate = (double)Math.Truncate(p1_Winrate * 10000) / 10000;
                p1_Loserate = denominator / (numerator + denominator);
                p1_Loserate = (double)Math.Truncate(p1_Loserate * 10000) / 10000;


                AfterRate = numerator / denominator;
                AfterRate = (double)Math.Truncate(AfterRate * 10000) / 10000;

            }
        }

        private void evaluate()

        {
            if(AfterRate > alpha[3] || AfterRate < beta[3]) // 1%
            {
                if (AfterRate > alpha[3])
                {
                    sd.set_eval_text("승 확실", "패 확실");
                    one = "승 확실";
                    return;
                }
                else if (AfterRate < beta[3])
                {
                    sd.set_eval_text("패 확실", "승 확실");
                    one = "패 확실";
                    return;
                }
            }
            else one = "접전";

            if(AfterRate > alpha[2] || AfterRate < beta[2]) // 5%
            {
                if (AfterRate > alpha[2])
                {
                    sd.set_eval_text("승 유력", "패 유력");
                    five = "승 유력";
                    return;
                }
                else if (AfterRate < beta[2])
                {
                    sd.set_eval_text("패 유력", "승 유력");
                    five = "패 유력";
                    return;
                }
            }
            else five = "접전";

            if (AfterRate > alpha[1] || AfterRate < beta[1]) // 10%
            {
                if (AfterRate > alpha[1])
                {
                    ten = "주도";
                    sd.set_eval_text("주도", "열세");
                    return;
                }
                else if (AfterRate < beta[1])
                {
                    ten = "열세";
                    sd.set_eval_text("열세", "주도");
                    return;
                }
            }
            else ten = "접전";

            if (AfterRate > alpha[0] || AfterRate < beta[0]) // 30%
            {
                if (AfterRate > alpha[0])
                {
                    thirty = "주도";
                    sd.set_eval_text("주도", " ");
                    return;
                }
                else if (AfterRate < beta[0])
                {
                    thirty = " ";
                    sd.set_eval_text(" ", "주도");
                    return;
                }
            }
            else
            {
                thirty = "접전";
                sd.set_eval_text("접전", "접전");
            }
        }

        private void add_listview()
        {
            ListViewItem items = new ListViewItem();
            items.Text = playername;
            items.SubItems.Add(skill);
            items.SubItems.Add(who_get_score.ToString());
            items.SubItems.Add(p1_score.ToString());
            items.SubItems.Add("vs");
            items.SubItems.Add(p2_score.ToString());
            items.SubItems.Add(timing);
            items.SubItems.Add(adapt);

            items.SubItems.Add((p1_Winrate * 100).ToString());
            items.SubItems.Add((p1_Loserate * 100).ToString());
            items.SubItems.Add(AfterRate.ToString());

            items.SubItems.Add(thirty);
            items.SubItems.Add(ten);
            items.SubItems.Add(five);
            items.SubItems.Add(one);
            log.Items.Add(items);
            log.TopItem = log.Items[log.Items.Count - 1];

        }

        // 세트 종료 버튼 클릭 시
        private void set_over_Click(object sender, EventArgs e)
        {
            // display 초기화
            sd.click_set_over_send(firstWinrate1, firstWinrate2); // 승률 초기화
            sd.setting_score(0, 0); // 스코어 초기화
            sd.set_eval_text(" ", " "); // 승패 평가 초기화
            sd.set_currentset(++current_set, p1_score, p2_score); // 세트스코어 설정

            // Initialize 초기화
            p1_score = 0; p2_score = 0;
            p1_Winrate = firstWinrate1;
            p2_Winrate = firstWinrate2;

            log.Items.Clear();

            MessageBox.Show("세트가 종료되었습니다.");
        }

        // ------------------------------------------- 결과 보조창 ------------------------------------------- //
        private void display_form_Click(object sender, EventArgs e)
        {
            sd.player1Name = solo_player1Name;
            sd.player1Nation = solo_player1Nation;
            sd.player1Age = solo_player1Age;
            sd.player1Ranking = solo_player1Ranking;
            sd.player1Winrate = player1Winrate;
            sd.player2Name = solo_player2Name;
            sd.player2Nation = solo_player2Nation;
            sd.player2Age = solo_player2Age;
            sd.player2Ranking = solo_player2Ranking;
            sd.player2Winrate = player2Winrate;
            sd.Show();
        }

        public void display_form_closed()
        {
            sd.Dispose();

            sd = new Display_();
            sd.init_ = this;
        }
    }
}
