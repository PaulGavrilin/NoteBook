﻿string pathfinder = "C:/Users/PC-3 Lenovo/Desktop/Кружок робототехники и конструирования Клуб'OK";
DirectoryInfo di = new DirectoryInfo(pathfinder);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i = i + 1)
{
    System.Console.WriteLine(fi[i].Name);
}
//Rec
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = "C:/Users/PC-3 Lenovo/Desktop/GeekBrains";
CatalogInfo(path);