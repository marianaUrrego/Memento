// See https://aka.ms/new-console-template for more information
using Memento_clasesAnidadas.Clases;

TextEditor editor = new("Versión inicial");
Caretaker caretaker = new(editor);

Console.WriteLine("Estado actual: " + editor);

caretaker.Save();
editor.SetContent("Primera edición");
Console.WriteLine("Después de edición: " + editor);

caretaker.Save();
editor.SetContent("Segunda edición");
Console.WriteLine("Después de segunda edición: " + editor);

caretaker.Undo();
Console.WriteLine("Deshacer: " + editor);

caretaker.Undo();
Console.WriteLine("Deshacer otra vez: " + editor);