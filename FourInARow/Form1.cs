namespace FourInARow
{
    public partial class Form1 : Form
    {
        public int PlayerName = 1;
        public int Player1Score = 0;
        public int Player2Score = 0;
        public int StartingPlayer = 1;
        public void FillColumnA()
        {
            if (A1 == 0 && PlayerName != 0)
            {
                if (A6 == 0)
                {
                A6 = PlayerName;
                if (PlayerName == 1)
                {
                    button6.ForeColor = Color.Red;
                }
                else
                {
                    button6.ForeColor = Color.Blue;
                }
                button6.Text = "o";
                }
                else if (A5 == 0)
                {
                    A5 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button5.ForeColor = Color.Red;
                    }
                    else
                    {
                        button5.ForeColor = Color.Blue;
                    }
                    button5.Text = "o";
                }
                else if (A4 == 0)
                {
                    A4 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button4.ForeColor = Color.Red;
                    }
                    else
                    {
                        button4.ForeColor = Color.Blue;
                    }
                    button4.Text = "o";
                }
                else if (A3 == 0)
                {
                    A3 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button3.ForeColor = Color.Red;
                    }
                    else
                    {
                        button3.ForeColor = Color.Blue;
                    }
                    button3.Text = "o";
                }
                else if (A2 == 0)
                {
                    A2 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button2.ForeColor = Color.Red;
                    }
                    else
                    {
                        button2.ForeColor = Color.Blue;
                    }
                    button2.Text = "o";
                }
                else if (A1 == 0)
                {
                    A1 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button1.ForeColor = Color.Red;
                    }
                    else
                    {
                        button1.ForeColor = Color.Blue;
                    }
                    button1.Text = "o";
                }
                if (PlayerName == 1)
                {
                    PlayerName = 2;
                    label5.ForeColor = Color.LightCoral;
                    label6.ForeColor = Color.Blue;
                }
                else if (PlayerName == 2)
                {
                    PlayerName = 1;
                    label5.ForeColor = Color.Red;
                    label6.ForeColor = Color.LightSkyBlue;
                }
            }
            
        }
        public void FillColumnB()
        {
            if (B1 == 0 && PlayerName != 0)
            {
                if (B6 == 0)
                {
                    B6 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button12.ForeColor = Color.Red;
                    }
                    else
                    {
                        button12.ForeColor = Color.Blue;
                    }
                    button12.Text = "o";
                }
                else if (B5 == 0)
                {
                    B5 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button11.ForeColor = Color.Red;
                    }
                    else
                    {
                        button11.ForeColor = Color.Blue;
                    }
                    button11.Text = "o";
                }
                else if (B4 == 0)
                {
                    B4 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button10.ForeColor = Color.Red;
                    }
                    else
                    {
                        button10.ForeColor = Color.Blue;
                    }
                    button10.Text = "o";
                }
                else if (B3 == 0)
                {
                    B3 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button9.ForeColor = Color.Red;
                    }
                    else
                    {
                        button9.ForeColor = Color.Blue;
                    }
                    button9.Text = "o";
                }
                else if (B2 == 0)
                {
                    B2 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button8.ForeColor = Color.Red;
                    }
                    else
                    {
                        button8.ForeColor = Color.Blue;
                    }
                    button8.Text = "o";
                }
                else if (B1 == 0)
                {
                    B1 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button7.ForeColor = Color.Red;
                    }
                    else
                    {
                        button7.ForeColor = Color.Blue;
                    }
                    button7.Text = "o";
                }
                if (PlayerName == 1)
                {
                    PlayerName = 2;
                    label5.ForeColor = Color.LightCoral;
                    label6.ForeColor = Color.Blue;
                }
                else if (PlayerName == 2)
                {
                    PlayerName = 1;
                    label5.ForeColor = Color.Red;
                    label6.ForeColor = Color.LightSkyBlue;
                }
            }
        }
        public void FillColumnC()
        {
            if (C1 == 0 && PlayerName != 0)
            {
                if (C6 == 0)
                {
                    C6 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button18.ForeColor = Color.Red;
                    }
                    else
                    {
                        button18.ForeColor = Color.Blue;
                    }
                    button18.Text = "o";
                }
                else if (C5 == 0)
                {
                    C5 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button17.ForeColor = Color.Red;
                    }
                    else
                    {
                        button17.ForeColor = Color.Blue;
                    }
                    button17.Text = "o";
                }
                else if (C4 == 0)
                {
                    C4 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button16.ForeColor = Color.Red;
                    }
                    else
                    {
                        button16.ForeColor = Color.Blue;
                    }
                    button16.Text = "o";
                }
                else if (C3 == 0)
                {
                    C3 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button15.ForeColor = Color.Red;
                    }
                    else
                    {
                        button15.ForeColor = Color.Blue;
                    }
                    button15.Text = "o";
                }
                else if (C2 == 0)
                {
                    C2 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button14.ForeColor = Color.Red;
                    }
                    else
                    {
                        button14.ForeColor = Color.Blue;
                    }
                    button14.Text = "o";
                }
                else if (C1 == 0)
                {
                    C1 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button13.ForeColor = Color.Red;
                    }
                    else
                    {
                        button13.ForeColor = Color.Blue;
                    }
                    button13.Text = "o";
                }
                if (PlayerName == 1)
                {
                    PlayerName = 2;
                    label5.ForeColor = Color.LightCoral;
                    label6.ForeColor = Color.Blue;
                }
                else if (PlayerName == 2)
                {
                    PlayerName = 1;
                    label5.ForeColor = Color.Red;
                    label6.ForeColor = Color.LightSkyBlue;
                }
            }
        }
        public void FillColumnD()
        {
            if (D1 == 0 && PlayerName != 0)
            {
                if (D6 == 0)
                {
                    D6 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button24.ForeColor = Color.Red;
                    }
                    else
                    {
                        button24.ForeColor = Color.Blue;
                    }
                    button24.Text = "o";
                }
                else if (D5 == 0)
                {
                    D5 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button23.ForeColor = Color.Red;
                    }
                    else
                    {
                        button23.ForeColor = Color.Blue;
                    }
                    button23.Text = "o";
                }
                else if (D4 == 0)
                {
                    D4 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button22.ForeColor = Color.Red;
                    }
                    else
                    {
                        button22.ForeColor = Color.Blue;
                    }
                    button22.Text = "o";
                }
                else if (D3 == 0)
                {
                    D3 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button21.ForeColor = Color.Red;
                    }
                    else
                    {
                        button21.ForeColor = Color.Blue;
                    }
                    button21.Text = "o";
                }
                else if (D2 == 0)
                {
                    D2 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button20.ForeColor = Color.Red;
                    }
                    else
                    {
                        button20.ForeColor = Color.Blue;
                    }
                    button20.Text = "o";
                }
                else if (D1 == 0)
                {
                    D1 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button19.ForeColor = Color.Red;
                    }
                    else
                    {
                        button19.ForeColor = Color.Blue;
                    }
                    button19.Text = "o";
                }
                if (PlayerName == 1)
                {
                    PlayerName = 2;
                    label5.ForeColor = Color.LightCoral;
                    label6.ForeColor = Color.Blue;
                }
                else if (PlayerName == 2)
                {
                    PlayerName = 1;
                    label5.ForeColor = Color.Red;
                    label6.ForeColor = Color.LightSkyBlue;
                }
            }
        }
        public void FillColumnE()
        {
            if (E1 == 0 && PlayerName != 0)
            {
                if (E6 == 0)
                {
                    E6 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button30.ForeColor = Color.Red;
                    }
                    else
                    {
                        button30.ForeColor = Color.Blue;
                    }
                    button30.Text = "o";
                }
                else if (E5 == 0)
                {
                    E5 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button29.ForeColor = Color.Red;
                    }
                    else
                    {
                        button29.ForeColor = Color.Blue;
                    }
                    button29.Text = "o";
                }
                else if (E4 == 0)
                {
                    E4 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button28.ForeColor = Color.Red;
                    }
                    else
                    {
                        button28.ForeColor = Color.Blue;
                    }
                    button28.Text = "o";
                }
                else if (E3 == 0)
                {
                    E3 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button27.ForeColor = Color.Red;
                    }
                    else
                    {
                        button27.ForeColor = Color.Blue;
                    }
                    button27.Text = "o";
                }
                else if (E2 == 0)
                {
                    E2 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button26.ForeColor = Color.Red;
                    }
                    else
                    {
                        button26.ForeColor = Color.Blue;
                    }
                    button26.Text = "o";
                }
                else if (E1 == 0)
                {
                    E1 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button25.ForeColor = Color.Red;
                    }
                    else
                    {
                        button25.ForeColor = Color.Blue;
                    }
                    button25.Text = "o";
                }
                if (PlayerName == 1)
                {
                    PlayerName = 2;
                    label5.ForeColor = Color.LightCoral;
                    label6.ForeColor = Color.Blue;
                }
                else if (PlayerName == 2)
                {
                    PlayerName = 1;
                    label5.ForeColor = Color.Red;
                    label6.ForeColor = Color.LightSkyBlue;
                }
            }
        }
        public void FillColumnF()
        {
            if (F1 == 0 && PlayerName != 0)
            {
                if (F6 == 0)
                {
                    F6 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button36.ForeColor = Color.Red;
                    }
                    else
                    {
                        button36.ForeColor = Color.Blue;
                    }
                    button36.Text = "o";
                }
                else if (F5 == 0)
                {
                    F5 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button35.ForeColor = Color.Red;
                    }
                    else
                    {
                        button35.ForeColor = Color.Blue;
                    }
                    button35.Text = "o";
                }
                else if (F4 == 0)
                {
                    F4 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button34.ForeColor = Color.Red;
                    }
                    else
                    {
                        button34.ForeColor = Color.Blue;
                    }
                    button34.Text = "o";
                }
                else if (F3 == 0)
                {
                    F3 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button33.ForeColor = Color.Red;
                    }
                    else
                    {
                        button33.ForeColor = Color.Blue;
                    }
                    button33.Text = "o";
                }
                else if (F2 == 0)
                {
                    F2 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button32.ForeColor = Color.Red;
                    }
                    else
                    {
                        button32.ForeColor = Color.Blue;
                    }
                    button32.Text = "o";
                }
                else if (F1 == 0)
                {
                    F1 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button31.ForeColor = Color.Red;
                    }
                    else
                    {
                        button31.ForeColor = Color.Blue;
                    }
                    button31.Text = "o";
                }
                if (PlayerName == 1)
                {
                    PlayerName = 2;
                    label5.ForeColor = Color.LightCoral;
                    label6.ForeColor = Color.Blue;
                }
                else if (PlayerName == 2)
                {
                    PlayerName = 1;
                    label5.ForeColor = Color.Red;
                    label6.ForeColor = Color.LightSkyBlue;
                }
            }
        }
        public void FillColumnG()
        {
            if (G1 == 0 && PlayerName != 0)
            {
                if (G6 == 0)
                {
                    G6 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button42.ForeColor = Color.Red;
                    }
                    else
                    {
                        button42.ForeColor = Color.Blue;
                    }
                    button42.Text = "o";
                }
                else if (G5 == 0)
                {
                    G5 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button41.ForeColor = Color.Red;
                    }
                    else
                    {
                        button41.ForeColor = Color.Blue;
                    }
                    button41.Text = "o";
                }
                else if (G4 == 0)
                {
                    G4 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button40.ForeColor = Color.Red;
                    }
                    else
                    {
                        button40.ForeColor = Color.Blue;
                    }
                    button40.Text = "o";
                }
                else if (G3 == 0)
                {
                    G3 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button39.ForeColor = Color.Red;
                    }
                    else
                    {
                        button39.ForeColor = Color.Blue;
                    }
                    button39.Text = "o";
                }
                else if (G2 == 0)
                {
                    G2 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button38.ForeColor = Color.Red;
                    }
                    else
                    {
                        button38.ForeColor = Color.Blue;
                    }
                    button38.Text = "o";
                }
                else if (G1 == 0)
                {
                    G1 = PlayerName;
                    if (PlayerName == 1)
                    {
                        button37.ForeColor = Color.Red;
                    }
                    else
                    {
                        button37.ForeColor = Color.Blue;
                    }
                    button37.Text = "o";
                }
                if (PlayerName == 1)
                {
                    PlayerName = 2;
                    label5.ForeColor = Color.LightCoral;
                    label6.ForeColor = Color.Blue;
                }
                else if (PlayerName == 2)
                {
                    PlayerName = 1;
                    label5.ForeColor = Color.Red;
                    label6.ForeColor = Color.LightSkyBlue;
                } 
            }
        }
        public void CheckIfWin()
        {
            int[,] Squares = new int[7, 6] { { A1, A2, A3, A4, A5, A6 }, { B1, B2, B3, B4, B5, B6 }, { C1, C2, C3, C4, C5, C6},
              {D1, D2, D3, D4, D5, D6}, {E1, E2, E3, E4, E5, E6}, {F1, F2, F3, F4, F5, F6}, {G1, G2, G3, G4, G5, G6} };
            //horizontal
            int TestWin = 0;
            for (int l = 1; l < 3; l++)
            {
                for (int k = 0; k < 4; k++)
                {
                    for (int i = 0; i < 6; i++)
                    {

                            TestWin = 0;
                            for (int j = 0; j < 4; j++)
                                if (Squares[j + k, i] == l)
                                {
                                    TestWin++;

                                }
                        if (TestWin == 4)
                        {
                            Win(l);

                        }
                    }
                }
            }
            //vertical
            for (int l = 1; l < 3; l++)
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int i = 0; i < 7; i++)
                    {
                            TestWin = 0;
                            for (int j = 0; j < 4; j++)
                                if (Squares[i, j + k] == l)
                                {
                                    TestWin++;

                                }
                            if (TestWin == 4)
                            {
                                Win(l);

                            }
                        
                    }
                }
            }
            //diagonal bottom left to top right
            for (int l = 1; l < 3; l++)
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int i = 0; i < 4; i++)
                    {                  
                            TestWin = 0;
                            for (int j = 0; j < 4; j++)
                                if (Squares[i + j, j + k] == l)
                                {
                                    TestWin++;

                                }
                            if (TestWin == 4)
                            {
                                Win(l);

                            }
                    }
                }
            }
            // horizontal top left to bottom right
            for (int l = 1; l < 3; l++)
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int i = 0; i < 4; i++)
                    {                    
                        {
                            TestWin = 0;
                            for (int j = 0; j < 4; j++)
                                if (Squares[i + j, 5 - j - k] == l)
                                {
                                    TestWin++;
                                }
                            if (TestWin == 4)
                            {
                                Win(l);

                            }
                        }
                    }
                }
            }


        }
        public void Win(int Winner)
        {
            if (PlayerName != 0)
            {
                if (Winner == 1)
                {
                    label1.Text = "The winner is Player 1";
                    Player1Score++;
                }
                else
                {
                    label1.Text = "The Winner is Player 2";
                    Player2Score++;
                }
            label2.Text = Player1Score + " - " + Player2Score;
            PlayerName = 0;
        }
        }
        public void Restart()
        {
            if (StartingPlayer == 1)
            {
                StartingPlayer++;
                label5.ForeColor = Color.LightCoral;
                label6.ForeColor = Color.Blue;
            }
            else if (StartingPlayer == 2)
            {
                StartingPlayer--;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.LightSkyBlue;
            }
            PlayerName = StartingPlayer;
            A1 = 0;
            A2 = 0;
            A3 = 0;
            A4 = 0;
            A5 = 0;
            A6 = 0;
            B1 = 0;
            B2 = 0;
            B3 = 0;
            B4 = 0;
            B5 = 0;
            B6 = 0;
            C1 = 0;
            C2 = 0;
            C3 = 0;
            C4 = 0;
            C5 = 0;
            C6 = 0;
            D1 = 0;
            D2 = 0;
            D3 = 0;
            D4 = 0;
            D5 = 0;
            D6 = 0;           
            E1 = 0;
            E2 = 0;
            E3 = 0;
            E4 = 0;
            E5 = 0;
            E6 = 0;          
            F1 = 0;
            F2 = 0;
            F3 = 0;
            F4 = 0;
            F5 = 0;
            F6 = 0;            
            G1 = 0;
            G2 = 0;
            G3 = 0;
            G4 = 0;
            G5 = 0;
            G6 = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
            button19.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button24.Text = "";
            button25.Text = "";
            button26.Text = "";
            button27.Text = "";
            button28.Text = "";
            button29.Text = "";
            button30.Text = "";
            button31.Text = "";
            button32.Text = "";
            button33.Text = "";
            button34.Text = "";
            button35.Text = "";
            button36.Text = "";
            button37.Text = "";
            button38.Text = "";
            button39.Text = "";
            button40.Text = "";
            button41.Text = "";
            button42.Text = "";
            label1.Text = "";
        }
        int A1 = 0;
        int A2 = 0;
        int A3 = 0;
        int A4 = 0;
        int A5 = 0;
        int A6 = 0;
        int B1 = 0;
        int B2 = 0;
        int B3 = 0;
        int B4 = 0;
        int B5 = 0;
        int B6 = 0;
        int C1 = 0;
        int C2 = 0;
        int C3 = 0;
        int C4 = 0;
        int C5 = 0;
        int C6 = 0;
        int D1 = 0;
        int D2 = 0;
        int D3 = 0;
        int D4 = 0;
        int D5 = 0;
        int D6 = 0;
        int E1 = 0;
        int E2 = 0;
        int E3 = 0;
        int E4 = 0;
        int E5 = 0;
        int E6 = 0;        
        int F1 = 0;
        int F2 = 0;
        int F3 = 0;
        int F4 = 0;
        int F5 = 0;
        int F6 = 0;      
        int G1 = 0;
        int G2 = 0;
        int G3 = 0;
        int G4 = 0;
        int G5 = 0;
        int G6 = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        //public int[,] Squares = new int[7, 6] {{ 0,0,0,0,0,0},{ 0,0,0,0,0,0}, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }};
        /*private void UpdateSquares()
        {


        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            FillColumnA();
            CheckIfWin();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FillColumnA();
            CheckIfWin();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FillColumnA();
            CheckIfWin();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FillColumnA();
            CheckIfWin();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FillColumnA();
            CheckIfWin();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            FillColumnA();
            CheckIfWin();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            FillColumnB();
            CheckIfWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FillColumnB();
            CheckIfWin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FillColumnB();
            CheckIfWin();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FillColumnB();
            CheckIfWin();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FillColumnB();
            CheckIfWin();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FillColumnB();
            CheckIfWin();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FillColumnC();
            CheckIfWin();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FillColumnC();
            CheckIfWin();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FillColumnC();
            CheckIfWin();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FillColumnC();
            CheckIfWin();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FillColumnC();
            CheckIfWin();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FillColumnC();
            CheckIfWin();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FillColumnD();
            CheckIfWin();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FillColumnD();
            CheckIfWin();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            FillColumnD();
            CheckIfWin();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            FillColumnD();
            CheckIfWin();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            FillColumnD();
            CheckIfWin();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            FillColumnD();
            CheckIfWin();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            FillColumnE();
            CheckIfWin();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            FillColumnE();
            CheckIfWin();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            FillColumnE();
            CheckIfWin();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            FillColumnE();
            CheckIfWin();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            FillColumnE();
            CheckIfWin();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            FillColumnE();
            CheckIfWin();

        }

        private void button31_Click(object sender, EventArgs e)
        {
            FillColumnF();
            CheckIfWin();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            FillColumnF();
            CheckIfWin();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            FillColumnF();
            CheckIfWin();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            FillColumnF();
            CheckIfWin();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            FillColumnF();
            CheckIfWin();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            FillColumnF();
            CheckIfWin();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            FillColumnG();
            CheckIfWin();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            FillColumnG();
            CheckIfWin();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            FillColumnG();
            CheckIfWin();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            FillColumnG();
            CheckIfWin();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            FillColumnG();
            CheckIfWin();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            FillColumnG();
            CheckIfWin();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}