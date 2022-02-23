﻿using ErrorMessageService.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Data.Seed
{
    public class ErrorMessageSeed : IEntityTypeConfiguration<ErrorMessages>
    {
        private readonly int[] _ids;

        public ErrorMessageSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<ErrorMessages> builder)
        {
            builder.HasData(
                new ErrorMessages { ErrorMessageId = 1, SubStatusCode = 1000, StatusCode = 100, Name = "Continue", Decription = "This interim response indicates that the client should continue the request or ignore the response if the request is already finished.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 2, SubStatusCode = 1001, StatusCode = 101, Name = "Switching Protocols", Decription = "This code is sent in response to an Upgrade request header from the client and indicates the protocol the server is switching to.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 3, SubStatusCode = 1002, StatusCode = 102, Name = "Processing", Decription = "This code indicates that the server has received and is processing the request, but no response is available yet.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 4, SubStatusCode = 1003, StatusCode = 103, Name = "Early Hints", Decription = "This status code is primarily intended to be used with the Link header, letting the user agent start preloading resources while the server prepares a response.", LanguageId = _ids[0] },

                new ErrorMessages { ErrorMessageId = 5, SubStatusCode = 2000, StatusCode = 200, Name = "Ok", Decription = "The request succeeded.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 6, SubStatusCode = 2001, StatusCode = 201, Name = "Created", Decription = "The request succeeded, and a new resource was created as a result.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 7, SubStatusCode = 2002, StatusCode = 202, Name = "Accepted", Decription = "The request has been received but not yet acted upon.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 8, SubStatusCode = 2003, StatusCode = 203, Name = "Non-Authoritative Information", Decription = "This response code means the returned metadata is not exactly the same as is available from the origin server, but is collected from a local or a third-party copy. ", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 9, SubStatusCode = 2004, StatusCode = 204, Name = "No Content", Decription = "There is no content to send for this request, but the headers may be useful. ", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 10, SubStatusCode = 2005, StatusCode = 205, Name = "Reset Content", Decription = "Tells the user agent to reset the document which sent this request.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 11, SubStatusCode = 2006, StatusCode = 206, Name = "Partial Content", Decription = "This response code is used when the Range header is sent from the client to request only part of a resource.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 12, SubStatusCode = 2007, StatusCode = 207, Name = "Multi-Status", Decription = "Conveys information about multiple resources, for situations where multiple status codes might be appropriate.", LanguageId = _ids[0] },

                new ErrorMessages { ErrorMessageId = 13, SubStatusCode = 3000, StatusCode = 300, Name = "Multiple Choice", Decription = "The request has more than one possible response.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 14, SubStatusCode = 3001, StatusCode = 301, Name = "Moved Permanently", Decription = "The URL of the requested resource has been changed permanently.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 15, SubStatusCode = 3002, StatusCode = 302, Name = "Found", Decription = "This response code means that the URI of requested resource has been changed temporarily.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 16, SubStatusCode = 3003, StatusCode = 303, Name = "See Other", Decription = "The server sent this response to direct the client to get the requested resource at another URI with a GET request.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 17, SubStatusCode = 3004, StatusCode = 304, Name = "Not Modified", Decription = "This is used for caching purposes. It tells the client that the response has not been modified, so the client can continue to use the same cached version of the response.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 18, SubStatusCode = 3005, StatusCode = 305, Name = "Use Proxy", Decription = "Defined in a previous version of the HTTP specification to indicate that a requested response must be accessed by a proxy. ", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 19, SubStatusCode = 3007, StatusCode = 307, Name = "Temporary Redirect", Decription = "The server sends this response to direct the client to get the requested resource at another URI with same method that was used in the prior request.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 20, SubStatusCode = 3008, StatusCode = 308, Name = "Permanent Redirect", Decription = "This means that the resource is now permanently located at another URI, specified by the Location: HTTP Response header. This has the same semantics as the 301 Moved Permanently HTTP response code, with the exception that the user agent must not change the HTTP method used: if a POST was used in the first request, a POST must be used in the second request.", LanguageId = _ids[0] },

                new ErrorMessages { ErrorMessageId = 21, SubStatusCode = 4000, StatusCode = 400, Name = "Bad Request", Decription = "The server could not understand the request due to invalid syntax.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 22, SubStatusCode = 4001, StatusCode = 401, Name = "Unauthorized", Decription = "Although the HTTP standard specifies unauthorized, semantically this response means unauthenticated.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 23, SubStatusCode = 4002, StatusCode = 402, Name = "Payment Required", Decription = "This response code is reserved for future use. The initial aim for creating this code was using it for digital payment systems, however this status code is used very rarely and no standard convention exists.",LanguageId = _ids[0]},
                new ErrorMessages { ErrorMessageId = 24, SubStatusCode = 4003, StatusCode = 403, Name = "Forbidden", Decription = "The client does not have access rights to the content; that is, it is unauthorized, so the server is refusing to give the requested resource. Unlike 401 Unauthorized, the client's identity is known to the server.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 25, SubStatusCode = 4004, StatusCode = 404, Name = "Not Found", Decription = "he server can not find the requested resource. In the browser, this means the URL is not recognized. In an API, this can also mean that the endpoint is valid but the resource itself does not exist. Servers may also send this response instead of 403 Forbidden to hide the existence of a resource from an unauthorized client. This response code is probably the most well known due to its frequent occurrence on the web.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 26, SubStatusCode = 4005, StatusCode = 405, Name = "Method Not Allowed", Decription = "The request method is known by the server but is not supported by the target resource. For example, an API may not allow calling DELETE to remove a resource.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 27, SubStatusCode = 4006, StatusCode = 406, Name = "Not Acceptable", Decription = "This response is sent when the web server, after performing server-driven content negotiation, doesn't find any content that conforms to the criteria given by the user agent.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 28, SubStatusCode = 4007, StatusCode = 407, Name = "Proxy Authentication Required", Decription = "This is similar to 401 Unauthorized but authentication is needed to be done by a proxy.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 29, SubStatusCode = 4008, StatusCode = 408, Name = "Request Timeout", Decription = "This response is sent on an idle connection by some servers, even without any previous request by the client.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 30, SubStatusCode = 4009, StatusCode = 409, Name = "Conflict", Decription = "This response is sent when a request conflicts with the current state of the server.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 31, SubStatusCode = 4010, StatusCode = 410, Name = "Gone", Decription = "This response is sent when the requested content has been permanently deleted from server, with no forwarding address. Clients are expected to remove their caches and links to the resource.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 32, SubStatusCode = 4011, StatusCode = 411, Name = "Length Required", Decription = "Server rejected the request because the Content-Length header field is not defined and the server requires it.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 33, SubStatusCode = 4012, StatusCode = 412, Name = "Precondition Failed", Decription = "The client has indicated preconditions in its headers which the server does not meet.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 34, SubStatusCode = 4013, StatusCode = 413, Name = "Payload Too Large", Decription = "Request entity is larger than limits defined by server. The server might close the connection or return an Retry-After header field.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 35, SubStatusCode = 4014, StatusCode = 414, Name = "URI Too Long", Decription = "The URI requested by the client is longer than the server is willing to interpret.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 36, SubStatusCode = 4016, StatusCode = 416, Name = "Range Not Satisfiable", Decription = "The range specified by the Range header field in the request cannot be fulfilled. It's possible that the range is outside the size of the target URI's data.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 37, SubStatusCode = 4017, StatusCode = 417, Name = "Expectation Failed", Decription = "This response code means the expectation indicated by the Expect request header field cannot be met by the server.", LanguageId = _ids[0] },

                new ErrorMessages { ErrorMessageId = 38, SubStatusCode = 5000, StatusCode = 500, Name = "Internal Server Error", Decription = "The server has encountered a situation it does not know how to handle.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 39, SubStatusCode = 5001, StatusCode = 501, Name = "Not Implemented", Decription = "The request method is not supported by the server and cannot be handled. The only methods that servers are required to support (and therefore that must not return this code) are GET and HEAD.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 40, SubStatusCode = 5002, StatusCode = 502, Name = "Bad Gateway", Decription = "This error response means that the server, while working as a gateway to get a response needed to handle the request, got an invalid response.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 41, SubStatusCode = 5003, StatusCode = 503, Name = "Service Unavailable", Decription = "The server is not ready to handle the request. Common causes are a server that is down for maintenance or that is overloaded. Note that together with this response, a user-friendly page explaining the problem should be sent. This response should be used for temporary conditions and the Retry-After HTTP header should, if possible, contain the estimated time before the recovery of the service. The webmaster must also take care about the caching-related headers that are sent along with this response, as these temporary condition responses should usually not be cached.", LanguageId = _ids[0] },
                new ErrorMessages { ErrorMessageId = 42, SubStatusCode = 5004, StatusCode = 504, Name = "Gateway Timeout", Decription = "This error response is given when the server is acting as a gateway and cannot get a response in time.", LanguageId = _ids[0] },
                
                new ErrorMessages { ErrorMessageId = 43, SubStatusCode = 1000, StatusCode = 100, Name = "Devam", Decription = "Şimdiye kadar her şeyin yolunda gittiğinin ve isteğin henüz sunucu tarafından reddedilmediğinin bir göstergesidir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 44, SubStatusCode = 1001, StatusCode = 101, Name = "Anahtarlama Protokolü", Decription = "Bu aşamada, sunucunun bir istemci tarafından talep edildiği gibi protokolü değiştirdiğini belirtir. Sunucu daha sonra protokolün değiştirildiğini belirtmek için yanıt başlığında bir yükseltme yapar.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 45, SubStatusCode = 1002, StatusCode = 102, Name = "İşlem", Decription = "Bu HTTP durum kodu , sunucunun isteği aldığını ve işlediğini, ancak henüz bir yanıt olmadığını gösterir. ", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 46, SubStatusCode = 1003, StatusCode = 103, Name = "Erken İpuçları", Decription = "Bu HTTP durum kodu, esas olarak, sunucu bir HTTP mesajı göndermeden önce bazı yanıt başlıklarını döndürmek için kullanılır. ", LanguageId = _ids[1] },
                
                new ErrorMessages { ErrorMessageId = 47, SubStatusCode = 2000, StatusCode = 200, Name = "Tamam", Decription = "HTTP 200 durum kodu, yanıtın başarılı olduğunu gösterir. Yani, istemci ile sunucu arasındaki iletişim herhangi bir hata olmadan sorunsuz bir şekilde yürütülmüştür.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 48, SubStatusCode = 2001, StatusCode = 201, Name = "Oluşturuldu", Decription = "Bu, talebin sadece başarılı olmadığını, aynı zamanda bir kaynağın da yaratıldığını gösterir. Bu durum kodu, sunucuya gönderilen kaynağı tanımladığı için genellikle bir POST isteğiyle birlikte gelir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 49, SubStatusCode = 2002, StatusCode = 202, Name = "Onaylandı", Decription = "Bu, bir istemcinin sunucuda bir şey yaratma talebinde bulunduğu, ardından yapılan talebin kabul edildiği, ancak hala bir miktar işlemden geçtiği için henüz tamamlanmadığı anlamına gelir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 50, SubStatusCode = 2003, StatusCode = 203, Name = "Yetersiz Bilgi", Decription = "Bu, başarılı bir isteği gösterir, ancak varlık başlığı, kaynak sunucununkinden değiştirilmiştir. Vekilin bir değişiklik uygulandığında konut sakinlerine bir uyarı göndermesine izin verir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 51, SubStatusCode = 2004, StatusCode = 204, Name = "İçerik Yok", Decription = "Bu, gönderilen isteğin alındığı, ancak yanıt yükünde gönderilecek ek veri olmadığı anlamına gelir. PUT yöntemi çoğunlukla 204 yanıtı için kullanılır ve varsayılan olarak önbelleğe alınabilir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 52, SubStatusCode = 2005, StatusCode = 205, Name = "İçeriği Baştan al", Decription = "Burada istek başarılı bir şekilde işlenir, ancak yanıt kullanıcıya belge görünümünü sıfırlamasını söyler, böylece istek sunucudan alındığı orijinal durumuna geri döner.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 53, SubStatusCode = 2006, StatusCode = 206, Name = "Kısmi İçerik", Decription = "GET için kısmi içerik (içeriğin bir belirli bir parçası) başarılıyla döndürülmüştür.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 54, SubStatusCode = 2007, StatusCode = 207, Name = "Çok-Statü", Decription = "Sunucu, mesajın gövdesine XML belgesi olarak yerleştirilmiş olan birçok bağımsız işlemin sonucunu bir kerede geçti.", LanguageId = _ids[1] },
                
                new ErrorMessages { ErrorMessageId = 55, SubStatusCode = 3000, StatusCode = 300, Name = "Çok Seçenek", Decription = "Bu HTTP kodu, bir kullanıcının seçebileceği çok sayıda seçeneği veya kaynağı gösterir ve her bir seçenek veya kaynak benzersiz bir şekilde tanımlanabilir.Belirli bir yanıtı seçmenin genel olarak kabul edilmiş bir yolu olmadığından, bu yanıt kodu nadiren kullanılır.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 56, SubStatusCode = 3001, StatusCode = 301, Name = "Kalıcı Taşındı", Decription = "Burada, kaynağa yapılacak tüm gelecekteki istekler belirli bir URL'ye yönlendirilmelidir. Artık var olmayan bir sayfadan yönlendirme yapmak için kullanılabilir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 57, SubStatusCode = 3002, StatusCode = 302, Name = "Geçici Taşındı", Decription = "Bu yanıt, 301 HTTP durum koduna benzer. Buradaki fark, istenen kaynağın geçici olarak belirli bir başlığa taşınmış olmasıdır.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 58, SubStatusCode = 3003, StatusCode = 303, Name = "Diğerlerine Bak", Decription = "Bu HTTP durum kodu, bu isteğin yanıtının başka bir URL'e yönlendirildiğini gösterir. Bu durum kodu, herhangi bir HTTP yöntemi için geçerlidir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 59, SubStatusCode = 3004, StatusCode = 304, Name = "Güncellenmedi", Decription = "Burada, kullanıcı aracısı son kaynağın önbelleğe alınmış bir kopyasına sahip olduğundan, istenen kaynağı yeniden göndermeye gerek yoktur. Amaç, kullanıcı aracısının en son güncellemenin bir kopyasına zaten sahip olması nedeniyle veri aktarımını en aza indirmektir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 60, SubStatusCode = 3005, StatusCode = 305, Name = "Proxy Kullan", Decription = "Sunucu tarafından döndürülen proxy'in kullanılması gerektiği belirtilir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 61, SubStatusCode = 3007, StatusCode = 307, Name = "Geçici olarak yeniden gönder", Decription = "Bu durumda, yanıt kodu, istenen kaynağın geçici olarak başka bir URL'e taşındığını gösterir. İstemcinin bir istekte bulunmak için orijinal URL'i kullanmaya devam etmesi beklenir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 62, SubStatusCode = 3008, StatusCode = 308, Name = "Kalıcı Yönlendirme", Decription = "Bu durumda, istenen kaynağa, isteklerin sorunsuz çalışmasına izin veren yeni bir kalıcı URL atanmıştır. Değiştirilebilen 301 HTTP durum kodunun aksine, yeniden yönlendirme sırasında istek yöntemi değişmez.", LanguageId = _ids[1] },
                
                new ErrorMessages { ErrorMessageId = 63, SubStatusCode = 4000, StatusCode = 400, Name = "Kötü İstek", Decription = "Bu, alınan isteğin yanlış söz diziminden kaynaklanabilecek bir hata nedeniyle sunucu tarafından işlenemediğini gösterir. Sunucu, bir sonraki talep alındığında bazı değişikliklerin yapılmasını bekler, aksi takdirde aynı hata devam eder.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 64, SubStatusCode = 4001, StatusCode = 401, Name = "Yetkisiz", Decription = "Bu durumda, alınan bir yanıta erişim sağlamak için yetkilendirme gerekir. Bu HTTP durum kodu HTTP 403'e benzer. Ancak burada, talebin kabul edilebilmesi için geçerli kimlik bilgilerine sahip olması beklenir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 65, SubStatusCode = 4002, StatusCode = 402, Name = "Ödeme Gerekli", Decription = "Ödeme gerekiyor. (gelecekte kullanılması için ayrılmıştır).", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 66, SubStatusCode = 4003, StatusCode = 403, Name = "Yasaklandı", Decription = "Bu HTTP durum kodu, kullanıcı-istemcinin geçerli bir veriye sahip olduğu ancak sunucu tarafından erişimin reddedildiği anlamına gelir. Kullanıcının söz konusu kaynak üzerinde herhangi bir hakka sahip olmasına izin verilmediğinden, tekrarlanan girişimlerde bulunmak kullanıcı olarak başarılı bir yanıt vermeyecektir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 67, SubStatusCode = 4004, StatusCode = 404, Name = "Sayfa Bulunamadı", Decription = "Bu HTTP kodu, istenen kaynağın sunucu tarafından bulunamayacağı anlamına gelir. Bu, geçici bir aksaklıktan kaynaklanıyor olabilir ve gelecekte başka bir istekte bulunulursa kaynak kullanılabilir olabilir. Çoğunlukla, 404'e götüren bağlantılara genellikle bozuk bağlantılar denir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 68, SubStatusCode = 4005, StatusCode = 405, Name = "İzin verilmeyen Metod", Decription = "Bu HTTP kodu, istenen bir yöntemin, sunucu tarafından tanındığında bile istenen kaynak için desteklenmediği anlamına gelir. Kaynak bir GET veya POST yöntemi bekliyor olabilir, ancak bir DELETE veya PUT yöntemi alırsa, yapılan istek 405 olarak reddedilecektir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 69, SubStatusCode = 4006, StatusCode = 406, Name = "Kabul Edilemez", Decription = "İstemcinin Accept header'ında verilen özellik karşılanamıyor.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 70, SubStatusCode = 4007, StatusCode = 407, Name = "Proxy Kimlik Doğrulaması Gerekli", Decription = "Proxy üzerinden yetkilendirme gerekir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 71, SubStatusCode = 4008, StatusCode = 408, Name = "İstek zaman aşımına uğradı", Decription = "İstek zaman aşımına uğradı (belirli bir sürede istek tamamlanamadı).", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 72, SubStatusCode = 4009, StatusCode = 409, Name = "Fikir ayrılığı", Decription = "İstek içinde çelişki var.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 73, SubStatusCode = 4010, StatusCode = 410, Name = "Gitmiş", Decription = "Kaynak artık yok.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 74, SubStatusCode = 4011, StatusCode = 411, Name = "Gerekli Uzunluk", Decription = "İstekte Content - Length (içeriğin boyutu) belirtilmemiş.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 75, SubStatusCode = 4012, StatusCode = 412, Name = "Ön Koşul Başarısız", Decription = "Sunucu istekte belirtilen bazı önkoşulları karşılamıyor.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 76, SubStatusCode = 4013, StatusCode = 413, Name = "Yük Çok Büyük", Decription = "İsteğin boyutu çok büyük olduğu için işlenemedi.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 77, SubStatusCode = 4014, StatusCode = 414, Name = "URI Çok Uzun", Decription = "URI (URL) fazla büyük.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 78, SubStatusCode = 4016, StatusCode = 416, Name = "Menzil Tatmin Edilemez", Decription = "İstenilen kaynak istenilen medya tipini desteklemiyor.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 79, SubStatusCode = 4017, StatusCode = 417, Name = "Beklenti Başarısız", Decription = "İstek yapılan parça (bir dosyanın bir parçası vb..) sunucu tarafından verilebiliyor veya uygun değil.", LanguageId = _ids[1] },
                
                new ErrorMessages { ErrorMessageId = 80, SubStatusCode = 5000, StatusCode = 500, Name = "İç Sunucu Hatası", Decription = "Burada, belirli bir isteğin, isteği tamamlayamamasına neden olan beklenmedik bir durumla karşılaştığı anlamına gelir. Kullanıcının bu HTTP durum kodunu web sayfasında görmesi beklenmez.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 81, SubStatusCode = 5001, StatusCode = 501, Name = "Uygulanmadı", Decription = "Bu HTTP durum kodu, sunucunun belirli bir isteği tamamlamak için gereken gereksinimleri desteklemediğini veya sahip olmadığını gösterir. Bu, kullanıcı-istemcinin erişmeye çalıştığı sunucunun düzeltilmesi gerektiği anlamına gelir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 82, SubStatusCode = 5002, StatusCode = 502, Name = "Kötü Ağ Geçidi", Decription = "Bu HTTP kodu, sunucunun proxy olarak hareket ederken istekte bulunurken sunucudan geçersiz bir yanıt aldığını gösterir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 83, SubStatusCode = 5003, StatusCode = 503, Name = "Hizmet kullanılamıyor", Decription = "Bu HTTP durum kodu, geçici bir durumu gösterir. Bu, sunucuya yapılan isteğin şu anda eylemi gerçekleştiremediği anlamına gelir; bu, bakım nedeniyle veya sunucunun aşırı yüklenmiş olduğu anlamına gelebilir.", LanguageId = _ids[1] },
                new ErrorMessages { ErrorMessageId = 84, SubStatusCode = 5004, StatusCode = 504, Name = "Ağ Geçidi Zaman Aşımı", Decription = "Bu HTTP durum kodu, sunucunun bir proxy gibi davrandığını, isteği beklenen zaman aralığında göndermediğini gösterir. Bu düzeltmenin sunucudan gelmesi bekleniyor.", LanguageId = _ids[1] }

        );
        }
    }
}
