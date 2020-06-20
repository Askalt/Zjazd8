using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    public class LabelGenerator:IControlGenerator
    {
        public Control Generate()
        {
            return new Label()
            {
                Content = "My/label"
            };
        }
    }
}
