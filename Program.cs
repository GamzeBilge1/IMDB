using IMDB;

List<Filmler> FilmBilgi = new List<Filmler>(); // Film bilgilerini saklamak için bir liste tanımlıyoruz

bool devamEt = true;

while (true)
{
    Console.WriteLine("Film adı giriniz");
    string film = Console.ReadLine();


    Console.WriteLine("IMDB puanı giriniz");
    double puan = Convert.ToDouble(Console.ReadLine());

    while (puan > 10 || puan < 0)  // IMDB puanının geçerli bir aralıkta olup olmadığı kontrol edilir
    {
        Console.WriteLine("0-10 arası bir puan giriniz.");
        puan = Convert.ToDouble(Console.ReadLine());
    }

    // Yeni bir film nesnesi oluşturulur ve listeye eklenir

    Filmler yeniFilm = new Filmler(film, puan); 
    FilmBilgi.Add(yeniFilm);

    Console.WriteLine("yeni bir film eklemek ister misiniz");
    string cevap = Console.ReadLine().ToLower();

    if (cevap == "e" || cevap == "evet")
    {
        devamEt = true;  // Kullanıcı devam etmek istiyorsa döngü yeniden başlar

    }
    else
    {    // Kullanıcı hayır derse, tüm liste yazdırılır
        Console.WriteLine("\nIMDB Film Listesi:");
        foreach (var item in FilmBilgi)
        {
            Console.WriteLine($"Film: {item.Isim}, IMDB Puanı: {item.Puan}");

        }

        Console.WriteLine("\nIMDB Puanı 4 ile 9 arasında olan filmler:");
        foreach (var item in FilmBilgi)
        {
            if (item.Puan >= 4 && item.Puan <= 9)   // IMDB puanı 4 ile 9 arasında olan filmler yazdırılır
            {
                Console.WriteLine($"Film: {item.Isim}, IMDB Puanı: {item.Puan}");
            }
        }
        // 'a' harfi ile başlayan filmler yazdırılır
        Console.WriteLine("\n'A' harfi ile başlayan filmler:");
        foreach (var item in FilmBilgi)
        {
            if (item.Isim.StartsWith("a", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Film: {item.Isim}, IMDB Puanı: {item.Puan}");
            }
        }

        break; // Döngüden çıkılır
    }

   
}

