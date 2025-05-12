using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//https://github.com/ckdghks5179/clue_game
//https://github.com/ckdghks5179/clue_game.git

//https://github.com/HyeongjunCH/clue_game.git
//내꺼

namespace Clue
{
    public partial class Form1 : Form
    {
        Form2 notePad;
        Suggest suggest;

        int[,] clue_map;
        Point[,] clue_map_point;

        Player[] playerList = new Player[6];
        List<Card> cardList = new List<Card>();

        int currentTurnPlayer = 0;

        List<string> mans = new List<string>();
        List<string> weapons = new List<string>();
        List<string> rooms = new List<string>();

        string[] man = { "Green", "Mustard", "Peacock", "Plum", "Scarlett", "White" };
        string[] weapon = { "촛대", "파이프", "리볼버", "밧줄", "렌치", "단검" };
        string[] room = { "주방", "공부방", "무도회장", "온실", "식당", "당구장", "서재", "라운지", "홀" };

        PictureBox[] playerPics = new PictureBox[6];
        


        class Player
        {
            public string playerName;

            public string name;
            public int id;
            public PictureBox playerPic;

            public List<Card> cards;

            public int x; //열
            public int y; //행

            public bool isAlive = true;
            public bool isTurn = false;
            public bool isInRoom = false;
        }

        public void AddPlayer(int id, string playerName)
        {
            Player player = new Player();
            player.id = id;
            player.playerName = playerName;
            player.cards = new List<Card>();
            playerList[id] = player;

            string[] names = { "Green", "Mustard", "Peacock", "Plum", "Scarlett", "White" };

            //player(7,0) (17,0) (24,7) (0,14) (6,23) (19,23)
            int[] initialX = { 7, 17, 24, 0, 6, 19 };
            int[] initialY = { 0, 0, 7, 14, 23, 23 };

            player.name = names[id];
            player.playerPic = playerPics[id];
            player.x = initialX[id];
            player.y = initialY[id];

            player.playerPic.Location = clue_map_point[player.x, player.y];
            clue_map[initialX[id], initialY[id]] = 3;

            player.isTurn = false;
            player.isInRoom = false;
            player.isAlive = true;
        }

        class Card
        {
            string type; //player, weapon, room
            string name;

            public Card(string type, string name)
            {
                this.type = type;
                this.name = name;
            }

            public string Type
            {
                get { return type; }
                set { type = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

        }

        private void InitializeClueMap()
        {
            //empty = 0, wall = 1, door = 2, player = 3, room = 4
            clue_map = new int[,]
            {
                { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1}, 
                { 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 4, 1, 1, 0, 0, 1, 1, 1, 4, 1, 1, 1, 1, 0, 0, 1, 1, 1, 4, 1, 1},
                { 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 0, 0, 2, 1, 1, 1, 1, 1, 1, 2, 0, 0, 0, 2, 1, 1, 1, 1},
                { 1, 1, 1, 1, 2, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 1, 1, 1, 1, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 2, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 4, 1, 1, 1, 2, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 2, 1},
                { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 2, 1, 4, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 2, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 2, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 2, 1, 1, 0, 0, 2, 1, 1, 1, 1, 1, 1},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 2, 2, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 2, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 1, 1, 4, 1, 1, 1, 0, 0, 1, 1, 1, 4, 1, 1, 0, 0, 1, 2, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 4, 1, 1},
                { 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1}
            };
            //player(7,0) (17,0) (24,7) (0,14) (6,23) (19,23)
            //주방(6,4), 공부방 비밀통로
            //무도회장(5,8) (5,15) (7,9) (7,14)
            //온실(5,19), 라운지 비밀통로
            //식당(12,7) (15,6)
            //최종추리방(10,12) (13,10) (13, 14) (16,12)
            //당구장 (9,18) (12,22)
            //서재 (14,20) (16,17)
            //라운지 (19,5), 온실 비밀통로
            //홀(18,11) (18,12) (20,14)
            //공부방(21,18), 주방 비밀통로

           /* player1.Location = clue_map_point[7, 0];
            clue_map[7, 0] = 3;
            Player firstPlayer = new Player();
            firstPlayer.x = 7;
            firstPlayer.y = 0;
            playerList[0] = firstPlayer;

            player2.Location = clue_map_point[6, 23];
            clue_map[6, 23] = 3;
            Player secondPlayer = new Player();
            secondPlayer.x = 23;
            secondPlayer.y = 6;
            playerList[1] = secondPlayer;
           */
            AddPlayer(0, "Green");
            AddPlayer(1, "Mustard");
            AddPlayer(2, "Peacock");
            AddPlayer(3, "Plum");
            AddPlayer(4, "Scarlett");
            AddPlayer(5, "White");
        }

        private void InitializeClueMap_Point()
        {
            //Point(x = 열, y = 행)
            clue_map_point = new Point[25, 24];
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    clue_map_point[i, j] = new Point(8 + j * 20, 8 + i * 16);
                }
            }
        }

        private void OpenPlayerChooseForm()
        {
            PlayerChoose ChooseForm = new PlayerChoose();
            ChooseForm.ShowDialog();  
        }

        private int RollDice()
        {
            Random random = new Random();
            return random.Next(2, 13);
        }

        private bool isDoor(int x, int y)
        {
            if (clue_map[x, y] == 2)
            {
                return true;
            }
            return false;
        }

        public Form1()
        {
            InitializeComponent();

            playerPics[0] = player1;
            playerPics[1] = player2;
            playerPics[2] = player3;
            playerPics[3] = player4;
            playerPics[4] = player5;
            playerPics[5] = player6;

            InitializeClueMap_Point();
            InitializeClueMap();
            OpenPlayerChooseForm();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            player1.SizeMode = PictureBoxSizeMode.StretchImage;
            player2.SizeMode = PictureBoxSizeMode.StretchImage;
            player3.SizeMode = PictureBoxSizeMode.StretchImage;
            player4.SizeMode = PictureBoxSizeMode.StretchImage;
            player5.SizeMode = PictureBoxSizeMode.StretchImage;
            player6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int diceValue = RollDice();
            dice1.Text = diceValue.ToString();
            lbRemain.Text = diceValue.ToString();
            btnRoll.Enabled = false;
            btnTurnEnd.Enabled = true;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lbRemain.Text != "0")
            {
                if (playerList[currentTurnPlayer].x - 1 < 0)
                {
                    MessageBox.Show("이동할 수 없습니다.");
                    return;
                }

                if (clue_map[playerList[currentTurnPlayer].x - 1, playerList[currentTurnPlayer].y] == 1)
                {
                    MessageBox.Show("이동할 수 없습니다.");
                    return;
                }
                else if (clue_map[playerList[currentTurnPlayer].x - 1, playerList[currentTurnPlayer].y] == 3)
                {
                    MessageBox.Show("이동할 수 없습니다.");
                    return;
                }

                playerPics[currentTurnPlayer].Location = clue_map_point[playerList[currentTurnPlayer].x - 1, playerList[currentTurnPlayer].y];
                clue_map[playerList[currentTurnPlayer].x, playerList[currentTurnPlayer].y] = 0;
                clue_map[playerList[currentTurnPlayer].x - 1, playerList[currentTurnPlayer].y] = 3;
                playerList[currentTurnPlayer].x -= 1;

                lbRemain.Text = (int.Parse(lbRemain.Text) - 1).ToString();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lbRemain.Text != "0")
            {
                if(playerList[currentTurnPlayer].x + 1 > 24)
                {
                    MessageBox.Show("이동할 수 없습니다.");
                    return;
                }

                if (clue_map[playerList[currentTurnPlayer].x + 1, playerList[currentTurnPlayer].y] == 1)
                {
                    MessageBox.Show("이동할 수 없습니다.");
                    return;
                }
                else if (clue_map[playerList[currentTurnPlayer].x + 1, playerList[currentTurnPlayer].y] == 3)
                {
                    MessageBox.Show("이동할 수 없습니다.");
                    return;
                }

                playerPics[currentTurnPlayer].Location = clue_map_point[playerList[currentTurnPlayer].x + 1, playerList[currentTurnPlayer].y];
                clue_map[playerList[currentTurnPlayer].x, playerList[currentTurnPlayer].y] = 0;
                clue_map[playerList[currentTurnPlayer].x + 1, playerList[currentTurnPlayer].y] = 3;
                playerList[currentTurnPlayer].x += 1;

                lbRemain.Text = (int.Parse(lbRemain.Text) - 1).ToString();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lbRemain.Text != "0")
            {
                if (playerList[currentTurnPlayer].y + 1 > 23)
                {
                    MessageBox.Show("이동할 수 없습니다.");
                    return;
                }

                if (clue_map[playerList[currentTurnPlayer].x, playerList[currentTurnPlayer].y + 1] == 1)
                {
                    MessageBox.Show("이동할 수 없습니다.");
                    return;
                }
                else if (clue_map[playerList[currentTurnPlayer].x, playerList[currentTurnPlayer].y + 1] == 3)
                {
                    MessageBox.Show("이동할 수 없습니다.");
                    return;
                }

                playerPics[currentTurnPlayer].Location = clue_map_point[playerList[currentTurnPlayer].x, playerList[currentTurnPlayer].y + 1];
                clue_map[playerList[currentTurnPlayer].x, playerList[currentTurnPlayer].y] = 0;
                clue_map[playerList[currentTurnPlayer].x, playerList[currentTurnPlayer].y + 1] = 3;
                playerList[currentTurnPlayer].y += 1;

                lbRemain.Text = (int.Parse(lbRemain.Text) - 1).ToString();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lbRemain.Text != "0")
            {
                if (playerList[currentTurnPlayer].y - 1 < 0)
                {
                    MessageBox.Show("이동할 수 없습니다.");
                    return;
                }

                if (clue_map[playerList[currentTurnPlayer].x, playerList[currentTurnPlayer].y - 1] == 1)
                {
                    MessageBox.Show("이동할 수 없습니다.");
                    return;
                }
                else if (clue_map[playerList[currentTurnPlayer].x, playerList[currentTurnPlayer].y - 1] == 3)
                {
                    MessageBox.Show("이동할 수 없습니다.");
                    return;
                }

                playerPics[currentTurnPlayer].Location = clue_map_point[playerList[currentTurnPlayer].x, playerList[currentTurnPlayer].y - 1];
                clue_map[playerList[currentTurnPlayer].x, playerList[currentTurnPlayer].y] = 0;
                clue_map[playerList[currentTurnPlayer].x, playerList[currentTurnPlayer].y - 1] = 3;
                playerList[currentTurnPlayer].y -= 1;

                lbRemain.Text = (int.Parse(lbRemain.Text) - 1).ToString();
            }
        }

        private void btnTurnEnd_Click(object sender, EventArgs e)
        {
            lbRemain.Text = "0";
            btnRoll.Enabled = true;
            btnTurnEnd.Enabled = false;

            currentTurnPlayer = (currentTurnPlayer + 1) % playerList.Length;

            //다음 플레이어에게 턴 넘기기
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            notePad = new Form2();
            notePad.Show();
        }

        private void btnSug_Click(object sender, EventArgs e)
        {
            suggest = new Suggest();
            suggest.Show();
        }
    }
}
