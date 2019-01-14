namespace Empregando.Domain.Commands
{
    public class RegistrarNovoUsuarioCommand : Command
    {
        public string Email { get; private set; }

        public string Senha { get; private set; }

        public string Nome { get; private set; }

        public RegistrarNovoUsuarioCommand(string email, string senha, string nome)
        {
            Email = email;
            Senha = senha;
            Nome = nome;
        }

        public override bool Valido()
        {
            if (string.IsNullOrEmpty(Email))
                return false;

            if (string.IsNullOrEmpty(Senha))
                return false;

            if (string.IsNullOrEmpty(Nome))
                return false;

            return true;
        }
    }
}
