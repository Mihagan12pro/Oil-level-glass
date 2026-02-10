namespace Oil_level_glass.Model.Data.Other
{
    public class RGB
    {
        public int Red { get; set; }

        public int Green { get; set; }

        public int Blue { get; set; }

        public int Color
        {
            get
            {
                return ((Red | (Green << 8)) | (Blue << 16));
            }
        }

        public RGB(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
