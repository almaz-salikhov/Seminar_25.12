// Дана строка, замените всее вхождения запятых на пробелы 

string str = "Hello,world,hello";
string[] splittedStr = str.Split(',');
// запятая уже не будет фигурировать, как элемент, посольку она просто разделитель 
// сплит ищет переданный аргумент (запятая) и делит строку по этим аргументам
// а результат она будет помещать в массив 

string result = String.Empty; // инициализация пустой строки 
foreach (string s in splittedStr)
{
    result = result + s + ' ';
}

// Подходы записи инициализации пустой строки 

string epmtyStr1 = string.Empty;

string epmtyStr2 = String.Empty;

string epmtyStr3 = "";