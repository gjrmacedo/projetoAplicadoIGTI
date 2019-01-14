using System;

namespace Empregando.Domain.Commands
{
    public abstract class Command : ICommand
    {
        public DateTime Timestamp { get; private set; }

        public abstract bool Valido();

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}