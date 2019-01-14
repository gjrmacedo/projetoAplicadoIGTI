using System;

namespace Empregando.Domain.Commands
{
    public interface ICommand
    {
        DateTime Timestamp { get; }
        bool Valido();
    }
}