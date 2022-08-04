Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "максим")
{
    Console.WriteLine("Ура, добро пожаловать " + username);
}
else
{
    Console.Write("Привет, " + username);
    Console.WriteLine();
}