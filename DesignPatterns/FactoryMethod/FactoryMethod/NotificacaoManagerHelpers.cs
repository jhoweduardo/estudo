namespace FactoryMethod
{
    internal static class NotificacaoManagerHelpers
    {
        private static readonly object _lock = new object();
        private static NotificacaoManager instance;
    }
}