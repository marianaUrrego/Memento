using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_clasesAnidadas.Clases
{
    internal class Caretaker
    {
        private readonly Stack<TextEditor.Memento> history = new();
        private readonly TextEditor editor;

        public Caretaker(TextEditor editor)
        {
            this.editor = editor;
        }

        public void Save()
        {
            history.Push(editor.Save());
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                editor.Restore(history.Pop());
            }
        }
    }
}
