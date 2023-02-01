namespace Navigate
{
    class Navigation
    {

        public (double,double,String) navigateTerrain(String input, double x, double y)
        {
            int count = 0;
            String direction = "";
            var directionX = x;
            var directionY = y;

            for(int i =0; i <x; i++)
            {
                if (input[i] == 'F')
                {
                    directionX = directionX + 1;
                    directionY = directionY - 1;
                }
                if (input[i] == 'R' || input[i] == 'L')
                {
                    directionY = directionY + 1;
                    directionX = directionX - 1;

                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[0] == '\n')
                {
                    return (0, 0, null);
                }
                if (input[i] == 'L')
                { 
    
                    count --;
                }
                else if (input[i] == 'R')
                {
            
                    count ++;
                }
            }
            if (count > 0)
            {

                if (count % 4 == 0)
                    direction = "N";
                else if (count % 4 == 1)
                {
                    direction = "E";
                
                }
                else if (count % 4 == 2)
                {
                    direction = "S";

                }
                else if (count % 4 == 3)
                {
                    direction = "W";
                }
                
            }

            if (count < 0)
            {

                if (count % 4 == 0)
                {
                    direction = "N";
                }
                else if (count % 4 == -1)
                {
                    direction = "W";
                }
                else if (count % 4 == -2)
                {
                    direction = "S";
                }
                else if (count % 4 == -3)
                {
                    direction = "E";
                }
            }
            return (directionX, directionY, direction);

        }

        static void Main(string[] args)     
        {
            Navigation nav = new Navigation();
            Console.WriteLine("Enter the size of the plateu eg) 5x5, 3x3");
            var size = Console.ReadLine().Split('x').Select(x => Double.Parse(x.Trim())).ToList(); 
            var x = size[0];
            var y = size[1];
            Console.WriteLine("Enter the commands to move the robot on the Mars plateau");
            var userInput = Console.ReadLine();
            var result = nav.navigateTerrain(userInput, 5, 5);
            Console.WriteLine(result);
        }
    }
}