// See https://aka.ms/new-console-template for more information
using Method2.Application.MethodExtension;
using Method2.Application;
using Exercices;
using Operations;
using Programming_in_csharp;


/*WDatetime wdatetime = new WDatetime();
wdatetime.initializeDatetime();*/

//WString wstring = new WString();
//WBreakContinue wBreakContinue = new WBreakContinue();
//WEnum wEnum = new WEnum();
//WMagicString wMagicString = new WMagicString();
//TryCatch tryCatch = new TryCatch();
//WNullable nullable = new WNullable();
//Exercise1 exercise1 = new Exercise1();
//Exercise2 exercise2 = new Exercise2();
//Exercise3 exercise3 = new Exercise3();
//Exercise5 exercise5 = new Exercise5();
//Exercise6 exercise6 = new Exercise6();
//Exercise7 exercise7 = new Exercise7();
//Exercise8 exercise8 = new Exercise8();
//Exercise9 exercise9 = new Exercise9();
//Exercise10 exercise10 = new Exercise10();
//Exercise11 exercise11 = new Exercise11();
//Exercise12 exercise12 = new Exercise12();
//Exercise13 exercise13 = new Exercise13();
//Exercise14 exercise14 = new Exercise14();
//Exercise15 exercise15 = new Exercise15();
//Exercise16 exercise16 = new Exercise16();
//Exercise17 exercise17 = new Exercise17();
//Exercise18 exercise18 = new Exercise18();

/*var v1 = new ClassObject(new List<int> { 3, 4});
var v2 = new ClassObject(new List<int> { 1, 2});

ClassObject result = v1.Plus(v2);
ClassObject result2 = v1 + v2;
ClassObject prod = v1 * v2;
v1++;
*/

//double average = new Params().CalculateAverage(4,5,7,3,7,10,100);
//Console.WriteLine(average.ToString());

//Console.WriteLine(15.Power(2));
//Console.WriteLine(3.Power(3));
//Console.WriteLine(50.Double());

//var iteratorList = new Encapsulation();
//iteratorList.List = new List<int>() { 1, 2, 3 };
//iteratorList.WriteList();

//iteratorList.List = null;

//Console.WriteLine(iteratorList.WriteList);

//List<Animal> animals = new List<Animal>();
//animals.Add(new Cow("Maria"));
//animals.Add(new Sheep("Felipe"));

//foreach (var animal in animals)
//{
//    animal.MakeNoise();
//}

Animal cat = new Cat("Miki");
Animal pelican = new Pelican("Ariel");
Animal cow = new Cow("Maria");
Animal sheep = new Sheep("Martha");

AnimalMakeNoise(cat);
AnimalMakeNoise(pelican);
AnimalMakeNoise(cow);
AnimalMakeNoise(sheep);

static void AnimalMakeNoise(Animal animal) {
    animal.MakeNoise();
}
//48