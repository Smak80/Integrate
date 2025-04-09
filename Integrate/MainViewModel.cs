using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Integrate
{
    public class MainViewModel : INotifyPropertyChanged
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

        public void OnIntegrate()
        {
            try
            {


                Result = Method switch
                {
                    Method.MiddleRect => IntegralData.IntegrateByMiddleRect(
                          new NCalc.Expression(Function),
                          LowLimit,
                          HighLimit,
                          Parts
                        ),
                    Method.Trapezoid => IntegralData.IntegrateByTrapezoid(
                          new NCalc.Expression(Function),
                          LowLimit,
                          HighLimit,
                          Parts
                        ),
                    Method.Simpson => IntegralData.IntegrateBySimpson(
                          new NCalc.Expression(Function),
                          LowLimit,
                          HighLimit,
                          Parts
                        )
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Неверная функция: " );
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
