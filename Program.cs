
/* # Задача 39
**Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

/* // создает рандомный массив int
int[] RandomArrayInt(int elements, int min, int max){
    int[] array = new int[elements];
    for(int i = 0; i < elements; i++){
        array[i] = new Random().Next(min, max + 1);
    }
    
    return array;
} 

// метод возвращает строку из массива int
string ArrayIntToString(int[] arr){
    string result = "[";

    for(int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1){
            result = result + $"{arr[i]}, ";
        } else {
            result = result + $"{arr[i]}";
        }
    }

    result = result + "]";

    return result;
}

int[] array = RandomArrayInt(10, 100, 999);
int[] newArray = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    newArray[i] = array[array.Length - i -1];
}

System.Console.Write($"{ArrayIntToString(array)} -> {ArrayIntToString(newArray)}"); */


/* **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет,
 может ли существовать треугольник с сторонами такой длины.

 **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.
*/

/* System.Console.Write($"Введите число 1 ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Введите число 2 ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Введите число 3 ");
int z = Convert.ToInt32(Console.ReadLine());

if ( x < (y + z) && y < (x +z) && z < (x + y)){
    System.Console.WriteLine($"Треугольник");
} else {
    System.Console.WriteLine($"Не треугольник");
}
 */
/* **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

/* System.Console.Write($"Введите число ");
int dec = Convert.ToInt32(Console.ReadLine());

string binary = string.Empty;

while (dec != 0) {
    binary = Convert.ToString(dec % 2) + binary;
    dec = dec / 2;
}

System.Console.WriteLine($"{binary}"); */


/* **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

// метод возвращает строку из массива int
string ArrayIntToString(int[] arr){
    string result = "[";

    for(int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1){
            result = result + $"{arr[i]}, ";
        } else {
            result = result + $"{arr[i]}";
        }
    }

    result = result + "]";

    return result;
}

System.Console.Write($"Введите число ");
int dec = Convert.ToInt32(Console.ReadLine());
int[] f = new int[dec];

    f[0] = 0;
    f[1] = 1;
for (int i = 2; i < dec; i++){
    f[i] = f[i - 1] + f[i -2]; 
}

System.Console.Write($"{dec} -> {ArrayIntToString(f)}");

/* Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. */

