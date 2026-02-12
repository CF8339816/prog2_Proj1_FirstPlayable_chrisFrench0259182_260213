using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{
    internal class LoadMap
    {
        /*  Array of strings for the map data

          draw method . 





          */

        string filepath1 = "map1.txt";
        string filepath2 = "map2.txt";
        public string[] Maps;
        

        public void MapLoader()
        {
            String Filepath = filepath1;

            try
            {
                Maps = File.ReadAllLines(Filepath);

                foreach (string map in Maps)
                {
                    //foreach (char mapChar in map)
                    foreach (char mapTile in map)
                    {
                        // switch (mapChar)
                        switch (mapTile)
                        {
                            #region // colouring the individual tiles
                            case '#': // WALL
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            case '%': // Lava
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case 'G': // Goal
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                break;

                            case '|': //Border
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;

                            case '-': // Border
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;

                            case '+': // Border
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                                #endregion
                        }

                        Console.Write(mapTile);
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: The file '{filepath1}' was not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


        }


        static bool CanMoveTo(int tarMapX, int tarMapY)
        {
            if (tarMapY >= 0 && tarMapY < Maps.Length && tarMapX >= 0 && tarMapX < Maps[tarMapY].Length)
            {
                char tarTile = Maps[tarMapY][tarMapX];

                switch (tarTile)
                {
                    case '#': //defines un traversable
                    case '@':
                    case '&':

                        return false;

                    case ' ':  //verifies traversable
                    
                    case '%':
                        return true;

                    default:
                        return true;
                }
            }
            return false;


        }
}
