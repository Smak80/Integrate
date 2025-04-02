using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Integrate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IntegralData _integralData;
        public MainWindow()
        {
            InitializeComponent();
            _integralData = new IntegralData()
            {
                Function = "cos(x)",
                LowLimit = 0,
                HighLimit = 1,
                Parts = 10
            };
            DataContext = _integralData;

        }
    }
}