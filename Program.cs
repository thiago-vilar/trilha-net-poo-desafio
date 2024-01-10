using DesafioPOO.Models;

    Console.WriteLine("\n");
    Nokia nokia = new Nokia("123456789", "Nokia Lumia", "IMEI123456789", 512);
    nokia.Ligar();
    nokia.InstalarAplicativo("WhatsApp");

    Console.WriteLine("\n");
    Iphone iphone = new Iphone("987654321", "iPhone 13", "IMEI987654321", 2048);
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Telegram");
    Console.WriteLine("\n");

//implementar (sequência bash)
//git config --global user.name "Thiago Vilar"
//git config --global user.email "oceanocabral@gmail.com"
//git status
//git add .
//git commit -m "Desafio concluído(att versão .NET8.0-alteração .csproj)"
//git push