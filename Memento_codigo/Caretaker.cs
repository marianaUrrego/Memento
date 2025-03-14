using System;
using System.Collections.Generic;

namespace Memento_codigo.Clases
{
    internal public class Caretaker
    {
        private readonly List<IMemento> _history = new List<IMemento>();
        private readonly TextEditor _editor;

        public Caretaker(TextEditor editor)
        {
            _editor = editor;
        }

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Guardando el estado...");
            _history.Add(_editor.Save());
        }

        public void Undo()
        {
            if (_history.Count == 0)
            {
                Console.WriteLine("Caretaker: No hay estados previos para restaurar.");
                return;
            }

            IMemento memento = _history[_history.Count - 1];
            _history.RemoveAt(_history.Count - 1);

            Console.WriteLine("Caretaker: Restaurando estado...");
            memento.Restore();
        }
    }
}