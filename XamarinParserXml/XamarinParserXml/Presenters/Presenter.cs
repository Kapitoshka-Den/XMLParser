using System;
using System.Collections.Generic;
using System.Text;
using XamarinParserXml.Views;

namespace XamarinParserXml.Presenters
{
    abstract public class Presenter
    {
        protected IView _view;

        public Presenter(IView view)
        {
            _view= view;
        }
    }
}
