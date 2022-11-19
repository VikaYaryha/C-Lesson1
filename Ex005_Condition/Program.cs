Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine ();

if (username.ToLower () == "маша") //все буквы в username приводит в нижний регистр, 
//поэтому обязательно в ковычках писать все буквы в нижним регистре (не КАПСОМ)
{
    Console.WriteLine ("Ура, это же Маша!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine(username);
}