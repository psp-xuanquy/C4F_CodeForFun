using System;


Console.Write("Moi ban nhap 1 nam bat ky: ");
int year = int.Parse(s: Console.ReadLine());
string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
string[] Chi = { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui" };

Console.WriteLine($"Nam {year} co nam am lich la: {Can[year % 10].ToUpper()} {Chi[year % 12].ToUpper()}");
