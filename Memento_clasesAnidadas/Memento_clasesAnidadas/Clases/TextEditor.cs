using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_clasesAnidadas.Clases
{
    internal class TextEditor
    {
        private string content; // Estado interno

        public TextEditor(string content)
        {
            this.content = content;
        }

        public void SetContent(string newContent)
        {
            content = newContent;
        }

        public Memento Save()
        {
            return new Memento(content);
        }

        public void Restore(Memento memento)
        {
            if (memento != null)
            {
                content = memento.GetState();
            }
        }
        public override string ToString()
        {
            return content;
        }

        // Clase anidada Memento
        public class Memento
        {
            private readonly string state;

            internal Memento(string state)
            {
                this.state = state;
            }

            internal string GetState()
            {
                return state;
            }
        }
    }
}
