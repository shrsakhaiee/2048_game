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

        public Form1()
        {
            InitializeComponent();
            game_board = new Label[4, 4];
            for(int i=0;i<4;i++)
            {
                for(int j=0;j<4;j++)
                {
                    game_board[i, j] = new Label();
                    game_board[i, j].Text = "2";
                    game_board[i, j].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;
                    game_board[i, j].Font = new Font("Tahoma",35);
                    game_board[i, j].BackColor = Color.BurlyWood;
                    game_board[i, j].BorderStyle = new BorderStyle();
                    var margin = game_board[i, j].Margin;
                    margin.All = 4;
                    game_board[i, j].Margin = margin;
                    game_board[i, j].TextAlign = ContentAlignment.MiddleCenter;

                    tableLayoutPanel1.Controls.Add(game_board[i, j], i, j);

                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {

                MessageBox.Show("چپ");
            }
            else if(e.KeyData==Keys.Right)
            {
                MessageBox.Show("راست");
            }
            else if(e.KeyData==Keys.Down)
            {
                MessageBox.Show("پایین");
            }
            else if(e.KeyData == Keys.Up)
            {
                MessageBox.Show("بالا");
            }
        }
            
    }
}
