//Console.WriteLine("Witam wszystkich,jestem Tomek!");

//Napisz w Program.cs kod, w ktorym: 
//-zdeklarujesz zmienna z imieniem
//-zdeklarujesz zmienna z plcia (dobierz odpowiednia)
//-zdeklarujesz zmienna z wiekiem
//A nastepnie napisz kilka instrukcji warunkowych,
//ktore przeanalizuja te dane w nastepujacy sposob:
//(1) jesli mamy doczynienia z kobieta i ma ona ponizej 30lat, 
//to zwroci komunikat "Kobieta ponizej 30 lat."
//(2) jesli mamy do czynienia z osoba o imieniu Ewa i ma ona rowne 30 lat, to zwroci komunikat:
//"Ewa, 30 lat."
//(3) jesli mamy do czynienia z mezczyzna i ma ponizej 18 lat zwroci komunikat:
//"Niepelnoletni mezczyzna"
//(4) jesli dane nie spelniaja zadnego z warunkow program nie zwraca nic.


using Microsoft.VisualBasic.FileIO;

string name = "Tomasz";
int age = 30;
string sex = "male";


if (sex == "male" && age < 30)
{
    Console.WriteLine("Mezczyzna ponizej 30 Lat.");
}
else if (name == "Tomasz" && age == 30)
{
    Console.WriteLine("Tomasz Lat 30.");
}
else if (age < 18 && sex == "male")
{
    Console.WriteLine("Niepelnoletni mezczyzna.");
}

