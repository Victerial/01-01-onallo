namespace onallo.Client.Models
{
    public class RectangleModel
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;
    }
}
