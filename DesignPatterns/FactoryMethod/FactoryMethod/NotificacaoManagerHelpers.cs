namespace FactoryMethod
{
    internal static class NotificacaoManagerHelpers
    {
        private static readonly object _lock = new object();
        private static NotificacaoManager instance;
        public static NotificacaoManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                        instance = new NotificacaoManager();

                    return instance;
                }
            }
        }
    }
}