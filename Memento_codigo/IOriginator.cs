using System;

namespace Memento_codigo.Interfaces
{
    public interface IOriginator
    {
        IMemento Save();
    }
}
