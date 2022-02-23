using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErrorMessageService.Data.Migrations
{
    public partial class InitialV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "App",
                columns: table => new
                {
                    AppId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_App", x => x.AppId);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguagePath = table.Column<int>(type: "int", nullable: false),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "ErrorMessage",
                columns: table => new
                {
                    ErrorMessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubStatusCode = table.Column<int>(type: "int", nullable: false),
                    StatusCode = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Decription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorMessage", x => x.ErrorMessageId);
                    table.ForeignKey(
                        name: "FK_ErrorMessage_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ErrorsDetails",
                columns: table => new
                {
                    ErrorsDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppId = table.Column<int>(type: "int", nullable: false),
                    ErrorMessageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorsDetails", x => x.ErrorsDetailsId);
                    table.ForeignKey(
                        name: "FK_ErrorsDetails_App_AppId",
                        column: x => x.AppId,
                        principalTable: "App",
                        principalColumn: "AppId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ErrorsDetails_ErrorMessage_ErrorMessageId",
                        column: x => x.ErrorMessageId,
                        principalTable: "ErrorMessage",
                        principalColumn: "ErrorMessageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "App",
                columns: new[] { "AppId", "AppName" },
                values: new object[,]
                {
                    { 1, "App1" },
                    { 2, "App2" },
                    { 3, "App3" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "LanguageId", "LanguageName", "LanguagePath" },
                values: new object[,]
                {
                    { 1, "İngilizce", 1 },
                    { 2, "Türkçe", 2 }
                });

            migrationBuilder.InsertData(
                table: "ErrorMessage",
                columns: new[] { "ErrorMessageId", "Decription", "LanguageId", "Name", "StatusCode", "SubStatusCode" },
                values: new object[,]
                {
                    { 1, "This interim response indicates that the client should continue the request or ignore the response if the request is already finished.", 1, "Continue", 100, 1000 },
                    { 2, "This code is sent in response to an Upgrade request header from the client and indicates the protocol the server is switching to.", 1, "Switching Protocols", 101, 1001 },
                    { 3, "This code indicates that the server has received and is processing the request, but no response is available yet.", 1, "Processing", 102, 1002 },
                    { 4, "This status code is primarily intended to be used with the Link header, letting the user agent start preloading resources while the server prepares a response.", 1, "Early Hints", 103, 1003 },
                    { 5, "The request succeeded.", 1, "Ok", 200, 2000 },
                    { 6, "The request succeeded, and a new resource was created as a result.", 1, "Created", 201, 2001 },
                    { 7, "The request has been received but not yet acted upon.", 1, "Accepted", 202, 2002 },
                    { 8, "This response code means the returned metadata is not exactly the same as is available from the origin server, but is collected from a local or a third-party copy. ", 1, "Non-Authoritative Information", 203, 2003 },
                    { 9, "There is no content to send for this request, but the headers may be useful. ", 1, "No Content", 204, 2004 },
                    { 10, "Tells the user agent to reset the document which sent this request.", 1, "Reset Content", 205, 2005 },
                    { 11, "This response code is used when the Range header is sent from the client to request only part of a resource.", 1, "Partial Content", 206, 2006 },
                    { 12, "Conveys information about multiple resources, for situations where multiple status codes might be appropriate.", 1, "Multi-Status", 207, 2007 },
                    { 13, "The request has more than one possible response.", 1, "Multiple Choice", 300, 3000 },
                    { 14, "The URL of the requested resource has been changed permanently.", 1, "Moved Permanently", 301, 3001 },
                    { 15, "This response code means that the URI of requested resource has been changed temporarily.", 1, "Found", 302, 3002 },
                    { 16, "The server sent this response to direct the client to get the requested resource at another URI with a GET request.", 1, "See Other", 303, 3003 },
                    { 17, "This is used for caching purposes. It tells the client that the response has not been modified, so the client can continue to use the same cached version of the response.", 1, "Not Modified", 304, 3004 },
                    { 18, "Defined in a previous version of the HTTP specification to indicate that a requested response must be accessed by a proxy. ", 1, "Use Proxy", 305, 3005 },
                    { 19, "The server sends this response to direct the client to get the requested resource at another URI with same method that was used in the prior request.", 1, "Temporary Redirect", 307, 3007 },
                    { 20, "This means that the resource is now permanently located at another URI, specified by the Location: HTTP Response header. This has the same semantics as the 301 Moved Permanently HTTP response code, with the exception that the user agent must not change the HTTP method used: if a POST was used in the first request, a POST must be used in the second request.", 1, "Permanent Redirect", 308, 3008 },
                    { 21, "The server could not understand the request due to invalid syntax.", 1, "Bad Request", 400, 4000 },
                    { 22, "Although the HTTP standard specifies unauthorized, semantically this response means unauthenticated.", 1, "Unauthorized", 401, 4001 },
                    { 23, "This response code is reserved for future use. The initial aim for creating this code was using it for digital payment systems, however this status code is used very rarely and no standard convention exists.", 1, "Payment Required", 402, 4002 },
                    { 24, "The client does not have access rights to the content; that is, it is unauthorized, so the server is refusing to give the requested resource. Unlike 401 Unauthorized, the client's identity is known to the server.", 1, "Forbidden", 403, 4003 },
                    { 25, "he server can not find the requested resource. In the browser, this means the URL is not recognized. In an API, this can also mean that the endpoint is valid but the resource itself does not exist. Servers may also send this response instead of 403 Forbidden to hide the existence of a resource from an unauthorized client. This response code is probably the most well known due to its frequent occurrence on the web.", 1, "Not Found", 404, 4004 },
                    { 26, "The request method is known by the server but is not supported by the target resource. For example, an API may not allow calling DELETE to remove a resource.", 1, "Method Not Allowed", 405, 4005 },
                    { 27, "This response is sent when the web server, after performing server-driven content negotiation, doesn't find any content that conforms to the criteria given by the user agent.", 1, "Not Acceptable", 406, 4006 },
                    { 28, "This is similar to 401 Unauthorized but authentication is needed to be done by a proxy.", 1, "Proxy Authentication Required", 407, 4007 },
                    { 29, "This response is sent on an idle connection by some servers, even without any previous request by the client.", 1, "Request Timeout", 408, 4008 },
                    { 30, "This response is sent when a request conflicts with the current state of the server.", 1, "Conflict", 409, 4009 },
                    { 31, "This response is sent when the requested content has been permanently deleted from server, with no forwarding address. Clients are expected to remove their caches and links to the resource.", 1, "Gone", 410, 4010 },
                    { 32, "Server rejected the request because the Content-Length header field is not defined and the server requires it.", 1, "Length Required", 411, 4011 },
                    { 33, "The client has indicated preconditions in its headers which the server does not meet.", 1, "Precondition Failed", 412, 4012 },
                    { 34, "Request entity is larger than limits defined by server. The server might close the connection or return an Retry-After header field.", 1, "Payload Too Large", 413, 4013 },
                    { 35, "The URI requested by the client is longer than the server is willing to interpret.", 1, "URI Too Long", 414, 4014 },
                    { 36, "The range specified by the Range header field in the request cannot be fulfilled. It's possible that the range is outside the size of the target URI's data.", 1, "Range Not Satisfiable", 416, 4016 },
                    { 37, "This response code means the expectation indicated by the Expect request header field cannot be met by the server.", 1, "Expectation Failed", 417, 4017 },
                    { 38, "The server has encountered a situation it does not know how to handle.", 1, "Internal Server Error", 500, 5000 },
                    { 39, "The request method is not supported by the server and cannot be handled. The only methods that servers are required to support (and therefore that must not return this code) are GET and HEAD.", 1, "Not Implemented", 501, 5001 },
                    { 40, "This error response means that the server, while working as a gateway to get a response needed to handle the request, got an invalid response.", 1, "Bad Gateway", 502, 5002 },
                    { 41, "The server is not ready to handle the request. Common causes are a server that is down for maintenance or that is overloaded. Note that together with this response, a user-friendly page explaining the problem should be sent. This response should be used for temporary conditions and the Retry-After HTTP header should, if possible, contain the estimated time before the recovery of the service. The webmaster must also take care about the caching-related headers that are sent along with this response, as these temporary condition responses should usually not be cached.", 1, "Service Unavailable", 503, 5003 },
                    { 42, "This error response is given when the server is acting as a gateway and cannot get a response in time.", 1, "Gateway Timeout", 504, 5004 }
                });

            migrationBuilder.InsertData(
                table: "ErrorMessage",
                columns: new[] { "ErrorMessageId", "Decription", "LanguageId", "Name", "StatusCode", "SubStatusCode" },
                values: new object[,]
                {
                    { 43, "Şimdiye kadar her şeyin yolunda gittiğinin ve isteğin henüz sunucu tarafından reddedilmediğinin bir göstergesidir.", 2, "Devam", 100, 1000 },
                    { 44, "Bu aşamada, sunucunun bir istemci tarafından talep edildiği gibi protokolü değiştirdiğini belirtir. Sunucu daha sonra protokolün değiştirildiğini belirtmek için yanıt başlığında bir yükseltme yapar.", 2, "Anahtarlama Protokolü", 101, 1001 },
                    { 45, "Bu HTTP durum kodu , sunucunun isteği aldığını ve işlediğini, ancak henüz bir yanıt olmadığını gösterir. ", 2, "İşlem", 102, 1002 },
                    { 46, "Bu HTTP durum kodu, esas olarak, sunucu bir HTTP mesajı göndermeden önce bazı yanıt başlıklarını döndürmek için kullanılır. ", 2, "Erken İpuçları", 103, 1003 },
                    { 47, "HTTP 200 durum kodu, yanıtın başarılı olduğunu gösterir. Yani, istemci ile sunucu arasındaki iletişim herhangi bir hata olmadan sorunsuz bir şekilde yürütülmüştür.", 2, "Tamam", 200, 2000 },
                    { 48, "Bu, talebin sadece başarılı olmadığını, aynı zamanda bir kaynağın da yaratıldığını gösterir. Bu durum kodu, sunucuya gönderilen kaynağı tanımladığı için genellikle bir POST isteğiyle birlikte gelir.", 2, "Oluşturuldu", 201, 2001 },
                    { 49, "Bu, bir istemcinin sunucuda bir şey yaratma talebinde bulunduğu, ardından yapılan talebin kabul edildiği, ancak hala bir miktar işlemden geçtiği için henüz tamamlanmadığı anlamına gelir.", 2, "Onaylandı", 202, 2002 },
                    { 50, "Bu, başarılı bir isteği gösterir, ancak varlık başlığı, kaynak sunucununkinden değiştirilmiştir. Vekilin bir değişiklik uygulandığında konut sakinlerine bir uyarı göndermesine izin verir.", 2, "Yetersiz Bilgi", 203, 2003 },
                    { 51, "Bu, gönderilen isteğin alındığı, ancak yanıt yükünde gönderilecek ek veri olmadığı anlamına gelir. PUT yöntemi çoğunlukla 204 yanıtı için kullanılır ve varsayılan olarak önbelleğe alınabilir.", 2, "İçerik Yok", 204, 2004 },
                    { 52, "Burada istek başarılı bir şekilde işlenir, ancak yanıt kullanıcıya belge görünümünü sıfırlamasını söyler, böylece istek sunucudan alındığı orijinal durumuna geri döner.", 2, "İçeriği Baştan al", 205, 2005 },
                    { 53, "GET için kısmi içerik (içeriğin bir belirli bir parçası) başarılıyla döndürülmüştür.", 2, "Kısmi İçerik", 206, 2006 },
                    { 54, "Sunucu, mesajın gövdesine XML belgesi olarak yerleştirilmiş olan birçok bağımsız işlemin sonucunu bir kerede geçti.", 2, "Çok-Statü", 207, 2007 },
                    { 55, "Bu HTTP kodu, bir kullanıcının seçebileceği çok sayıda seçeneği veya kaynağı gösterir ve her bir seçenek veya kaynak benzersiz bir şekilde tanımlanabilir.Belirli bir yanıtı seçmenin genel olarak kabul edilmiş bir yolu olmadığından, bu yanıt kodu nadiren kullanılır.", 2, "Çok Seçenek", 300, 3000 },
                    { 56, "Burada, kaynağa yapılacak tüm gelecekteki istekler belirli bir URL'ye yönlendirilmelidir. Artık var olmayan bir sayfadan yönlendirme yapmak için kullanılabilir.", 2, "Kalıcı Taşındı", 301, 3001 },
                    { 57, "Bu yanıt, 301 HTTP durum koduna benzer. Buradaki fark, istenen kaynağın geçici olarak belirli bir başlığa taşınmış olmasıdır.", 2, "Geçici Taşındı", 302, 3002 },
                    { 58, "Bu HTTP durum kodu, bu isteğin yanıtının başka bir URL'e yönlendirildiğini gösterir. Bu durum kodu, herhangi bir HTTP yöntemi için geçerlidir.", 2, "Diğerlerine Bak", 303, 3003 },
                    { 59, "Burada, kullanıcı aracısı son kaynağın önbelleğe alınmış bir kopyasına sahip olduğundan, istenen kaynağı yeniden göndermeye gerek yoktur. Amaç, kullanıcı aracısının en son güncellemenin bir kopyasına zaten sahip olması nedeniyle veri aktarımını en aza indirmektir.", 2, "Güncellenmedi", 304, 3004 },
                    { 60, "Sunucu tarafından döndürülen proxy'in kullanılması gerektiği belirtilir.", 2, "Proxy Kullan", 305, 3005 },
                    { 61, "Bu durumda, yanıt kodu, istenen kaynağın geçici olarak başka bir URL'e taşındığını gösterir. İstemcinin bir istekte bulunmak için orijinal URL'i kullanmaya devam etmesi beklenir.", 2, "Geçici olarak yeniden gönder", 307, 3007 },
                    { 62, "Bu durumda, istenen kaynağa, isteklerin sorunsuz çalışmasına izin veren yeni bir kalıcı URL atanmıştır. Değiştirilebilen 301 HTTP durum kodunun aksine, yeniden yönlendirme sırasında istek yöntemi değişmez.", 2, "Kalıcı Yönlendirme", 308, 3008 },
                    { 63, "Bu, alınan isteğin yanlış söz diziminden kaynaklanabilecek bir hata nedeniyle sunucu tarafından işlenemediğini gösterir. Sunucu, bir sonraki talep alındığında bazı değişikliklerin yapılmasını bekler, aksi takdirde aynı hata devam eder.", 2, "Kötü İstek", 400, 4000 },
                    { 64, "Bu durumda, alınan bir yanıta erişim sağlamak için yetkilendirme gerekir. Bu HTTP durum kodu HTTP 403'e benzer. Ancak burada, talebin kabul edilebilmesi için geçerli kimlik bilgilerine sahip olması beklenir.", 2, "Yetkisiz", 401, 4001 },
                    { 65, "Ödeme gerekiyor. (gelecekte kullanılması için ayrılmıştır).", 2, "Ödeme Gerekli", 402, 4002 },
                    { 66, "Bu HTTP durum kodu, kullanıcı-istemcinin geçerli bir veriye sahip olduğu ancak sunucu tarafından erişimin reddedildiği anlamına gelir. Kullanıcının söz konusu kaynak üzerinde herhangi bir hakka sahip olmasına izin verilmediğinden, tekrarlanan girişimlerde bulunmak kullanıcı olarak başarılı bir yanıt vermeyecektir.", 2, "Yasaklandı", 403, 4003 },
                    { 67, "Bu HTTP kodu, istenen kaynağın sunucu tarafından bulunamayacağı anlamına gelir. Bu, geçici bir aksaklıktan kaynaklanıyor olabilir ve gelecekte başka bir istekte bulunulursa kaynak kullanılabilir olabilir. Çoğunlukla, 404'e götüren bağlantılara genellikle bozuk bağlantılar denir.", 2, "Sayfa Bulunamadı", 404, 4004 },
                    { 68, "Bu HTTP kodu, istenen bir yöntemin, sunucu tarafından tanındığında bile istenen kaynak için desteklenmediği anlamına gelir. Kaynak bir GET veya POST yöntemi bekliyor olabilir, ancak bir DELETE veya PUT yöntemi alırsa, yapılan istek 405 olarak reddedilecektir.", 2, "İzin verilmeyen Metod", 405, 4005 },
                    { 69, "İstemcinin Accept header'ında verilen özellik karşılanamıyor.", 2, "Kabul Edilemez", 406, 4006 },
                    { 70, "Proxy üzerinden yetkilendirme gerekir.", 2, "Proxy Kimlik Doğrulaması Gerekli", 407, 4007 },
                    { 71, "İstek zaman aşımına uğradı (belirli bir sürede istek tamamlanamadı).", 2, "İstek zaman aşımına uğradı", 408, 4008 },
                    { 72, "İstek içinde çelişki var.", 2, "Fikir ayrılığı", 409, 4009 },
                    { 73, "Kaynak artık yok.", 2, "Gitmiş", 410, 4010 },
                    { 74, "İstekte Content - Length (içeriğin boyutu) belirtilmemiş.", 2, "Gerekli Uzunluk", 411, 4011 },
                    { 75, "Sunucu istekte belirtilen bazı önkoşulları karşılamıyor.", 2, "Ön Koşul Başarısız", 412, 4012 },
                    { 76, "İsteğin boyutu çok büyük olduğu için işlenemedi.", 2, "Yük Çok Büyük", 413, 4013 },
                    { 77, "URI (URL) fazla büyük.", 2, "URI Çok Uzun", 414, 4014 },
                    { 78, "İstenilen kaynak istenilen medya tipini desteklemiyor.", 2, "Menzil Tatmin Edilemez", 416, 4016 },
                    { 79, "İstek yapılan parça (bir dosyanın bir parçası vb..) sunucu tarafından verilebiliyor veya uygun değil.", 2, "Beklenti Başarısız", 417, 4017 },
                    { 80, "Burada, belirli bir isteğin, isteği tamamlayamamasına neden olan beklenmedik bir durumla karşılaştığı anlamına gelir. Kullanıcının bu HTTP durum kodunu web sayfasında görmesi beklenmez.", 2, "İç Sunucu Hatası", 500, 5000 },
                    { 81, "Bu HTTP durum kodu, sunucunun belirli bir isteği tamamlamak için gereken gereksinimleri desteklemediğini veya sahip olmadığını gösterir. Bu, kullanıcı-istemcinin erişmeye çalıştığı sunucunun düzeltilmesi gerektiği anlamına gelir.", 2, "Uygulanmadı", 501, 5001 },
                    { 82, "Bu HTTP kodu, sunucunun proxy olarak hareket ederken istekte bulunurken sunucudan geçersiz bir yanıt aldığını gösterir.", 2, "Kötü Ağ Geçidi", 502, 5002 },
                    { 83, "Bu HTTP durum kodu, geçici bir durumu gösterir. Bu, sunucuya yapılan isteğin şu anda eylemi gerçekleştiremediği anlamına gelir; bu, bakım nedeniyle veya sunucunun aşırı yüklenmiş olduğu anlamına gelebilir.", 2, "Hizmet kullanılamıyor", 503, 5003 },
                    { 84, "Bu HTTP durum kodu, sunucunun bir proxy gibi davrandığını, isteği beklenen zaman aralığında göndermediğini gösterir. Bu düzeltmenin sunucudan gelmesi bekleniyor.", 2, "Ağ Geçidi Zaman Aşımı", 504, 5004 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ErrorMessage_LanguageId",
                table: "ErrorMessage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ErrorsDetails_AppId",
                table: "ErrorsDetails",
                column: "AppId");

            migrationBuilder.CreateIndex(
                name: "IX_ErrorsDetails_ErrorMessageId",
                table: "ErrorsDetails",
                column: "ErrorMessageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErrorsDetails");

            migrationBuilder.DropTable(
                name: "App");

            migrationBuilder.DropTable(
                name: "ErrorMessage");

            migrationBuilder.DropTable(
                name: "Language");
        }
    }
}
