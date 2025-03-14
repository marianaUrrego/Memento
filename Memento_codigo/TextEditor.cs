using System;
using Memento_codigo.Interfaces;

namespace Memento_codigo.Clases
{
    internal public class TextEditor : IOriginator
    {
        private string _content;

        public void Write(string text)
        {
            _content = text;
            Console.WriteLine($"Editor: Escribiendo \"{_content}\"");
        }

        public IMemento Save()
        {
            return new TextEditorMemento(this, _content);
        }

        public void RestoreState(string state)
        {
            _content = state;
            Console.WriteLine($"Editor: Estado restaurado a \"{_content}\"");
        }
    }
}
