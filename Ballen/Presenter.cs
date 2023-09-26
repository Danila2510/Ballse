using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballse
{
    public class Presenter
    {
        private readonly IModel _model;
        private readonly IView _view;
        public Presenter (IModel model, IView view)
        {
            _model = model;
            _view = view;
            _view.ClickAnsw += new EventHandler<EventArgs>(Show);
        }
        private void Show(object sender, EventArgs e)
        {
            _model.Show();
            _view.Answer = _model.Result;
        }
    }
}
