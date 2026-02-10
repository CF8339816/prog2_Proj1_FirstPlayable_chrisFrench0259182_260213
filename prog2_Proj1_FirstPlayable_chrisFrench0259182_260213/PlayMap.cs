using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{
   public class PlayMap
    {

     
        string filepath1 = "map1.txt";
        string filepath2 = "map2.txt";
        public string[] Maps;
        public void _playMap()
        {

            //Directory.GetCurrentDirectory();
            try
            {
                Maps = File.ReadAllLines(filepath1);

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













       



























        //static char mapTile;
        //static string filepath = "map2.txt";
        //static string[] Maps;
        ////static string map;
        //static int mapXs;
        //static int mapYs;
        //static void DrawMap()
        //{
        //    Directory.GetCurrentDirectory();
        //    try
        //    {
        //        Maps = File.ReadAllLines(filepath);

        //        foreach (string map in Maps)
        //        {
        //            //foreach (char mapChar in map)
        //            foreach (char mapTile in map)
        //            {
        //                // switch (mapChar)
        //                switch (mapTile)
        //                {
        //                    #region // colouring the individual tiles
        //                    case 'g': // Grass
        //                        Console.ForegroundColor = ConsoleColor.DarkYellow;
        //                        break;

        //                    case 'w': // Water
        //                        Console.ForegroundColor = ConsoleColor.Blue;
        //                        break;

        //                    case 'm': // Mountain
        //                        Console.ForegroundColor = ConsoleColor.Gray;
        //                        break;

        //                    case 't': // Trees
        //                        Console.ForegroundColor = ConsoleColor.Green;
        //                        break;
        //                    case 'b': // Base
        //                        Console.ForegroundColor = ConsoleColor.DarkGray;
        //                        break;

        //                    case '|': //Border
        //                        Console.ForegroundColor = ConsoleColor.Yellow;
        //                        break;

        //                    case '-': // Border
        //                        Console.ForegroundColor = ConsoleColor.Yellow;
        //                        break;

        //                    case '+': // Border
        //                        Console.ForegroundColor = ConsoleColor.Yellow;
        //                        break;
        //                        #endregion
        //                }

        //                Console.Write(mapTile);
        //            }
        //            Console.WriteLine();
        //        }
        //        Console.ResetColor();
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        Console.WriteLine($"Error: The file '{filepath}' was not found.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"An error occurred: {ex.Message}");
        //    }
        //}

        //static void mapLegend()
        //{
        //    Console.SetCursorPosition(output_X, output_Y + 11);
        //    string MapLegend =
        //    "+========= Map Legend ============+";
        //    Console.ForegroundColor = ConsoleColor.DarkYellow;
        //    Console.WriteLine($" {MapLegend}\n");

        //    Console.SetCursorPosition(output_X + 2, output_Y + 12);

        //    Console.ForegroundColor = ConsoleColor.DarkYellow;
        //    Console.Write("g = Grass  ");

        //    Console.ForegroundColor = ConsoleColor.Blue;
        //    Console.Write("w = Water  ");

        //    Console.ForegroundColor = ConsoleColor.Gray;
        //    Console.Write("m = Mountain  ");

        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.Write("t = Trees  ");

        //    Console.ForegroundColor = ConsoleColor.DarkGray;
        //    Console.Write("b = Base  ");

        //    Console.ResetColor();


        }
    }
}
