//ДЗ задача номер 4

Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

int [] myArray;
myArray = new int [3];
myArray[0] = a ;
myArray[1] = b ;
myArray[2] = c ;

int max = myArray[0];

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > max) {
        max = myArray[i];
    }
}

Console.WriteLine("MAX: "+ max );

