using System.ComponentModel;
using onallo.Client.Models;


namespace onallo.Client.ViewModels.BaseClass
{
    public class RectangleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private RectangleModel _rectangle = new RectangleModel();

        public double Width
        {
            get => _rectangle.Width;
            set
            {
                if (_rectangle.Width != value)
                {
                    _rectangle.Width = value;
                    OnPropertyChanged(nameof(Width));
                    OnPropertyChanged(nameof(Area));
                }
            }
        }

        public double Height
        {
            get => _rectangle.Height;
            set
            {
                if (_rectangle.Height != value)
                {
                    _rectangle.Height = value;
                    OnPropertyChanged(nameof(Height));
                    OnPropertyChanged(nameof(Area));
                }
            }
        }

        public double Area => _rectangle.Area;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
