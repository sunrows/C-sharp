//Перевод римских чисел
// III -> 3
// LVIII -> 58
//MCMXCIV -> 1994


int RomeToArabic (char sumbol)
{
    // Возвращает арабское число соответствующие входной римской цифре

    string romeNumeric = "IVXLCDM";
    int [] arabicNumeric = new int [7] {1, 5, 10, 50, 100, 500, 1000};
    int index = romeNumeric.IndexOf(sumbol);
    if (index >=0) return arabicNumeric [index];
    return 0; //  если не найден символ римских цифр, возвращаем 0

}


int RomeNumberParse(string romeNumber)
{
    int result = 0;
    for (int i = 0; i<romeNumber.Length; i++)
    {
        int currentNumber = RomeToArabic(romeNumber[i]);
        if (currentNumber == 0)
        {
            // Выбрасиваем исключения если обнаружен неверный символ
            throw new Exception("Invalid character in the Roman notation of the number!");
        }
        if (i+1<romeNumber.Length)
        {
            // Если есть следующая цифра
            if (currentNumber < RomeToArabic(romeNumber[i+1]))
            {
                result -= currentNumber;
            }
            else 
            {
                result += currentNumber;
            }
        }
        else
        // Обработка последней цифры 
        { 
            result += currentNumber;
        }

    }
    return result;
}


// проверка по значениям из задания 

string[] exampleRome = {"III", "LVIII", "MCMXCIV"};
foreach (var item in exampleRome)
{
    int arabicNumber = RomeNumberParse(item);
    Console.WriteLine($"{item} = {arabicNumber}");   
}