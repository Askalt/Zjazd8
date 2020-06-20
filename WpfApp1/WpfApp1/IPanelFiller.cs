using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    public interface IPanelFiller
    {
        void Fill(Panel panel,int number);
    }
}
