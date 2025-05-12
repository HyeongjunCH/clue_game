namespace Clue
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnTurnEnd = new System.Windows.Forms.Button();
            this.dice1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbRemain = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnSug = new System.Windows.Forms.Button();
            this.btnFinalSug = new System.Windows.Forms.Button();
            this.player3 = new System.Windows.Forms.PictureBox();
            this.player4 = new System.Windows.Forms.PictureBox();
            this.player5 = new System.Windows.Forms.PictureBox();
            this.player6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(948, 696);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(162, 73);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnTurnEnd
            // 
            this.btnTurnEnd.Location = new System.Drawing.Point(948, 789);
            this.btnTurnEnd.Name = "btnTurnEnd";
            this.btnTurnEnd.Size = new System.Drawing.Size(162, 73);
            this.btnTurnEnd.TabIndex = 1;
            this.btnTurnEnd.Text = "End Turn";
            this.btnTurnEnd.UseVisualStyleBackColor = true;
            this.btnTurnEnd.Click += new System.EventHandler(this.btnTurnEnd_Click);
            // 
            // dice1
            // 
            this.dice1.AutoSize = true;
            this.dice1.Location = new System.Drawing.Point(1023, 622);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(23, 24);
            this.dice1.TabIndex = 2;
            this.dice1.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(888, 800);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbRemain
            // 
            this.lbRemain.AutoSize = true;
            this.lbRemain.Location = new System.Drawing.Point(1052, 669);
            this.lbRemain.Name = "lbRemain";
            this.lbRemain.Size = new System.Drawing.Size(23, 24);
            this.lbRemain.TabIndex = 5;
            this.lbRemain.Text = "0";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(1281, 640);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(55, 76);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(1281, 802);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(55, 76);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1349, 733);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(80, 52);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(1185, 733);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(82, 52);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(954, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Remain:";
            // 
            // player1
            // 
            this.player1.Image = ((System.Drawing.Image)(resources.GetObject("player1.Image")));
            this.player1.Location = new System.Drawing.Point(978, 472);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(25, 25);
            this.player1.TabIndex = 11;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.Image = ((System.Drawing.Image)(resources.GetObject("player2.Image")));
            this.player2.Location = new System.Drawing.Point(1050, 472);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(25, 25);
            this.player2.TabIndex = 12;
            this.player2.TabStop = false;
            // 
            // btnNote
            // 
            this.btnNote.Location = new System.Drawing.Point(958, 61);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(175, 60);
            this.btnNote.TabIndex = 13;
            this.btnNote.Text = "Memo";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnSug
            // 
            this.btnSug.Location = new System.Drawing.Point(958, 175);
            this.btnSug.Name = "btnSug";
            this.btnSug.Size = new System.Drawing.Size(175, 60);
            this.btnSug.TabIndex = 14;
            this.btnSug.Text = "Suggest";
            this.btnSug.UseVisualStyleBackColor = true;
            this.btnSug.Click += new System.EventHandler(this.btnSug_Click);
            // 
            // btnFinalSug
            // 
            this.btnFinalSug.ForeColor = System.Drawing.Color.Red;
            this.btnFinalSug.Location = new System.Drawing.Point(958, 308);
            this.btnFinalSug.Name = "btnFinalSug";
            this.btnFinalSug.Size = new System.Drawing.Size(207, 83);
            this.btnFinalSug.TabIndex = 15;
            this.btnFinalSug.Text = "Final\r\nSuggest";
            this.btnFinalSug.UseVisualStyleBackColor = true;
            // 
            // player3
            // 
            this.player3.Image = ((System.Drawing.Image)(resources.GetObject("player3.Image")));
            this.player3.Location = new System.Drawing.Point(1118, 472);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(25, 25);
            this.player3.TabIndex = 16;
            this.player3.TabStop = false;
            // 
            // player4
            // 
            this.player4.Image = ((System.Drawing.Image)(resources.GetObject("player4.Image")));
            this.player4.Location = new System.Drawing.Point(1201, 472);
            this.player4.Name = "player4";
            this.player4.Size = new System.Drawing.Size(25, 25);
            this.player4.TabIndex = 17;
            this.player4.TabStop = false;
            // 
            // player5
            // 
            this.player5.Image = ((System.Drawing.Image)(resources.GetObject("player5.Image")));
            this.player5.Location = new System.Drawing.Point(1281, 472);
            this.player5.Name = "player5";
            this.player5.Size = new System.Drawing.Size(25, 25);
            this.player5.TabIndex = 18;
            this.player5.TabStop = false;
            // 
            // player6
            // 
            this.player6.Image = ((System.Drawing.Image)(resources.GetObject("player6.Image")));
            this.player6.Location = new System.Drawing.Point(1349, 472);
            this.player6.Name = "player6";
            this.player6.Size = new System.Drawing.Size(25, 25);
            this.player6.TabIndex = 19;
            this.player6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 1023);
            this.Controls.Add(this.player6);
            this.Controls.Add(this.player5);
            this.Controls.Add(this.player4);
            this.Controls.Add(this.player3);
            this.Controls.Add(this.btnFinalSug);
            this.Controls.Add(this.btnSug);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lbRemain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.btnTurnEnd);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnTurnEnd;
        private System.Windows.Forms.Label dice1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbRemain;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Button btnSug;
        private System.Windows.Forms.Button btnFinalSug;
        private System.Windows.Forms.PictureBox player3;
        private System.Windows.Forms.PictureBox player4;
        private System.Windows.Forms.PictureBox player5;
        private System.Windows.Forms.PictureBox player6;
    }
}

