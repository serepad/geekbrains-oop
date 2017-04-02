using System;

namespace snake
{
    class FoodCreator
    {
        int mapWidth;
        int MapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int MapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.MapHeight = MapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, MapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}