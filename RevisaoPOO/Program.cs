int opcao = 0;
do{
    System.Console.WriteLine("===MENU===");
    System.Console.WriteLine("1. Cadastrar Usuário");
    System.Console.WriteLine("2. Cadastrar Livro");
    System.Console.WriteLine("3. Realizar Empréstimo");
    System.Console.WriteLine("4. Devolver Livro");
    System.Console.WriteLine("5. Sair");
    System.Console.WriteLine("Escolha uma opção: ");
    try
    {
        opcao = int.Parce(Console.ReadLine());
        switch (opcao)
        {
           case 1:
            break;
           case 2:
            break;
           case 3:
            break;
           case 4:
            break;
           case 5:
            System.Console.WriteLine("Saindo...");
            break;
            
        }
    }
    catch (System.Exception)
    {
        
        System.Console.WriteLine("Opção inválida. Tente novamente.");
        Console.ReadKey();
    }
} while (opcao !=5);