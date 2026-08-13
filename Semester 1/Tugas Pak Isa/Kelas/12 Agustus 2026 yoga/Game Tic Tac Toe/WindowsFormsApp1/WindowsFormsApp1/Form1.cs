using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string currentPlayer = "X";
        private string[] board = new string[9];
        private bool gameOver = false;
        private Button[] gridButtons;

        public Form1()
        {
            InitializeComponent();
            InitializeGameLogic();
        }

        private void InitializeGameLogic()
        {
            // Menghubungkan 9 tombol dari Form Designer ke dalam Array
            // Pastikan name kontrol tombol 3x3 Anda adalah button1, button2, ..., button9
            gridButtons = new Button[] {
                button1, button2, button3,
                button4, button5, button6,
                button7, button8, button9
            };

            // Menambahkan event handler click secara otomatis ke 9 tombol
            for (int i = 0; i < gridButtons.Length; i++)
            {
                int index = i; // Menyiapkan indeks lokal
                gridButtons[i].Click += (sender, e) => GridButton_Click(index);
            }

            // Menghubungkan event handler untuk tombol Reset
            // Jika nama tombol reset Anda bukan 'btnReset', sesuaikan variabel di bawah
            if (button10 != null)
            {
                button10.Click += (sender, e) => ResetGame();
            }

            // Memulai game pertama kali
            ResetGame();
        }

        private void GridButton_Click(int index)
        {
            // Jalankan perintah hanya jika kotak masih kosong & game belum selesai
            if (board[index] == "" && !gameOver)
            {
                board[index] = currentPlayer;
                gridButtons[index].Text = currentPlayer;

                // Warna teks berbeda (X = Biru, O = Merah)
                gridButtons[index].ForeColor = (currentPlayer == "X")
                    ? Color.FromArgb(0, 85, 170)
                    : Color.FromArgb(204, 0, 0);

                if (CheckWinner())
                {
                    gameOver = true;
                    MessageBox.Show($"Pemain {currentPlayer} Menang!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (IsDraw())
                {
                    gameOver = true;
                    MessageBox.Show("Permainan Seri (Draw)!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Ganti giliran pemain
                    currentPlayer = (currentPlayer == "X") ? "O" : "X";
                }
            }
        }

        private bool CheckWinner()
        {
            int[,] winConditions = new int[,]
            {
                {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // Baris
                {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // Kolom
                {0, 4, 8}, {2, 4, 6}             // Diagonal
            };

            for (int i = 0; i < 8; i++)
            {
                int a = winConditions[i, 0];
                int b = winConditions[i, 1];
                int c = winConditions[i, 2];

                if (board[a] != "" && board[a] == board[b] && board[b] == board[c])
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsDraw()
        {
            foreach (string cell in board)
            {
                if (cell == "") return false;
            }
            return true;
        }

        private void ResetGame()
        {
            currentPlayer = "X";
            gameOver = false;

            for (int i = 0; i < 9; i++)
            {
                board[i] = "";
                if (gridButtons[i] != null)
                {
                    gridButtons[i].Text = "";
                }
            }
        }
    }
}