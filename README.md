# 🤖 AITech - AI Powered Corporate Platform


📖 Proje Hakkında

**AITech**, klasik kurumsal web sitesi anlayışını yapay zeka ile birleştiren bir AR-GE projesidir. .NET 8.0 ve Katmanlı Mimari (N-Tier Architecture) kullanılarak geliştirilen bu proje, kullanıcılarına **Google Gemini AI** entegrasyonu sayesinde interaktif bir asistan deneyimi sunar.

Sistem; WebUI, Business, DataAccess, Entity ve DTO katmanlarından oluşur ve SOLID prensiplerine tam uyumluluk gösterir.

## 🏗️ Mimari ve Tasarım Yaklaşımı

* **Layered Architecture:** Proje 5 ana katmana ayrılarak modülerlik sağlanmıştır.
* **Code First:** Veritabanı tasarımı Entity Framework Core Code First yaklaşımıyla C# sınıfları üzerinden yönetilmiştir.
* **Service Oriented:** İş mantığı ve dış servis (API) haberleşmeleri Service katmanında izole edilmiştir.
* **DTO (Data Transfer Object):** Entity'ler doğrudan sunulmayıp, DTO'lar aracılığıyla veri güvenliği ve validasyon sağlanmıştır.

## 🌟 Öne Çıkan Özellikler

### 1. Google Gemini AI Entegrasyonu 🧠
Sistemin kalbinde yer alan **"AI Business Assistant"** modülü:
* Kullanıcıdan gelen istemleri (prompt) alır.
* **Google Gemini API** (v1beta/models/gemini-2.5-flash) ile haberleşir.
* Gelen cevabı Markdown formatından HTML'e çevirerek kullanıcıya profesyonel, maddeli ve okunaklı bir çıktı sunar.
* *Örnek Senaryo:* Kullanıcı "Bir kahve dükkanı için slogan bul" yazar, AI 5 farklı yaratıcı slogan önerisi sunar.

### 2. Dinamik Yönetim Paneli 📊
* Tüm proje, hizmet, referans ve takım arkadaşlarının yönetildiği CRUD işlemleri.
* Sitenin genel istatistiklerini sunan Admin Dashboard.
* Swagger UI ile API endpoint'lerinin test edilebilirliği.

### 3. Modern Arayüz 🎨
* Bootstrap 5 ve özel CSS ile **Glassmorphism** (Buzlu Cam) tasarım dili.
* Responsive (Mobil Uyumlu) yapı.
* Kullanıcı deneyimini artıran dinamik yükleme (AJAX) işlemleri.

## 🛠️ Teknoloji Yığını (Tech Stack)

| Kategori | Teknoloji |
|----------|-----------|
| **Framework** | .NET 8.0, ASP.NET Core MVC |
| **Data Access** | Entity Framework Core 8 |
| **Database** | MS SQL Server |
| **AI Integration** | Google Gemini API (Generative AI) |
| **Architecture** | Layered Arch., Repository Pattern |
| **Frontend** | Bootstrap 5, jQuery, HTML5/CSS3 |
| **Tools** | Visual Studio 2022, Swagger UI |

<img width="945" height="421" alt="ss0" src="https://github.com/user-attachments/assets/a46a560d-49dd-423e-b893-074b86bfb85a" />
<img width="946" height="472" alt="ss1" src="https://github.com/user-attachments/assets/01b6702a-12c7-4f7a-b562-10fb9ad1413f" />
<img width="946" height="250" alt="ss2" src="https://github.com/user-attachments/assets/ac1d4209-83a8-4fac-a8a6-a7e41e8767b5" />
<img width="946" height="473" alt="ss3" src="https://github.com/user-attachments/assets/a321e36c-e4a7-4486-b25b-a667a57af462" />
<img width="945" height="473" alt="ss4" src="https://github.com/user-attachments/assets/8140fd70-1acc-4916-9062-d89017e2a431" />
<img width="946" height="439" alt="ss5" src="https://github.com/user-attachments/assets/2379a9fb-65e1-4339-82a4-1eb485e9ed36" />
<img width="945" height="440" alt="ss6" src="https://github.com/user-attachments/assets/6a2a68d3-6652-43bd-ac70-9f10553bc06b" />
<img width="944" height="390" alt="ss7" src="https://github.com/user-attachments/assets/b412c3c8-f715-45b5-b3dd-0edb7d0a8631" />
<img width="947" height="372" alt="ss8" src="https://github.com/user-attachments/assets/1b52fdee-ef4c-4bc7-8158-30513e14e709" />
<img width="947" height="346" alt="ss9" src="https://github.com/user-attachments/assets/64d91ae4-0b4c-49b3-b706-33974ec0727e" />
<img width="951" height="471" alt="ss10" src="https://github.com/user-attachments/assets/fc0f011a-8130-4605-8411-69991506d28d" />
<img width="951" height="470" alt="ss11" src="https://github.com/user-attachments/assets/6c1ec877-e3ef-445d-ac05-99d148a716b2" />
<img width="950" height="469" alt="ss12" src="https://github.com/user-attachments/assets/e2139447-e10b-4423-a9af-e9d2ebcecd5a" />
<img width="952" height="470" alt="ss13" src="https://github.com/user-attachments/assets/e004d594-c43b-400c-b4fa-8365afd5d106" />
<img width="950" height="470" alt="ss14" src="https://github.com/user-attachments/assets/faaed524-fa59-4506-ae4e-ab51f6271bf1" />
<img width="952" height="469" alt="ss15" src="https://github.com/user-attachments/assets/6a1e30dd-f39f-4c2e-8ed3-c8088c78738d" />
<img width="950" height="468" alt="ss16" src="https://github.com/user-attachments/assets/4ed88a55-4f24-4f46-a776-10502ceb3131" />
<img width="950" height="469" alt="ss17" src="https://github.com/user-attachments/assets/d9dc1ebb-100a-47ff-8025-8416dee5424d" />


* [Email](mailto:erselgemici.eg@gmail.com)
