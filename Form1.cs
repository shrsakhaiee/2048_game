using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        Label[,] game_board;
        int n = 4;
        int r_x, r_y;
        string r;

        public Form1()
        {
            InitializeComponent();
            game_board = new Label[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    game_board[i, j] = new Label();
                    //game_board[i, j].Text = "2";
                    game_board[i, j].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;
                    game_board[i, j].Font = new Font("Tahoma", 35);
                    game_board[i, j].BackColor = Color.BurlyWood;
                    game_board[i, j].BorderStyle = new BorderStyle();
                    var margin = game_board[i, j].Margin;
                    margin.All = 4;
                    game_board[i, j].Margin = margin;
                    game_board[i, j].TextAlign = ContentAlignment.MiddleCenter;

                    tableLayoutPanel1.Controls.Add(game_board[i, j], i, j);

                }
            }
            make_Rn();
            make_Rn();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool move = false;
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (game_board[i, j].Text != "")
                            if (e.KeyData == Keys.Left)
                            {

                                if (i > 0 && game_board[i - 1, j].Text == "")
                                {
                                    move = true;
                                    game_board[i - 1, j].Text = game_board[i, j].Text;
                                    game_board[i, j].Text = "";

                                }
                                else if (j > 0 && game_board[i - 1, j].Text == game_board[i, j].Text)
                                {
                                    game_board[i - 1, j].Text = Convert.ToString(Convert.ToInt32(game_board[i, j].Text) * 2);
                                    game_board[i, j].Text = "";
                                }
                                else if (e.KeyData == Keys.Right)
                                {
                                    if (i < n - 1 && game_board[i + 1, j].Text == "")
                                    {
                                        move = true;
                                        game_board[i + 1, j].Text = game_board[i, j].Text;
                                        game_board[i, j].Text = "";

                                    }
                                    else if (j > n - 1 && game_board[i + 1, j].Text == game_board[i, j].Text)
                                    {
                                        game_board[i + 1, j].Text = Convert.ToString(Convert.ToInt32(game_board[i, j].Text) * 2);
                                        game_board[i, j].Text = "";
                                    }
                                    else if (e.KeyData == Keys.Down)
                                    {
                                        if (j < n - 1 && game_board[i, j + 1].Text == "")
                                        {
                                            move = true;
                                            game_board[i, j + 1].Text = game_board[i, j].Text;
                                            game_board[i, j].Text = "";

                                        }
                                        else if (j < n - 1 && game_board[i, j + 1].Text == game_board[i, j].Text)
                                        {
                                            game_board[i, j + 1].Text = Convert.ToString(Convert.ToInt32(game_board[i, j].Text) * 2);
                                            game_board[i, j].Text = "";
                                        }
                                        else if (e.KeyData == Keys.Up)
                                        {
                                            if (j > 0 && game_board[i, j - 1].Text == "")
                                            {
                                                move = true;
                                                game_board[i, j - 1].Text = game_board[i, j].Text;
                                                game_board[i, j].Text = "";

                                            }
                                            else if (j > 0 && game_board[i, j - 1].Text == game_board[i, j].Text)
                                            {
                                                game_board[i, j - 1].Text = Convert.ToString(Convert.ToInt32(game_board[i, j].Text) * 2);
                                                game_board[i, j].Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                    }
                    if (move == true)
                    {

                        make_Rn();
                    }
                }
            }
        }
                    private void make_Rn()
                    {
                        var Rand = new Random();
                        int[] num = { 2, 2, 2, 4 };
                        bool empty;

                        do
                        {
                            empty = true;
                            r_x = Rand.Next(0, n - 1);
                            r_y = Rand.Next(0, n - 1);

                            if (game_board[r_x, r_y].Text != "")
                                empty = false;
                        } while (empty == false);

                        r = (num[Rand.Next(0, num.Length)]).ToString();
                        game_board[r_x, r_y].Text = r;
                    }
                }
            }

