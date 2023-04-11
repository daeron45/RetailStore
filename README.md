# RetailStore
Verilen bir Fatura ve Müþteri bilgilerine göre indirim hesaplar.

Bu uygulama, bir API proje ve onu  çalýþtýran bir Console projeden oluþur. Her iki projde de Asp.Net Core 6.0 kullanýlarak oluþturulmuþtur.
- API projesi, DiscountCalculator adlý bir class içerir. Bu class, toplam fatura tutarýný 'Invoice' isimli bir model üzerinden alýr. Müþterinin maðaza çalýþaný olup olmadýðý, maðaza üyesi olup olmadýðý ve 2 yýldan fazladýr müþteri mi deðil mi gibi bilgiler ise 'Customer' modelinden alýnýr. Bu class, indirim miktarýný  ve nihai fatura tutarýný hesaplar ve bunlarý JSON nesnesi olarak döndürür.Bu class, RESTful API'nin POST yöntemiyle çaðrýlýr.

- API, indirim hesaplamalarýný gerçekleþtirirken gelen faturanýn bakkaliye ürünleri içerip içermediði kontrol eder ve buna göre öncelikle yüzdeye dayalý indirimleri hesaplar. Daha sonra, fatura tutarý üzerinden sabit tutarda indirimi hesaplar. Son olarak,  nihai fatura tutarý hesaplanýr.

- Projeyi test etmek için Postman gibi bir araç kullanarak HTTP POST isteklerini http://localhost:port/api/invoice/discount adresindeki API uç noktasýna 'Invoice' ve 'Customer' model parametreleriyle gönderebilirsiniz. Console projesi de bu API yi test etmek için kullanabileceðiniz istek kodlarýný içerir. Önce API projesini çalýþtýrýp, Console projesindeki 'Invoice' ve 'Customer' modellerinin verilerini istediðiniz gibi düzenleyip çalýþtýrsanýz sonucu görebilirsiniz.

- API uygulamasýný ayrýca Swagger ile de test edebilirsiniz.

Bu API, web veya mobil uygulamasýna entegre edilebilir ve müþterilerin indirimli fatura tutarlarýný görmelerini saðlanabilir.
