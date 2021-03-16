using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace library_accounting_system.Services
{
    class PageService
    {
        private Stack<Page> _history;

        public event Action<Page> OnPageChanged;
        public bool CanGoToBack => _history.Skip(1).Any();

        public PageService()
        {
            _history = new Stack<Page>();
        }

        public void Navigate(Page page)
        {
            OnPageChanged?.Invoke(page);
            _history.Push(page);
        }

        internal void GoToBack()
        {
            _history.Pop();
            var page = _history.Peek();
            OnPageChanged?.Invoke(page);
        }
    }
}
