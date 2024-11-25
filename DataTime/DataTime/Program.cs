using System.Globalization;

Console.WriteLine("Работа с датой и временем");
string data = "October 15, 2024";
string time = "01:45:32";
Console.WriteLine($"Дата: {data}");
Console.WriteLine($"Время: {time}");
DateOnly Data, Data2;
// ParseExact и TryParse
Data = DateOnly.ParseExact(data, "MMMM dd, yyyy", CultureInfo.InvariantCulture);
Data2 = DateOnly.TryParse(data, out DateOnly date) ? date : DateOnly.MaxValue; 
Console.WriteLine($"\r\nParseExact: {Data}");
Console.WriteLine($"TryParse: {Data2}");
// Parse и TryParseExact
TimeOnly Time, Time2;
string format = "HH.mm.ss";
Time = TimeOnly.Parse(time, CultureInfo.InvariantCulture);
Time2 = TimeOnly.TryParseExact(time, format, out TimeOnly times) ? times : TimeOnly.MinValue;
Console.WriteLine($"\r\nParse: {Time}");
Console.WriteLine($"Формат: {format}");
Console.WriteLine($"TryParseExact: {Time2}");

