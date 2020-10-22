using System;
using System.Text.RegularExpressions;

namespace IRobo.Domain
{
    public class Bot
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int DirectionGraus { get; set; }
        public string DirectionDescription { get; set; }

        public MapArea MapArea { get; set; }


        public Bot()
        {
            PositionX = 0;
            PositionY = 0;
            DirectionGraus = 0;
            DirectionDescription = "N";
            MapArea = new MapArea();
        }

        public bool ValidCommand(string command)
        {
            bool valid = true;

            char[] characters = command.ToUpper().ToCharArray();
            foreach (var item in characters)
            {
                if (item != 'M' && item != 'L' && item != 'R')
                   return valid = false;
            }
            return valid;
        }

        public string Action(string command)
        {
            char[] characters = command.ToCharArray();

            foreach (var item in characters)
            {
                switch (item)
                {
                    case 'M':
                        this.MoveBot();
                        break;
                    case 'L':
                        this.Direction(item.ToString());
                        break;
                    case 'R':
                        this.Direction(item.ToString());
                        break;
                    default:
                        break;
                }
            }

            return string.Format("({0},{1},{2})", PositionX, PositionY, GetDescriptionDirection(DirectionGraus));
        }

        private void MoveBot()
        {
            switch (this.DirectionGraus)
            {
                case 0:
                    if (this.MapArea.ValidAxis(this.PositionY + 1))
                        this.PositionY += 1;
                    break;
                case 90:
                    if (this.MapArea.ValidAxis(this.PositionX + 1))
                        this.PositionX += 1;
                    break;
                case 180:
                    if (this.MapArea.ValidAxis(this.PositionY - 1))
                        this.PositionY -= 1;
                    break;
                case 270:
                    if (this.MapArea.ValidAxis(this.PositionX - 1))
                        this.PositionX -= 1;
                    break;
                default:
                    break;
            }
        }

        public string GetDescriptionDirection(int DirectionGraus)
        {
            switch (DirectionGraus)
            {
                case 0:
                    DirectionDescription = "N";
                    break;
                case 90:
                    DirectionDescription = "E";
                    break;
                case 180:
                    DirectionDescription = "S";
                    break;
                case 270:
                    DirectionDescription = "W";
                    break;
            }
            return DirectionDescription;
        }

        public int Direction(string param)
        {
            if (param == "L")
            {
                if (this.DirectionGraus == 0)
                    this.DirectionGraus = 360;

                this.DirectionGraus = this.DirectionGraus - 90;
            }
            else
            {
                this.DirectionGraus = this.DirectionGraus + 90;

                if (this.DirectionGraus == 360)
                    this.DirectionGraus = 0;
            }
            return this.DirectionGraus;
        }
    }
}
