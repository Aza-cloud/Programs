Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "азамат")
{
    Console.WriteLine("Ура, Это же АЗАМАТ!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}