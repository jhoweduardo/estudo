﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SmsNotificacao : INotificacao
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"[SMS] Enviando: {mensagem}");
        }
    }
}
