using Memento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Clases
{
    //este es el memento
    class TextEditorMemento : IMemento
    {
        private readonly TextEditor _editor;
        private readonly string _content;

        //constructor
        public TextEditorMemento(TextEditor editor, string content)
        {
            _editor = editor;
            _content = content;
        }
        
        //Devuelve el contenido al estado anterior
        public void Restore()
        {
            _editor.SetContent(_content);
        }
    }
}
