
# Single Responsibility Principle

**SingleResponsibilityPrinciple** projesi, SOLID prensiplerinden biri olan **Single Responsible Principle (SRP)**'ni uygulamalı olarak göstermek için geliştirilmiş bir örnek projedir. Bu prensip, bir sınıfın yalnızca tek bir sorumluluğa sahip olması gerektiğini ve değişikliklerin yalnızca o sorumlulukla ilgili nedenlerden kaynaklanması gerektiğini belirtir.

## Özellikler

- **SOLID Prensipleri**: Tek Sorumluluk Prensibi uygulanarak yazılmış sınıf yapıları.
- **Katmanlı Mimari**: İş ve veri katmanlarının ayrılması.
- **Bağımlılıkların Ayrımı**: İşlemler için farklı sınıflar kullanılarak bağımlılıkların minimalize edilmesi.

## Teknolojiler

- **.NET 7.0**
- **C#**
- **Entity Framework Core**
- **Console Application**

## Kurulum

### Gereksinimler

- .NET 7.0 SDK
- Visual Studio veya Visual Studio Code

### Adımlar

1. Depoyu klonlayın:

   ```bash
   git clone https://github.com/Minelka/SingleResponsibilityPrinciple.git
   ```

2. Proje dizinine gidin:

   ```bash
   cd SingleResponsibilityPrinciple
   ```

3. Bağımlılıkları yükleyin:

   ```bash
   dotnet restore
   ```

4. Uygulamayı çalıştırın:

   ```bash
   dotnet run
   ```

## Proje Yapısı

```
SingleResponsibilityPrinciple
├─ Models         # Veri modelleri
├─ Services      # İş servisleri
├─ Data          # Veritabanı işlemleri (Mock)
└─ Program.cs    # Başlatma noktası
```

### Açıklama

- **Models**: Uygulamada kullanılan veri modellerini içerir.
- **Services**: İş kurallarını ve işlemleri gerçekleştirir.
- **Data**: Mock veritabanı sınıflarını içerir.
- **Program.cs**: Ana dosya, uygulamanın çalıştırılmasını sağlar.

## Lisans

Bu proje açık kaynak değildir ve yalnızca izinli kullanıcılar tarafından kullanılabilir.
