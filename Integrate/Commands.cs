using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Integrate
{
    public class Commands
    {
        public static RoutedCommand Integrate {  get; set; }
        static Commands()
        {
            Integrate = new RoutedCommand(nameof(Integrate), typeof(MainWindow));
        }
    }
}
