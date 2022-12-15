using ConsoleApp6;

Isogram isogram = new Isogram();
while (true)
{
    Console.WriteLine($"Введите слово для проверки на то изограмма ли оно");
    string word = Console.ReadLine();
    isogram.CheckingTheIsogram(word);
}