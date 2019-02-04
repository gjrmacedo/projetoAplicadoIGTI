using Empregando.Domain.Commands;

namespace Empregando.Domain.CommandHandlers
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Handle(T command);
    }
}