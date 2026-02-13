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
        private string filepath1 = "map1.txt";
        public string[] Maps;

        public void MapLoader()
        {
            try
            {
                Maps = File.ReadAllLines(filepath1);
                Console.Clear(); // Ensure screen is fresh

                foreach (string line in Maps)
                {
                    foreach (char mapTile in line)
                    {
                        SetTileColor(mapTile);
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

        // This is vital! When a player moves off a tile, call this to put the map back.
        public void DrawTileAt(int x, int y)
        {
            if (y < 0 || y >= Maps.Length || x < 0 || x >= Maps[y].Length) return;

            char tile = Maps[y][x];
            Console.SetCursorPosition(x, y);
            SetTileColor(tile);
            Console.Write(tile);
            Console.ResetColor();
        }

        private void SetTileColor(char tile)
        {
            switch (tile)
            {
                case '#': Console.ForegroundColor = ConsoleColor.Gray; break;
                case '%': Console.ForegroundColor = ConsoleColor.Red; break;
                case 'G': Console.ForegroundColor = ConsoleColor.Cyan; break;
                case '@': Console.ForegroundColor = ConsoleColor.Magenta; break;
                case '|': Console.ForegroundColor = ConsoleColor.Yellow; break;
                case '-': Console.ForegroundColor = ConsoleColor.Yellow; break;
                case '+': Console.ForegroundColor = ConsoleColor.Yellow; break;
                default: Console.ForegroundColor = ConsoleColor.White; break;
            }
        }

        public bool CanMoveTo(int tarMapX, int tarMapY)
        {
            // Safety check if map failed to load
            if (Maps == null) return false;

            // Boundary Check
            if (tarMapY >= 0 && tarMapY < Maps.Length && tarMapX >= 0 && tarMapX < Maps[tarMapY].Length)
            {
                char tarTile = Maps[tarMapY][tarMapX];

                switch (tarTile)
                {
                    case '#':
                    case '|':
                    case '-':
                    case '+':
                    case '!':
                    case '&':
                        return false; // Walls and borders  player  and enemy are blocked

                    default:
                        return true; // Spaces and Lava are walkable
                }
            }
            return false;
        }









        //    /*  Array of strings for the map data

        //      draw method . 





        //      */

        //    string filepath1 = "map1.txt";
        //    string filepath2 = "map2.txt";
        //    public string[] Maps;


        //    public void MapLoader()
        //    {
        //        String Filepath = filepath1;

        //        try
        //        {
        //            Maps = File.ReadAllLines(Filepath);

        //            foreach (string map in Maps)
        //            {

        //                foreach (char mapTile in map)
        //                {

        //                    switch (mapTile)
        //                    {
        //                        #region // colouring the individual tiles
        //                        case '#': // WALL
        //                            Console.ForegroundColor = ConsoleColor.Gray;
        //                            break;
        //                        case '%': // Lava
        //                            Console.ForegroundColor = ConsoleColor.Red;
        //                            break;
        //                        case 'G': // Goal
        //                            Console.ForegroundColor = ConsoleColor.Cyan;
        //                            break;

        //                        case '|': //Border
        //                            Console.ForegroundColor = ConsoleColor.Yellow;
        //                            break;

        //                        case '-': // Border
        //                            Console.ForegroundColor = ConsoleColor.Yellow;
        //                            break;

        //                        case '+': // Border
        //                            Console.ForegroundColor = ConsoleColor.Yellow;
        //                            break;
        //                            #endregion
        //                    }

        //                    Console.Write(mapTile);
        //                }
        //                Console.WriteLine();
        //            }
        //            Console.ResetColor();
        //        }
        //        catch (FileNotFoundException)
        //        {
        //            Console.WriteLine($"Error: The file '{filepath1}' was not found.");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"An error occurred: {ex.Message}");
        //        }


        //    }
        //  public bool CanMoveTo(int tarMapX, int tarMapY)
        //    {
        //        if (tarMapY >= 0 && tarMapY < Maps.Length && tarMapX >= 0 && tarMapX < Maps[tarMapY].Length)
        //        {
        //            char tarTile = Maps[tarMapY][tarMapX];

        //            switch (tarTile)
        //            {
        //                case '#': //defines un traversable
        //                case '@':
        //                case '&':

        //                    return false;

        //                case ' ':  //verifies traversable

        //                case '%':
        //                    return true;

        //                default:
        //                    return true;
        //            }
        //        }
        //        return false;


        //    }


        //}
    }
}