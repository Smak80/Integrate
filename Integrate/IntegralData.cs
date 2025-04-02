using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Integrate
{
    public enum Method { MiddleRect, Trapezoid, Simpson };
    public class IntegralData : INotifyPropertyChanged
    {
        private string _function = "";
        private double _lowLimit;
        private double _highLimit;
        private int _parts;
        private double? _result = null;
        private Method _method = Method.MiddleRect;

        public string Function 
        {
            get => _function; 
            set 
            { 
                _function = value;
                OnPropertyChanged();
            }
        }
        public double LowLimit
        {
            get => _lowLimit;
            set
            {
                _lowLimit = value;
                OnPropertyChanged();
            }
        }
        public double HighLimit
        {
            get => _highLimit;
            set
            {
                _highLimit = value;
                OnPropertyChanged();
            }
        }
        public int Parts
        {
            get => _parts;
            set
            {
                _parts = value;
                OnPropertyChanged();
            }
        }
        public double? Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public Method Method
        {
            get => _method;
            set
            {
                _method = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
