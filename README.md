# RetailStore
Verilen bir Fatura ve M��teri bilgilerine g�re indirim hesaplar.

Bu uygulama, bir API proje ve onu  �al��t�ran bir Console projeden olu�ur. Her iki projde de Asp.Net Core 6.0 kullan�larak olu�turulmu�tur.
- API projesi, DiscountCalculator adl� bir class i�erir. Bu class, toplam fatura tutar�n� 'Invoice' isimli bir model �zerinden al�r. M��terinin ma�aza �al��an� olup olmad���, ma�aza �yesi olup olmad��� ve 2 y�ldan fazlad�r m��teri mi de�il mi gibi bilgiler ise 'Customer' modelinden al�n�r. Bu class, indirim miktar�n�  ve nihai fatura tutar�n� hesaplar ve bunlar� JSON nesnesi olarak d�nd�r�r.Bu class, RESTful API'nin POST y�ntemiyle �a�r�l�r.

- API, indirim hesaplamalar�n� ger�ekle�tirirken gelen faturan�n bakkaliye �r�nleri i�erip i�ermedi�i kontrol eder ve buna g�re �ncelikle y�zdeye dayal� indirimleri hesaplar. Daha sonra, fatura tutar� �zerinden sabit tutarda indirimi hesaplar. Son olarak,  nihai fatura tutar� hesaplan�r.

- Projeyi test etmek i�in Postman gibi bir ara� kullanarak HTTP POST isteklerini http://localhost:port/api/invoice/discount adresindeki API u� noktas�na 'Invoice' ve 'Customer' model parametreleriyle g�nderebilirsiniz. Console projesi de bu API yi test etmek i�in kullanabilece�iniz istek kodlar�n� i�erir. �nce API projesini �al��t�r�p, Console projesindeki 'Invoice' ve 'Customer' modellerinin verilerini istedi�iniz gibi d�zenleyip �al��t�rsan�z sonucu g�rebilirsiniz.

- API uygulamas�n� ayr�ca Swagger ile de test edebilirsiniz.

Bu API, web veya mobil uygulamas�na entegre edilebilir ve m��terilerin indirimli fatura tutarlar�n� g�rmelerini sa�lanabilir.
