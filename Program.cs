﻿// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (Sõne) formaadis

Console.WriteLine("Please, enter your lastname:");
string userLastName = Console.ReadLine();

if(userGender == 'm')

{
    Console.WriteLine($"Welcome, Mr. {userLastName!");
}
else if(userGender == 'f')
{
    Console.WriteLine("$Welcome, Ms. {userLastName!");
}
Console.WriteLine($"Welcome, {userGender});

