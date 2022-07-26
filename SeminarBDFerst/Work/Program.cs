//Скрипт
string result = string.Empty;
string[] marks = { "отличник", "ударник", "троечик" };
for (int i = 0; i < 10; i++)
{
    string ferstName = $"Имя_{i}";
    string lastName = $"Имя_{i}";
    int id = i;
    string mark = marks[new Random().Next(marks.Length)];
    result += $"{id}\t{ferstName}\t{lastName}\t{mark};\n";
}

//Console.WriteLine($"{result}");
File.WriteAllText("table.xls", result, System.Text.Encoding.UTF32);

/* Псевдокод:
   Model-ученики
    id
    ferstName
    lastName
    mark */