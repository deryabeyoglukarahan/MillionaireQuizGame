int dogruSayisi = 0;

//1.soru 
Console.WriteLine("1 -> Türkiye'nin başkenti neresidir?");
Console.WriteLine("a) İstanbul    b) Ankara");
string cevap1 = Console.ReadLine().ToLower();

if (cevap1 == "b")
{
    Console.WriteLine("Doğru cevap!");
    dogruSayisi++;
}
else
{
    Console.WriteLine("Yanlış cevap!");
}

//2.soru
Console.WriteLine("\n2 -> Türk bayrağındaki ay ve yıldız hangi renktedir?");
Console.WriteLine("a) Beyaz    b) Kırmızı");
string cevap2 = Console.ReadLine().ToLower();

if (cevap2 == "a")
{
    Console.WriteLine("Doğru cevap!");
    dogruSayisi++;
}
else
{
    Console.WriteLine("Yanlış cevap!");
}

// Eğer ilk iki soruda 2'de en az 1 doğru yapılmış ise, 3. soru sorulur
if (dogruSayisi >= 1)
{
    // 3. Soru
    Console.WriteLine("\n3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
    Console.WriteLine("a) 7    b) 12");
    string cevap3 = Console.ReadLine().ToLower();

    if (cevap3 == "b")
    {
        Console.WriteLine("Doğru cevap!");
        dogruSayisi++;
    }
    else
    {
        Console.WriteLine("Yanlış cevap!");
    }
}

// Eğer ilk iki soruda 2'de 0 yapılmışsa, 3. soru sorulmaz
else
{
    Console.WriteLine("\nİlk iki soruda yeterli doğru yanıt alınamadı. 3. soru sorulmuyor.");
}

// En az 2 doğru yapılmışsa ödül kazanılır, 2'den az doğru sayısı varsa yarışma kaybedilir.
Console.WriteLine("\nToplam doğru cevap sayınız: " + dogruSayisi);
if (dogruSayisi >= 2)
{
    Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
}
else
{
    Console.WriteLine("Üzgünüz, büyük ödülü kazanamadınız.");
}