using System;

/**
 * <summary>
 * Player
 * 
 * Class for players. Has attributes name and class
 * 
 * name: players name
 * points: players points
 * 
 * Player can be created either as a blank object or with name and points
 * </summary>
 */
namespace ScrabbleCounter
{
    public class Player
    {
        private string name;
        private int points;


        public Player(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public Player()
        {
            this.name = "";
            this.points = 0;
        }

        /**
         * Method AddPoints adds the given amount of points for player
         * 
         * points: amount of points to be added
         */
        public void AddPoints(int points)
        {
            this.points += points;
        }

        /**
         * Method Remove points removes the amount of points from points
         * 
         * points: amount of points to be removed from player
         */
        public void RemovePoints(int points)
        {
            this.points -= points;
        }


        /**
         * Method GiveName gives a name to the player
         * 
         * name: name to be given to player
         */
        public void GiveName(string name)
        {
            this.name = name;
        }
    }
}
