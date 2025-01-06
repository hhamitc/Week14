# Identity ve Data Protection Uygulaması

Bu proje, ASP.NET Core Web API kullanarak kimlik doğrulama ve yetkilendirme işlemlerini gerçekleştiren bir uygulamadır. Identity ve Entity Framework Core kullanılarak geliştirilmiştir.

## Özellikler

- Kullanıcı kaydı ve girişi
- Güvenli şifre hashleme
- Email format kontrolü
- Kapsamlı validation kontrolleri
- Swagger UI ile API dokümantasyonu

## Kullanılan Teknolojiler

- ASP.NET Core 8.0
- Entity Framework Core
- Microsoft Identity
- SQL Server
- Swagger/OpenAPI

## Gereksinimler

- .NET 8.0 SDK
- SQL Server
- Visual Studio 2022 veya VS Code

## Kurulum

1. Projeyi klonlayın:
```bash
git clone [repo-url]
```

2. Veritabanı bağlantı dizesini `appsettings.json` dosyasında güncelleyin:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=IdentityPracticeDb;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true"
  }
}
```

3. Migration'ları uygulayın:
```bash
dotnet ef database update
```

4. Projeyi çalıştırın:
```bash
dotnet run
```

## API Endpoint'leri

### Kullanıcı Kaydı
```http
POST /api/User/register
```
Request body:
```json
{
    "email": "user@example.com",
    "password": "Test123!"
}
```

### Kullanıcı Girişi
```http
POST /api/User/login
```
Request body:
```json
{
    "email": "user@example.com",
    "password": "Test123!"
}
```

## Şifre Politikası

Şifreler aşağıdaki kurallara uygun olmalıdır:
- En az 6 karakter uzunluğunda
- En az bir büyük harf
- En az bir küçük harf
- En az bir sayı
- En az bir özel karakter

## Validation Kontrolleri

- Email adresi geçerli formatta olmalıdır
- Email ve şifre alanları zorunludur
- Şifre belirlenen politikaya uygun olmalıdır

## Güvenlik Özellikleri

- Şifreler hash'lenerek saklanır
- Identity altyapısı ile güvenli kimlik doğrulama
- Model validation ile veri güvenliği

## Test

Swagger UI üzerinden API'yi test edebilirsiniz:
```
https://localhost:7106/swagger
```

## Hata Kodları

- 200: İşlem başarılı
- 400: Geçersiz istek (validation hatası)
- 401: Yetkisiz erişim
- 500: Sunucu hatası

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. 