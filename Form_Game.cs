using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace OOP2Lab1
{
    public partial class Form_Game : Form
    {
        
        int gridSize = 9;
        int[,] Board = new int[100,100] ;
        bool flag = false;
        public Form_Game()
        {
            InitializeComponent();
        }
        private Panel[,] BoardPanels;
        
        private void button_Start_Click(object sender, EventArgs e)
        {
            //int level = 9;///////////////////////level oyunun zorluk seviyesinden gelen alan büyüklüğü
            //string[,] playground=new string[level,level];
            //int i, j;

            /*for(i = 0; i < level; i++)
            {
                for (j = 0; j < level; j++)
                {
                    playground[i,j] = "0";
                    textBox_Array.Text = textBox_Array.Text + playground[i,j]+"\t";
                }
                    textBox_Array.Text = textBox_Array.Text + Environment.NewLine + Environment.NewLine;
            }*/
            //object random = 6;
            //PictureBox p = random as PictureBox;
            //p.BackColor = Color.Red;
            // PictureBox p;
            // p.Name = "pictureBox" + rand_num;
            // p.Image = Image.FromFile(@"C:\Users\Erkin\Desktop\oopresim\circlered.png");

            //////////////////////////////////////////////////
            //////////////////////////////////////////////////
            
             int tileSize = 20;
             
            var clr1 = Color.DarkGray;
            var clr2 = Color.White;

            // initialize the "chess board"
            BoardPanels = new Panel[gridSize, gridSize];
            

            for (var n=0; n<gridSize; n++)
            {
                for(var m=0;m<gridSize;m++)
                {
                    Board[n,m] = 0;
                }
            }


            // double for loop to handle all rows and columns
            for (var n = 0; n < gridSize; n++)
            {
                for (var m = 0; m < gridSize; m++)
                {
                    // create new Panel control which will be one 
                    // chess board tile
                    var newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * n, tileSize * m),
                        Name = n + " " + m
                    };

                    // add to Form's Controls so that they show up
                    Controls.Add(newPanel);

                    // add to our 2d array of panels for future use
                    BoardPanels[n, m] = newPanel;
                    newPanel.Click += newPanel_Click;
                    // color the backgrounds
                    if (n % 2 == 0)
                        newPanel.BackColor = m % 2 != 0 ? clr1 : clr2;
                    else
                        newPanel.BackColor = m % 2 != 0 ? clr2 : clr1;
                    //newPanel.BackgroundImage = Image.FromFile(@"C:\Users\Erkin\Desktop\oopresim\circlegreen.png");
                }

            }
            ///circle green=1
            ////Square red = 2
            ///triangle red=3
            ///circle red =4
            Random rd = new Random();
            
            for (int i = 0; i < gridSize / 3; i++)
            {
                int rand_num = rd.Next(1, 20);
                int rand_num2 = rd.Next(1, 20);
                if (rand_num % 2 == 0)
                {
                    Board[rand_num % gridSize, rand_num2 % gridSize] = 1;
                    BoardPanels[rand_num % gridSize, rand_num2 % gridSize].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\circlegreen.png");
                }
                else if (rand_num % 3 == 0)
                {
                    Board[rand_num % gridSize, rand_num2 % gridSize] = 2;
                    BoardPanels[rand_num % gridSize, rand_num2 % gridSize].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\squarered.png");
                }
                else
                {
                    Board[rand_num % gridSize, rand_num2 % gridSize] = 3;
                    BoardPanels[rand_num % gridSize, rand_num2 % gridSize].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\trianglered.png");
                }
                    

            }


            button_Start.Enabled = false;
        }
        private void newPanel_Click(object sender, EventArgs e)
        {
            
            Panel temp=sender as Panel;
            Random rd = new Random();
            int x, y;
            //temp.BackgroundImage = Image.FromFile(@"C:\Users\Erkin\Desktop\oopresim\circlegreen.png");
            y = temp.Location.Y / 20;
            x = temp.Location.X / 20;

            
            if(flag==false)
            {
               
            for (int i = 0; i < gridSize / 3; i++)
            {
                int rand_num = rd.Next(1, 20);
                int rand_num2 = rd.Next(1, 20);

                if (rand_num % 4 == 0&& Board[rand_num % gridSize, rand_num2 % gridSize]==0)
                {
                    Board[rand_num % gridSize, rand_num2 % gridSize] = 1;
                    BoardPanels[rand_num % gridSize, rand_num2 % gridSize].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\circlegreen.png");
                }
                else if (rand_num % 3 == 0&& Board[rand_num % gridSize, rand_num2 % gridSize]==0)
                {
                    Board[rand_num % gridSize, rand_num2 % gridSize] = 2;
                    BoardPanels[rand_num % gridSize, rand_num2 % gridSize].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\squarered.png");
                }
                else if (rand_num % 2 == 0&& Board[rand_num % gridSize, rand_num2 % gridSize]==0)
                {
                    Board[rand_num % gridSize, rand_num2 % gridSize] = 3;
                    BoardPanels[rand_num % gridSize, rand_num2 % gridSize].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\trianglered.png");
                }
                else if(rand_num%5==0&& Board[rand_num % gridSize, rand_num2 % gridSize]==0)
                {
                    Board[rand_num % gridSize, rand_num2 % gridSize] = 1;
                    BoardPanels[rand_num % gridSize, rand_num2 % gridSize].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\circlegreen.png");
                }
                else if(rand_num%6==0&& Board[rand_num % gridSize, rand_num2 % gridSize] == 0)
                    {
                        Board[rand_num % gridSize, rand_num2 % gridSize] = 4;
                        BoardPanels[rand_num % gridSize, rand_num2 % gridSize].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\circlered.png");
                    }
                else
                    {
                        Board[rand_num % gridSize, rand_num2 % gridSize] = 2;
                        BoardPanels[rand_num % gridSize, rand_num2 % gridSize].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\squarered.png");
                    }
                        
                }
                flag = true;
            }
            else if(true)
            {
                
                flag = false;
            
            if (temp.BackgroundImage!=null)
            {
                
              if (Board[x,y]==1)
                {
                        BoardPanels[x,y].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\circlegreen.png");
                        Board[x, y] = 0;
                }
              if (Board[x,y]==2)
                {
                        BoardPanels[x,y].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\squarered.png");
                        Board[x, y] = 0;
                }
               if (Board[x,y]==3)
                {
                        BoardPanels[x,y].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\squarered.png");
                        Board[x, y] = 0;
                }
               if(Board[x,y]==4)
                {
                       BoardPanels[x, y].BackgroundImage = Image.FromFile(@"C:\Users\ibrah\source\repos\OOP2Lab1\OOP2Lab1\circlered.png");
                        Board[x, y] = 0;
                }


             }
            else
                temp.BackgroundImage = null;

            }


            
        }
        

       
    }
}
