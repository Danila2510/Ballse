using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballse
{
    public interface IView
    {
        string Answer { set; }
        event EventHandler<EventArgs> ClickAnsw;
    }
}
