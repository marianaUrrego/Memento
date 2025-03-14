using Memento.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

var editor = new TextEditor("Hello, World!");
var caretaker = new Caretaker();

caretaker.AddMemento(editor.Save());
editor.SetContent("Holi");

caretaker.AddMemento(editor.Save());
editor.SetContent("Patrón Memento");

caretaker.AddMemento(editor.Save());
editor.SetContent("Esto es un ejemplo de editor de texto.");

Console.WriteLine("\nCaretaker: Deshaciendo cambio");
caretaker.Undo();
caretaker.Undo();