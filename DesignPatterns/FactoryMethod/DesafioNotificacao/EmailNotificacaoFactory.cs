﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class EmailNotificacaoFactory : NotificacaoFactory 
    {
        public override INotificacao CriarNotificacao() => new EmailNotificacao();
    }
}
