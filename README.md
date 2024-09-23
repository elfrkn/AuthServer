## Asp.Net Core Api + Token Bazlı Kimlik Doğrulama(JSON WEB TOKEN)

Bu projede oluşturmuş olduğum AuthServer Identity ile beraber oluşturulan tokenı hem dağıtıp hem de tokenı kabul etmektedir.
Katmanlı mimari kullanarak oluşturmuş olduğum projemde Core katmanında entityler,Dto nesneleri ve interfaceler vardır.
Data katmanında veri tabanı ile ilgili işlemler,tanımlamış olduğum repository interfacelerin implementleri  vardır.
Service katmanında ise core katmanındaki service ile ilgili interfaceler implement edilmiştir.

Projede Apilerden verileri almak için access token ile beraber random ve unique bir refresh token oluşturularak identity bilgileri ile beraber refresh token veritabanına kaydedilir.Refresh token sadece access token üreten api ile haberleşebilir.
Kullanıcı istek yaptığında access tokenın süresi ve imzası kontrol edilir.
Access tokenın süresi dolmadığı sürece kullanıcı istediği verilere erişebilir.Access tokenın süresi dolduğunda ise Access tokenın imzası doğru ama süresi geçmiş olduğunda refresh token ile beraber authServer a istek yapılır.
Eğer ki ilgili kullanıcıya ait bir refresh token var ise authServer tekrardan yeni bir access token ve refresh token üretilerek kaydedilir.
Refresh tokenın süresi dolmuş ise kullanıcı login ekranına döndürülür.
Apilerde refresh token kullanılarak koruma altına alınmış olur.

Ayrıca projede Identity bilgileri olmadan,client bilgileri ile access token oluşturularak refresh token kullanılmadan ulaşılabilecek apiler oluşturulmuştur.
Role,Claim ve Policy bazlı yetkilendirme yapılmıştır.

### Kullanılan Teknolojiler
<ul>
<li>Asp .Net Core 8.0</li>
<li>Repository Pattern</li>
<li>Unit Of Work Pattern</li>
<li>Cors(Cross-Origin Resource Sharing)</li>
<li>Json Web Token</li>
<li>Identity</li>
<li>Role-Based Authorization</li>
<li>Claim-Based Authorization</li>
<li>Policy-Based Authorization</li>
</ul>















 
