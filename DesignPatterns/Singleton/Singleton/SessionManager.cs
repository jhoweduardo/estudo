namespace Singleton
{
    public class SessionManager
    {
        private static SessionManager instance;
        private static readonly object _lock = new object();
        private SessionManager() { }

        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime HorarioLogin { get; set; }

        public static SessionManager Instance
        {
            get {
                lock (_lock) 
                if (instance == null)
                    instance = new SessionManager();

                return instance; }
        }

        public void IniciarSessao(string nome, string email)
        {
            Nome = nome;
            Email = email;
            HorarioLogin = DateTime.Now;
        }

        public void ExibirSessao()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Horario de login: {HorarioLogin}");
        }
    }
}
