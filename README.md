## Asp.Net Core Api + Token Bazlı Kimlik Doğrulama(JSON WEB TOKEN) :computer:

:heavy_check_mark: Bu projede oluşturmuş olduğum AuthServer Identity ile beraber oluşturulan tokenı hem dağıtıp hem de tokenı kabul etmektedir.
Katmanlı mimari kullanarak oluşturmuş olduğum projemde Core katmanında entityler,Dto nesneleri ve interfaceler vardır.
Data katmanında veri tabanı ile ilgili işlemler,tanımlamış olduğum repository interfacelerin implementleri  vardır.
Service katmanında ise core katmanındaki service ile ilgili interfaceler implement edilmiştir.

:heavy_check_mark: Projede Apilerden verileri almak için access token ile beraber random ve unique bir refresh token oluşturularak identity bilgileri ile beraber refresh token veritabanına kaydedilir.Refresh token sadece access token üreten api ile haberleşebilir.

:heavy_check_mark: Kullanıcı istek yaptığında access tokenın süresi ve imzası kontrol edilir.
Access tokenın süresi dolmadığı sürece kullanıcı istediği verilere erişebilir.Access tokenın süresi dolduğunda ise Access tokenın imzası doğru ama süresi geçmiş olduğunda refresh token ile beraber authServer a istek yapılır.

:heavy_check_mark: Eğer ki ilgili kullanıcıya ait bir refresh token var ise authServer tekrardan yeni bir access token ve refresh token üretilerek kaydedilir.
Refresh tokenın süresi dolmuş ise kullanıcı login ekranına döndürülür.
Apilerde refresh token kullanılarak koruma altına alınmış olur.

:heavy_check_mark: Ayrıca projede Identity bilgileri olmadan,client bilgileri ile access token oluşturularak refresh token kullanılmadan ulaşılabilecek apiler oluşturulmuştur.
Role,Claim ve Policy bazlı yetkilendirme yapılmıştır.

### Kullanılan Teknolojiler
<ul>
:heavy_minus_sign: Asp .Net Core 8.0 </br>
:heavy_minus_sign: Repository Pattern </br>
:heavy_minus_sign: Unit Of Work Pattern </br>
:heavy_minus_sign: Cors(Cross-Origin Resource Sharing) </br>
:heavy_minus_sign: Json Web Token </br>
:heavy_minus_sign: Identity </br>
:heavy_minus_sign: Role-Based Authorization </br>
:heavy_minus_sign: Claim-Based Authorization </br>
:heavy_minus_sign: Policy-Based Authorization </br>
:heavy_minus_sign: Fluent Validation </br>
</ul>

 #### Create Token :star:
![CreateToken](https://github.com/user-attachments/assets/739f4538-930f-4dae-818e-7e56f064f68e)

#### Create Token By Client :star:
![CreateTokenByClient](https://github.com/user-attachments/assets/118ae939-332f-4efe-8c65-0eeff5e05f44)

#### MiniApps :star:
![MiniApi2](https://github.com/user-attachments/assets/d1b94221-0dd7-451e-9441-3afb7a46c99d) 
![MiniApi1](https://github.com/user-attachments/assets/beaad2a0-2002-4db1-ab64-57d03f9ce156)
![MiniApi3](https://github.com/user-attachments/assets/2725712f-e9fd-404c-82e0-7b00e91f802a)

#### Create Product and User :star:
![User](https://github.com/user-attachments/assets/82895738-c8c2-4e21-baab-a997ce9a0ecf) 
![Product](https://github.com/user-attachments/assets/6f7aa579-aeb4-4533-a6dc-0df2884c8327)

#### Custom Exception  :star:
![CustomException](https://github.com/user-attachments/assets/19dd9e34-20d3-439a-bf2d-09ee2194a087)

#### Jwt with UserRole/Claim-Based and Policy-Based Authorization  :star:
![Ekran görüntüsü 2024-09-24 193729](https://github.com/user-attachments/assets/2ade71eb-27d2-4573-99f8-86875efa071d)





 
