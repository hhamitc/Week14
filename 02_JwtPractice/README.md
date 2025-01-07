# JWT Kimlik Doğrulama Sistemi

Bu proje, ASP.NET Core Web API kullanılarak geliştirilmiş bir JWT (JSON Web Token) tabanlı kimlik doğrulama sistemi örneğidir. Kullanıcıların kayıt olmasına, giriş yapmasına ve korumalı kaynaklara erişmesine olanak tanır.

## 🚀 Özellikler

- Kullanıcı kaydı ve girişi
- JWT tabanlı kimlik doğrulama
- Korumalı ve herkese açık API endpoint'leri
- Entity Framework Core ile veritabanı entegrasyonu
- Swagger/OpenAPI desteği

## 🛠 Kullanılan Teknolojiler

- .NET 7.0
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT (JSON Web Tokens)
- Swagger/OpenAPI

## 📦 NuGet Paketleri

- Microsoft.AspNetCore.Authentication.JwtBearer (7.0.0)
- Microsoft.EntityFrameworkCore (7.0.0)
- Microsoft.EntityFrameworkCore.SqlServer (7.0.0)
- Microsoft.EntityFrameworkCore.Tools (7.0.0)
- Swashbuckle.AspNetCore (6.5.0)
- System.IdentityModel.Tokens.Jwt (7.0.0)

## 🚀 Kurulum

1. Projeyi klonlayın
2. SQL Server'ın yüklü olduğundan emin olun
3. `appsettings.json` dosyasındaki connection string'i kendi SQL Server ayarlarınıza göre güncelleyin
4. Package Manager Console'da aşağıdaki komutları çalıştırın:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
5. Projeyi çalıştırın:
   ```bash
   dotnet run
   ```

## 🔑 API Endpoint'leri

### Kimlik Doğrulama Endpoint'leri

#### Kullanıcı Kaydı
```http
POST /api/Auth/register
Content-Type: application/json

{
    "email": "kullanici@ornek.com",
    "password": "Sifre123!"
}
```

#### Kullanıcı Girişi
```http
POST /api/Auth/login
Content-Type: application/json

{
    "email": "kullanici@ornek.com",
    "password": "Sifre123!"
}
```

### Test Endpoint'leri

#### Herkese Açık Endpoint
```http
GET /api/Test/public
```

#### Korumalı Endpoint
```http
GET /api/Test/test
Authorization: Bearer [JWT_TOKEN]
```

## 🧪 Postman ile Test

1. **Kullanıcı Kaydı:**
   - Yeni bir POST isteği oluşturun
   - URL: `http://localhost:5053/api/Auth/register`
   - Headers:
     ```
     Content-Type: application/json
     ```
   - Body (raw - JSON):
     ```json
     {
         "email": "test@example.com",
         "password": "Test123!"
     }
     ```

2. **Giriş ve Token Alma:**
   - Yeni bir POST isteği oluşturun
   - URL: `http://localhost:5053/api/Auth/login`
   - Headers:
     ```
     Content-Type: application/json
     ```
   - Body (raw - JSON):
     ```json
     {
         "email": "test@example.com",
         "password": "Test123!"
     }
     ```
   - Response'da JWT token'ı alacaksınız

3. **Korumalı Endpoint'i Test Etme:**
   - Yeni bir GET isteği oluşturun
   - URL: `http://localhost:5053/api/Test/test`
   - Headers:
     ```
     Authorization: Bearer [Login'den aldığınız token]
     ```

## 📝 Önemli Notlar

- JWT token'ların geçerlilik süresi 60 dakikadır
- Güvenlik için tüm hassas bilgiler `appsettings.json` dosyasında saklanmaktadır
- Development ortamında Swagger UI'a `http://localhost:5053/swagger` adresinden erişilebilir
- Veritabanı bağlantı ayarlarını kendi ortamınıza göre güncellemeyi unutmayın

## 🔒 Güvenlik Önlemleri

- Token doğrulama parametreleri aktif:
  - Yayıncı doğrulama (Issuer)
  - Hedef kitle doğrulama (Audience)
  - Süre doğrulama (Lifetime)
  - İmza anahtarı doğrulama (SigningKey)
- Kullanıcı ID'leri JSON yanıtlarında gizlenir
- HTTPS zorunludur

