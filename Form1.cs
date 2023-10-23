using System.Runtime.CompilerServices;

namespace FigurUppgifter
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.Black, 2);
        Brush myBrush = new SolidBrush(Color.Black);
        Graphics g;
        int figurNr = 1;

        /*************************
         * Fyll i ditt namn här: *
         * ***********************/
        string name = "Namn Namnsson";

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(DrawShapes);
            g = this.CreateGraphics();
            lbl_fignr.Text = figurNr.ToString();
            lbl_name.Text = name;
        }

        private void DrawShapes(object? sender, PaintEventArgs e)
        {
            g.Clear(Color.White);   // Rensar skärmen. Låt stå!


            /*****************************************************************************
             * Här skriver du din kod för uppgifterna. Gör en if-sats för varje uppgift.
             * Du får skapa vilka variabler du vill och byta färg hur ofta som helst.
             * Du får bara använda varje ritkommando EN gång per uppgift.
             * ***************************************************************************/

            if (figurNr == 1)
            {
                // Ritar en svart kvadrat.
                // Hur gör du fler utan att skriva DrawRect fler gånger?
                SetColor(Color.Black);
                for (int x = 0; x < 5; x++)
                {
                    DrawRect(x*50 + 250, 200, 40, 40);
                }

            }

            if (figurNr == 2)
            {
                // Ritar en svart kvadrat.
                SetColor(Color.Black);
                for (int x = 0; x < 5; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        DrawRect(x * 50 + 250, y * 50 + 200, 40, 40);
                    }
                }
            }

            if (figurNr == 3)
            {
                // Ritar en blå kvadrat.
                for (int x = 0; x < 6; x++)
                {
                    if (x % 2 == 1)
                    {
                        SetColor(Color.Orange);
                    }
                    else
                    {
                        SetColor(Color.Blue);
                    }
                    FillRect(x * 50 + 250, 200, 40, 40);
                }
                
            }

            if (figurNr == 4)
            {
                // Ritar en svart kvadrat.
                SetColor(Color.Black);
                for (int y = 0; y < 4; y++)
                {
                        for (int x = 0; x < 4 - y; x++)
                        {
                            DrawRect(x * 50 + 250, y * 50 + 200, 40, 40);
                        }
                }
            }
            if (figurNr == 5)
            {
                // Rita en röd fyrkant och cirkel
                
                for (int y = 0; y < 3; y++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (y % 2 == 1)
                        {
                            SetColor(Color.Yellow);
                        }
                        else
                        {
                            SetColor(Color.Red);
                        }

                        if (x % 2 == 1)
                        {
                            FillOval(x * 50 + 250, y * 50 + 250, 40, 40);
                        }
                        else
                        {
                            FillRect(x * 50 + 250, y * 50 + 250, 40, 40);
                        }
                    }
                }
            }

            if (figurNr == 6)
            {
                // Ritar en blå kvadrat.
                for (int x = 0; x < 6; x++)
                {
                    if (x % 4 < 2)
                    {
                        SetColor(Color.Blue);
                    }
                    else
                    {
                        SetColor(Color.Orange);    
                    }
                    FillRect(x * 50 + 250, 200, 40, 40);
                }
                
            }
            if (figurNr == 7)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (x % 5 == 0 || x % 5 == 4)
                    {
                        SetColor(Color.Red);
                    }
                    else if (x % 5 == 1 || x % 5 == 3) 
                    {
                        SetColor (Color.Yellow);
                    }
                    else if (x % 5 == 2)
                    {
                        SetColor(Color.Blue);
                    }
                    FillRect(x * 50 + 250, 200, 40, 40);
                }
            }
            if (figurNr == 8)
            {
                SetColor(Color.Black);
                for (int x = 6; x >= 0; x--)
                {
                    DrawOval(250, 200, x*35, x*35);
                }
            }
            if (figurNr == 9)
            {
                int extra = 2;
                SetColor(Color.LimeGreen);
                for (int x = 0; x < 5 + extra; x++)
                {
                    FillOval(x * 50 + 250, 200, 40, 40);
                    if (x == 4 + extra) 
                    {
                        for (int y = 0; y < 2 + extra; y++)
                        {
                            FillOval(x * 50 + 250, y * 50 + 250, 40, 40);
                        }
                    }
                }
                
            }
            if (figurNr == 10)
            {
                SetColor(Color.Black);
                for (int x = 0; x < 4; x++)
                {
                    DrawRect(250 - x * 25, 200 - x * 25, x * 50 + 250, x * 50 + 150);
                }
            }




            // Här fortsätter du med fler if-satser för resten av figurerna.


        }   // Den här måsvingen borde (ska) höra ihop med den första i DrawShapes (på rad 25).



        /********************************************
         *                                          *
         *  Här under ska du inte röra någon kod!!  *
         *                                          *
         ********************************************/

        private void SetColor(Color color)
        {
            myPen.Color = color;
            myBrush = new SolidBrush(color);
        }

        private void DrawRect(int x, int y, int width, int height)
        {
            g.DrawRectangle(myPen, x, y, width, height);
        }

        private void FillRect(int x, int y, int width, int height)
        {
            g.FillRectangle(myBrush, x, y, width, height);
        }

        private void DrawOval(int x, int y, int width, int height)
        {
            g.DrawEllipse(myPen, x, y, width, height);
        }

        private void FillOval(int x, int y, int width, int height)
        {
            g.FillEllipse(myBrush, x, y, width, height);
        }

        private void DrawLine(int x1, int y1, int x2, int y2)
        {
            g.DrawLine(myPen, x1, y1, x2, y2);
        }

        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            figurNr = hScrollBar.Value;
            lbl_fignr.Text = figurNr.ToString();
            this.Refresh();
        }
    }
}