using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballse
{
    public interface IModel
    {
        string Result { get; set; }
        void Show();
    }
}
