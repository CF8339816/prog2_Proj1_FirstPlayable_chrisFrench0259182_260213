using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{
    internal class Map
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
    }
