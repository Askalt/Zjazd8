using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    class PanelFiller : IPanelFiller
    {
        private readonly IControlGenerator _controlGenerator;
        public PanelFiller(IControlGenerator controlGenerator)
        {
            _controlGenerator = controlGenerator;
        }
        public void Fill(Panel panel,int number)
        {
            for (int i = 0; i < number; i++)
            {
                panel.Children.Add(_controlGenerator.Generate());
            }
        }
    }
}
