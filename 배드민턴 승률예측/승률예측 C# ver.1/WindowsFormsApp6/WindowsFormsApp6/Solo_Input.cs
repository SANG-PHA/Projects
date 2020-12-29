using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp6
{
    public partial class Solo_Input : Form
    {
        public Solo_Input()
        {
            InitializeComponent();
        }

        // 엑셀 파일을 불러오기 위한 변수들
        Workbook workbook = null;
        Worksheet worksheet = null;
        Microsoft.Office.Interop.Excel.Application application = null;



        // Initialize에서 전달받을 선수이름, 국적 저장 변수
        public string player1Name;
        public string player1Nation;
        public string player2Name;
        public string player2Nation;
        public int player1Winrate;

        // Solo_Display객체 생성
        Solo_Display solo_display = new Solo_Display();

        //폼이 켜질 때
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize에서 전달받은 선수 이름과 국적
            player1_name.Text = player1Name;
            p1_name.Text = player1Name;
            player1_nation.Text = player1Nation;
            player2_name.Text = player2Name;
            p2_name.Text = player2Name;
            player2_nation.Text = player2Nation;

            //초반 승률 display
            if(player1Winrate > 50)
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

            //Solo_Display 폼 로드
            solo_display.player1Name = player1Name;
            solo_display.player1Nation = player1Nation;
            solo_display.player2Name = player2Name;
            solo_display.player2Nation = player2Nation;
            solo_display.player1Winrate = player1Winrate;
            solo_display.Show();

            ////////////////////////////////////////////////////////
            for (int i = 0; i < 20; i++)
            {
                ListViewItem items = new ListViewItem();
                items.Text = "홍길동" + i;
                items.SubItems.Add("recieve");
                items.SubItems.Add("득점");
                items.SubItems.Add("홍길동");
                items.SubItems.Add("10");
                items.SubItems.Add("vs");
                items.SubItems.Add("12");
                items.SubItems.Add("11-15");
                items.SubItems.Add("S.Receive+6-10");
                log.Items.Add(items);
            }
            ////////////////////////////////////////////////////////
        }

      

        //플레이어 사진 선택
        private void player1_Click(object sender, EventArgs e)
        {
            //파일로부터 이미지 로드
            openFileDialog2.ShowDialog();
            Image img = Image.FromFile(openFileDialog2.FileName);

            //이미지 리사이즈
            Image resized_img = ReSizeImg(img);

            //버튼 이미지 설정, display폼에 이미지 전달
            player1.Image = resized_img;
            solo_display.player1_img_set(resized_img);
        }

        private void player2_Click(object sender, EventArgs e)
        {
            //파일로부터 이미지 로드
            openFileDialog2.ShowDialog();
            Image img = Image.FromFile(openFileDialog2.FileName);

            //이미지 리사이즈
            Image resized_img = ReSizeImg(img);

            //버튼 이미지 설정, display폼에 이미지 전달
            player2.Image = resized_img;
            solo_display.player2_img_set(resized_img);
        }

        // 엑셀 파일 불러오기
        private void SelectExel_Click(object sender, EventArgs e)
        {
            try
            {
                // 백그라운드에서 엑셀 프로세스가 쌓이는 것을 방지하기 위해 메모리 해제 먼저
                if (workbook != null || worksheet != null || application != null)
                {
                    DeleteObject(worksheet);
                    DeleteObject(workbook);
                    application.Quit();
                    DeleteObject(application);
                }

                openFileDialog1.ShowDialog();
                String filepath = openFileDialog1.FileName;
                if (filepath != null)
                {

                    application = new Microsoft.Office.Interop.Excel.Application();
                    workbook = application.Workbooks.Open(Filename: @filepath);
                    worksheet = workbook.Worksheets.get_Item("Match Setup");
                    application.Visible = false;

                    String data = "" + worksheet.get_Range("B4").Value;
                    Console.WriteLine(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 : " + ex.Message, "에러!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //메모리 해제 함수
        private void DeleteObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("메모리 할당을 해제하는 중 문제가 발생하였습니다. " + ex.ToString(), "경고!");
            }
            finally
            {
                GC.Collect();
            }
        }

        private Bitmap ReSizeImg(Image source)
        {
            int W = source.Width, H = source.Height;
            //이미지 리사이즈
            while (W > 100)
                W = (int)(W * 0.9);
            while (H > 120)
                H = (int)(H * 0.9);

            //리사이즈 된 이미지를 버튼의 이미지로 설정
            Size resize = new Size(W, H);
            Bitmap ResizeImg = new Bitmap(source, resize);

            return ResizeImg;
        }

        private void Solo_Input_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (workbook != null || worksheet != null || application != null)
            {
                DeleteObject(worksheet);
                DeleteObject(workbook);
                application.Quit();
                DeleteObject(application);
            }
        }


        //----------------------------------------세타 값 계산 파트입니다--------------------------------------------------------------------
        string tech = "";
        int p1_score = 0, p2_score = 0, score_gap = 0;

        // 버튼 클릭 시
        private void DROP_Click(object sender, EventArgs e)
        {
            tech = DROP.Text;
            DROP.BackColor = Color.Moccasin;
            CLEAR.BackColor = Color.LightGray;
            SMASH.BackColor = Color.LightGray;
            DRIVE.BackColor = Color.LightGray;
            S_CUT.BackColor = Color.LightGray;
            S_RECIEVE.BackColor = Color.LightGray;
            HAIRPIN.BackColor = Color.LightGray;
            PUSH.BackColor = Color.LightGray;
            U_CLEAR.BackColor = Color.LightGray;
            SERVICE.BackColor = Color.LightGray;
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            tech = CLEAR.Text;
            DROP.BackColor = Color.LightGray;
            CLEAR.BackColor = Color.Moccasin;
            SMASH.BackColor = Color.LightGray;
            DRIVE.BackColor = Color.LightGray;
            S_CUT.BackColor = Color.LightGray;
            S_RECIEVE.BackColor = Color.LightGray;
            HAIRPIN.BackColor = Color.LightGray;
            PUSH.BackColor = Color.LightGray;
            U_CLEAR.BackColor = Color.LightGray;
            SERVICE.BackColor = Color.LightGray;
        }

        private void SMASH_Click(object sender, EventArgs e)
        {
            tech = SMASH.Text;
            DROP.BackColor = Color.LightGray;
            CLEAR.BackColor = Color.LightGray;
            SMASH.BackColor = Color.Moccasin;
            DRIVE.BackColor = Color.LightGray;
            S_CUT.BackColor = Color.LightGray;
            S_RECIEVE.BackColor = Color.LightGray;
            HAIRPIN.BackColor = Color.LightGray;
            PUSH.BackColor = Color.LightGray;
            U_CLEAR.BackColor = Color.LightGray;
            SERVICE.BackColor = Color.LightGray;
        }

        private void DRIVE_Click(object sender, EventArgs e)
        {
            tech = DRIVE.Text;
            DROP.BackColor = Color.LightGray;
            CLEAR.BackColor = Color.LightGray;
            SMASH.BackColor = Color.LightGray;
            DRIVE.BackColor = Color.Moccasin;
            S_CUT.BackColor = Color.LightGray;
            S_RECIEVE.BackColor = Color.LightGray;
            HAIRPIN.BackColor = Color.LightGray;
            PUSH.BackColor = Color.LightGray;
            U_CLEAR.BackColor = Color.LightGray;
            SERVICE.BackColor = Color.LightGray;
        }

        private void S_CUT_Click(object sender, EventArgs e)
        {
            tech = S_CUT.Text;
            DROP.BackColor = Color.LightGray;
            CLEAR.BackColor = Color.LightGray;
            SMASH.BackColor = Color.LightGray;
            DRIVE.BackColor = Color.LightGray;
            S_CUT.BackColor = Color.Moccasin;
            S_RECIEVE.BackColor = Color.LightGray;
            HAIRPIN.BackColor = Color.LightGray;
            PUSH.BackColor = Color.LightGray;
            U_CLEAR.BackColor = Color.LightGray;
            SERVICE.BackColor = Color.LightGray;
        }

        private void S_RECIEVE_Click(object sender, EventArgs e)
        {
            tech = S_RECIEVE.Text;
            DROP.BackColor = Color.LightGray;
            CLEAR.BackColor = Color.LightGray;
            SMASH.BackColor = Color.LightGray;
            DRIVE.BackColor = Color.LightGray;
            S_CUT.BackColor = Color.LightGray;
            S_RECIEVE.BackColor = Color.Moccasin;
            HAIRPIN.BackColor = Color.LightGray;
            PUSH.BackColor = Color.LightGray;
            U_CLEAR.BackColor = Color.LightGray;
            SERVICE.BackColor = Color.LightGray;
        }

        private void HAIRPIN_Click(object sender, EventArgs e)
        {
            tech = HAIRPIN.Text;
            DROP.BackColor = Color.LightGray;
            CLEAR.BackColor = Color.LightGray;
            SMASH.BackColor = Color.LightGray;
            DRIVE.BackColor = Color.LightGray;
            S_CUT.BackColor = Color.LightGray;
            S_RECIEVE.BackColor = Color.LightGray;
            HAIRPIN.BackColor = Color.Moccasin; 
            PUSH.BackColor = Color.LightGray;
            U_CLEAR.BackColor = Color.LightGray;
            SERVICE.BackColor = Color.LightGray;
        }

        private void PUSH_Click(object sender, EventArgs e)
        {
            tech = PUSH.Text;
            DROP.BackColor = Color.LightGray;
            CLEAR.BackColor = Color.LightGray;
            SMASH.BackColor = Color.LightGray;
            DRIVE.BackColor = Color.LightGray;
            S_CUT.BackColor = Color.LightGray;
            S_RECIEVE.BackColor = Color.LightGray;
            HAIRPIN.BackColor = Color.LightGray;
            PUSH.BackColor = Color.Moccasin;
            U_CLEAR.BackColor = Color.LightGray;
            SERVICE.BackColor = Color.LightGray;
        }

        private void U_CLEAR_Click(object sender, EventArgs e)
        {
            tech = U_CLEAR.Text;
            DROP.BackColor = Color.LightGray;
            CLEAR.BackColor = Color.LightGray;
            SMASH.BackColor = Color.LightGray;
            DRIVE.BackColor = Color.LightGray;
            S_CUT.BackColor = Color.LightGray;
            S_RECIEVE.BackColor = Color.LightGray;
            HAIRPIN.BackColor = Color.LightGray;
            PUSH.BackColor = Color.LightGray;
            U_CLEAR.BackColor = Color.Moccasin;
            SERVICE.BackColor = Color.LightGray;
        }

        private void SERVICE_Click(object sender, EventArgs e)
        {
            tech = SERVICE.Text;
            DROP.BackColor = Color.LightGray;
            CLEAR.BackColor = Color.LightGray;
            SMASH.BackColor = Color.LightGray;
            DRIVE.BackColor = Color.LightGray;
            S_CUT.BackColor = Color.LightGray;
            S_RECIEVE.BackColor = Color.LightGray;
            HAIRPIN.BackColor = Color.LightGray;
            PUSH.BackColor = Color.LightGray;
            U_CLEAR.BackColor = Color.LightGray;
            SERVICE.BackColor = Color.Moccasin;
        }

        // 득점
        private void get_Click(object sender, EventArgs e)
        {
            // 버튼 색 변경
            {
                DROP.BackColor = Color.LightGray;
                CLEAR.BackColor = Color.LightGray;
                SMASH.BackColor = Color.LightGray;
                DRIVE.BackColor = Color.LightGray;
                S_CUT.BackColor = Color.LightGray;
                S_RECIEVE.BackColor = Color.LightGray;
                HAIRPIN.BackColor = Color.LightGray;
                PUSH.BackColor = Color.LightGray;
                U_CLEAR.BackColor = Color.LightGray;
                SERVICE.BackColor = Color.LightGray;
            }

        }

        // 실점
        private void lose_Click(object sender, EventArgs e)
        {
            // 버튼 색 변경
            {
                DROP.BackColor = Color.LightGray;
                CLEAR.BackColor = Color.LightGray;
                SMASH.BackColor = Color.LightGray;
                DRIVE.BackColor = Color.LightGray;
                S_CUT.BackColor = Color.LightGray;
                S_RECIEVE.BackColor = Color.LightGray;
                HAIRPIN.BackColor = Color.LightGray;
                PUSH.BackColor = Color.LightGray;
                U_CLEAR.BackColor = Color.LightGray;
                SERVICE.BackColor = Color.LightGray;
            }

        }

        private void calculate()
        {

        }

        //---------------------------------------------------------------------------------------------------------------------------------------
    }
}
