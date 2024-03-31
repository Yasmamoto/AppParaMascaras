using BibliotecaDeMascara;

while (true)
{
    Mascaras.Menu();
    Console.Write("\nSelecione um calculo do menu...");
    byte menu = Convert.ToByte(Console.ReadLine());

    switch (menu)
    {
        case 1:
            Console.Write("Digite o seu telefone: ");
            string telefoneMsk = Console.ReadLine();

            Console.WriteLine($"Seu telefone sem mascara é: {Mascaras.RemoverMascaraTel(telefoneMsk)}");
            break;
        case 2:
            Console.Write("Digite o seu telefone: ");
            string telefone = Console.ReadLine();

            Console.WriteLine($"Seu telefone com mascara é: {Mascaras.AdicionarMascaraTel(telefone)}");
            break;
        case 3:
            Console.Write("Digite o seu CPF: ");
            string CpfMsk = Console.ReadLine();

            Console.WriteLine($"\nSeu CPF sem máscara é: {Mascaras.RemoverMascaraCPF(CpfMsk)}");
            break;
        case 4:
            Console.Write("Digite o seu CPF: ");
            string Cpf = Console.ReadLine();

            Console.WriteLine($"\nSeu CPF com máscara é: {Mascaras.AdicionarMascaraCPF(Cpf)}");
            break;
        case 5:
            Console.Write("Digite o seu CEP: ");
            string CepMsk = Console.ReadLine();
            Console.WriteLine($"\nSeu CEP sem máscara é: {Mascaras.RemoverMascaraCEP(CepMsk)}");
            break;
        case 6:
            Console.Write("Digite o seu CEP: ");
            string Cep = Console.ReadLine();
            Console.WriteLine($"\nSeu CEP sem máscara é: {Mascaras.AdicionarMascaraCEP(Cep)}");
            break;
        case 7:
            goto sair;
        default:
            Console.WriteLine("--> OPÇÃO INVÁLIDA!! <--");
            break;
    }
sair:;
}