using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class NotificacaoManager
    {
        private static NotificacaoManager instance;
        private static readonly object _lock = new object();

        private INotificacao _notificacao;

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

        public void EnviarMensagem(NotificacaoFactory factory, string mensagem)
        {
            _notificacao = factory.CriarNotificacao();

            _notificacao.Enviar(mensagem);
        }

    }
}
