
string[] dictionary;


// Programm block
dictionary = CreateAndFillArray();
System.Console.WriteLine("Вывод на экран изначального массива: ");
PrintArray(dictionary);
System.Console.WriteLine("");
dictionary = ReshapeArray(dictionary);
System.Console.WriteLine("Вывод на экран массива в котором только строки чья длина меньше или равна 3: ");
PrintArray(dictionary);




// Implementation of functions
string[] CreateAndFillArray()
{
    int size = 0;
    string input;
    int i = 0;
    System.Console.WriteLine("Введите размер массива слов: ");
    size = int.Parse(Console.ReadLine()!);
    
    dictionary = new string[size];

    while(i < size){
        System.Console.WriteLine("Заполните массив: ");
        input = Console.ReadLine()!;
        dictionary[i] = input;
        i++;
    }
    return dictionary;
}

string[] ReshapeArray(string[] dictionary)
{
    string[] newdictionary;
    int count = 0;
    for(int i = 0; i < dictionary.Length; i++){
        if(dictionary[i].Length <= 3){
            count++;
        }
    }
    newdictionary = new string[count];
    count = 0;

    for(int i = 0; i < dictionary.Length; i++){
        if(dictionary[i].Length <= 3){
            newdictionary[count] = dictionary[i];
            count++;
        }
    }
    return newdictionary;
}

void PrintArray(string[] dictionary)
{
    foreach(var item in dictionary){
        System.Console.Write(item + " ");
    }
}