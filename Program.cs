using MedienBibliothek;

string id = Guid.NewGuid().ToString();
Console.WriteLine(id);

Song song1 = new Song(id, "YSL-Beezy");
song1.Seconds = 187;
Console.WriteLine("Minuten: {0}", song1.Minutes);