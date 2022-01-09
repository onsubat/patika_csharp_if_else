// See https://aka.ms/new-console-template for more information

int saat = DateTime.Now.Hour;

if (saat <= 10)
    Console.WriteLine("Sabah şerifleriniz hayır olsun efenim.");
else if (saat >= 11 && saat <= 16)
    Console.WriteLine("Tünaydınlar efenim.");
else
    Console.WriteLine("Hayırlı akşamlar dilerim efenim.");

string sonuc;

sonuc = saat <= 10 ? "Tekrar günaydınlar." : saat >= 11 && saat <= 16 ? "Size tünaydın demiştim değil mi?" : "İyi geceler dileğiyle.";

Console.WriteLine(sonuc);