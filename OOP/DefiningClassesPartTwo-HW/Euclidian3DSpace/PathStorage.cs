﻿namespace Euclidian3DSpace
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void WritePathToFile(string fileLocation, Path path)
        {
            StreamWriter writer = new StreamWriter(fileLocation, false);
            using (writer)
            {
                writer.Write(path);
            }
        }

        public static Path ReadPathFromFile(string fileLocation)
        {
            Path generatedPath = new Path();
            StreamReader reader = new StreamReader(fileLocation);
            using (reader)
            {
                string currLine = reader.ReadLine();

                while (currLine != null)
                {
                    currLine = currLine.Substring(currLine.IndexOf("-->") + 3);
                    int[] coordinates = currLine.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToArray();

                    generatedPath.AddPoint(coordinates[0], coordinates[1], coordinates[2]);

                    currLine = reader.ReadLine();
                }
            }

            return generatedPath;
        }
    }
}
