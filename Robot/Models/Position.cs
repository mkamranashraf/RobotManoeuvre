using Robot.Helpers;

namespace Robot.Models
{
    public class Position
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Directions CurrentDirection { get; set; }

        public Position(int x, int y, Directions direction)
        {
            this.PosX = x;
            this.PosY = y;
            this.CurrentDirection = direction;
        }
        public override string ToString()
        {
            return $"Output: {PosX},{PosY},{CurrentDirection}";
        }
    }
}
