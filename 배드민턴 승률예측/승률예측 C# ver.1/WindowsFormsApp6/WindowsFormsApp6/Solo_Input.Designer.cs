namespace WindowsFormsApp6
{
    partial class Solo_Input
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectExel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.p1_name = new System.Windows.Forms.RadioButton();
            this.p2_name = new System.Windows.Forms.RadioButton();
            this.DROP = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.SMASH = new System.Windows.Forms.Button();
            this.DRIVE = new System.Windows.Forms.Button();
            this.S_CUT = new System.Windows.Forms.Button();
            this.HAIRPIN = new System.Windows.Forms.Button();
            this.S_RECIEVE = new System.Windows.Forms.Button();
            this.PUSH = new System.Windows.Forms.Button();
            this.U_CLEAR = new System.Windows.Forms.Button();
            this.SERVICE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.get = new System.Windows.Forms.Button();
            this.lose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.player2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.player1_name = new System.Windows.Forms.Label();
            this.player1_nation = new System.Windows.Forms.Label();
            this.player2_nation = new System.Windows.Forms.Label();
            this.player2_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.p1_loserate = new System.Windows.Forms.Label();
            this.p1_winrate = new System.Windows.Forms.Label();
            this.p2_loserate = new System.Windows.Forms.Label();
            this.p2_winrate = new System.Windows.Forms.Label();
            this.p1_winrate_text = new System.Windows.Forms.Label();
            this.p2_winrate_text = new System.Windows.Forms.Label();
            this.player1_score = new System.Windows.Forms.Label();
            this.player2_score = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.p2_70 = new System.Windows.Forms.Label();
            this.p2_90 = new System.Windows.Forms.Label();
            this.p2_95 = new System.Windows.Forms.Label();
            this.p2_99 = new System.Windows.Forms.Label();
            this.p1_70 = new System.Windows.Forms.Label();
            this.p1_90 = new System.Windows.Forms.Label();
            this.p1_95 = new System.Windows.Forms.Label();
            this.p1_99 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.ListView();
            this.타구선수 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.기술 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.득점여부 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.득점선수 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player1_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player2_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.시점 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.적용 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // SelectExel
            // 
            this.SelectExel.Location = new System.Drawing.Point(651, 2);
            this.SelectExel.Name = "SelectExel";
            this.SelectExel.Size = new System.Drawing.Size(95, 20);
            this.SelectExel.TabIndex = 1;
            this.SelectExel.Text = "엑셀 파일 선택";
            this.SelectExel.UseVisualStyleBackColor = true;
            this.SelectExel.Click += new System.EventHandler(this.SelectExel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "엑셀 파일 (*.xlsx) |*.xlsx";
            // 
            // p1_name
            // 
            this.p1_name.AutoSize = true;
            this.p1_name.Checked = true;
            this.p1_name.Location = new System.Drawing.Point(127, 66);
            this.p1_name.Name = "p1_name";
            this.p1_name.Size = new System.Drawing.Size(77, 16);
            this.p1_name.TabIndex = 2;
            this.p1_name.TabStop = true;
            this.p1_name.Text = "플레이어1";
            this.p1_name.UseVisualStyleBackColor = true;
            // 
            // p2_name
            // 
            this.p2_name.AutoSize = true;
            this.p2_name.Location = new System.Drawing.Point(239, 66);
            this.p2_name.Name = "p2_name";
            this.p2_name.Size = new System.Drawing.Size(77, 16);
            this.p2_name.TabIndex = 3;
            this.p2_name.Text = "플레이어2";
            this.p2_name.UseVisualStyleBackColor = true;
            // 
            // DROP
            // 
            this.DROP.Location = new System.Drawing.Point(12, 133);
            this.DROP.Name = "DROP";
            this.DROP.Size = new System.Drawing.Size(79, 49);
            this.DROP.TabIndex = 4;
            this.DROP.Text = "DROP";
            this.DROP.UseVisualStyleBackColor = true;
            this.DROP.Click += new System.EventHandler(this.DROP_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(93, 133);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(79, 49);
            this.CLEAR.TabIndex = 5;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // SMASH
            // 
            this.SMASH.Location = new System.Drawing.Point(173, 133);
            this.SMASH.Name = "SMASH";
            this.SMASH.Size = new System.Drawing.Size(79, 49);
            this.SMASH.TabIndex = 6;
            this.SMASH.Text = "SMASH";
            this.SMASH.UseVisualStyleBackColor = true;
            this.SMASH.Click += new System.EventHandler(this.SMASH_Click);
            // 
            // DRIVE
            // 
            this.DRIVE.Location = new System.Drawing.Point(253, 133);
            this.DRIVE.Name = "DRIVE";
            this.DRIVE.Size = new System.Drawing.Size(79, 49);
            this.DRIVE.TabIndex = 7;
            this.DRIVE.Text = "DRIVE";
            this.DRIVE.UseVisualStyleBackColor = true;
            this.DRIVE.Click += new System.EventHandler(this.DRIVE_Click);
            // 
            // S_CUT
            // 
            this.S_CUT.BackColor = System.Drawing.Color.LightGray;
            this.S_CUT.Location = new System.Drawing.Point(333, 133);
            this.S_CUT.Name = "S_CUT";
            this.S_CUT.Size = new System.Drawing.Size(79, 49);
            this.S_CUT.TabIndex = 8;
            this.S_CUT.Text = "S_CUT";
            this.S_CUT.UseVisualStyleBackColor = false;
            this.S_CUT.Click += new System.EventHandler(this.S_CUT_Click);
            // 
            // HAIRPIN
            // 
            this.HAIRPIN.Location = new System.Drawing.Point(93, 188);
            this.HAIRPIN.Name = "HAIRPIN";
            this.HAIRPIN.Size = new System.Drawing.Size(79, 49);
            this.HAIRPIN.TabIndex = 9;
            this.HAIRPIN.Text = "HAIRPIN";
            this.HAIRPIN.UseVisualStyleBackColor = true;
            this.HAIRPIN.Click += new System.EventHandler(this.HAIRPIN_Click);
            // 
            // S_RECIEVE
            // 
            this.S_RECIEVE.Location = new System.Drawing.Point(12, 188);
            this.S_RECIEVE.Name = "S_RECIEVE";
            this.S_RECIEVE.Size = new System.Drawing.Size(79, 49);
            this.S_RECIEVE.TabIndex = 10;
            this.S_RECIEVE.Text = "S_RECIEVE";
            this.S_RECIEVE.UseVisualStyleBackColor = true;
            this.S_RECIEVE.Click += new System.EventHandler(this.S_RECIEVE_Click);
            // 
            // PUSH
            // 
            this.PUSH.Location = new System.Drawing.Point(173, 188);
            this.PUSH.Name = "PUSH";
            this.PUSH.Size = new System.Drawing.Size(79, 49);
            this.PUSH.TabIndex = 11;
            this.PUSH.Text = "PUSH";
            this.PUSH.UseVisualStyleBackColor = true;
            this.PUSH.Click += new System.EventHandler(this.PUSH_Click);
            // 
            // U_CLEAR
            // 
            this.U_CLEAR.Location = new System.Drawing.Point(253, 188);
            this.U_CLEAR.Name = "U_CLEAR";
            this.U_CLEAR.Size = new System.Drawing.Size(79, 49);
            this.U_CLEAR.TabIndex = 12;
            this.U_CLEAR.Text = "U_CLEAR";
            this.U_CLEAR.UseVisualStyleBackColor = true;
            this.U_CLEAR.Click += new System.EventHandler(this.U_CLEAR_Click);
            // 
            // SERVICE
            // 
            this.SERVICE.Location = new System.Drawing.Point(333, 188);
            this.SERVICE.Name = "SERVICE";
            this.SERVICE.Size = new System.Drawing.Size(79, 49);
            this.SERVICE.TabIndex = 13;
            this.SERVICE.Text = "SERVICE";
            this.SERVICE.UseVisualStyleBackColor = true;
            this.SERVICE.Click += new System.EventHandler(this.SERVICE_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "득/실점 기술";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "득점여부";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(92, 284);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(104, 64);
            this.get.TabIndex = 16;
            this.get.Text = "득점";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // lose
            // 
            this.lose.Location = new System.Drawing.Point(228, 284);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(104, 64);
            this.lose.TabIndex = 17;
            this.lose.Text = "실점";
            this.lose.UseVisualStyleBackColor = true;
            this.lose.Click += new System.EventHandler(this.lose_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "선수 선택";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.White;
            this.player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.player1.Location = new System.Drawing.Point(444, 27);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(100, 120);
            this.player1.TabIndex = 19;
            this.player1.Text = " ";
            this.player1.UseVisualStyleBackColor = false;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.White;
            this.player2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.player2.Location = new System.Drawing.Point(622, 27);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(100, 120);
            this.player2.TabIndex = 20;
            this.player2.Text = " ";
            this.player2.UseVisualStyleBackColor = false;
            this.player2.Click += new System.EventHandler(this.player2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "vs";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1_name
            // 
            this.player1_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1_name.Location = new System.Drawing.Point(445, 148);
            this.player1_name.Name = "player1_name";
            this.player1_name.Size = new System.Drawing.Size(98, 23);
            this.player1_name.TabIndex = 22;
            this.player1_name.Text = "이름";
            this.player1_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1_nation
            // 
            this.player1_nation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1_nation.Location = new System.Drawing.Point(445, 174);
            this.player1_nation.Name = "player1_nation";
            this.player1_nation.Size = new System.Drawing.Size(98, 23);
            this.player1_nation.TabIndex = 23;
            this.player1_nation.Text = "국가";
            this.player1_nation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2_nation
            // 
            this.player2_nation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2_nation.Location = new System.Drawing.Point(623, 174);
            this.player2_nation.Name = "player2_nation";
            this.player2_nation.Size = new System.Drawing.Size(98, 23);
            this.player2_nation.TabIndex = 25;
            this.player2_nation.Text = "국가";
            this.player2_nation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2_name
            // 
            this.player2_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2_name.Location = new System.Drawing.Point(623, 148);
            this.player2_name.Name = "player2_name";
            this.player2_name.Size = new System.Drawing.Size(98, 23);
            this.player2_name.TabIndex = 24;
            this.player2_name.Text = "이름";
            this.player2_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "Score";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "초반승률";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1_loserate
            // 
            this.p1_loserate.BackColor = System.Drawing.Color.White;
            this.p1_loserate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1_loserate.Location = new System.Drawing.Point(443, 247);
            this.p1_loserate.Name = "p1_loserate";
            this.p1_loserate.Size = new System.Drawing.Size(100, 18);
            this.p1_loserate.TabIndex = 28;
            this.p1_loserate.Text = " ";
            // 
            // p1_winrate
            // 
            this.p1_winrate.BackColor = System.Drawing.Color.SeaShell;
            this.p1_winrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1_winrate.Location = new System.Drawing.Point(493, 247);
            this.p1_winrate.Name = "p1_winrate";
            this.p1_winrate.Size = new System.Drawing.Size(50, 18);
            this.p1_winrate.TabIndex = 29;
            this.p1_winrate.Text = " ";
            // 
            // p2_loserate
            // 
            this.p2_loserate.BackColor = System.Drawing.Color.White;
            this.p2_loserate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2_loserate.Location = new System.Drawing.Point(623, 247);
            this.p2_loserate.Name = "p2_loserate";
            this.p2_loserate.Size = new System.Drawing.Size(100, 18);
            this.p2_loserate.TabIndex = 31;
            this.p2_loserate.Text = " ";
            // 
            // p2_winrate
            // 
            this.p2_winrate.BackColor = System.Drawing.Color.LightCyan;
            this.p2_winrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2_winrate.Location = new System.Drawing.Point(623, 247);
            this.p2_winrate.Name = "p2_winrate";
            this.p2_winrate.Size = new System.Drawing.Size(50, 18);
            this.p2_winrate.TabIndex = 30;
            this.p2_winrate.Text = " ";
            // 
            // p1_winrate_text
            // 
            this.p1_winrate_text.Location = new System.Drawing.Point(472, 265);
            this.p1_winrate_text.Name = "p1_winrate_text";
            this.p1_winrate_text.Size = new System.Drawing.Size(43, 18);
            this.p1_winrate_text.TabIndex = 32;
            this.p1_winrate_text.Text = "50%";
            this.p1_winrate_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2_winrate_text
            // 
            this.p2_winrate_text.Location = new System.Drawing.Point(655, 265);
            this.p2_winrate_text.Name = "p2_winrate_text";
            this.p2_winrate_text.Size = new System.Drawing.Size(43, 18);
            this.p2_winrate_text.TabIndex = 33;
            this.p2_winrate_text.Text = "50%";
            this.p2_winrate_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1_score
            // 
            this.player1_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1_score.Location = new System.Drawing.Point(445, 217);
            this.player1_score.Name = "player1_score";
            this.player1_score.Size = new System.Drawing.Size(98, 23);
            this.player1_score.TabIndex = 34;
            this.player1_score.Text = "0";
            this.player1_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2_score
            // 
            this.player2_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2_score.ForeColor = System.Drawing.SystemColors.ControlText;
            this.player2_score.Location = new System.Drawing.Point(623, 217);
            this.player2_score.Name = "player2_score";
            this.player2_score.Size = new System.Drawing.Size(98, 23);
            this.player2_score.TabIndex = 35;
            this.player2_score.Text = "0";
            this.player2_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "99%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(570, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 37;
            this.label8.Text = "95%";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(570, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 12);
            this.label9.TabIndex = 38;
            this.label9.Text = "90%";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(570, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 12);
            this.label10.TabIndex = 39;
            this.label10.Text = "70%";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(557, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 40;
            this.label11.Text = "승부예측";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2_70
            // 
            this.p2_70.Location = new System.Drawing.Point(652, 377);
            this.p2_70.Name = "p2_70";
            this.p2_70.Size = new System.Drawing.Size(45, 12);
            this.p2_70.TabIndex = 87;
            this.p2_70.Text = "패 확실";
            this.p2_70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2_90
            // 
            this.p2_90.Location = new System.Drawing.Point(652, 353);
            this.p2_90.Name = "p2_90";
            this.p2_90.Size = new System.Drawing.Size(45, 12);
            this.p2_90.TabIndex = 86;
            this.p2_90.Text = "패 확실";
            this.p2_90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2_95
            // 
            this.p2_95.Location = new System.Drawing.Point(652, 329);
            this.p2_95.Name = "p2_95";
            this.p2_95.Size = new System.Drawing.Size(45, 12);
            this.p2_95.TabIndex = 85;
            this.p2_95.Text = "패 확실";
            this.p2_95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2_99
            // 
            this.p2_99.Location = new System.Drawing.Point(652, 305);
            this.p2_99.Name = "p2_99";
            this.p2_99.Size = new System.Drawing.Size(45, 12);
            this.p2_99.TabIndex = 84;
            this.p2_99.Text = "패 확실";
            this.p2_99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1_70
            // 
            this.p1_70.Location = new System.Drawing.Point(466, 377);
            this.p1_70.Name = "p1_70";
            this.p1_70.Size = new System.Drawing.Size(45, 12);
            this.p1_70.TabIndex = 83;
            this.p1_70.Text = "패 확실";
            this.p1_70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1_90
            // 
            this.p1_90.Location = new System.Drawing.Point(466, 353);
            this.p1_90.Name = "p1_90";
            this.p1_90.Size = new System.Drawing.Size(45, 12);
            this.p1_90.TabIndex = 82;
            this.p1_90.Text = "패 확실";
            this.p1_90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1_95
            // 
            this.p1_95.Location = new System.Drawing.Point(466, 329);
            this.p1_95.Name = "p1_95";
            this.p1_95.Size = new System.Drawing.Size(45, 12);
            this.p1_95.TabIndex = 81;
            this.p1_95.Text = "패 확실";
            this.p1_95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1_99
            // 
            this.p1_99.Location = new System.Drawing.Point(466, 305);
            this.p1_99.Name = "p1_99";
            this.p1_99.Size = new System.Drawing.Size(45, 12);
            this.p1_99.TabIndex = 80;
            this.p1_99.Text = "패 확실";
            this.p1_99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(599, 377);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 79;
            this.label16.Text = "-------";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(599, 353);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 78;
            this.label15.Text = "-------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(599, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 77;
            this.label14.Text = "-------";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(517, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 76;
            this.label13.Text = "-------";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(599, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 75;
            this.label12.Text = "-------";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(517, 353);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 74;
            this.label17.Text = "-------";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(517, 329);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 12);
            this.label18.TabIndex = 73;
            this.label18.Text = "-------";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(517, 305);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 12);
            this.label19.TabIndex = 72;
            this.label19.Text = "-------";
            // 
            // log
            // 
            this.log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.타구선수,
            this.기술,
            this.득점여부,
            this.득점선수,
            this.player1_col,
            this.vs,
            this.player2_col,
            this.시점,
            this.적용});
            this.log.HideSelection = false;
            this.log.Location = new System.Drawing.Point(10, 413);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(729, 152);
            this.log.TabIndex = 88;
            this.log.UseCompatibleStateImageBehavior = false;
            this.log.View = System.Windows.Forms.View.Details;
            // 
            // 타구선수
            // 
            this.타구선수.Text = "타구선수";
            this.타구선수.Width = 71;
            // 
            // 기술
            // 
            this.기술.Text = "기술";
            this.기술.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.기술.Width = 111;
            // 
            // 득점여부
            // 
            this.득점여부.Text = "득점여부";
            this.득점여부.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.득점여부.Width = 79;
            // 
            // 득점선수
            // 
            this.득점선수.Text = "득점선수";
            this.득점선수.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.득점선수.Width = 90;
            // 
            // player1_col
            // 
            this.player1_col.Text = "player1";
            this.player1_col.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player1_col.Width = 78;
            // 
            // vs
            // 
            this.vs.Text = "vs";
            this.vs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vs.Width = 25;
            // 
            // player2_col
            // 
            this.player2_col.Text = "player2";
            this.player2_col.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player2_col.Width = 74;
            // 
            // 시점
            // 
            this.시점.Text = "시점";
            this.시점.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.시점.Width = 63;
            // 
            // 적용
            // 
            this.적용.Text = "적용";
            this.적용.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.적용.Width = 127;
            // 
            // Solo_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 572);
            this.Controls.Add(this.log);
            this.Controls.Add(this.p2_70);
            this.Controls.Add(this.p2_90);
            this.Controls.Add(this.p2_95);
            this.Controls.Add(this.p2_99);
            this.Controls.Add(this.p1_70);
            this.Controls.Add(this.p1_90);
            this.Controls.Add(this.p1_95);
            this.Controls.Add(this.p1_99);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.player2_score);
            this.Controls.Add(this.player1_score);
            this.Controls.Add(this.p1_winrate);
            this.Controls.Add(this.p2_winrate_text);
            this.Controls.Add(this.p1_winrate_text);
            this.Controls.Add(this.p2_winrate);
            this.Controls.Add(this.p2_loserate);
            this.Controls.Add(this.p1_loserate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.player2_nation);
            this.Controls.Add(this.player2_name);
            this.Controls.Add(this.player1_nation);
            this.Controls.Add(this.player1_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lose);
            this.Controls.Add(this.get);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SERVICE);
            this.Controls.Add(this.U_CLEAR);
            this.Controls.Add(this.PUSH);
            this.Controls.Add(this.S_RECIEVE);
            this.Controls.Add(this.HAIRPIN);
            this.Controls.Add(this.S_CUT);
            this.Controls.Add(this.DRIVE);
            this.Controls.Add(this.SMASH);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.DROP);
            this.Controls.Add(this.p2_name);
            this.Controls.Add(this.p1_name);
            this.Controls.Add(this.SelectExel);
            this.Name = "Solo_Input";
            this.Text = "단식 입력";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Solo_Input_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SelectExel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton p1_name;
        private System.Windows.Forms.RadioButton p2_name;
        private System.Windows.Forms.Button DROP;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button SMASH;
        private System.Windows.Forms.Button DRIVE;
        private System.Windows.Forms.Button S_CUT;
        private System.Windows.Forms.Button HAIRPIN;
        private System.Windows.Forms.Button S_RECIEVE;
        private System.Windows.Forms.Button PUSH;
        private System.Windows.Forms.Button U_CLEAR;
        private System.Windows.Forms.Button SERVICE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.Button lose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button player1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button player2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label player1_name;
        private System.Windows.Forms.Label player1_nation;
        private System.Windows.Forms.Label player2_nation;
        private System.Windows.Forms.Label player2_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label p1_loserate;
        private System.Windows.Forms.Label p1_winrate;
        private System.Windows.Forms.Label p2_loserate;
        private System.Windows.Forms.Label p2_winrate;
        private System.Windows.Forms.Label p1_winrate_text;
        private System.Windows.Forms.Label p2_winrate_text;
        private System.Windows.Forms.Label player1_score;
        private System.Windows.Forms.Label player2_score;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label p2_70;
        private System.Windows.Forms.Label p2_90;
        private System.Windows.Forms.Label p2_95;
        private System.Windows.Forms.Label p2_99;
        private System.Windows.Forms.Label p1_70;
        private System.Windows.Forms.Label p1_90;
        private System.Windows.Forms.Label p1_95;
        private System.Windows.Forms.Label p1_99;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListView log;
        private System.Windows.Forms.ColumnHeader 타구선수;
        private System.Windows.Forms.ColumnHeader 기술;
        private System.Windows.Forms.ColumnHeader 득점여부;
        private System.Windows.Forms.ColumnHeader 득점선수;
        private System.Windows.Forms.ColumnHeader player1_col;
        private System.Windows.Forms.ColumnHeader vs;
        private System.Windows.Forms.ColumnHeader player2_col;
        private System.Windows.Forms.ColumnHeader 시점;
        private System.Windows.Forms.ColumnHeader 적용;
    }
}

