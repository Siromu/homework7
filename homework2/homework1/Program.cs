/* 1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.*/


Console.WriteLine("Введите Ваше имя: ");
string name = Console.ReadLine();

Console.WriteLine("Введите Вашу фамилию: ");
string surname = Console.ReadLine();

Console.WriteLine("Введите Ваш возраст: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Ваш рост в метрах: ");
double height = double.Parse(Console.ReadLine());

/* double height = double.Parse(Console.ReadLine());
   height = height / 100; - получаем рост в см */

Console.WriteLine("Введите Ваш вес в кг: ");
int weight = int.Parse(Console.ReadLine());


Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);

Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", name, surname, age, height, weight);

Console.WriteLine($"Имя: {name} Фамилия: {surname} Возраст: {age} Рост: {height} Вес: {weight}");


/*2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
где m — масса тела в килограммах, h — рост в метрах.*/

var imt = (weight / (Math.Pow(height, 2)));

string resultImt = string.Format("{0:F2}", imt); //ограничение вывода после запятой

Console.WriteLine($"Ваше IMT равно: {resultImt}");


/* 3.
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода. */


float Distance(float x1, float x2)
{
    var distance = x2 - x1;
    return distance;
}

var r = Math.Sqrt(Math.Pow(Distance(1, 4), 2) + Math.Pow(Distance(5, 6), 2));

Console.WriteLine($"Расстояние между точками равно: {string.Format("{0:F2}", r)}"); //тоже самое, что и с использованием переменной 



/* 4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
а) с использованием третьей переменной;
б) *без использования третьей переменной. */

int a = 1;
int b = 3;

(a, b) = (b, a);

/* 
a = a + b;
b = a - b;
a = a - b; - то же самое, что и (a, b) = (b, a);
*/

Console.WriteLine($"{a}, {b}");


/* 5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организовать в центре экрана.
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y). */

void Print(string name, string surname, string city)
{
    Console.WriteLine($"{name} {surname} {city}");

}

Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2); // середина экрана
Print("Саша", "Вернер", "Павлодар");
