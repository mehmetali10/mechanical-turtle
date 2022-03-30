using System;


namespace turtle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();    // creating robot object
            robot.penDown_Action();       //pen is down now, it draws when robot will move
            robot.turnRight_action();     //robot turned right dimension  
            robot.moveForward_action();   
            robot.moveForward_action();
            robot.moveForward_action();
            robot.faceDown_action();
            robot.moveForward_action();
            robot.moveForward_action();
            robot.moveForward_action();
            robot.moveForward_action();
            robot.turnLeft_action();
            robot.moveForward_action();
            robot.moveForward_action();
            robot.faceUp_action();
            robot.moveForward_action();
            robot.moveForward_action();




            robot.printGrid();
           


            Console.ReadLine();
        }
    }

    class Robot
    {
        bool faceUp;
        bool faceDown;
        bool faceRight;
        bool faceLeft;
        bool penUp;
        bool penDown;
        int x;
        int y;
        int[,] grid;

        public Robot()
        {
            grid = new int[20, 20];
            Array.Clear(grid, 0, grid.Length);
            faceRight = true;
            faceLeft = false;
            faceUp = false;
            faceDown = false;
            penUp = true;
            penDown = false;
            x = 0;
            y = 0;

        }

        //displays grid 
        public void printGrid()
        {

            for (int i = 0; i < grid.GetLength(1); i++)
            {
                for (int j = 0; j < grid.GetLength(0); j++)
                {
                    if(y == i && x == j)
                        Console.Write("X" + " ");
                    else
                        Console.Write(grid[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        //makes penup true, pendown false
        public void penUp_Action()
        {
            penUp = true;
            penDown=false;  
        } 

        //makes pendown ture, penup false
        public void penDown_Action()
        {
            penDown = true;
            penUp = false;
        }

        //makes faceup true, others false
        public void faceUp_action()
        {

                faceDown = false;
                faceUp = true;
                faceLeft = false;
                faceRight = false;
            
         
        }

        //makes facedown true, other false
        public void faceDown_action()
        {
                faceUp = false;
                faceDown = true;
                faceLeft = false;
                faceRight = false;
                   
        }

        //makes faceright true, others false
        public void turnRight_action()
        {
            
                faceDown=false;
                faceUp = false;
                faceLeft = false;
                faceRight = true;
            
        
        }

        //makes faceleft true, others false
        public void turnLeft_action()
        {
           
                faceDown = false;
                faceUp = false;
                faceRight = false;
                faceLeft = true;
            
           
        }

        // takes a step 
        public void moveForward_action()
        {
         
            if(faceRight)
            {
                 x++;

                if(x > 19)
                {
                    x = 19;
                }
              
                
            }
            if(faceLeft)
            {
                 x--;
               
                if(x < 0)
                {
                    x = 0;
                }
               
            }
            if(faceDown)
            {
                 y++;

                if(y > 19)
                {
                    y = 19;
                }
               
            }
            if(faceUp)
            {
                 y--;
             
                if(y<0)
                {
                    y=0;
                }
                
            }

            if (penDown)
                grid[y, x] = 1;
            
            
        }
    }


}
