using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clue
{
    internal class Board
    {
        List<Room> rooms;

        int[,] board;

        public Board()
        {
            // Initialize the board with rooms and layout
            rooms = new List<Room>();
            board = new int[25, 25]; // Example size, adjust as needed
            // Initialize rooms and their positions on the board
            //InitializeRooms();
        }


    }
}
