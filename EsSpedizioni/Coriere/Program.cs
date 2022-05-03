// See https://aka.ms/new-console-template for more information
using Coriere;
using EsSpedizioni;

var corriere1 = new CoriereSpedizioni("Fedex");
var corriere2 = new CoriereSpedizioni("DHL");
var corriere3 = new CoriereSpedizioni("Poste Italaine");

var VincitoreConcorso = new Plico("Samsung", "Sr Eduardo", "ab123", 4, 2, 3);
var Multa = new Plico("Polizia Locale","Sr Carlo", "cd456", 10, 2, 3);
var paccoAmazon = new Pacco("Amazon", "via dante ", "ef789", 140, 30, 20, 14);
var paccoEbay = new Pacco("Ebay", "via livello ", "hg739", 100, 20, 20, 34);

corriere3.AddSpedizione(VincitoreConcorso);
corriere3.AddSpedizione(Multa);

corriere2.AddSpedizione(paccoAmazon);
corriere1.AddSpedizione(paccoEbay);

Console.WriteLine("lista Spedizione di corriere");
Console.WriteLine(Environment.NewLine);
Console.WriteLine(corriere3.GetSpedizioni());
Console.WriteLine($"con un totale di ingombro di {corriere3.GetTotalIngombro()}");
//CancellaTutteSpedizioni
corriere3.CancellaTutteSpedizioni();
Console.WriteLine("******************************************************");
Console.WriteLine("lista Spedizione di corriere");
Console.WriteLine(Environment.NewLine);
Console.WriteLine(corriere3.GetSpedizioni());
Console.ReadLine();


