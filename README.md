# 🛒 Modern E-Ticaret Web Uygulaması | ASP.NET Core MVC & MongoDB

Bu proje, **M&Y Akademi Danışmanlık** kapsamında **Murat Yücedağ** rehberliğinde geliştirilmiştir. MongoDB tabanlı veritabanı yapısı ve ASP.NET Core MVC mimarisi kullanılarak hazırlanan bu web uygulaması, modern bir e-ticaret deneyimi sunmayı hedefler.

Kullanıcılar ürünleri görüntüleyebilir, slider bileşenleri ile kampanyaları takip edebilir ve e-posta aboneliği yoluyla özel indirim kuponlarına erişebilir.  
**Yönetici paneli** üzerinden ürün, kategori ve müşteri gibi içerikler kolayca yönetilebilir.

---

## 🚀 Temel Özellikler

- 📦 MongoDB ile NoSQL veri yapısı
- 🛍️ Ürün, kategori ve slider (kampanya) yönetimi
- 👤 Müşteri yönetimi (admin panel üzerinden)
- 💌 E-posta aboneliği ve otomatik indirim kuponu gönderimi
- 🔄 Asenkron işlemler (async/await)
- 🧩 Reusable ViewComponent ve Partial View kullanımı
- 🧠 Katmanlı mimari (Controller - Service - DTO - View)

---

## 🔐 Admin Paneli Özellikleri

Yönetici paneli üzerinden aşağıdaki işlemler yapılabilir:

- ➕ Yeni ürün ekleme, güncelleme ve silme
- 📂 Kategori oluşturma ve düzenleme
- 👤 Müşteri bilgilerini görüntüleme ve yönetme
- 🖼️ Slider kampanyaları oluşturma
- 📊 Genel içerik yönetimi ve izleme

---

## 🧱 Proje Mimarisi

### Katmanlar

- **Controller:** HTTP isteklerini karşılar, servis katmanını kullanır.
- **Service:** İş mantığını yönetir, MongoDB ile veri işlemlerini gerçekleştirir.
- **DTO:** Veri transferini kolaylaştırır (Model ↔ View).
- **View:** Razor tabanlı kullanıcı arayüzleri.
- **ViewComponent / Partial:** Slider, ürün kartı vb. gibi parçalanabilir bileşenler.

---

## 🗃️ MongoDB Koleksiyonları

- **Products**
  - `ProductId`, `ProductName`, `Price`, `Description`, `CategoryId`, `Images`

- **Categories**
  - `CategoryId`, `CategoryName`

- **Sliders**
  - `SliderId`, `Title`, `ImageUrl`

- **Customers**
  - `CustomerId`, `Name`, `Email`, `Phone`

- **Subscribers**
  - `Email`, `DiscountCode`, `CreatedAt`

➡️ Koleksiyonlar arasında ilişkiler ID referanslarıyla sağlanır. Örn: `Product.CategoryId`.

---

## 📧 E-Posta Aboneliği ve Kupon Sistemi

- Kullanıcılar e-posta adresi bırakarak **%20 indirim kuponu** alır.
- Kuponlar otomatik olarak **rastgele 8 karakterli** alfanümerik kodlarla oluşturulur.
- Gmail SMTP ile otomatik e-posta gönderimi yapılır.
- Güvenlik için **uygulama şifresi** kullanılır.

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji           | Açıklama                                                       |
|---------------------|----------------------------------------------------------------|
| ASP.NET Core MVC    | Web uygulama çatısı                                            |
| MongoDB             | NoSQL veritabanı sistemi                                       |
| Bootstrap 5         | Responsive ve modern kullanıcı arayüzü                         |
| C# 10               | Backend geliştirme                                             |
| JavaScript (Fetch)  | Dinamik veri işlemleri                                         |
| LINQ                | Veri sorgulama                                                 |
| DTO Pattern         | Katmanlar arası veri aktarımı                                  |
| Async/Await         | Performanslı asenkron işlemler                                 |
| Gmail SMTP          | Otomatik indirim kuponu gönderimi                             |

---

## 🖼️ Proje Görselleri


![Ekran görüntüsü 2025-05-24 190037](https://github.com/user-attachments/assets/2d4228ff-2b34-4a14-bf22-19ffe405ec62)
![Ekran görüntüsü 2025-05-24 190041](https://github.com/user-attachments/assets/264178d4-05e4-44b2-a59c-3c09b581d4ad)
![Ekran görüntüsü 2025-05-24 190044](https://github.com/user-attachments/assets/90f30d98-a762-4bb4-a585-357dd7bb9c85)
![Ekran görüntüsü 2025-05-24 190048](https://github.com/user-attachments/assets/9aae6584-2498-4809-85bd-45540828df07)
![Ekran görüntüsü 2025-05-24 184929](https://github.com/user-attachments/assets/940ff300-5839-4741-8699-807624f6fb32)
![Ekran görüntüsü 2025-05-24 184944](https://github.com/user-attachments/assets/9951fd27-996c-4830-972e-d64455629735)
![Ekran görüntüsü 2025-05-24 185000](https://github.com/user-attachments/assets/24f58ca7-43f1-4768-b2c8-b6ff0fe02374)
![Ekran görüntüsü 2025-05-24 185029](https://github.com/user-attachments/assets/bcd18525-fa4a-4e5a-a608-5e05c87802e2)
![Ekran görüntüsü 2025-05-24 185039](https://github.com/user-attachments/assets/03ce6771-3ec9-4226-ab83-36b647a1ef80)

---

Projeyi geliştirip katkı sağlamak isterseniz pull request gönderebilirsiniz. ⭐
