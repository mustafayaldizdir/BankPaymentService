# Bank Payment Service Case
This case for Bermuda Technology Company

# Case Content
1. .net core ile bir web api projesi oluşturulması,
2. Oluşturulan bu projede payment API metodunun dışarıya açılması,
3. API metodunun parametre olarak kredi kartı numarası, kredi kartı sahibi, cvv ve son kullanma tarihi bilgisi ile tutar değerlerini alması,
4. IPaymentProvider vb. bir isimle interface oluşturulması,
5. Oluşturulan bu interface'i implement eden banka sınıfları açılması,
6. Kredi kartı numarasının ilk 6 hanesinden paylaştığımız bin listesiyle hangi banka olduğunu anlayıp ilgili bankanın sınıfına interface aracılığıyla erişip ödeme metodunun çağrılmasını bekliyoruz.
7. Ödeme hareketini de bir tabloya yazarsanız güzel olur.

Banka sınıfları içerisinde implement edilen metotlarda bankaya ait bir kod olmasına gerek yok, sadece input alıp başarılı cevap dönülebilir.
