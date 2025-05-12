using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clue
{
    internal class GameManager
    {
        List<Player> players;
        int currentPlayerIndex;
        List<Card> solution;
        Board board;

        public void StartGame(int playerCount)
        {
            // Initialize the game with the specified number of players
            players = new List<Player>();
            currentPlayerIndex = 0;
            // Initialize the board
            board = new Board();
            // Create players
            for (int i = 0; i < playerCount; i++)
            {
                players.Add(new Player(i));
            }
            // Shuffle deck and deal cards
            DealCards();
            // Set up solution
            //SetupSolution();
        }

        private void DealCards()
        {
            // Logic to shuffle the deck and deal cards to players
            // For example, shuffle the deck and distribute cards to players
            // You can implement this method based on your game rules
        }

        private void NextTurn()
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
        }
    }
}
