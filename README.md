# Hafta 5 – Kapanış

Bu proje, bir araba fabrikasında araba üretimini simüle eden bir **C# konsol uygulaması**dır. Uygulama, kullanıcıdan alınan bilgilerle araba nesneleri oluşturur ve liste halinde saklar.

---

## 🎯 Amaç

* Kullanıcıyla etkileşimli bir şekilde araba nesneleri oluşturmak.
* `goto` kullanarak belirli girişlerde tekrar giriş istemek.
* Hatalı girişleri engelleyerek programın çökmesini önlemek.
* Üretilen arabaları bir listede saklayarak program sonunda özet bilgi sunmak.

---

## 🧠 Mantık Özeti

1. Kullanıcıya araba üretmek isteyip istemediği sorulur.

   * **Evet**: Araba üretme adımlarına geçilir.
   * **Hayır**: Program sonlandırılır.
   * **Geçersiz cevap**: Uyarı mesajı gösterilir ve soru tekrar sorulur.
2. Araba üretilirken kullanıcıdan şu bilgiler alınır:

   * Seri Numarası
   * Marka
   * Model
   * Renk
   * Kapı Sayısı
3. **Üretim Tarihi** araba nesnesi oluşturulduğu anda otomatik olarak atanır.
4. Kapı sayısı sayısal değilse:

   * Uyarı mesajı verilir.
   * Kullanıcı tekrar kapı sayısı girmeye yönlendirilir.
5. Oluşturulan araba nesnesi `List<Araba>` listesine eklenir.
6. Kullanıcıya tekrar araba üretmek isteyip istemediği sorulur:

   * **Evet**: 2. adıma dönülür.
   * **Hayır**: Program sonlandırılır ve üretilen arabaların seri numaraları ile markaları listelenir.

---

## 🖨️ Örnek Program Akışı

```
Araba üretmek istiyor musunuz? (E/H): e
Seri Numarası: SN123
Marka: Toyota
Model: Corolla
Renk: Beyaz
Kapı Sayısı: dört
Hatalı giriş! Lütfen kapı sayısını sayısal olarak giriniz.
Kapı Sayısı: 4
Başka araba üretmek istiyor musunuz? (E/H): e
...
Başka araba üretmek istiyor musunuz? (E/H): h

=== Üretilen Arabalar ===
Seri No: SN123 - Marka: Toyota
Seri No: SN124 - Marka: Honda

Program sonlandı.
```

---

## 📌 Notlar

* `goto` komutu ile belirli hatalı girişlerde kullanıcı aynı adıma yönlendirilir.
* **Büyük/küçük harf duyarlılığı** ortadan kaldırılmıştır (`ToLower`).
* Üretim tarihi otomatik olarak atanır, kullanıcıdan istenmez.
