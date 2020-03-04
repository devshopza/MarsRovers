using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MarsRovers.Library;

namespace MarsRovers.ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "BulkDeploy.txt";

            using (var streamReader = File.OpenText(fileName))
            {
                var line = streamReader.ReadLine();

                if (line != null)
                {
                    var plateau = Plateau.CreatePlateau(line);
                    var count = 0;
                    Rover rover = null;

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (count % 2 == 0)
                        {
                            rover = Rover.CreateRover(line);
                            rover.SetPlateau(plateau);
                        }
                        else
                        {
                            rover.ExecuteBatchCmds(line);
                            Console.WriteLine(rover.GetPosition());
                        }

                        count++;
                    }
                }
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
