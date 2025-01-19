# 🎥 IMDB Film Listesi Uygulaması

Bu uygulama, kullanıcıdan film adı ve IMDB puanı alarak bir film listesi oluşturur. Kullanıcı istediği kadar film ekleyebilir ve ardından listeyi belirli kriterlere göre filtreleyerek görüntüleyebilir.

---

## 📋 Özellikler
- Kullanıcıdan **film adı** ve **IMDB puanı (0-10)** alınır.
- IMDB puanı **4 ile 9** arasında olan filmleri listeler.
- `a` veya `A` harfi ile başlayan filmleri listeler.
- Kullanıcı istediği kadar film ekleyebilir.
- Filmler listeye eklendikten sonra topluca görüntülenir.

---

## 🚀 Nasıl Çalışır?
1. Kullanıcıya bir film adı ve IMDB puanı girmesi istenir.
2. Girilen IMDB puanının **0 ile 10** arasında olup olmadığı kontrol edilir.
3. Girilen film bilgileri bir listeye eklenir.
4. Kullanıcı, yeni bir film ekleyip eklememek istediğine dair yönlendirilir:
   - **Evet (E/e):** Yeni bir film ekleme ekranına geri döner.
   - **Hayır (H/h):** Listeleme işlemleri başlar.
5. Uygulama, tüm film listesini ve belirli kriterlere uygun filmleri ekrana yazdırır.

---

## 📂 Kod Yapısı
- **Filmler Sınıfı:**
  - Film adı ve IMDB puanı için gerekli özellikleri (`Isim`, `Puan`) tutar.
  - Film nesnelerini oluşturmak için parametreli bir constructor sağlar.
  
- **Ana Döngü:**
  - Sonsuz bir `while` döngüsü ile çalışır.
  - Kullanıcıdan veri toplar ve listeyi günceller.

---

## 🎯 Örnek Kullanım

### Girdi:
- Film adı: `Avatar`
- IMDB puanı: `8.5`
- Yeni film eklemek isteği: `Evet`
- Film adı: `Avengers`
- IMDB puanı: `9.0`
- Yeni film eklemek isteği: `Hayır`

### Çıktı:
1. Tüm Filmler:
   - Avatar, 8.5
   - Avengers, 9.0
2. IMDB Puanı 4 ile 9 Arasında Olan Filmler:
   - Avatar, 8.5
   - Avengers, 9.0
3. `A` Harfi ile Başlayan Filmler:
   - Avatar, 8.5
   - Avengers, 9.0


