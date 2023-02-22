Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")         // при использовании ToLower при вводе буквы верхнего регистра преобразуются в буквы нижнего регистра
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}


