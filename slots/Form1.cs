using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slots
{
    public partial class Slots : Form
    {
        public int Wins { get; set; }
        public int amount { get; set; }
        public Random random { get; set; }
        public Slots()
        {
            InitializeComponent();
            random = new Random();
            amount = 0;
            Wins = 0;
            tbAvailableAmount.Text = amount.ToString();
            cbCost.Items.Add(5);
            cbCost.Items.Add(10);
            cbCost.Items.Add(20);
            cbCost.Items.Add(50);
            cbCost.Items.Add(100);
            cbCost.Items.Add(500);
            cbCost.Items.Add(1000);
            cbCost.Text = cbCost.Items[1].ToString();
            row1col1.Image = new Bitmap(@"..\..\img\slots.jpg");
            row1col2.Image = new Bitmap(@"..\..\img\slots.jpg");
            row1col3.Image = new Bitmap(@"..\..\img\slots.jpg");
            row2col1.Image = new Bitmap(@"..\..\img\slots.jpg");
            row2col2.Image = new Bitmap(@"..\..\img\slots.jpg");
            row2col3.Image = new Bitmap(@"..\..\img\slots.jpg");
            row3col1.Image = new Bitmap(@"..\..\img\slots.jpg");
            row3col2.Image = new Bitmap(@"..\..\img\slots.jpg");
            row3col3.Image = new Bitmap(@"..\..\img\slots.jpg");
            row1col1.SizeMode = PictureBoxSizeMode.StretchImage;
            row1col1.ClientSize = new Size(200, 200);
            row1col2.SizeMode = PictureBoxSizeMode.StretchImage;
            row1col2.ClientSize = new Size(200, 200);
            row1col3.SizeMode = PictureBoxSizeMode.StretchImage;
            row1col3.ClientSize = new Size(200, 200);
            row2col1.SizeMode = PictureBoxSizeMode.StretchImage;
            row2col1.ClientSize = new Size(200, 200);
            row2col2.SizeMode = PictureBoxSizeMode.StretchImage;
            row2col2.ClientSize = new Size(200, 200);
            row2col3.SizeMode = PictureBoxSizeMode.StretchImage;
            row2col3.ClientSize = new Size(200, 200);
            row3col1.SizeMode = PictureBoxSizeMode.StretchImage;
            row3col1.ClientSize = new Size(200, 200);
            row3col2.SizeMode = PictureBoxSizeMode.StretchImage;
            row3col2.ClientSize = new Size(200, 200);
            row3col3.SizeMode = PictureBoxSizeMode.StretchImage;
            row3col3.ClientSize = new Size(200, 200);
            tbTotal.Text = Wins.ToString();
        }

        private void newSpin(int n, PictureBox pb)
        {
            if (n < 100)
            {
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ClientSize = new Size(200, 200);
                pb.Image = new Bitmap(@"..\..\img\apple.png");
            }
            else if(n >= 100 && n < 200)
            {
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ClientSize = new Size(200, 200);
                pb.Image = new Bitmap(@"..\..\img\cherry.png");
            }
            else if (n >= 200 && n < 300)
            {
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ClientSize = new Size(200, 200);
                pb.Image = new Bitmap(@"..\..\img\pineapple.jpg");
            }
            else if (n >= 300 && n < 400)
            {
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ClientSize = new Size(200, 200);
                pb.Image = new Bitmap(@"..\..\img\grapes.jpg");
            }
            else if (n >= 400 && n < 600)
            {
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ClientSize = new Size(200, 200);
                pb.Image = new Bitmap(@"..\..\img\melon.jpg");
            }
            else if (n >= 600 && n < 700)
            {
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ClientSize = new Size(200, 200);
                pb.Image = new Bitmap(@"..\..\img\orange.jpg");
            }
            else if (n >= 700 && n < 750)
            {
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ClientSize = new Size(200, 200);
                pb.Image = new Bitmap(@"..\..\img\jackpot.jpg");
            }
            else if(n >= 750 && n < 850)
            {
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ClientSize = new Size(200, 200);
                pb.Image = new Bitmap(@"..\..\img\banana.png");
            }
            else
            {
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ClientSize = new Size(200, 200);
                pb.Image = new Bitmap(@"..\..\img\strawberry.png");
            }
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if(this.amount < Int32.Parse(cbCost.SelectedItem.ToString()))
            {
                MessageBox.Show("Not enough funds! Add funds or change spin cost!", "Attention", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
                return;
            }
            int num1 = random.Next(1000); int num2 = random.Next(1000); int num3 = random.Next(1000);
            int num4 = random.Next(1000); int num5 = random.Next(1000); int num6 = random.Next(1000);
            int num7 = random.Next(1000); int num8 = random.Next(1000); int num9 = random.Next(1000);
            List<int> Column1 = new List<int>();
            List<int> Column2 = new List<int>();
            List<int> Column3 = new List<int>();
            Column1.Add(num1); Column1.Add(num4); Column1.Add(num7);
            Column2.Add(num2); Column2.Add(num5); Column2.Add(num8);
            Column3.Add(num3); Column3.Add(num6); Column3.Add(num9);
            newSpin(num1, row1col1); newSpin(num2, row1col2); newSpin(num3, row1col3);
            newSpin(num4, row2col1); newSpin(num5, row2col2); newSpin(num6, row2col3);
            newSpin(num7, row3col1); newSpin(num8, row3col2); newSpin(num9, row3col3);
            checkCurrent(Column1, Column2, Column3);
            this.amount -= Int32.Parse(cbCost.SelectedItem.ToString());
            tbAvailableAmount.Text = this.amount.ToString();
            DialogResult = DialogResult.OK;
        }

        private void checkCurrent(List<int> c1, List<int> c2, List<int> c3)
        {
            int totalWin = 0;
            // Check Apples
            if ((InRange(0, 99, c1[0]) || InRange(0, 99, c1[1]) || InRange(0, 99, c1[2]))
                && (InRange(0, 99, c2[0]) || InRange(0, 99, c2[1]) || InRange(0, 99, c2[2]))
                && (InRange(0, 99, c3[0]) || InRange(0, 99, c3[1]) || InRange(0, 99, c3[2])))
            {
                int bonus = 3;
                int col1 = 0, col2 = 0, col3 = 0;
                int spinCost = Int32.Parse(cbCost.Text.ToString());
                foreach (int i in c1)
                {
                    if (i >= 0 && i <= 99) col1++;
                }
                foreach (int i in c2)
                {
                    if (i >= 0 && i <= 99) col2++;
                }
                foreach (int i in c3)
                {
                    if (i >= 0 && i <= 99) col3++;
                }
                totalWin += (col1 + col2 + col3) * spinCost * bonus;
                this.amount += totalWin;
            }
            // Check Cherries
            if ((InRange(100, 199, c1[0]) || InRange(100, 199, c1[1]) || InRange(100, 199, c1[2]))
                && (InRange(100, 199, c2[0]) || InRange(100, 199, c2[1]) || InRange(100, 199, c2[2]))
                && (InRange(100, 199, c3[0]) || InRange(100, 199, c3[1]) || InRange(100, 199, c3[2])))
            {
                int bonus = 3;
                int col1 = 0, col2 = 0, col3 = 0;
                int spinCost = Int32.Parse(cbCost.Text.ToString());
                foreach (int i in c1)
                {
                    if (i >= 100 && i <= 199) col1++;
                }
                foreach (int i in c2)
                {
                    if (i >= 100 && i <= 199) col2++;
                }
                foreach (int i in c3)
                {
                    if (i >= 100 && i <= 199) col3++;
                }
                totalWin += (col1 + col2 + col3) * spinCost * bonus;

                this.amount += totalWin;
            }
            // Check Pineapples
            if ((InRange(200, 299, c1[0]) || InRange(200, 299, c1[1]) || InRange(200, 299, c1[2]))
                && (InRange(200, 299, c2[0]) || InRange(200, 299, c2[1]) || InRange(200, 299, c2[2]))
                && (InRange(200, 299, c3[0]) || InRange(200, 299, c3[1]) || InRange(200, 299, c3[2])))
            {
                int bonus = 2;
                int col1 = 0, col2 = 0, col3 = 0;
                int spinCost = Int32.Parse(cbCost.Text.ToString());
                foreach (int i in c1)
                {
                    if (i >= 200 && i <= 299) col1++;
                }
                foreach (int i in c2)
                {
                    if (i >= 200 && i <= 299) col2++;
                }
                foreach (int i in c3)
                {
                    if (i >= 200 && i <= 299) col3++;
                }
                totalWin += (col1 + col2 + col3) * spinCost * bonus;

                this.amount += totalWin;
            }
            // Check Grapes
            if ((InRange(300, 399, c1[0]) || InRange(300, 399, c1[1]) || InRange(300, 399, c1[2]))
                && (InRange(300, 399, c2[0]) || InRange(300, 399, c2[1]) || InRange(300, 399, c2[2]))
                && (InRange(300, 399, c3[0]) || InRange(300, 399, c3[1]) || InRange(300, 399, c3[2])))
            {
                int bonus = 2;
                int col1 = 0, col2 = 0, col3 = 0;
                int spinCost = Int32.Parse(cbCost.Text.ToString());
                foreach (int i in c1)
                {
                    if (i >= 300 && i <= 399) col1++;
                }
                foreach (int i in c2)
                {
                    if (i >= 300 && i <= 399) col2++;
                }
                foreach (int i in c3)
                {
                    if (i >= 300 && i <= 399) col3++;
                }
                totalWin += (col1 + col2 + col3) * spinCost * bonus;

                this.amount += totalWin;
            }
            // Check Melons
            if ((InRange(400, 599, c1[0]) || InRange(400, 599, c1[1]) || InRange(400, 599, c1[2]))
                && (InRange(400, 599, c2[0]) || InRange(400, 599, c2[1]) || InRange(400, 599, c2[2]))
                && (InRange(400, 599, c3[0]) || InRange(400, 599, c3[1]) || InRange(400, 599, c3[2])))
            {
                int bonus = 1;
                int col1 = 0, col2 = 0, col3 = 0;
                int spinCost = Int32.Parse(cbCost.Text.ToString());
                foreach (int i in c1)
                {
                    if (i >= 400 && i <= 599) col1++;
                }
                foreach (int i in c2)
                {
                    if (i >= 400 && i <= 599) col2++;
                }
                foreach (int i in c3)
                {
                    if (i >= 400 && i <= 599) col3++;
                }
                totalWin += (col1 + col2 + col3) * spinCost * bonus;

                this.amount += totalWin;
            }
            // Check Oranges
            if ((InRange(600, 699, c1[0]) || InRange(600, 699, c1[1]) || InRange(600, 699, c1[2]))
                && (InRange(600, 699, c2[0]) || InRange(600, 699, c2[1]) || InRange(600, 699, c2[2]))
                && (InRange(600, 699, c3[0]) || InRange(600, 699, c3[1]) || InRange(600, 699, c3[2])))
            {
                int bonus = 2;
                int col1 = 0, col2 = 0, col3 = 0;
                int spinCost = Int32.Parse(cbCost.Text.ToString());
                foreach (int i in c1)
                {
                    if (i >= 600 && i <= 699) col1++;
                }
                foreach (int i in c2)
                {
                    if (i >= 600 && i <= 699) col2++;
                }
                foreach (int i in c3)
                {
                    if (i >= 600 && i <= 699) col3++;
                }
                totalWin += (col1 + col2 + col3) * spinCost * bonus;

                this.amount += totalWin;
            }
            // Check Jackpots
            if ((InRange(700, 749, c1[0]) || InRange(700, 749, c1[1]) || InRange(700, 749, c1[2]))
                && (InRange(700, 749, c2[0]) || InRange(700, 749, c2[1]) || InRange(700, 749, c2[2]))
                && (InRange(700, 749, c3[0]) || InRange(700, 749, c3[1]) || InRange(700, 749, c3[2])))
            {
                int bonus = 50;
                int col1 = 0, col2 = 0, col3 = 0;
                int spinCost = Int32.Parse(cbCost.Text.ToString());
                foreach (int i in c1)
                {
                    if (i >= 700 && i <= 749) col1++;
                }
                foreach (int i in c2)
                {
                    if (i >= 700 && i <= 749) col2++;
                }
                foreach (int i in c3)
                {
                    if (i >= 700 && i <= 749) col3++;
                }
                totalWin += (col1 + col2 + col3) * spinCost * bonus;

                this.amount += totalWin;
            }
            // Check Bananas
            if ((InRange(750, 849, c1[0]) || InRange(750, 849, c1[1]) || InRange(750, 849, c1[2]))
                && (InRange(750, 849, c2[0]) || InRange(750, 849, c2[1]) || InRange(750, 849, c2[2]))
                && (InRange(750, 849, c3[0]) || InRange(750, 849, c3[1]) || InRange(750, 849, c3[2])))
            {
                int bonus = 1;
                int col1 = 0, col2 = 0, col3 = 0;
                int spinCost = Int32.Parse(cbCost.Text.ToString());
                foreach (int i in c1)
                {
                    if (i >= 750 && i <= 849) col1++;
                }
                foreach (int i in c2)
                {
                    if (i >= 750 && i <= 849) col2++;
                }
                foreach (int i in c3)
                {
                    if (i >= 750 && i <= 849) col3++;
                }
                totalWin += (col1 + col2 + col3) * spinCost * bonus;

                this.amount += totalWin;
            }
            // Check Strawberries
            if ((InRange(850, 999, c1[0]) || InRange(850, 999, c1[1]) || InRange(850, 999, c1[2]))
                && (InRange(850, 999, c2[0]) || InRange(850, 999, c2[1]) || InRange(850, 999, c2[2]))
                && (InRange(850, 999, c3[0]) || InRange(850, 999, c3[1]) || InRange(850, 999, c3[2])))
            {
                int bonus = 1;
                int col1 = 0, col2 = 0, col3 = 0;
                int spinCost = Int32.Parse(cbCost.Text.ToString());
                foreach (int i in c1)
                {
                    if (i >= 850 && i <= 999) col1++;
                }
                foreach (int i in c2)
                {
                    if (i >= 850 && i <= 999) col2++;
                }
                foreach (int i in c3)
                {
                    if (i >= 850 && i <= 999) col3++;
                }
                totalWin += (col1 + col2 + col3) * spinCost * bonus;

                this.amount += totalWin;
            }
            if (totalWin != 0)
            {
                lblResult.Text = $"You won {totalWin}!!!";
                lblResult.ForeColor = Color.Green;
                Wins += totalWin;
                tbTotal.Text = Wins.ToString();
            }
            else
            {
                lblResult.Text = $"Better luck next time!!!";
                lblResult.ForeColor = Color.Red;
            }
            tbAvailableAmount.Text = this.amount.ToString();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddFounds_Click(object sender, EventArgs e)
        {
            AddFunds addFunds = new AddFunds();
            if(addFunds.ShowDialog(this) == DialogResult.OK)
            {
                this.amount += addFunds.Amount;
                tbAvailableAmount.Text = this.amount.ToString();
                btnSpin.Focus();
            }
        }

        private bool InRange(int lower_limit, int upper_limit, int value)
        {
            return (value > lower_limit && value <= upper_limit);
        }

        private void Slots_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.Space)
            {
                btnSpin.PerformClick();
            }
        }

        private void btnSpin_MouseLeave(object sender, EventArgs e)
        {
            btnSpin.BackColor = Button.DefaultBackColor;
            btnSpin.ForeColor = Button.DefaultForeColor;
        }

        private void btnSpin_MouseEnter(object sender, EventArgs e)
        {
            btnSpin.BackColor = Color.Black;
            btnSpin.ForeColor = Color.White;
        }

        private void cbCost_SelectedValueChanged(object sender, EventArgs e)
        {
            btnSpin.Focus();
        }
    }
}
