namespace Harry_Potter_4D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        // Harry Potter unit id
        static int HarryPotterId = '@' + 0;
        static int HarryPotterStepsCount = 0;

        // Command Parameters
        static int Dimension;
        static int Offset;
        static int UnitID;

        static bool IsRunning = true;

        // Dimensions numbers
        const int First = 0;
        const int Second = 1;
        const int Third = 2;
        const int Fourth = 3;

        static void Main()
        {
            //Read and parse hypercube dimensions
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstDimensionSize = dimensions[0];
            var secondDimensionSize = dimensions[1];
            var thirdDimensionSize = dimensions[2];
            var fourthDimensionSize = dimensions[3];

            var allUnitsCoordinates = new int[125, 4];

            HarryPotterStepsCount = 0;
            Offset = 0;
            Dimension = 0;
            UnitID = 0;

            // Read and parse Harry Potter's initial coordinates
            SetupHarryPotterInitialCoordinates(allUnitsCoordinates);

            // Setup initial values for the Basilisks coordinates
            InitializeBasilisksInitialCoordinates(allUnitsCoordinates);

            // Read and parse all Basilisks initial coordinates
            SetupBasilisksInitialCoordinates(allUnitsCoordinates);

            IsRunning = true;

            while (IsRunning)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    Console.WriteLine(String.Format("@: \"I am the chosen one!\" - {0}", HarryPotterStepsCount));
                    return;
                }

                ParseCommand(command);
                ExecuteCommand(firstDimensionSize, secondDimensionSize, thirdDimensionSize, fourthDimensionSize, allUnitsCoordinates);
            }
        }

        private static void ExecuteCommand(int firstDimensionSize, int secondDimensionSize, int thirdDimensionSize, int fourthDimensionSize, int[,] allUnitsCoordinates)
        {
            // Select strategy
            if (Dimension == First)
            {
                ExecuteStrategy(First, firstDimensionSize, allUnitsCoordinates);
            }
            else if (Dimension == Second)
            {
                ExecuteStrategy(Second, secondDimensionSize, allUnitsCoordinates);
            }
            else if (Dimension == Third)
            {
                ExecuteStrategy(Third, thirdDimensionSize, allUnitsCoordinates);
            }
            else
            {
                ExecuteStrategy(Fourth, fourthDimensionSize, allUnitsCoordinates);
            }

            // Process command consequences
            if (UnitID == HarryPotterId)
            {
                HarryPotterStepsCount++;

                // Check for each basilisk in the array if Harry Potter stepped up in the wrong chamber and got killed
                for (int basiliskId = 65; basiliskId < allUnitsCoordinates.GetLength(0); basiliskId++)
                {
                    if (PositionsMatch(basiliskId, HarryPotterId, allUnitsCoordinates))
                    {
                        Console.WriteLine(String.Format("{0}: \"Step {1} was the worst you ever made.\"", (char)basiliskId, HarryPotterStepsCount));
                        Console.WriteLine(String.Format("{0}: \"You will regret until the rest of your life... All 3 seconds of it!\"", (char)basiliskId));
                        IsRunning = false;
                        break;
                    }
                }
            }
            else
            {
                // Checks if the basilisk moved is in the same chamber with Harry Potter
                if (PositionsMatch(UnitID, HarryPotterId, allUnitsCoordinates))
                {
                    Console.WriteLine(String.Format("{0}: \"You thought you could escape, didn't you?\" - {1}", (char)UnitID, HarryPotterStepsCount));
                    IsRunning = false;
                }
            }
        }

        private static bool PositionsMatch(int firstUnitId, int secondUnitId, int[,] allUnitsCoordinates)
        {
            return (
                allUnitsCoordinates[firstUnitId, 0] == allUnitsCoordinates[secondUnitId, 0] &&
                allUnitsCoordinates[firstUnitId, 1] == allUnitsCoordinates[secondUnitId, 1] &&
                allUnitsCoordinates[firstUnitId, 2] == allUnitsCoordinates[secondUnitId, 2] &&
                allUnitsCoordinates[firstUnitId, 3] == allUnitsCoordinates[secondUnitId, 3]);
        }

        private static void ExecuteStrategy(int dimension, int dimensionSize, int[,] allUnitsCoordinates)
        {
            var resultCoordinate = allUnitsCoordinates[UnitID, dimension] + Offset;

            if (resultCoordinate >= dimensionSize)
            {
                allUnitsCoordinates[UnitID, dimension] = dimensionSize - 1;
            }
            else if (resultCoordinate < 0)
            {
                allUnitsCoordinates[UnitID, dimension] = 0;
            }
            else
            {
                allUnitsCoordinates[UnitID, dimension] = resultCoordinate;
            }
        }

        private static void SetupBasilisksInitialCoordinates(int[,] allUnitsCoordinates)
        {
            int basilisksCount = int.Parse(Console.ReadLine());
            int singleBasiliskName;
            int[] singleBasiliskCoordinates;
            string singleBasiliskData;

            for (int i = 0; i < basilisksCount; i++)
            {
                singleBasiliskData = Console.ReadLine();
                singleBasiliskName = singleBasiliskData[0] + 0;
                singleBasiliskCoordinates = singleBasiliskData.Substring(2).Split(' ').Select(int.Parse).ToArray();

                allUnitsCoordinates[singleBasiliskName, 0] = singleBasiliskCoordinates[0];
                allUnitsCoordinates[singleBasiliskName, 1] = singleBasiliskCoordinates[1];
                allUnitsCoordinates[singleBasiliskName, 2] = singleBasiliskCoordinates[2];
                allUnitsCoordinates[singleBasiliskName, 3] = singleBasiliskCoordinates[3];

                //Console.WriteLine(allUnitsCoordinates[singleBasiliskName, 3]);
            }
        }

        private static void ParseCommand(string command)
        {
            UnitID = command[0] - 0;
            Dimension = command[2] - 65;
            Offset = int.Parse(command.Substring(4));

            //Console.WriteLine(Offset);
        }

        private static void InitializeBasilisksInitialCoordinates(int[,] allUnitsCoordinates)
        {
            for (int i = 65; i < allUnitsCoordinates.GetLength(0); i++)
            {
                allUnitsCoordinates[i, 0] = int.MaxValue;
                allUnitsCoordinates[i, 1] = int.MaxValue;
                allUnitsCoordinates[i, 2] = int.MaxValue;
                allUnitsCoordinates[i, 3] = int.MaxValue;
            }

            //Console.WriteLine(allUnitsCoordinates[65, 0]);
        }

        private static void SetupHarryPotterInitialCoordinates(int[,] allUnitsCoordinates)
        {
            int[] hpInitialCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            allUnitsCoordinates[HarryPotterId, 0] = hpInitialCoordinates[0];
            allUnitsCoordinates[HarryPotterId, 1] = hpInitialCoordinates[1];
            allUnitsCoordinates[HarryPotterId, 2] = hpInitialCoordinates[2];
            allUnitsCoordinates[HarryPotterId, 3] = hpInitialCoordinates[3];

            //Console.WriteLine(HarryPotterId);
            //Console.WriteLine(allUnitsCoordinates[HarryPotterId, 0]);
        }
    }
}
