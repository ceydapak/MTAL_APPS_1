

## 📌 Tüm Uygulamalarda Altın Kurallar (Bunu Unutma!)

1. **TextBox'tan Gelen Veri Yazıdır (`string`):** 
   * `TextBox` içerisine yazılan her şey bilgisayar için bir metindir. Metinlerle matematiksel toplama, çıkarma veya çarpma yapamazsın!
   * Sayısal işlem yapabilmek için mutlaka `Convert.ToInt32()` veya `Convert.ToDouble()` kullanmalısın.

2. **Sonucu Ekrana Yazdırırken Metne Çevir (`.ToString()`):**
   * Hesapladığın sayısal sonucu bir `TextBox` veya `Label` içinde göstermek istediğinde, sayının sonuna `.ToString()` ekleyerek tekrar metne dönüştürmelisin.

3. **Cümle Sonlarına Noktalı Virgül (`;`) Koy:**
   * C# dilinde her kod satırının sonuna `;` koymak zorundasın. Unutursan kod çalışmaz ve kırmızı çizgi ile hata verir!

4. **Sonuç Kutularını Kitle (`Enabled = false`):**
   * Kullanıcının elle müdahale etmesini istemediğin (sadece sonucun yazdırılacağı) `TextBox` nesnelerinin özellikler (`Properties`) penceresinden `Enabled` değerini `false` yapmalısın.

---

## 📝 Uygulama Yönergeleri

### 🎥 Uygulama 1: Sinema Bilet Tutarı Hesaplama

> **Amaç:** Farklı bilet türlerinin sayılarını alıp toplam tutarı hesaplamak.

* 💡 **Dikkat Etmen Gerekenler:**
  * Bilet adetleri yarım veya buçuklu olamayacağı için `int` (tamsayı) veri tipini kullan.
  * Dönüştürme yaparken `Convert.ToInt32()` komutundan yararlan.
  * **İşlem Mantığı:** Öğrenci bilet adedini 60 ile, tam bilet adedini 100 ile çarptıktan sonra bu iki değeri topla.

---

### ⭕ Uygulama 2: Daire Alan ve Çevre Hesaplama

> **Amaç:** Yarıçapı girilen dairenin alanını ve çevresini hesaplamak.

* 💡 **Dikkat Etmen Gerekenler:**
  * Yarıçap veya Pi sayısı ondalıklı olabileceği için değişkenlerini `double` türünde tanımla.
  * `TextBox`'tan yarıçapı okurken `Convert.ToDouble()` kullan.
  * **Alan Formülü:** $\pi \times r \times r$ (`pi * yaricap * yaricap`)
  * **Çevre Formülü:** $2 \times \pi \times r$ (`2 * pi * yaricap`)

---

### 📚 Uygulama 3: Ders Ortalaması Hesaplama

> **Amaç:** 3 notun ortalamasını doğru işlem sırasıyla bulmak.

* 💡 **Dikkat Etmen Gerekenler:**
  * Sınav notları veya ortalama ondalıklı çıkabileceği için `double` veri tipini seç.
  * **İşlem Önceliğine Dikkat:** Notları toplarken mutlaka **parantez** kullanmalısın!
    * ❌ **Yanlış:** `yazili1 + yazili2 + performans / 3` *(Sadece performansı 3'e böler)*
    * ✅ **Doğru:** `(yazili1 + yazili2 + performans) / 3` *(Önce tüm notları toplar, sonra 3'e böler)*

---

### 📝 Uygulama 4: Net Hesaplama

> **Amaç:** Doğru ve yanlış sayılarından net sayısını bulmak.

* 💡 **Dikkat Etmen Gerekenler:**
  * 4 yanlış 1 doğruyu götürdüğü için yanlış sayısını her zaman 4'e bölmelisin.
  * Netler ondalıklı çıkabileceği için (örn: `33.75`) tüm değişkenleri `double` yap.
  * **İşlem Mantığı:** `dogru - (yanlis / 4)`
  * Formdaki Türkçe ve Matematik alanlarını karışmaması için bir `GroupBox` nesnesi içinde gruplayabilirsin.

---

## 🛠️ Sık Yapılan Hatalar ve Çözümleri

* **Hata:** `Cannot implicitly convert type 'double' to 'string'`
  * **Çözüm:** Sayısal sonucu `Text` özelliğine aktarırken sonuna `.ToString()` eklemeyi unuttun.
* **Hata:** `Input string was not in a correct format.`
  * **Çözüm:** `TextBox` boşken veya harf yazılıyken hesapla butonuna bastın. İçine sadece sayı girdiğinden emin ol.

  https://www.baamboozle.com/game/4864838