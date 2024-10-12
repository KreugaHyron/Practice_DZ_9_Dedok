//1-3
using Practice_DZ_9_Dedok;

Console.WriteLine("Task_1,2,3(array): ");
int[] array = { 5, 18, 27, 945, 1008, 15, 22, 9, 13, 7, 56 };

int product = array.Aggregate((a, b) => a * b);
Console.WriteLine($"Добуток елементів масиву: {product}");

int count = array.Count();
Console.WriteLine($"Кількість елементів масиву: {count}");

int countMultiplesOfNine = array.Count(x => x % 9 == 0);
Console.WriteLine($"Кількість елементів, кратних 9: {countMultiplesOfNine}");

int countMultiplesOfSevenGreaterThan945 = array.Count(x => x % 7 == 0 && x > 945);
Console.WriteLine($"Кількість елементів, кратних 7 і більших за 945: {countMultiplesOfSevenGreaterThan945}");

int sum = array.Sum();
Console.WriteLine($"Сума елементів масиву: {sum}");

int sumEvenNumbers = array.Where(x => x % 2 == 0).Sum();
Console.WriteLine($"Сума парних елементів масиву: {sumEvenNumbers}");

int min = array.Min();
Console.WriteLine($"Мінімум в масиві: {min}");

int max = array.Max();
Console.WriteLine($"Максимум в масиві: {max}");

double average = array.Average();
Console.WriteLine($"Середнє значення в масиві: {average}");

var top3Max = array.OrderByDescending(x => x).Take(3);
Console.WriteLine("Три перші максимальні елементи: " + string.Join(", ", top3Max));

var top3Min = array.OrderBy(x => x).Take(3);
Console.WriteLine("Три перші мінімальні елементи: " + string.Join(", ", top3Min));

var frequencyStats = array.GroupBy(x => x)
                          .Select(group => new { Number = group.Key, Count = group.Count() });
Console.WriteLine("Статистика входження кожного числа:");
foreach (var stat in frequencyStats)
{
    Console.WriteLine($"{stat.Number} – {stat.Count} рази");
}

var evenFrequencyStats = array.Where(x => x % 2 == 0)
                              .GroupBy(x => x)
                              .Select(group => new { Number = group.Key, Count = group.Count() });
Console.WriteLine("Статистика входження парних чисел:");
foreach (var stat in evenFrequencyStats)
{
    Console.WriteLine($"{stat.Number} – {stat.Count} рази");
}

int evenCount = array.Count(x => x % 2 == 0);
int oddCount = array.Count(x => x % 2 != 0);
Console.WriteLine($"Парні – {evenCount} рази, Непарні – {oddCount} рази");
Console.WriteLine();
//4
Console.WriteLine("Task_4(Laptop): ");
var laptops = new List<Laptop>
        {
            new Laptop { Model = "XPS 13", Manufacturer = "Dell", ProcessorFrequency = 2.6, Cores = 4, Price = 1200, Year = 2020 },
            new Laptop { Model = "MacBook Air", Manufacturer = "Apple", ProcessorFrequency = 2.8, Cores = 4, Price = 1500, Year = 2021 },
            new Laptop { Model = "Aspire 5", Manufacturer = "Acer", ProcessorFrequency = 2.0, Cores = 4, Price = 700, Year = 2019 },
            new Laptop { Model = "Yoga Slim 7", Manufacturer = "Lenovo", ProcessorFrequency = 2.3, Cores = 4, Price = 850, Year = 2022 },
            new Laptop { Model = "ThinkPad X1", Manufacturer = "Lenovo", ProcessorFrequency = 2.5, Cores = 6, Price = 2000, Year = 2021 }
        };

int totalLaptops = laptops.Count();
Console.WriteLine($"Кількість ноутбуків: {totalLaptops}");

decimal minPrice = 1000; 
int countExpensiveLaptops = laptops.Count(l => l.Price > minPrice);
Console.WriteLine($"Кількість ноутбуків з вартістю більше {minPrice}: {countExpensiveLaptops}");

decimal lowerBound = 800;
decimal upperBound = 1500;
int countLaptopsInRange = laptops.Count(l => l.Price >= lowerBound && l.Price <= upperBound);
Console.WriteLine($"Кількість ноутбуків в діапазоні {lowerBound} - {upperBound}: {countLaptopsInRange}");

string manufacturer = "Lenovo";
int countByManufacturer = laptops.Count(l => l.Manufacturer == manufacturer);
Console.WriteLine($"Кількість ноутбуків виробника {manufacturer}: {countByManufacturer}");

var cheapestLaptop = laptops.OrderBy(l => l.Price).First();
Console.WriteLine($"Ноутбук з мінімальною вартістю: {cheapestLaptop}");

var mostExpensiveLaptop = laptops.OrderByDescending(l => l.Price).First();
Console.WriteLine($"Ноутбук з максимальною вартістю: {mostExpensiveLaptop}");

var slowestLaptop = laptops.OrderBy(l => l.ProcessorFrequency).First();
Console.WriteLine($"Ноутбук з найменшою частотою процесору: {slowestLaptop}");

var newestLaptop = laptops.OrderByDescending(l => l.Year).First();
Console.WriteLine($"Найновіша модель ноутбуку: {newestLaptop}");

var averagePrice = laptops.Average(l => l.Price);
Console.WriteLine($"Середня вартість ноутбуків: {averagePrice}");

var manufacturerStats = laptops.GroupBy(l => l.Manufacturer)
                               .Select(group => new { Manufacturer = group.Key, Count = group.Count() });
Console.WriteLine("Статистика за кількістю ноутбуків кожного виробника:");
foreach (var stat in manufacturerStats)
{
    Console.WriteLine($"{stat.Manufacturer} – {stat.Count} ноутбуки(ів)");
}

var modelStats = laptops.GroupBy(l => l.Model)
                        .Select(group => new { Model = group.Key, Count = group.Count() });
Console.WriteLine("Статистика за кількістю моделей ноутбуків:");
foreach (var stat in modelStats)
{
    Console.WriteLine($"{stat.Model} – {stat.Count} модель(і)");
}

var yearStats = laptops.GroupBy(l => l.Year)
                       .Select(group => new { Year = group.Key, Count = group.Count() });
Console.WriteLine("Статистика ноутбуків за роками:");
foreach (var stat in yearStats)
{
    Console.WriteLine($"{stat.Year} – {stat.Count} ноутбук(и)");
}

var top5Expensive = laptops.OrderByDescending(l => l.Price).Take(5);
Console.WriteLine("П'ять найдорожчих ноутбуків:");
foreach (var laptop in top5Expensive)
{
    Console.WriteLine(laptop);
}

var top5Cheapest = laptops.OrderBy(l => l.Price).Take(5);
Console.WriteLine("П'ять найдешевших ноутбуків:");
foreach (var laptop in top5Cheapest)
{
    Console.WriteLine(laptop);
}

var top3Oldest = laptops.OrderBy(l => l.Year).Take(3);
Console.WriteLine("Три найстаріші моделі ноутбуків:");
foreach (var laptop in top3Oldest)
{
    Console.WriteLine(laptop);
}

var top3Newest = laptops.OrderByDescending(l => l.Year).Take(3);
Console.WriteLine("Три найновіші моделі ноутбуків:");
foreach (var laptop in top3Newest)
{
    Console.WriteLine(laptop);
}
Console.WriteLine();
//5
Console.WriteLine("Task_5(order): ");
int[] numbers = { 1, 2, 8, -1, 4, 2, 7, 9, 15, 5 };

int maxLength = FindMaxIncreasingSubsequenceLength(numbers);
Console.WriteLine($"Довжина найбільшої зростаючої послідовності: {maxLength}");
static int FindMaxIncreasingSubsequenceLength(int[] numbers)
{
    if (numbers.Length == 0) return 0;

    int maxLength = 1;  
    int currentLength = 1;  
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > numbers[i - 1])
        {
            currentLength++;  
        }
        else
        {
            maxLength = Math.Max(maxLength, currentLength);  
            currentLength = 1;  
        }
    }
    maxLength = Math.Max(maxLength, currentLength);

    return maxLength;
}
Console.WriteLine();
//6
Console.WriteLine("Task_6(surnames): ");
string[] surnames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Martinez", "Wilson", "Anderson", "Taylor" };

bool allMoreThanThree = surnames.All(s => s.Length > 3);
Console.WriteLine($"Чи всі прізвища мають довжину більше трьох символів? {allMoreThanThree}");

bool allMoreThanThreeAndLessThanTen = surnames.All(s => s.Length > 3 && s.Length < 10);
Console.WriteLine($"Чи всі прізвища мають довжину більше трьох і менше десяти символів? {allMoreThanThreeAndLessThanTen}");

bool anyStartsWithW = surnames.Any(s => s.StartsWith("W"));
Console.WriteLine($"Чи є в масиві прізвище, яке починається з 'W'? {anyStartsWithW}");

bool anyEndsWithY = surnames.Any(s => s.EndsWith("y", StringComparison.OrdinalIgnoreCase));
Console.WriteLine($"Чи є в масиві прізвище, яке закінчується на 'Y'? {anyEndsWithY}");

bool containsOrange = surnames.Contains("Orange");
Console.WriteLine($"Чи є у масиві прізвище 'Orange'? {containsOrange}");

string firstWithSixLetters = surnames.FirstOrDefault(s => s.Length == 6);
Console.WriteLine($"Перше прізвище з довжиною 6 символів: {firstWithSixLetters}");

string lastWithLessThanFifteenLetters = surnames.LastOrDefault(s => s.Length < 15);
Console.WriteLine($"Останнє прізвище з довжиною менше 15 символів: {lastWithLessThanFifteenLetters}");
Console.WriteLine();
//7
Console.WriteLine("Task_7(journal): ");
Journal[] journals = {
            new Journal { Title = "Політика України", Genre = "Політика", Pages = 40, PublicationDate = new DateTime(2022, 6, 1) },
            new Journal { Title = "Модні тренди", Genre = "Мода", Pages = 50, PublicationDate = new DateTime(2021, 3, 15) },
            new Journal { Title = "Спорт для всіх", Genre = "Спорт", Pages = 35, PublicationDate = new DateTime(2023, 8, 5) },
            new Journal { Title = "Сад та городник", Genre = "Сад та город", Pages = 25, PublicationDate = new DateTime(2020, 11, 20) },
            new Journal { Title = "Рибалка з друзями", Genre = "Рибалка", Pages = 28, PublicationDate = new DateTime(2022, 9, 30) },
            new Journal { Title = "Мисливець та рибалка", Genre = "Полювання", Pages = 45, PublicationDate = new DateTime(2019, 12, 10) },
            new Journal { Title = "Автомобілі сьогодні", Genre = "Авто", Pages = 33, PublicationDate = new DateTime(2022, 5, 18) }
        };
bool allMoreThan30Pages = journals.All(j => j.Pages > 30);
Console.WriteLine($"У всіх журналів кількість сторінок більше 30: {allMoreThan30Pages}");

bool allSpecificGenres = journals.All(j => j.Genre == "Політика" || j.Genre == "Мода" || j.Genre == "Спорт");
Console.WriteLine($"Всі журнали у жанрі «Політика», «Мода» або «Спорт»: {allSpecificGenres}");

bool anyGardenGenre = journals.Any(j => j.Genre == "Сад та город");
Console.WriteLine($"Є хоча б один журнал у жанрі «Сад та город»: {anyGardenGenre}");

bool anyFishingGenre = journals.Any(j => j.Genre == "Рибалка");
Console.WriteLine($"Є хоча б один журнал у жанрі «Рибалка»: {anyFishingGenre}");

bool containsHuntingGenre = journals.Any(j => j.Genre.Equals("Полювання", StringComparison.OrdinalIgnoreCase));
Console.WriteLine($"Є журнали про «Полювання»: {containsHuntingGenre}");

Journal first2022Journal = journals.FirstOrDefault(j => j.PublicationDate.Year == 2022);
Console.WriteLine($"Перший журнал з роком випуску 2022: {first2022Journal?.Title ?? "Немає"}");

Journal lastAutoJournal = journals.LastOrDefault(j => j.Title.StartsWith("Авто"));
Console.WriteLine($"Останній журнал, назва якого починається зі слова «Авто»: {lastAutoJournal?.Title ?? "Немає"}");
Console.WriteLine();
//8
Console.WriteLine("Task_8(another one order): ");
int[] randomNumbers = { 1, 2, 8, -1, 4, 2, 7, 9, 15, 5 };

var sequences = randomNumbers
    .Select((n, i) => new { Number = n, Index = i })
    .Where(x => x.Number > 0)
    .Aggregate(new List<List<int>> { new List<int>() }, (list, item) =>
{
if (list.Last().Count > 0 && item.Index == list.Last().LastIndex() + 1)
{
list.Last().Add(item.Number);
}
else
{
list.Add(new List<int> { item.Number });
}
return list;
});

var maxSequence = sequences.OrderByDescending(seq => seq.Count).FirstOrDefault();

if (maxSequence != null)
{
Console.WriteLine($"Довжина найбільшої додатної послідовності: {maxSequence.Count}");
Console.WriteLine("Послідовність: " + string.Join(" ", maxSequence));
}
else
{
Console.WriteLine("Додатні послідовності не знайдені.");
}
public static class Extensions
{
    public static int LastIndex(this List<int> list)
    {
        return list.Count - 1;
    }
}