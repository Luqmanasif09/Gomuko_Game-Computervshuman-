using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class GForm : Form
    {
        int dim;
        Cell[,] Cell_Array;
        int W_C = 5;
        Cell C;
        COLOR Turn=COLOR.RED;
        public GForm()
        {
            InitializeComponent();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (HumanvsComputer.Checked == true)
            {
                if (Fivex5.Checked == true)
                {
                    dim = 5;
                }
                else if (Tenx10.Checked == true)
                {
                    dim = 10;
                }
                else if (Fifteenx15.Checked == true)
                {
                    dim = 15;
                }
                else
                {
                    MessageBox.Show("Select Dimension please...!!!");
                    return;
                }
                Init1();
            }
            else if (HumanvsHuman.Checked == true)
            {
                if (Fivex5.Checked == true)
                {
                    dim = 5;
                }
                else if (Tenx10.Checked == true)
                {
                    dim = 10;
                }
                else if (Fifteenx15.Checked == true)
                {
                    dim = 15;
                }
                else
                {
                    MessageBox.Show("Select Dimension please...!!!");
                    return;
                }
                Init();
            }
            else
            {
                MessageBox.Show("Select please Version of game !!......");
                return;
            }
        }
        private void Init1()
        {
            Grid.Controls.Clear();
            Cell_Array = new Cell[dim, dim];

            for (int ri = 0; ri < dim; ri++)
            {
                for (int ci = 0; ci < dim; ci++)
                {
                    int H = Grid.Height / dim - 8;
                    int W = Grid.Width / dim - 8;

                    Cell c = new Cell(H, W);
                    Grid.Controls.Add(c);
                    c.Click += new System.EventHandler(Cell_Selected_HvsC);
                    Cell_Array[ri, ci] = c;
                }
            }
        }
        private void Init()
        {
            Grid.Controls.Clear();
            Cell_Array = new Cell[dim, dim];

            for(int ri=0; ri<dim; ri++)
            {
                for(int ci=0; ci<dim; ci++)
                {
                    int H = Grid.Height/dim-8;
                    int W = Grid.Width/dim -8;

                    Cell c = new Cell(H, W);
                    Grid.Controls.Add(c);
                    c.Click += new System.EventHandler(Cell_Selected_HvsH);
                    Cell_Array[ri, ci] = c;
                }
            }
        }
        void Cell_Selected_HvsH(object sender, EventArgs e)
        {
            C = (Cell)sender;
            if(C.Occupy!=COLOR.WHITE)
            {
                MessageBox.Show("Wrong Move...");
                return;
            }
            UpdateBoard();

            if (!Draw())
            {
                if (Is_Win(Turn))
                {
                    MessageBox.Show(Turn.ToString() + "Wins ...!!!");
                    Grid.Controls.Clear();
                }
            }
            else
            {
                MessageBox.Show("Game is Draw ...!!!");
                Grid.Controls.Clear();
            }

            TURNCHANGE();
        }
        void Cell_Selected_HvsC(object sender, EventArgs e)
        {
            C = (Cell)sender;
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    if (C.Occupy != COLOR.WHITE)
                    {
                        MessageBox.Show("Wrong Move...");
                        return;
                    }
                }
                else
                {
                    Computer_Move();
                }
                UpdateBoard();
                if (!Draw())
                {
                     if (Is_Win(Turn))
                     {
                         MessageBox.Show(Turn.ToString() + "Wins ...!!!");
                         Grid.Controls.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Game is Draw ...!!!");
                    Grid.Controls.Clear();
                }

                TURNCHANGE();
            }
        }
        bool Is_Win(COLOR Turn)
        {
           for(int i=0;i<dim;i++)
           {
               for(int j=0;j<dim;j++)
               {
                   if(Do_I_Win(Turn, i,j))
                   {
                       return true;
                   }
               }
           }
           return false;
        }
        void Computer_Move()
        {
            int temp = W_C;       
            Random R = new Random();
            int ri = 0, ci = 0;
            do
            {
                ri = R.Next(0, dim);
                ci = R.Next(0, dim);
            }
            while (Cell_Array[ri, ci].Occupy != COLOR.WHITE);

            C = Cell_Array[ri, ci];

            for (int i = W_C; i >= 0;i--)
            {
                for (int r = 0; r < dim; r++)
                {
                    for (int c = 0; c < dim; c++)
                    {
                        if (Cell_Array[r, c].Occupy == COLOR.WHITE)
                        {
                            Cell_Array[r, c].Occupy = Turn;
                            // C = Cell_Array[r, c];
                            if (Is_Win(Turn))
                            {
                                Cell_Array[r, c].Occupy = COLOR.WHITE;
                                C = Cell_Array[r, c];
                                return;
                            }
                            else
                            {
                                Cell_Array[r, c].Occupy = COLOR.WHITE;
                            }
                        }
                    }
                }
            }
            TURNCHANGE();
            for (int r = 0; r < dim; r++)
            {
                for (int c = 0; c < dim; c++)
                {
                    if (Cell_Array[r, c].Occupy == COLOR.WHITE)
                    {
                        Cell_Array[r, c].Occupy = Turn;
                        if (Is_Win(Turn))
                        {
                            TURNCHANGE();
                            Cell_Array[r, c].Occupy = COLOR.WHITE;
                            C = Cell_Array[r, c];
                            return;
                        }
                        else
                        {

                            Cell_Array[r, c].Occupy = COLOR.WHITE;
                        }
                    }
                }
                    
             }
             TURNCHANGE();
         }
        
       
            
        bool Do_I_Win(COLOR T,int ri,int ci)
        {
            return (Is_Horizonatal(T, ri, ci)) || Is_Vertical(T, ri, ci) || Is_DiagonalL2R(T, ri, ci) || Is_DiagonalR2L(T, ri, ci);
        }
        bool Is_Horizonatal(COLOR t, int ri, int ci)
        {
            if (ci + W_C > dim)
            {
                return false;
            }
            for (int i = 0; i < W_C; i++)
            {
                if (Cell_Array[ri, ci+i].Occupy != t)
                {
                    return false;
                }
            }
            return true;
        }
        bool Is_Vertical(COLOR t, int ri, int ci)
        {
            if (ri + W_C > dim)
            {
                return false;
            }
            for (int i = 0; i < W_C; i++)
            {
                if (Cell_Array[ri +i , ci].Occupy != t)
                {
                    return false;
                }
            }
            return true;
        }
        bool Is_DiagonalL2R(COLOR t, int ri, int ci)
        {
            if (ri + W_C > dim || ci + W_C > dim)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < W_C; i++)
                {
                    if ((Cell_Array[ri + i, ci + i].Occupy != t))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        bool Is_DiagonalR2L(COLOR t, int ri, int ci)
        {
            if (ri + W_C > dim || W_C + ci > dim)
            {
              return false;
            }
            else
            {
                int a = W_C - 1;
                int b = ci;
                for (int i = 0; i < W_C; i++)
                {
                    if (Cell_Array[a, b].Occupy != t)
                    {
                        return false;
                    }
                    a--;
                    b++;
                }
                return true;
            }
        }

        void TURNCHANGE()
        {
            if (Turn == COLOR.RED)
            {
                Turn = COLOR.BLUE;
            }
            else
            {
                Turn = COLOR.RED;
            }
        }
        void UpdateBoard()
        {
            C.Occupy = Turn;
            if (Turn == COLOR.BLUE)
            {
                C.BackColor = Color.Blue;
            }
            else
            {
                C.BackColor = Color.Red;
            }
        }
        bool Draw()
        {
            int count = 0;
            for (int i = 0; i < dim;i++ )
            {
                for(int j=0;j<dim;j++)
                {
                    if(Cell_Array[i,j].Occupy==COLOR.WHITE)
                    {
                        count++;
                    }
                }
            }
            if(count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void GForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
