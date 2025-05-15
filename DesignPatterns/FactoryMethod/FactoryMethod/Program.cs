using FactoryMethod;

var manager = NotificacaoManager.Instance;
manager.EnviarMensagem(new EmailNotificacaoFactory(), "Bem-vindo!");
manager.EnviarMensagem(new SmsNotificacaoFactory(), "Código: 1234");
manager.EnviarMensagem(new PushNotificacaoFactory(), "Você recebeu uma nova mensagem");
