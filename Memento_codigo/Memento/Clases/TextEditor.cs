using Memento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Clases
{
    //Este es el originador
    public class TextEditor : IOriginator
    {
        private string _content;

        //constructor
        public TextEditor(string content)
        {
            this._content = content;
            Console.WriteLine($"TextEditor: Contenido inicial: \"{_content}\"");
        }

        //Actualiza la info, cambia el estado
        public void SetContent(string content)
        {
            this._content = content;
            Console.WriteLine($"TextEditor: Contenido actualizado: \"{_content}\"");
        }

        //Guarda el contenido
        public IMemento Save()
        {
            return new TextEditorMemento(this, _content);
        }
    }
}
