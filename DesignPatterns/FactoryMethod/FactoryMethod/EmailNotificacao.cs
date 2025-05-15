﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class EmailNotificacao : INotificacao
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"[Email] Enviando: {mensagem}");
        }
    }
}
