using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SmsNotificacaoFactory : NotificacaoFactory
    {
        public override INotificacao CriarNotificacao() => new SmsNotificacao();
    }
}
