using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memento.Interfaces;

namespace Memento.Clases
{
    //Este es el cuidador
    internal class Caretaker
    {
        //solo guarda mementos
        private readonly List<IMemento> _history = new();

        //Deshace el contenido
        public void Undo()
        {
            if (_history.Count == 0) return;

            var memento = _history[^1];
            _history.RemoveAt(_history.Count - 1);

            Console.WriteLine("Caretaker: Restaurando al estado anterior...");
            memento.Restore();
        }

        //Agrega mementos(como guardar el historial)
        public void AddMemento(IMemento memento)
        {
            _history.Add(memento);
        }
    }
}
