 TESYS - Teknik Servis Yönetim Sistemi
TESYS, özellikle tarım makineleri ve ağır vasıta teknik servislerinin operasyonel süreçlerini dijitalleştirmek, stok takibini otomatize etmek ve proaktif arıza analizi yapmak amacıyla geliştirilmiş profesyonel bir ERP (Kurumsal Kaynak Planlama) yazılımıdır.

##  Öne Çıkan Özellikler

Proaktif Risk ve Sağlık Analizi: Makinelerin son servis tarihlerini baz alarak gün farkı hesabı yapar ve "Yeşil/Sarı/Kırmızı" indikatörlerle bakım zamanı gelen araçları raporlar.

Katmanlı Mimari (N-Tier): Kodun sürdürülebilirliği için Presentation, Business, Data Access ve Entity katmanları birbirinden ayrılmıştır.

Gelişmiş Raporlama: DevExpress Reporting motoru ile tek tıkla profesyonel PDF servis formları ve envanter dökümleri oluşturur.

Dinamik Stok Yönetimi: Yedek parçalar için kritik stok eşiği belirleme ve otomatik maliyet hesaplama özelliklerine sahiptir.

Müşteri & Makine İlişkisel Takibi: Bir müşteriye bağlı birden fazla makinenin tüm servis geçmişini kronolojik olarak saklar.

 Teknik Şematik (Tech Stack)
Dil: C# (.NET Framework)

Arayüz: DevExpress UI Components

Veritabanı: Microsoft SQL Server (MSSQL)

Mimari: N-Tier Architecture (Katmanlı Mimari)

ORM / Veri Erişim: ADO.NET & SQL Client

Proje Yapısı



Firat.Tesys.Solution
├── Firat.Tesys.Business    # İş Mantığı ve Validasyonlar (BLL)


├── Firat.Tesys.DataAccess  # SQL Sorguları ve Bağlantı Yönetimi (DAL)


├── Firat.Tesys.Forms       # Kullanıcı Arayüzü (UI - DevExpress)


├── Firat.Tesys.Interface   # Soyutlama ve Interface Tanımları


└── Firat.Tesys.Service     # Ortak Servis ve Yardımcı Fonksiyonlar





Mühendislik Metrikleri
Proje, akademik standartlarda geliştirilmiş olup aşağıdaki analizlere tabi tutulmuştur:

McCabe Cyclomatic Complexity: Ortalama fonksiyon karmaşıklığı 3.2 (Düşük riskli ve yüksek test edilebilir).

Function Point (İN) Analizi: Proje hacmi yaklaşık 4.500+ satır özgün koddan oluşmaktadır.

Kurulum (Setup)
Veritabanı klasörü içindeki .sql scriptini SQL Server üzerinde çalıştırın.

Firat.Tesys.DataAccess katmanındaki bağlantı dizesini (Connection String) kendi sunucunuza göre güncelleyin.

Visual Studio üzerinden projeyi Build edin ve çalıştırın.

👨‍💻 Geliştirici
Tevfik Metin
