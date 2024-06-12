# BM102 Proje Tarif Getir

BM102 Bilgisayar Programlama 2 dersinin Proje Ödevi için tasarlanan Tarif Getir uygulamasının reposudur.

Gazi Üniversitesi Mühendislik Fakültesi Bilgisayar Mühendisliği bölüm dersi olan BM102 Bilgisayar Programlama dersinde 2024 Bahar dönemi kapsamında verilmiş proje ödevimizdir. Projemiz bir tarif öneri uygulamasıdır. Bu projede nesne yönelimli bir dil olan XAML ve C# yazılım dili tabanlı .NET MAUI uygulaması ve veritabanı için de SQLITE kullanılmıştır.

Uygulamaya ilk girdiğimizde giriş yap sayfası gelmekte olup kullanıcının hesabı yoksa, oluşturması için hesap oluştur butonuna tıklayarak hesap oluşturma sayfasından hesap oluşturması istenir. Ayrıca şifrenin unutulması halinde kullanıcının şifresini değiştirebileceği Şifremi Unuttum adında bir sayfa da bulunmaktadır. Uygulamaya giriş yaptıktan sonra Tarifler, Tarif Getir ve Hesabım sekmeleri bizi karşılamaktadır. 

Tarifler sekmesinde yiyeceğin türü seçilir ve ilgili tarifler fotoğrafları ve isimleri ile listelenir. Tariflerden herhangi birine tıklanıldığında ise ilgili tarifin fotoğrafı, gereken malzemeler ve yapılışı gösterilmektedir. Buna ek olarak kullanıcının beğendiği tarifleri favoriye ekleyebileceği bir favori butonu da bulunmaktadır.

Tarif Getir sekmesinde hazırlamak istediğiniz yiyecek türünü seçebileceğiniz iki adet buton (Yemek – Tatlı) bulunmaktadır. Bunlardan herhangi birine basıldığında elinizde bulunan malzemeleri girmenizi isteyen bir Malzemeler sayfası gelmektedir. Buradan malzemeleri seçtikten sonra Tarif Ara butonuna basıldığında tarifler, seçilen malzemeler ile tariflerde bulunan malzemelerin eşleşme oranına göre sıralanarak listelenir. Tariflerden herhangi birine tıklanıldığında ise ilgili tarifin fotoğrafı, gereken malzemeler, mevcut malzemeler, eksik malzemeler ve yapılışı gösterilmektedir. Buna ek olarak kullanıcının beğendiği tarifleri favoriye ekleyebileceği bir favori butonu da bulunmaktadır.

Hesabım sekmesinde Kişisel Bilgiler, Favorilerim, Ayarlar ve Çıkış Yap butonları bulunmaktadır. Kişisel Bilgiler butonuna basıldığında kullanıcının; Adı, Soyadı, Kullanıcı Adı ve Şifresini görebileceği Kişisel Bilgiler sayfası açılmaktadır. Favorilerim butonuna basıldığında kullanıcının beğendiği yemek ve tatlı tariflerinin listelendiği Favorilerim sayfası açılmaktadır. Ayarlar butonuna basıldığında Ayarlar sayfası açılmakta olup bu sayfada kullanıcının şifresini değiştirebileceği Şifre Değiştir sayfasını açan bir buton bulunmaktadır. Çıkış Yap butonu ise mevcut oturumu sonlandırıp Giriş Yap sayfasına yönlendiren bir butondur.

Projeyi Hazırlayanlar:
- Yakup Karataş
- Duhan Demir
- Zeynep Gerçekdoğan
- Muhammed Aksoy
- Tolga Seymen
