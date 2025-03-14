using System;
using Memento_codigo.Interfaces;

namespace Memento_codigo.Clases
{
    internal class TextEditorMemento : IMemento
    {
        private readonly TextEditor _originator;
        private readonly string _state;

        public TextEditorMemento(TextEditor originator, string state)
        {
            _originator = originator;
            _state = state;
        }

        public void Restore()
        {
            _originator.RestoreState(_state);
        }
    }
}
