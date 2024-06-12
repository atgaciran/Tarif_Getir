using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarifGetir.Models;

namespace TarifGetir.Services
{
    public class YiyecekService
    {
        public static List<Yiyecek> AllRecipes { get; set; } = new List<Yiyecek>();
        public static List<Yiyecek> FavoriteRecipes { get; set; } = new List<Yiyecek>();

        public List<Yiyecek> GetAnaYemek()
            {
                return new List<Yiyecek>()
            {
                new Yiyecek
                {
                    Id =1,
                    Name="Ispanaklı Kiş",
                    TarifMetni="Soğanı yemeklik doğrayıp yağ eklediğiniz tavada soteleyin. İnce ince doğradığınız ıspanakları da ekleyip kavurmaya devam edin. Ispanaklar yumuşayınca tuz ve karabiber ekleyip ocaktan alın. Harcı bir kaba aktarın. Hamur için un hariç tüm malzemeleri bir kaba alın ve karıştırın. Unu yavaş yavaş ekleyerek ele yapışmayan yumuşak kıvamlı bir hamur yoğurun. Soğuyan harcın içine bir kutu kremayı ekleyip karıştırın. Hamuru merdane yardımıyla küçük borcam boyutunda açın. Hamuru borcama alın ve çatalla delikler açın. Harcı kiş hamuruna ekleyin ve önceden ısıtılmış fırında kızarana kadar pişirin. Üzerine kaşar peyniri rendesini ekleyip tekrar fırına verin. Kızarınca fırından çıkarın ve dilimleyerek servis edin. Ispanaklı kiş tarifiniz hazır. Afiyet olsun.",
                    Resim=ImageSource.FromFile("ispanakli_kis.webp"),
                    MalzemeListesi= ["Un", "Yumurta", "Tereyağı","Ispanak", "Soğan", "Krema", "Kaşar Peyniri" ],
                    TarifMalzemeListesi= ["300 g un", "1 yumurta sarısı", "165 g tereyağı", "1 çay kaşığı tuz", "300 g ıspanak", "1 adet soğan", "1 paket krema", "1 tatlı kaşığı tuz", "1 çay kaşığı karabiber", "50 g rendelenmiş kaşar peyniri" ]
                },
                new Yiyecek
                {
                    Id = 2,
                    Name = "Domates Soslu Makarna",
                    TarifMetni = "Soğanları ve sarımsakları incecik minik minik şekilde doğrayın. Bir tavaya alarak üzerine zeytinyağı ilave ederek hafif kavurun. Domatesleri rendeleyin. Rendelenmiş domatesleri üzerine ekleyin. Domates suyunu çekene kadar pişirin. Makarnayı suda haşlayın ve süzdürün. Süzdüğünüz makarnanın suyundan yarım kepçe alarak sosun içerisine aktarın. Güzelce karıştırın. Ardından süzdürülmüş makarnaları ilave edin. Makarnayı sosla beraber güzelce harmanlayın. Sosu çekene kadar birkaç dakika birlikte pişirin. Dilerseniz üzerine rendelenmiş kaşar ekebilirsiniz. Afiyet olsun.",
                    Resim = ImageSource.FromFile("domates_soslu_makarna.png"),
                    MalzemeListesi = [ "Makarna", "Domates", "Soğan", "Sarımsak" ],
                    TarifMalzemeListesi = [ "1 paket makarna", "3 adet rendelenmiş domates", "1 orta boy soğan", "1-2 diş sarımsak", "1 tatlı kaşığı tuz", "3-4 yemek kaşığı zeytinyağı", "1 çay kaşığı karabiber", "1 tatlı kaşığı kekik" ]
                },
                new Yiyecek
                {
                    Id = 3,
                    Name = "Biber Dolması",
                    TarifMetni = "Zeytinyağlı biber dolması için yarım su bardağı zeytinyağını geniş bir pilav tenceresine alın ve 2 adet yemeklik doğranmış kuru soğan ile birlikte pembeleşinceye kadar kavurun. 1,5 su bardağı yıkanmış pirinci ekleyin ve 2-3 dakika kadar kavurun. 1 tatlı kaşığı tuz, yarım çay kaşığı karabiber, yarım çay kaşığı yenibahar, yarım tatlı kaşığı toz şeker ve 1 tatlı kaşığı naneyi de ekledikten sonra son kez karıştırın. 2 su bardağı sıcak suyu ekleyip, pirinçler diri kalacak şekilde 7-8 dakika kadar pişirin ve ocaktan alın. Hazırladığınız dolma harcını, üst kapağını ve iç kısmını çıkardığınız yaklaşık 10-15 adet dolmalık biberin içerisine doldurun. Ağız kısımlarında şişme ve pişme payı bırakmaya özen gösterin. Hazırladığınız dolmaları tencereye dik bir şekilde dizin. Biberlerin üst kısımlarını domates ile kapatın. Tencerenin yarısına kadar su doldurun ve üzerlerine zeytinyağı gezdirip kapağını kapatın. Dolmaları, kısık ateşte pişirme suyu bitip pirinçler şişene kadar yaklaşık 30-35 dakika pişirin. Ilık ya da soğuk olarak servis edin. Afiyet olsun!",
                    Resim = ImageSource.FromFile("biber_dolmasi.png"),
                    MalzemeListesi = [ "Dolmalık Biber", "Soğan", "Pirinç", "Domates" ],
                    TarifMalzemeListesi = [ "1/2 su bardağı zeytinyağı", "2 adet soğan", "1,5 su bardağı pirinç", "10 adet orta boy dolmalık biber", "2 su bardağı sıcak su", "1 adet orta boy domates", "1 tatlı kaşığı tuz", "1 tatlı kaşığı nane", "1/2 tatlı kaşığı toz şeker", "1/2 çay kaşığı karabiber", "1/2 çay kaşığı yenibahar" ],
                },
                new Yiyecek
                {
                    Id = 4,
                    Name = "Özbek Pilavı",
                    TarifMetni = "Pilav yapımına başlamadan soğanları kalın yarım ay şeklinde, havuçları orta kalınlıkta şeritler (baton) halinde doğrayın. Pirinçleri nişastası akana kadar yıkayın ve ılık suda beklemeye bırakın. Sarımsakların dıştaki ince kabuklarını soyun. Geniş ve büyük bir tencerede sıvı yağı ısıtın ve etler koyu renk alana kadar kavurun. Etleri süzerek tencereden dışarı alın. Kalan yağda önce soğanları kavurup dışarı alın, ardından havuçları da renk alana kadar kavurun. Kavrulan havuçların üzerine kızarmış etleri, soğanı koyup karıştırın. Tencereye sarımsakları ekleyin ve son olarak tuzun yarısını ekleyip karıştırın. Tencereye malzemelerin seviyesini biraz geçecek kadar sıcak su koyup ocağın altını kısın, tencerenin kapağını kapatıp etler yumuşayana kadar yaklaşık 30 dakika pişirin. Etler yumuşayınca sarımsakları kenara ayırın, pirinçleri süzüp malzemelerin üzerini örtecek şekilde tencereye alın. Pirinçlerin üzerine tuz, karabiber, kimyon ve sarımsakları koyup kaşığın tersiyle bir kaç delik açın. Son olarak tam pirinçlerin seviyesine gelecek kadar az miktarda sıcak su ekleyip tencerenin kapağını kapatın. Pirinçler suyu çekince ocağı kapatın. Pilavın üzerine bir bez örtüp 25-30 dakika demlendirin. Afiyet olsun.",
                    Resim = ImageSource.FromFile("ozbek_pilavi.png"),
                    MalzemeListesi = [ "Kırmızı Et", "Soğan", "Sarımsak", "Havuç", "Pirinç" ],
                    TarifMalzemeListesi = [ "1 su bardağı sıvı yağ", "500 gram kuzu kuşbaşı (dana eti de kullanılabilir)", "3 adet soğan", "5 adet havuç", "2,5 su bardağı pirinç", "3 baş sarımsak", "1 tatlı kaşığı kimyon", "2 tatlı kaşığı tuz", "1 çay kaşığı karabiber", "1 litre sıcak su" ]
                },
                new Yiyecek
                {
                    Id = 5,
                    Name = "Pizza",
                    TarifMetni = "Bir kabın içerisine 1 paket kuru mayayı dökün. Üzerine 1,5 su bardağı ılık su ve 1 çay kaşığı şekeri ekleyerek güzelce karıştırın. Daha sonra mayalı karışıma 4 yemek kaşığı zeytinyağını ve 1/2 çay kaşığı tuzu ekleyip tahta kaşıkla karıştırın. 5 su bardağı unu azar azar ekleyin. Hamur kıvama gelince elinizle yoğurmaya başlayın ve ele yapışmayan, yumuşak bir hamur haline gelene kadar yoğurmaya devam edin. Hamur istediğiniz yumuşaklığa ulaşınca, kabın üzerini bir streç film ile kaplayıp en az 30 dakika hamurunuzu dinlendirin. Dinlenen hamurunuzu un serptiğiniz tezgaha alıp, katlayarak havasını çıkarın. Hamuru toparlayıp, 2 ya da 3 parçaya ayırın. İnce hamurlu ve orta boy pizza yapmak istiyorsanız hamurunuzu 3’e bölün. Daha büyük ve kalın hamurlu 2 pizza yapmak istiyorsanız, ikiye bölebilirsiniz. Kestiğiniz parçayı beze haline getirip un serptiğiniz tezgahın üzerinde merdane yardımıyla açın. Dilediğiniz inceliğe ulaştığınızda pişirme kağıdı serdiğiniz tepsinin üzerine alın. Bir çatal yardımıyla pizza hamurunun üzerinde delikler açın ve önceden ısıtılmış 200 derece fırında 10 dakika pişirin. Pizza sosunu, 2 su bardağı domates sosuna, 1 çay kaşığı fesleğen, 1 çay kaşığı kekik, sarımsak ve zeytinyağı ekleyerek hazırlayabilirsiniz. 10 dakika sonra hafif pişen hamuru fırından çıkarıp, hazırladığınız domates sosundan üzerine sürün. Pizza sosunun üzerine 1 su bardağı rendelenmiş kaşar ve yerleştirdikten sonra üzerine dileğiniz malzemeleri ekleyin. Burada serbest olabilirsiniz. Malzemeleri yerleştirdikten sonra en üste tekrar rendelenmiş kaşar ekleyin. Tekrar fırına koyun ve 20 dakika daha pişirin. Peynirler güzelce eriyip tüm malzemeler piştiğinde pizzanızı fırından çıkarabilirsiniz. Afiyet olsun!",
                    Resim = ImageSource.FromFile("pizza.png"),
                    MalzemeListesi = [ "Un", "Maya", "Şeker", "Sucuk", "Salam", "Sosis", "Mantar", "Yeşil Biber", "Kaşar Peyniri", "Domates" ],
                    TarifMalzemeListesi = [ "5 su bardağı un", "1,5 su bardağı ılık su", "1 paket kuru maya", "1 çay kaşığı toz şeker", "1/2 çay kaşığı tuz", "4 yemek kaşığı zeytinyağı", "2 su bardağı domates sosu", "1 çay kaşığı kekik", "1 çay kaşığı fesleğen", "1 su bardağı rendelenmiş kaşar peyniri", "İsteğe bağlı: sucuk, salam, sosis, biber, mısır, zeytin, mantar" ]
                },
                new Yiyecek
                {
                    Id = 6,
                    Name = "Nohut Yemeği",
                    TarifMetni = "Nohut yemeği için 300 gram kuşbaşı eti, üzerini 2 parmak geçecek kadar su ekleyin. Yumuşayana kadar haşlayın. Yağı tencerede kızdırın. Üzerine 1 adet yemeklik doğranmış soğanı da ekleyin ve pembeleşinceye kadar kavurun. 1 yemek kaşığı domates salçası, yarım yemek kaşığı biber salçası, 1'er çay kaşığı tuz, karabiber ve toz kırmızı biber ve haşlanmış kuşbaşını da ilave edip karıştırmaya devam edin. Son olarak 500 gram haşlanmış nohut, 2 kepçe et suyu ve 2 su bardağı suyu da ekleyip tencerenin kapağını kapatıp pişirmeye bırakın. Etler yumuşacık olduğunda ve yemeğin suyu hafif koyulaşınca nohut yemeğiniz olmuş demektir, afiyet olsun!",
                    Resim = ImageSource.FromFile("nohut_yemegi.png"),
                    MalzemeListesi = [ "Kırmızı Et", "Nohut", "Salça", "Soğan" ],
                    TarifMalzemeListesi = [ "300 g kuşbaşı dana eti", "1 yemek kaşığı sıvı yağ", "1 adet soğan", "1 yemek kaşığı domates salçası", "1/2 yemek kaşığı biber salçası", "1 çay kaşığı tuz", "1 çay kaşığı karabiber", "1 çay kaşığı toz kırmızı biber", "500 g nohut (bir gece önceden ıslatılmış)", "2 su bardağı su" ]
                },
                new Yiyecek
                {
                    Id = 7,
                    Name = "Tavuklu Kremalı Mantarlı Makarna",
                    TarifMetni = "Jülyen veya kuşbaşı doğranmış tavuğu zeytinyağında su ilave etmeden kavurun. Pişip kızarmaya başlayınca ince doğranmış mantarları ve rendelenmiş sarımsakları da ilave edin ve 5 – 6 dk. daha kavurun. Üzerine 1 kutu kremayı, tuzu, karabiberi ilave edip kaynatın. Önceden aldante kıvamında haşlanmış ve süzülmüş makarnaları da üzerine ilave edip karıştırın ve sıcak sıcak servis edin. Afiyet olsun.",
                    Resim = ImageSource.FromFile("tavuklu_kremali_makarna.png"),
                    MalzemeListesi = [ "Makarna", "Krema", "Mantar", "Tavuk", "Sarımsak" ],
                    TarifMalzemeListesi = [ "1/2 paket makarna", "1 adet tavuk göğsü", "200 g mantar", "1 kutu krema", "2 diş sarımsak", "1 çay kaşığı tuz", "1 çay kaşığı karabiber" ]
                },
                new Yiyecek
                {
                    Id = 8,
                    Name = "Kumpir",
                    TarifMetni = "Kumpir yapmaya başlamadan önce, büyük boy patatesleri iyice yıkayın ve temizleyin. Patateslerin üzerini önce bir fırın kağıdı ile sarın. Daha sonra üzerini alüminyum folyo ile kaplayın. Önceden 200 derecede ısıttığınız fırının tabanına patatesi yerleştirin. Ters çevirdiğiniz bir tepsiyi çok az aralık kalacak şekilde üzerine kapatın. Bu şekilde yaklaşık 90 dakika pişirin. Bu aşamada, patateslerin içi yumuşayıncaya kadar pişirmeye devam edin. Patatesler fırında pişerken, tereyağını oda sıcaklığında bekletin. Fırından çıkardığınız patatesi ortadan dikey şekilde kesin ve tereyağı, kaşar peynirini ilave edin. Bir çatal yardımıyla peynirler eriyene kadar nazikçe karıştırın. Bu aşamada patates içi tereyağı ile yumuşayacak ve kaşar peyniriyle kremamsı bir kıvam alacak. Daha sonra üzerine haşlanmış mısır, garnitür, zeytin, turşu, sosis ve salam ekleyebilirsiniz. Bu kısmı ağız tadınıza göre şekillendirebilirsiniz. Mayonez ve ketçap ekledikten sonra kumpir tarifi hazır. Afiyet olsun!",
                    Resim = ImageSource.FromFile("kumpir.png"),
                    MalzemeListesi = [ "Patates", "Kaşar Peyniri", "Tereyağı", "Salam", "Sosis", "Garnitür", "Turşu" ],
                    TarifMalzemeListesi = [ "2 adet büyük boy patates", "4 yemek kaşığı tereyağı", "3/4 su bardağı rendelenmiş kaşar peyniri", "1 çay bardağı mısır", "1/2 su bardağı çekirdekleri çıkarılmış zeytin", "4-5 adet kornişon turşu", "1 çay kaşığı tuz", "1 paket garnitür", "Sucuk", "Salam", "İsteğe bağlı: ketçap, mayonez" ]
                },
                new Yiyecek
                {
                    Id = 9,
                    Name = "Peynirli Erişte",
                    TarifMetni = "Geniş bir tencereye yağı alarak üzerine erişte ve ceviz içini ekleyin ve erişteler hafif renk alana kadar kavurun. Üzerine sıcak su ve tuzu da ilave ettikten sonra kapağı kapalı şekilde 10-15 dakika pişirin. Kapağı kapalı bir şekilde bir süre dinlendirin. Bir tavada tereyağı ve toz kırmızı biberi birkaç dakika çevirin. Yarısını eriştelerin üzerine ilave edip karıştırın. Diğer yarısını servis aşamasında üzerine gezdirin ve beyaz peynir ilave ederek servis edin. Dilerseniz üzerine ceviz ekleyebilirsiniz. Afiyet olsun.",
                    Resim = ImageSource.FromFile("peynirli_eriste.png"),
                    MalzemeListesi = [ "Erişte", "Tereyağı", "Beyaz Peynir"],
                    TarifMalzemeListesi = [ "2 su bardağı erişte", "3 yemek kaşığı tereyağı", "2 su bardağı sıcak su", "1 çay kaşığı tuz", "100 g beyaz peynir", "2 çay kaşığı toz kırmızı biber", "İsteğe bağlı: ceviz" ]
                },
                new Yiyecek
                {
                    Id = 10,
                    Name = "Kabak Mücver",
                    TarifMetni = "Mücver için bol suda yıkadığınız kabakları rendenin iri kısmıyla rendeleyin. Mücveri sulandırmaması için; rendelenmiş kabakların suyunu sıkarak çıkartın. Geniş bir kapta rendelenen kabakları, havucu, yumurtayı, taze soğanı, dereotunu, tuzu, karabiberi birleştirin. Unu da ilave edip tüm malzemeleri birbiriyle harmanlayın. Tüm malzemeler macun kıvamını alana kadar karıştırın. Her bir mücver 1 tepeleme yemek kaşığı olacak şekilde ayarlayıp tavaya dökün. Kızgın yağda altın sarısı rengini alana kadar kızartın. Mücverlerin fazla yağını havlu kağıda süzdürdükten sonra servis tabağına alın ve çırpılmış yoğurt ile servis edin. Afiyet olsun!",
                    Resim = ImageSource.FromFile("kabak_mucver.png"),
                    MalzemeListesi = [ "Kabak", "Yumurta", "Un" ],
                    TarifMalzemeListesi = ["3 adet kabak", "2 adet yumurta", "1 adet havuç", "6 dal taze soğan", "1/2 demet dereotu", "1,5 çay kaşığı tuz", "1 çay kaşığı karabiber", "İsteğe bağlı: ceviz" ]
                },
                new Yiyecek
                {
                    Id = 11,
                    Name = "Sucuklu Kuru Fasulye",
                    Resim = "Resources/Images/yemek/sucuklu_kuru_fasulye.jpg",
                    TarifMetni = "Bir gece önceden fasulyeyi ayıklayıp yıkayın ve ılık su ile ıslatın. Islatıp yumuşayan fasulyeyi yemeği yapmadan hemen önce süzün. Soğanları yemeklik, sucukları ile halka halka doğrayın. Tencereye zeytinyağını, soğanları ve tuzunu koyup orta ateşte pembeleşinceye kadar kavurun. Üzerine salçayı ilave edin ve 1 dakika daha kavurun. Sucukları ekleyip 1 dakika daha kavurun. Son olarak fasulyeleri fasulyelerin üzerini 2 parmak geçecek kadar sıcak suyu ekleyin. 25 – 30 dakika kadar kapağı kapalı olarak pişirin, fasulyeler istediğiniz kıvamda pişince ocaktan alın ve sıcak servis yapın. Afiyet olsun.",
                    MalzemeListesi =  [ "Kuru Fasulye", "Sucuk", "Soğan", "Salça" ],
                    TarifMalzemeListesi =
                    [
                        "500 g kuru fasulye",
                        "Yarım kangal sucuk",
                        "2 adet orta boy kuru soğan",
                        "Yarım çay bardağı zeytinyağı",
                        "2 yemek kaşığı biber ya da domates salçası",
                        "Tuz"
                    ]
                },
                new Yiyecek
                {
                    Id = 12,
                    Name = "Mantı",
                    Resim = "Resources/Images/yemek/manti.jpg",
                    TarifMetni = "3 su bardağı unu bir yoğurma kabına boşaltın, ortasını açıp 1 adet yumurta, tuz ve 1 su bardağı ılık suyu ekleyip yoğurun. Ele yapışmayan, esnek bir hamur elde edince, üzerini kapatarak dinlenmeye bırakın. İç malzeme için, 1 adet kuru soğanı rendeleyin. 250 gram kıymayı soğana ekleyin. Daha sonra, karabiber, tuz ve pul biber ekleyerek güzelce yoğurun. Hamuru bezelere ayırın. Her bezeyi oklavayla hazır yufkadan biraz kalın bir şekilde açın. Açtığınız yufkayı kareler şeklinde kesin. Her karenin ortasına kıymalı harçtan küçük bir parça yerleştirin. Bohça şeklinde kapatın. Derin bir tencereye su ekleyip kaynatın ve mantıları yaklaşık 20 dakika pişirin. Sosu için bir kapta 2 yemek kaşığı tereyağı eritin. Eriyen tereyağına 2 yemek kaşığı domates salçası ekleyip kavurun. Pişen mantının suyuyla salçayı biraz açıp birkaç dakika kaynatın. Mantıyı suyunu süzerek servis tabağına aldıktan sonra üzerine sarımsaklı yoğurt dökün. Üzerine hazırladığınız sosu döktükten sonra kuru nane, sumak ve pul biber ekleyerek servis edebilirsiniz. Mantı hazır! Afiyet olsun.",
                    MalzemeListesi = [ "Un", "Yumurta", "Kıyma", "Soğan", "Yoğurt", "Salça" ],
                    TarifMalzemeListesi =
                    ["Hamuru için:",
                        "3 su bardağı un",
                        "1 su bardağı ılık su",
                        "1 adet yumurta",
                        "1 çay kaşığı tuz",
                        "Harcı için:",
                        "250 g kıyma",
                        "1 adet orta boy soğan",
                        "1 çay kaşığı tuz",
                        "½ çay kaşığı karabiber",
                        "½ çay kaşığı pul biber",
                        "Sosu için:",
                        "2 yemek kaşığı tereyağı",
                        "2 yemek kaşığı salça",
                        "Üzeri için:",
                        "1 kase sarımsaklı yoğurt",
                        "1 çay kaşığı nane",
                        "½ çay kaşığı sumak",
                        "1 çay kaşığı pul biber"
                    ]
                },
                new Yiyecek
                {
                    Id = 13,
                    Name = "Karnıyarık",
                    Resim = "Resources/Images/yemek/karniyarik.jpg",
                    TarifMetni = "Patlıcanları alacalı olacak şekilde soyun, kürdanla birkaç yerden delikler açın. Üzerine zeytinyağını gezdirerek 200 derecede ısıtılmış fırına verin, patlıcanlar yumuşayana kadar pişirin. Kıymayı tencereye alın, suyunu salıp tekrar çekene kadar kavurun. Küp küp doğranmış biberleri de ekleyin. Sıvı yağını, küp küp doğranmış soğanları ve sarımsakları ekleyerek güzelce kavurun. Salçanızı da ekledikten sonra sıcak suyu su ilave ederek pişmeye bırakın. Baharatlarını ve ince kıyılmış maydanozu ekledikten sonra son bir kez karıştırın ve ocağın altını kapatın. Pişen patlıcanların ortasını bıçakla nazikçe açın, içini biraz tuzladıktan sonra kıymalı harçtan koyun. Diğer patlıcanlara da aynı işlemi yaparak fırın kabınıza yerleştirin. Üzerlerine domates ve biberleri ilave edin. Sosu için, sıcak suyun içinde salçayı güzelce karıştırın ve homojen olmasını sağlayın. Sosu fırın tepsisindeki karnıyarıkların üzerine dökün ve 180 derecelik, alt-üst fansız ayarlı fırının orta rafında domates ve biberler pişene kadar 20 dakika pişirin. Bu süre fırınınıza göre değişiklik gösterebilir, tüm malzemeler önceden piştiği için kontrollü olmanızda fayda var. Afiyet olsun!",
                    MalzemeListesi = [ "Patlıcan", "Kıyma", "Salça", "Soğan", "Sarımsak", "Yeşil Biber" ],
                    TarifMalzemeListesi =
                    [
                        "Malzemeler:",
                        "5 adet patlıcan",
                        "100 g kıyma",
                        "1 adet büyük boy soğan",
                        "2 diş sarımsak",
                        "1 adet yeşil biber",
                        "1 tutam maydanoz",
                        "2 yemek kaşığı sıvı yağ",
                        "1 tatlı kaşığı zeytinyağı",
                        "1 yemek kaşığı salça",
                        "2 çay kaşığı tuz",
                        "1 çay kaşığı karabiber",
                        "1/2 su bardağı sıcak su",
                        "Karnıyarık Sosu İçin:",
                        "1 su bardağı sıcak su",
                        "1 tatlı kaşığı (tepeleme) salça"
                    ]
                },
                new Yiyecek
                {
                    Id = 14,
                    Name = "Fırında Kaşarlı Mantar Sote",
                    Resim = "Resources/Images/yemek/kasarli_mantar_sote.jpg",
                    TarifMetni = "Öncelikle bütün malzemelerimizi güzelce yıkayıp kuruluyoruz. Mantarları kabuğunu soyarak kullanmak istiyorsanız üzerini silmeniz yeterli olacaktır fakat ben hep yıkayarak kullanıyorum. Ardından soğanları, biberleri ve domatesleri yıkayıp doğrama işlemine geçiyoruz. Soğanları ve biberleri küçük küçük, domatesleri de küp küp doğruyoruz. Domates kalın kabukluysa mutlaka soyalım. Mantarlarımızı bir damla limon sıkılmış suda bekletirsek kararmasını önleriz, ardından onları da çok küçük olmayacak şekilde doğruyoruz. Yaklaşık iki yemek kaşığı zeytinyağını tavada kızdırıp soğanları kavurmaya başlıyoruz. 1-2 dakika sonra hemen biberleri atalım ki biberlerimiz çok diri kalmasın. Soğanlar pembeleşip biberler yumuşadığında mantarları ekliyoruz. 5 dakika bu aşamada orta ateşte kavururken yarım yemek kaşığı kadar domates salçası ekliyoruz. Ardından 1 tutam tuz, 1 tutam karabiber ve 1 tutam pul biber ekliyoruz. Mantarlarımız suyunu çektiğinde domateslerimizi ekliyoruz. Domatesler de iyice pişip suyunu çektiğinde sotemizi alıyoruz. Üzerine kaşarları da ekleyip fırında 10-15 dakika pişiriyoruz. Afiyet olsun!",
                    MalzemeListesi =[ "Mantar", "Kaşar Peyniri", "Soğan", "Yeşil Biber", "Kırmızı Biber", "Domates", "Salça" ],
                    TarifMalzemeListesi =
                    [
                        "Malzemeler:",
                        "400g mantar",
                        "2 adet yeşil biber",
                        "2 adet kırmızı biber",
                        "1 adet büyük boy domates",
                        "1 adet soğan",
                        "½ su bardağı rendelenmiş kaşar peyniri",
                        "½ yemek kaşığı domates salçası",
                        "1 çay kaşığı tuz",
                        "1 çay kaşığı karabiber",
                        "1 çay kaşığı pul biber"
                    ]
                },
                new Yiyecek
                 {
                        Id = 15,
                        Name = "Alinazik",
                        Resim = "Resources/Images/yemek/alinazik.png",
                        TarifMetni = "Önce kıymayı tencereye alıp kendi suyunu salıp çekene kadar kavurun. Ardından yağları ekleyin kıyma biraz kızarınca ince doğranmış soğan ve sarımsağı ekleyin güzelce kavurun. En son salça ve baharatları ekleyip 2-3 dakika daha kavurun. Kıymalı harcımız hazır. Patlıcanları közleyip kabuklarını soyup ince ince doğrayın. Bir karıştırma kabına alıp üzerine sarımsak tuz ve yoğurt ekleyip pürüzsüz hale gelene kadar karıştırın. Servis edeceğimiz tabağa önce hazırladığımız yoğurtlu patlıcanı alın. Üzerine tekrar ısıtıp kıymalı harcı ekleyin. Maydanoz ile süsleyip servis edin. Afiyet olsun!",
                        MalzemeListesi =[ "Patlıcan", "Sarımsak", "Yoğurt", "Tereyağı", "Kıyma", "Soğan", "Salça" ],
                        TarifMalzemeListesi =
                        [
                            "Altı için:",
                            "3 adet büyük boy patlıcan",
                            "1 diş sarımsak",
                            "2,5 su bardağı süzme yoğurt",
                            "1 çay kaşığı tuz",
                            "Üzeri için:",
                            "300 g kıyma",
                            "½ çay bardağı sıvı yağ",
                            "2 tepeleme yemek kaşığı tereyağı",
                            "1 adet soğan",
                            "1 diş sarımsak",
                            "1 tatlı kaşığı domates salçası",
                            "1 tatlı kaşığı kırmızı toz biber",
                            "1 çay kaşığı karabiber",
                            "1 çay kaşığı tuz"
                        ]
                },
                new Yiyecek
                {
                    Id = 16,
                    Name = "Fırında Makarna",
                    Resim = "Resources/Images/yemek/firinda_makarna.jpg",
                    TarifMetni = "Beşamel sosu hazırlamak için; 4 yemek kaşığı tereyağı ve 2 yemek kaşığı sıvı yağı bir sos tenceresinde kızdırın. Ardından 3 yemek kaşığı unu üzerine ilave edin ve kokusu çıkana kadar kavurun. 2,5 su bardağı sütü de sos tenceresine ilave edip iyice karıştırın ve karışım koyulaşana kadar orta ateşte pişirin. Ara ara karıştırmayı ihmal etmeyin. Pişmiş olan beşamel sosun üzerine yarım muskat rendeleyip karıştırın ve ocaktan alın. Arzuya göre tuz ve karabiber ile tatlandırın. Derin bir tencerede kaynamış olan tuzlu suyun içine fırın makarnayı atın ve 10 dakika, yumuşayana kadar pişirin. Ocaktan alıp, suyunu süzdürün. Geniş bir kabın içerisinde, süzülmüş olan makarnayı ve beşamel sosu güzelce karıştırın. Makarnayı, pişireceğiniz fırın kabına alın ve üzerine 1,5 su bardağı rendelenmiş kaşar peyniri serpiştirin. Önceden ısıtılmış 190 derece fırında 25 dakika pişirin. İlk sıcaklığı geçtikten sonra dilimleyin ve servis edin. Fırın makarnamız hazır, afiyet olsun!",
                    MalzemeListesi =[ "Makarna", "Tereyağı", "Un", "Süt", "Kaşar Peyniri" ],
                    TarifMalzemeListesi =
                    [
                        "1 paket makarna",
                        "1,5 su bardağı rendelenmiş kaşar peyniri (üzeri için)",
                        "4 yemek kaşığı tereyağı",
                        "2 yemek kaşığı sıvı yağ",
                        "3 yemek kaşığı un",
                        "2,5 su bardağı süt",
                        "½ adet muskat cevizi"
                    ]
                },
                new Yiyecek
                {
                    Id = 17,
                    Name = "Etli Fajita",
                    Resim = "Resources/Images/yemek/etli_fajita.jpg",
                    TarifMetni = "Etleri, biberleri ve soğanları aynı boyda olacak şekilde julyen doğrayın. Derin bir tavayı zeytinyağı ile hafif yağlayın. Soğanları hafif rengi değişinceye kadar soteleyin. Biberleri ekleyin ve 3-4 dakika kadar sotelemeye devam edin. Etleri ekleyin ve 6-7 dakika kadar sotelemeye devam edin. Güveç veya ısıya dayanıklı porselen bir kabı kısık ateşte ocağa yerleştirin. Tereyağını ilave edin ve erimesini bekleyin. Eriyen tereyağının üzerine etleri, biberleri, soğanları ve dilediğiniz baharatları ilave edin. Afiyet olsun!",
                    MalzemeListesi =[ "Kırmızı Et", "Soğan", "Yeşil Biber", "Kırmızı Biber", "Tereyağı" ],
                    TarifMalzemeListesi =
                    [
                        "500 g dana bonfile",
                        "2 adet soğan",
                        "1 adet yeşil biber",
                        "1 adet kırmızı biber",
                        "1 adet sarı biber",
                        "2 çay kaşığı tuz",
                        "2 çay kaşığı karabiber",
                        "2 çay kaşığı sarımsak tozu",
                        "2 çay kaşığı soğan tozu",
                        "1 çay kaşığı acı toz biber",
                        "1 çay kaşığı toz tatlı biber",
                        "1 yemek kaşığı zeytinyağı",
                        "3 yemek kaşığı tereyağı"
                    ]
                },
                new Yiyecek
                {
                    Id = 18,
                    Name = "Yağlama",
                    Resim = "Resources/Images/yemek/yaglama.jpg",
                    TarifMetni = "Bir kabın içine unu alın ve ortasına bir havuz açın. Su, maya, şeker ve tuzu ilave ederek orta kısmını karıştırın. Ardından hamuru pürüzsüz bir kıvama gelene kadar yoğurun. Gerekirse un veya su ilavesi yaparak hamuru dengeleyin. Üzerini streç film ile kapatarak oda sıcaklığında iki katına çıkana kadar yaklaşık 40 dakika kadar mayalanmaya bırakın. Mayalanan hamurdan eşit küçük bezeler hazırlayın. (yaklaşık 10-12 adet) Hazırladığınız bezeleri yemek tabağı büyüklüğünde açın ve ısıtılmış düz bir tavada arkalı önlü pişirin. Kıymalı harcı için; sos tavasına yağları alın ve kızdırın. Ardından kıymayı ekleyip kavurun. Soğanları da ilave edip yumuşayana kadar pişirin. Üzerine salçayı ve domates püresini ekleyip 1-2 dakika kavurun. Ardından tuz, karabiber ve suyunu da ekleyip orta ateşte, kaynayıp yağı üzerine çıkana kadar pişirin. Tüm yufkaları pişirdikten sonra bir pişmiş yufka, ardından hazırladığınız kıymalı iç, ardından tekrar yufka sıralamasıyla kat çıkın. Tüm iç harç ve yufkalar bittiğinde yağlamayı dörde bölün ve maydanoz serpiştirip, arzuya göre üzerine yoğurt ekleyip servis edin. Afiyet olsun!",
                    MalzemeListesi = [ "Un", "Şeker", "Maya", "Soğan", "Kırmızı Et", "Salça", "Domates" ],
                    TarifMalzemeListesi =
                    [
                        "4 su bardağı un",
                        "1,5 çay kaşığı toz şeker",
                        "2 çay kaşığı tuz",
                        "1 yemek kaşığı instant maya",
                        "1,5 su bardağı ılık su",
                        "4 yemek kaşığı tereyağı",
                        "½ çay bardağı sıvı yağ",
                        "1 adet orta boy soğan",
                        "500 g orta yağlı dana kıyma",
                        "1 yemek kaşığı (tepeleme) domates salçası",
                        "2,5 su bardağı domates püresi (veya rendelenmiş domates)",
                        "1,5 çay kaşığı tuz",
                        "1 çay kaşığı karabiber",
                        "1,5 su bardağı su"
                    ]
                },
                new Yiyecek
                {
                    Id = 19,
                    Name = "Hünkar Beğendi",
                    Resim = "Resources/Images/yemek/hunkar_begendi.jpg",
                    TarifMetni = "Hünkar beğendi tarifi için 4 adet orta boy patlıcana bıçakla delikler açın ve fırın tepsisine alın. 200 derecede yaklaşık 20 dakika fırınlayın. Fırınlanmış patlıcanları bir kaba alın ve kabuklarının kolay soyulması için üzerini streçleyip, 15 dakika kadar bekledikten sonra kabukları soyun. Bir tavada 3 yemek kaşığı zeytinyağını kızdırın. 2 adet yemeklik doğranmış kuru soğanı da üzerine ilave edip pembeleşinceye kadar kavurun. 4 diş doğranmış sarımsağı da üzerine ekledikten sonra 600 gram kuşbaşı dana veya kuzu etini ilave edin. Etler suyunu salıp çekene kadar pişmeye bırakın. 1 yemek kaşığı domates salçası, 1'er çay kaşığı tuz ve karabiber, 3 adet soyulmuş, doğranmış domates ekleyin. 2 su bardağı sıcak su ekleyip etler yumuşayana kadar pişmeye bırakın. Şimdi de beğendiyi hazırlayalım. 1 yemek kaşığı tereyağını bir tavada eritin. 1,5 yemek kaşığı unu üzerine ilave edip kokusu çıkana kadar kavurun. Üzerine fırınladığınız ve kabuklarını soyduğunuz patlıcanları ekleyin. 1,5 su bardağı sütü de üzerine yavaş yavaş ilave edin ve sürekli olarak karıştırın. 1'er çay kaşığı tuz ve karabiberi de ekleyin. Sonra son olarak yarım su bardağı rendelenmiş kaşar peyniri ekleyin ve karıştırıp ocaktan alın. Beğendinin üzerine yumuşacık pişmiş etleri serpiştirin ve servis edin. Hünkar beğendi yemeği hazır, afiyet olsun!",
                    MalzemeListesi =  [ "Patlıcan", "Kırmızı Et", "Soğan", "Sarımsak", "Domates", "Salça", "Kaşar Peyniri", "Tereyağı", "Süt", "Un" ],
                    TarifMalzemeListesi =
                    [
                        "600 g kuzu but (arzuya göre dana eti)",
                        "2 adet orta boy kuru soğan",
                        "4 diş sarımsak",
                        "3 yemek kaşığı zeytinyağı",
                        "3 adet orta boy domates",
                        "1 yemek kaşığı domates salçası",
                        "2 su bardağı sıcak su",
                        "1 çay kaşığı tuz",
                        "½ su bardağı kaşar peyniri",
                        "1 yemek kaşığı tereyağı",
                        "1,5 su bardağı süt",
                        "4 adet orta boy patlıcan",
                        "1,5 yemek kaşığı un",
                        "1 çay kaşığı taze çekilmiş tane karabiber"
                    ]
                },
                new Yiyecek
                {
                    Id = 20,
                    Name = "Çökertme Kebabı",
                    Resim = "Resources/Images/yemek/cokertme_kebabi.jpg",
                    TarifMetni = "Fazla yağlı kısımlarından arındırılmış biftek ya da bonfile dilimlerini uzun ince şeritler halinde kesin. Et marinasyonu için tüm malzemeleri bir kapta karıştırın ve üzeri streç filmle kaplı kapta buzdolabında 1 saat kadar dinlendirin. Domates sosu hazırlamak için; tereyağını küçük bir tavada kızdırın. Üzerine pul biber ve rendelenmiş domatesi ekleyip, 10 dakika kadar pişirin ve ocaktan alın. Kabuğunu soyduğunuz patatesleri kibrit büyüklüğünde kesin. Bol suda durulayıp üzerlerini kağıt havlu yardımıyla kurulayın. Küçük bir tencerede kızdırdığınız derin yağda, birkaç partide altın sarısı rengini alana kadar kızartın. Kağıt havlu serili bir tabağa alıp dinlendirin. Etleri kızartmak için mümkünse döküm bir tavada az miktarda sıvı yağı kızdırın. Tereyağını ekleyin. Marine olan etleri yüksek ateşte pişirin. Renk aldıklarında tuz ve taze çekilmiş tane karabiberi katıp ocaktan alın. Servis tabaklarına sırasıyla; kızartılmış kibrit patates, çırpılmış sarımsaklı yoğurt, domates sos ve sotelenmiş et dilimlerini alıp kızarmış domates ve yeşil biberle süsledikten sonra bekletmeden sevdiklerinizle paylaşın. Afiyet olsun.",
                    MalzemeListesi = [ "Tereyağı", "Domates", "Soğan", "Süt", "Kırmızı Et", "Patates", "Yoğurt" ],
                    TarifMalzemeListesi =
                    [
                        "2 yemek kaşığı tereyağı",
                        "1 tatlı kaşığı pul biber",
                        "1 adet rendelenmiş domates",
                        "1 adet rendelenmiş soğan",
                        "1/2 çay bardağı zeytinyağı",
                        "1 tatlı kaşığı tuz",
                        "1 çay kaşığı kimyon",
                        "1 çay kaşığı karabiber",
                        "1/2 su bardağı süt",
                        "1 su bardağı soda",
                        "1 yemek kaşığı tereyağı (pişirmek için)",
                        "300 gram dana kontrfile",
                        "2 yemek kaşığı sıvı yağ",
                        "1/2 çay kaşığı tuz",
                        "1/2 çay kaşığı taze çekilmiş tane karabiber",
                        "2 adet orta boy patates",
                        "1,5 su bardağı ayçiçek yağı (kızartmak için)",
                        "4 yemek kaşığı sarımsaklı yoğurt"
                    ]
                },
                new Yiyecek
                {
                    Id = 21,
                    Name = "Yeşil Mercimekli Börek",
                    Resim ="Resources/Images/hamur_isi/mercimekli_borek.webp",
                    TarifMetni = "Soğanı yemeklik doğrayıp, sıvı yağ ve tereyağı karışımında yumuşayıncaya kadar kavurun. Ardından biber salçası ve domates salçasını ekleyin. Önceden haşlamış olduğunuz mercimekleri soğanlı karışıma ekleyin. Yaklaşık 3 dakika kadar ocakta tüm malzemeler bütünleşene kadar kavurun. Son olarak baharatlarını da ekleyip, soğuması için ocaktan alın. Süt ve zeytinyağını küçük bir kasede karıştırın. Yufkalardan birini serin ve yufkanın yarısına sütlü karışımdan bir fırça yardımıyla bolca sürün. Sütlü karışımlı yufkayı ikiye katlayın ve 8 eşit parça olacak şekilde kesin. Her parçanın geniş tarafına yakın iç harçtan koyun ve kenarlarından katlayarak sarın. Sarılan börekleri yağlanmış fırın tepsisine dizin. Üzerlerine yumurta sarısı, zeytinyağı ve süt karışımından sürüp, arzuya göre kavrulmuş susam serpin. Önceden ısınmış alt üst ayardaki fırında 180 derecede 40 dakika pişirin. Afiyet olsun!",
                    MalzemeListesi =[ "Yufka", "Süt", "Yeşil Mercimek", "Soğan", "Salça", "Yumurta" ],
                    TarifMalzemeListesi = [
                        "3 adet yufka",
                        "1/3 çay bardağı zeytinyağı",
                        "1/3 çay bardağı süt",
                        "1 su bardağı yeşil mercimek (haşlanmış)",
                        "1 adet orta boy soğan",
                        "1 yemek kaşığı sıvı yağ",
                        "1 tatlı kaşığı tereyağı",
                        "1 tatlı kaşığı domates salçası",
                        "1 tatlı kaşığı biber salçası",
                        "1 çay kaşığı tuz",
                        "½ çay kaşığı karabiber",
                        "½ çay kaşığı pul biber (arzuya göre)",
                        "1 adet yumurta sarısı",
                        "1 yemek kaşığı zeytinyağı",
                        "1 yemek kaşığı süt",
                        "2 yemek kaşığı susam (arzuya göre)"
                    ]
                },
                new Yiyecek
                {
                    Id = 22,
                    Name = "Kabartma Tozlu Poğaça",
                    Resim ="Resources/Images/hamur_isi/kabartma_tozlu_pogaca.webp",
                    TarifMetni = "Kabartma tozu, yoğurt, yumurta, yağ, tuz ve unu derin bir kapta yoğurup, hamur kıvamına getirin. Hamurları elinizde avuç içi büyüklüğünde yuvarlak şeklini verip içine istediğiniz harcı koyun ve yarım ay şeklinde kapatalım. Üzerlerine yumurta sarısı sürüp, çörek otu veya susam ile süsleyelim. 180 derecelik fırında üzeri altın rengi olana kadar pişirelim. Oda sıcaklığında ılıyınca servis edebilirsiniz. Afiyet olsun!",
                    MalzemeListesi =[ "Kabartma Tozu", "Tereyağı", "Yoğurt", "Yumurta", "Un" ],
                    TarifMalzemeListesi = [
                        "1 su bardağı yoğurt",
                        "1 su bardağı sıvı yağ",
                        "3 yumurta (1 tane sarı dışına)",
                        "125 g tereyağı",
                        "2 paket kabartma tozu",
                        "1 tatlı kaşığı tuz"
                    ]
                },
                new Yiyecek
                {
                    Id = 23,
                    Name = "Mayalı Poğaça",
                    Resim ="Resources/Images/hamur_isi/mayali_pogaca.webp",
                    TarifMetni = "Mayalı poğaça için ılık su ve sütü geniş bir karıştırma kabına alın. 1 paket yaş maya ve toz şekeri ekleyip karıştırdıktan sonra mayanın aktive olması için 5 dakika kadar bekletin. Maya tamamen eridikten sonra sıvı yağ ve tuzu ekleyin. Unu azar azar ekleyip hamuru toparlanana kadar yoğurmaya başlayın. Yumuşak ve yapışmayacak bir kıvamda bir hamur elde ettiğiniz zaman üzerini streç film ve nemli bir bezle kapatıp 40-45 dakika kadar oda ısısında mayalanmaya bırakın. Mayalanan hamurdan yumurta büyüklüğünde parçalar kopartıp avuç içinizde yuvarlayarak şekil verin. Tepsiye aralıklı olarak dizdiğiniz mayalı hamurların üzerine yumurta sarısı sürün. Son mayalandırma işlemi için 10-15 dakika kadar poğaçaları tepside bekletin ve önceden ısıtılmış 190 derece fırında 20 dakika kadar pişirin. Puf puf kabarmış mayalı poğaçalar hazır, afiyet olsun!",
                    MalzemeListesi =[ "Maya", "Un", "Yumurta", "Süt" ],
                    TarifMalzemeListesi = [
                        "1 adet yaş maya",
                        "3 çay bardağı süt",
                        "1 çay bardağı su",
                        "1 çay bardağı sıvıyağ",
                        "1 yemek kaşığı şeker",
                        "1 tatlı kaşığı tuz"
                    ]
                },
                new Yiyecek
                {
                    Id = 24,
                    Name = "Patatesli Gül Böreği",
                    Resim ="Resources/Images/hamur_isi/patatesli_gul_boregi.jpg",
                    TarifMetni = "Patateslerinizin kabuklarını soyup rendeleyin. Ardından ince ince doğranmış soğanları sıvı yağ ile birlikte tavaya alın ve güzelce kavurun. Tuz ilave edin. Patatesleri de üzerine ekleyerek birkaç dakika kavurun. Patatesler diri kalacaklar, uzun uzun kavurmanıza gerek yok. Yufkaları dört eşit parçaya bölün. Sıvı yağ ve suyu ayrı bir kapta karıştırın. Ardından fırça yardımıyla yufkaların her yerine sürün. Patatesleri yufkaların geniş tarafına uzunlamasına yayın. Sıkıca rulo yaptıktan sonra döndürerek gül şeklini verin. Fırın tepsinize dizin, üzerlerine yumurta sarısı sürün, dilerseniz çörekotu ya da susam serpin. Önceden ısıtılmış 180 derece fırında iyice kızarana kadar 25-30 dakika kadar pişirin. Fırından çıkarıp bir süre dinlendirin, ardından sıcak sıcak servis edin. Afiyetler olsun!",
                    MalzemeListesi =[ "Yufka", "Patates", "Soğan", "Yumurta" ],
                    TarifMalzemeListesi = [
                        "5 adet yufka",
                        "1 adet soğan",
                        "4 adet orta boy patates",
                        "1 çay kaşığı tuz",
                        "4 yemek kaşığı sıvı yağ",
                        "1 çay bardağı sıvı yağ (sos için)",
                        "1 çay bardağı su (sos için)",
                        "1 adet yumurta sarısı (üzeri için)",
                        "3 yemek kaşığı çörek otu (üzeri için)"
                    ]
                },
                new Yiyecek
                {
                    Id = 25,
                    Name = "Kıymalı Boşnak Böreği",
                    Resim ="Resources/Images/hamur_isi/bosnak_boregi.webp",
                    TarifMetni = "Öncelikle unun üzerine tuzu ekleyip su ile yavaş yavaş yoğuralım. Sert bir hamur elde edeceğiz. İyice yoğrulan hamuru 4 eşit parçaya bölelim. Daha sonra ayrı bir kapta sıvı yağı ve tereyağını eritelim. Soğumaya bırakalım. Eşit parçalara böldüğümüz hamuru her katı yağlı olacak şekilde elimizle ufak ufak açalım. İşlem bittikten sonra üzerini örtüp en az 1 saat dinlenmeye bırakalım. O sırada bir tavaya kıymayı kavurup soğanları ekleyelim. Dinlenen hamurumuzu erittiğimiz yağ yardımı ile büyük bir alanda elimizle açalım. İncecik bir hamur elde ettikten sonra iç harcını ekleyerek içerisine biraz da yağ koyarak kavuralım. Bu işlemi tüm hamurlara uygulayalım. Tepsimize yerleştirelim. Kalan yağı da hamurun üzerine gezdirerek fırında pişirelim. Afiyet olsun!",
                    MalzemeListesi =  [ "Un", "Kırmızı Et", "Soğan", "Tereyağı" ],
                    TarifMalzemeListesi = [
                        "5 su bardağı un",
                        "2 su bardağı su",
                        "1 tatlı kaşığı tuz",
                        "500 g kıyma",
                        "3 adet orta boy soğan",
                        "2 yemek kaşığı sıvı yağ",
                        "1 tatlı kaşığı tuz",
                        "1 tatlı kaşığı pul biber",
                        "½ tatlı kaşığı karabiber",
                        "1 çay bardağı sıvı yağ (hamuru yağlamak ve açmak için)",
                        "150 g tereyağı (hamuru yağlamak ve açmak için)"
                    ]
                }
            };
            }
        

      
            public List<Yiyecek> GetCorba()
            {
                return new List<Yiyecek>()
            {
                new Yiyecek
                {
                    Id = 26,
                    Name = "Mercimek Çorbası",
                    TarifMetni = "Derin bir tencereye 3 yemek kaşığı sıvı yağ ekleyin. İri doğranmış 1 adet büyük soğanı sıvı yağ ile birlikte kavurun. Kavrulan soğanlara 1 yemek kaşığı unu ekleyin ve kokusu çıkıp, renk alana kadar kavurma işlemini sürdürün. İri parçalar halinde doğradığınız birer adet havuç ve patatesi tencereye aktarıp karıştırmaya devam edin. Tuz, karabiber ve bol suda yıkadıktan sonra suyunu süzdürdüğünüz 1,5 su bardağı mercimeği de ilave edin ve son kez güzelce karıştırın. 6 su bardağı sıcak suyu da tencereye ilave edin. Ardından kapağını kapatın, patates ve havuçlar yumuşayana kadar ara ara karıştırarak 40 dakika kadar pişirin. Çorba piştikten sonra pürüzsüz bir kıvam alması için; el blenderından geçirin. 5 dakika daha pişirdikten sonra ocaktan alın. 3 yemek kaşığı sıvı yağ ve 2 yemek kaşığı tereyağını bir tavada kızdırın. Üzerine 1 tatlı kaşığı toz kırmızı biberi ekleyin ve 2 dakika yağı kızdırdıktan sonra ocaktan alın. Çorbayı bir kaseye alın ve üzerine kızdırdığınız yağdan gezdirip servis edin.",
                    Resim ="Resources/Images/corba/mercimek_corbasi.webp",
                    MalzemeListesi =["Soğan","Havuç", "Patates", "Kırmızı Mercimek"],
                    TarifMalzemeListesi =[
                        "3 yemek kaşığı ayçiçek yağı",
                        "1 adet kuru soğan",
                        "1 yemek kaşığı un",
                        "1 adet havuç",
                        "1 adet patates",
                        "1 tatlı kaşığı tuz",
                        "1 çay kaşığı karabiber",
                        "1,5 su bardağı kırmızı ya da sarı mercimek",
                        "6 su bardağı sıcak su",  "3 yemek kaşığı sıvı yağ",
                        "2 yemek kaşığı tereyağı",
                        "1 tatlı kaşığı kırmızı toz biber"
                    ]
                },
                new Yiyecek
                {
                    Id = 27,
                    Name = "Yeşil Mercimekli Erişte Çorbası",
                    TarifMetni = "Yeşil mercimekleri iyice yıkayın 10-15 dakika hafifçe yumuşamaya başlayana dek haşlayın. Haşladığınız suyu süzün. Soğanı küp küp doğrayın. Tereyağını eritin ve soğanları tereyağında çevirin. Domates salçasını soğanlarla beraber 2-3 dakika kavurun.  Haşlanan yeşil mercimekleri domates ve soğanlarla beraber kavurun. Tavuk suyunu ve suyu yavaş yavaş ilave edin. Tuz ve diğer baharatları ilave edin ve kaynatın. Erişteleri ilave edin ve iyice yumuşayana kadar kaynatmaya devam edin. Erişteler yumuşadığında çorbanız hazır. İşte bu kadar, afiyetler olsun!",
                    Resim ="Resources/Images/corba/eristeli_yesil_mercimek_corbasi.webp",
                    MalzemeListesi =[ "Yeşil Mercimek", "Erişte","Salça" ],
                    TarifMalzemeListesi = [
                    "1 su bardağı yeşil mercimek",
                    "½ su bardağı erişte",
                    "1 yemek kaşığı tereyağı",
                    "4 su bardağı su",
                    "1 su bardağı et suyu veya tavuk suyu",
                    "½ adet soğan",
                    "1 çay kaşığı nane",
                    "1 tatlı kaşığı tuz",
                    "1 çay kaşığı pul biber",
                    "1 yemek kaşığı domates salçası"
                    ]
                },
                new Yiyecek
                {
                    Id = 28,
                    Name = "Yoğurt Çorbası",
                    TarifMetni = "Orta boy bir tencerenin içerisine suyu dökün. İçine pirinçleri ekleyin. Kısık ateşte pirinçler yumuşayana kadar pişirin. Bir kabın içerisine yoğurt, yumurta ve unu aktarın. Güzelce çırpın ve içerisinde unun topaklanmamasına özen gösterin. Ocağın üzerinde pişen pirinçlerin suyundan bir kepçe alıp güzelce yoğurtlu karışıma yedirin. Ardından bu işlemi birkaç kepçe daha ilave ederek gerçekleştirin. Ocakta pişmekte olan pirinçlerin üzerine yoğurtlu karışımı çok dikkatli bir şekilde, incecik bir ip halinde dökerek bir yandan da karıştırın. Bu şekilde tüm yoğurdu ilave ettikten sonra kaynayana kadar güzelce karıştırın. Kuru naneyi ve tuzunu da ilave edin. Birkaç dakika daha ocakta pişirmeye devam edin. Bu aşamada kıvamı çok yoğunlaşırsa su ilave edebilirsiniz. Ayrı bir tavanın içerisinde tereyağını eritin ve üzerine kuru naneyi ekleyerek hafifçe yakın. Servis etmeden önce çorbanızın üzerine gezdirin. Ardından çorbanızı servis edin. Afiyetler olsun!",
                    Resim ="Resources/Images/corba/yogurt_corbasi.webp",
                    MalzemeListesi =[ "Pirinç", "Yoğurt", "Un", "Yumurta" ],
                    TarifMalzemeListesi =[
                        "2 litre su",
                        "6 yemek kaşığı pirinç",
                        "1 yemek kaşığı (tepeleme) un",
                        "1 adet yumurta",
                        "1,5 su bardağı yoğurt",
                        "2 çay kaşığı tuz",
                        "2 yemek kaşığı tereyağı",
                        "1 tatlı kaşığı (tepeleme) kuru nane"
                    ]
                },
                new Yiyecek
                {
                    Id = 29,
                    Name = "Domates Çorbası",
                    TarifMetni = "Tereyağını tavada eritin. Unu ekleyip kokusu çıkana kadar kısık ateşte kavurun. Rendelenmiş domatesleri kavrulmuş un karışımına ekledikten sonra 5 dakika kadar pişirin. Üzerine sıcak et suyunu ve tuzu ilave edin. Kesilmemesi için küçük bir cezvede ısıttığınız sütü azar azar ekleyip hızlıca karıştırın. Çorbayı kaynayana kadar orta ateşte ardından da kısık ateşte 15 dakika kadar pişirin. Domates çorbası hazır. Daha pürüzsüz bir kıvam alması için blenderdan geçirin. Servis kaselerine aldığınız çorbayı, rendelenmiş kaşar peynir ilavesiyle sıcak olarak servis edin. Afiyet olsun!",
                    Resim ="Resources/Images/corba/domates_corbasi.webp",
                    MalzemeListesi =[ "Domates", "Tereyağı", "Un", "Süt" ],
                    TarifMalzemeListesi =[
                        "1 yemek kaşığı tereyağı",
                        "2 çay bardağı sıcak süt",
                        "5 adet büyük boy domates",
                        "2 yemek kaşığı un",
                        "4 su bardağı sıcak et suyu",
                        "2 çay kaşığı tuz",
                        "1 su bardağı rendelenmiş kaşar peyniri"
                    ]
                },
                new Yiyecek
                {
                    Id = 30,
                    Name = "Lebeniye Çorbası",
                    TarifMetni = "Lebeniye çorbası için pirinci tencereye alarak 1 su bardağı su ekleyerek pişirin. Yumuşayınca üstüne biraz daha su ilave ederek kaynamaya bırakın. Lebeniye çorbasının terbiyesi için bütün malzemeleri bir araya getirin ve güzelce karıştırın. Köfte için bütün malzemeleri bir araya getirin ve güzelce yoğurun, nohut büyüklüğünde küçük köfteler yuvarlayın. Çorbadan bir kepçe terbiyesinin içine alarak ısının dengeleyerek çorbanın içine aktarın, nohutları da ilave ederek kaynayana kadar karıştırın. Köfteleri de tereyağında bir tavada pişirin. 1 yemek kaşığı tereyağında kızartın, iyice pişince naneyi de ekleyerek altını kapatın. Köfteleri de çorbanın içine ekleyince çorbanız hazır olacak. Lebeniye çorbası hazır. Afiyet olsun!",
                    Resim ="Resources/Images/corba/lebeniye_corbasi.webp",
                    MalzemeListesi =[ "Kırmızı Et", "Pirinç", "Soğan", "Nohut", "Yoğurt", "Un", "Tereyağı" ],
                    TarifMalzemeListesi =[
                        "1 su bardağı haşlanmış nohut",
                        "2 yemek kaşığı kırık pirinç",
                        "1,5 su bardağı yoğurt",
                        "2 yemek kaşığı un",
                        "1 yemek kaşığı limonun suyu",
                        "6 su bardağı su",
                        "1 tatlı kaşığı kuru nane",
                        "1 tatlı kaşığı tereyağı"
                    ]
                }
            };
            }

        

        
            public List<Yiyecek> GetSalata()
            {
                return new List<Yiyecek>()
            {
                new Yiyecek
                {
                    Id = 31,
                    Name = "Yeşil Mercimekli Börek",
                    Resim = "Resources/Images/salata/mercimek_koftesi.webp",
                    TarifMetni = "Mercimeği ve suyu ocağa alarak suyunu çekene kadar pişirin. Suyunu çekince bulguru ekleyin, yarım saat kapağını kapatıp bekletin. Tavada soğanı ve yağı kavurun. Salçayı ilave edin. Soğanlı karışımla mercimeği buluşturun. Oda sıcaklığına gelince yoğurun. Maydanoz ve baharatları ekleyip yoğurmaya devam edin. Yumurta büyüklüğünde parçalar koparıp şeklini verin. Marulla servis edin. Afiyet olsun!",
                    MalzemeListesi = [ "Kırmızı Mercimek", "Soğan", "Salça", "Bulgur" ],
                    TarifMalzemeListesi =
                    [
                        "1 su bardağı kırmızı mercimek",
                        "3 su bardağı su",
                        "1 adet soğan",
                        "1,5 su bardağı ince bulgur",
                        "2 yemek kaşığı biber salçası",
                        "½ demet maydanoz",
                        "4-5 yemek kaşığı zeytinyağı",
                        "1 çay kaşığı karabiber",
                        "1 çay kaşığı kimyon",
                        "1 tatlı kaşığı tuz",
                        "1 çay kaşığı toz kırmızı biber"
                    ]
                },
                new Yiyecek
                {
                    Id = 32,
                    Name = "Köz Patlıcan Salatası",
                    Resim = "Resources/Images/salata/koz_patlican.jpg",
                    TarifMetni = "Patlıcan ve biberleri yıkayıp kurulayalım. Pişirme kağıdı serilmiş tepsiye dizelim. 200 derece ısınmış fırında yaklaşık 25 dakika közlenmeye bırakalım. Bu sırada salata sosunu yapalım. Közlenen patlıcan ve biberlerin kabuğunu sayalım. Elimizle hafif sıkarak, suyundan kurtulalım. Küçük küçük doğrayıp karıştıralım. Salata sosu için: limonun suyunu sıkalım. Sarımsakları rendeleyelim. Limon suyuna ekleyelim. Zeytinyağ, tuz da ilave edip iyice karıştıralım tuz erisin. Üzerine sosu gezdirip iyice karıştıralım. Maydanoz ile süsleyelim. Afiyet olsun!",
                    MalzemeListesi = [ "Patlıcan", "Kırmızı Biber", "Sarımsak" ],
                    TarifMalzemeListesi =
                    [
                        "2 adet orta boy patlıcan",
                        "10 adet büyük boy kırmızı biber",
                        "3-4 dal maydanoz",
                        "1 adet limon",
                        "½ çay bardağı zeytinyağı",
                        "3 diş sarımsak",
                        "1 tatlı kaşığı tuz"
                    ]
                },
                new Yiyecek
                {
                    Id = 33,
                    Name = "Tavuklu Sezar Salata",
                    Resim = "Resources/Images/salata/tavuklu_sezar_salata.webp",
                    TarifMetni = "Bir kaseye ezdiğiniz sarımsağı alın. Mayonez ve hardalı da ekleyin. Güzelce karıştırın. Kızdırdığınız tavaya tavukları ekleyin. 2'şer dakika arkalı önlü kızartın. Sos ile marulları buluşturun. Güzelce harmanlayın. Krutonları ve tavukları da ekledikten sonra hazır. Parmesan peyniri ile servis edebilirsiniz.",
                    MalzemeListesi = [ "Tavuk", "Marul", "Sarımsak" ],
                    TarifMalzemeListesi =
                    [
                        "100 gram tavuk göğsü",
                        "10 adet kruton (fırınlanmış ekmek küpleri)",
                        "3-4 dilim parmesan peyniri",
                        "½ adet marul",
                        "2 yemek kaşığı mayonez",
                        "1 tatlı kaşığı hardal",
                        "1 diş sarımsak",
                        "¼ adet limon",
                        "½ çay kaşığı tuz"
                    ]
                },
                new Yiyecek
                {
                    Id = 34,
                    Name = "Havuç Tarator",
                    Resim = "Resources/Images/salata/havuc_tarator.jpg",
                    TarifMetni = "Havuçları bir tavaya alın. Çok az zeytinyağıyla beraber orta ateşte, yumuşayana dek, 2-3 dakika kadar kavurun ve bir köşede soğumaya alın. Bir kabın içerisine yoğurt, süzme yoğurt, zeytinyağı, ezilmiş sarımsak ve tuzu alarak karıştırın. Cevizler, havuçlar ve sarımsakları da ekleyin. Güzelce karıştırın. Havuç tarator hazır. Karışımı servis tabağına alın ve üzerine cevizleri ekleyin. Zeytinyağı gezdirin ve biraz kıyılmış maydanoz serpin. Afiyet olsun!",
                    MalzemeListesi = [ "Havuç", "Yoğurt", "Sarımsak" ],
                    TarifMalzemeListesi =
                    [
                        "2 adet büyük boy havuç (rendelenmiş)",
                        "5 yemek kaşığı yoğurt",
                        "3 yemek kaşığı süzme yoğurt",
                        "1 diş ezilmiş sarımsak",
                        "2 yemek kaşığı zeytinyağı (pişirmek için)",
                        "6 adet ceviz içi",
                        "1 çay kaşığı tuz",
                        "2 yemek kaşığı zeytinyağı (içine eklemek için)"
                    ]
                },
                new Yiyecek
                {
                    Id = 35,
                    Name = "Cacık",
                    Resim = "Resources/Images/salata/cacik.jpeg",
                    TarifMetni = "Salatalığı alacalı soyun ve uzunlamasına ikiye bölüm yarım ay şeklinde ince ince doğrayın. Salatalıkları bir kaseye alın ve hafifçe tuzlayıp karıştırın, kenarda bekletin. Sarımsağı hafifçe tuzlayıp havanda tokmakla dövün. Yoğurdun üzerine ezilmiş sarımsağı ekleyin ve pürüzsüz olana kadar karıştırın. Sarımsaklı yoğurdu salatalıkların üzerine aktarın ve birleşene kadar karıştırın. Cacığı servis kasesine alın, üzerine zeytinyağı gezdirip servis edin. Afiyet olsun!",
                    MalzemeListesi = [ "Yoğurt", "Sarımsak", "Salatalık" ],
                    TarifMalzemeListesi =
                    [
                        "1 adet büyük boy salatalık",
                        "2 tutam tuz",
                        "1 diş sarımsak",
                        "1,5 su bardağı yoğurt",
                        "1,5 su bardağı soğuk su",
                        "2 yemek kaşığı zeytinyağı"

                    ]

                }
            };
            }
        

        
            public List<Yiyecek> GetTatli()
            {
                return new List<Yiyecek>()
            {
                new Yiyecek
                {
                    Id = 36,
                    Name = "Kalburabastı",
                    Resim = "Resources/Images/tatli/kalburabasti.webp",
                    TarifMetni = "Öncelikle kalburabastının şerbetini hazırlayın. Şeker ve suyu karıştırarak kaynamaya bırakın, kaynadıktan sonra limon suyu sıkarak kısık ateşte 10 dakika kadar kaynatmaya devam edin. Ardından ocaktan alıp ılınmaya bırakın. Tatlı için, un hariç bütün malzemeleri bir araya getirin ve güzelce karıştırın. Azar azar unu ilave edin. Kıvamına göre 3,5-4 su bardağı kadar alacaktır. Ele yapışmayacak kıvama gelene kadar yoğurun. Cevizden biraz daha büyük olacak şekilde parçalar koparın ve yuvarlayın. İsterseniz süzgeçte ya da kullandığımız gibi bir kesme aparatının üzerine bastırarak şekil almasını sağlayın. Cevizi ortasına koyarak nazikçe birleştirin. Fırın tepsinize dizin, önceden ısıtılmış fırında iyice kızarana kadar 25- 30 dakika pişirin. Fırından çıkınca sıcak kalburabastının üzerine soğuk şerbeti dökün. Şerbeti iyice çekince servis edin. Kalburabastı hazır. Afiyetler olsun.",
                    MalzemeListesi =["Tereyağı", "Un", "İrmik", "Yoğurt", "Yumurta", "Kabartma Tozu", "Şeker", "Kuruyemiş"],
                    TarifMalzemeListesi =
                    [
                        "250 g tereyağı",
                        "3 su bardağı un",
                        "1 su bardağı irmik",
                        "2 yemek kaşığı yoğurt",
                        "2 yemek kaşığı ayçiçek yağı",
                        "1 yumurta",
                        "1 paket kabartma tozu",
                        "1 su bardağı ceviz içi",
                        "2,5 su bardağı toz şeker",
                        "2,5 su bardağı su",
                        "½ adet limonun suyu"
                    ]
                },
                new Yiyecek
                {
                    Id = 37,
                    Name = "Sufle",
                    Resim = "Resources/Images/tatli/sufle.webp",
                    TarifMetni = "Muffin kaplarını katı yağ ile yağlayın ve biraz un serpiştirin. Kalıbı sallayarak unun yayılmasını sağlayın. En son kalıbı ters çevirip fazla unun düşmesini sağlayın. Bitter çikolataları tereyağıyla birlikte benmari usulü eritin. Başka bir kapta yumurtaları tuz ve şekerle birlikte iyice çırpın. Unu da ekleyip karıştırmaya devam edin. Karışıma eritilmiş yağlı bitter çikolatayı yavaş yavaş akıtarak ve aynı zamanda karıştırarak yedirin. Hazır olan çikolatalı karışımı muffin kalıplarına paylaştırın. 200 derece ısınmış fırında 10 dakika kadar pişirin. Pişen suflelerin üzerine pudra şekeri serpin. Çilekle süsleyin. Çikolatalı suflenizi hemen servis edin.",
                    MalzemeListesi =["Çikolata", "Tereyağı", "Şeker", "Un", "Yumurta"],
                    TarifMalzemeListesi =
                    [
                        "3 adet yumurta",
                        "4 yemek kaşığı toz şeker",
                        "1 tutam tuz",
                        "170 gram bitter çikolata",
                        "2 yemek kaşığı un",
                        "110 gram tereyağı",
                        "Göz kararı süslemek için pudra şekeri ve çilek"
                    ]
                },
                new Yiyecek
                {
                    Id = 38,
                    Name = "Çilekli Tart",
                    Resim = "Resources/Images/tatli/cilekli_tart.webp",
                    TarifMetni = "Tartın kremasını hazırlamak için; derin bir kaba aldığınız yumurta sarılarını toz şeker ve mısır nişastası ilavesiyle çırpın. Toz şekerler tamamen erimiş ve karışımın rengi beyaza dönük olmalı. Soğuk sütü küçük bir tencereye aktarın. Bir taşım kaynattıktan sonra ocaktan alın. Sıcak sütü yavaşça ılıştırarak ve sürekli karıştırarak yumurtalı karışıma ekleyin. Aralarda karıştırarak, kısık ateşte koyu bir krema kıvamını alana kadar pişirin. Ocaktan aldığınız krema karışımına azar azar labne katıp, kıvam alması ve renginin berrak olması için bir çırpıcı yardımıyla karıştırın. Kremanın üzerini streçle kapatın. Kabuk tutmaması için resimdeki gibi, kremaya değecek şekilde kapatmalısınız. Oda sıcaklığına geldikten sonra buzdolabında en az 1 saat bekletin. Bir mutfak robotuna unu, tuzu ve pudra şekerini ekleyin. Küçük parçalara ayırdığınız soğuk tereyağını azar azar katıp kum gibi bir kıvam alana dek karıştırın. Yumurta sarısı ve soğuk suyu katıp bir parça daha karıştırmaya devam edin. Tahta bir kaşıkla toparladığınız tart hamurunu, yatay şekilde streç filmle sardıktan sonra buzdolabında 30 dakika kadar dinlendirin. Dinlenen hamuru açarak, tereyağıyla yağladığınız maksimum 27 cm.'lik bir tart kalıbına yerleştirin. Kenarlarını elinizle bastırarak yapıştırın. Tart hamurunun üzerine çatalla delikler açın. Hamurun eşit oranda pişmesi ve kabarması için tart kalıbı büyüklüğünde bir yağlı kağıt kesin ve hamurun üzerine açın. Orta kısmını ağırlık yapması ve hamura düz şeklini vermesi için pirinç, nohut, kuru fasulye gibi bir bakliyatla doldurun. Önceden ısıtılmış 180 derece fırında, yaklaşık 25 dakika hafif bir renk alana kadar tart hamurunu pişirin. Fırından çıktıktan sonra üzerindeki yağlı kağıt ve kuru bakliyatları alın. Aynı ısıda 10 dakika daha fırınladığınız tart tabanını fırından alın, dinlendirin. Buzdolabında soğuyan kremayı yumuşayana dek çırpın. Tartın orta kısmına boşaltın ve düzleyin. Üzerine çilekleri de yerleştirdikten sonra servis edin. Afiyet olsun!",
                    MalzemeListesi = ["Tereyağı", "Süt", "Un", "Yumurta", "Nişasta", "Şeker", "Vanilya", "Çilek"],
                    TarifMalzemeListesi =
                    [
                        "Tart Hamuru:",
                        "230 g un",
                        "125 g serin tereyağı",
                        "70 g tozşeker",
                        "2 adet orta boy yumurta sarısı",
                        "1 paket şekerli vanilin",
                        "1 çimdik tuz",
                        "Dolgu Kreması:",
                        "500 ml süt",
                        "80-100 g tozşeker",
                        "2 orta boy yumurta beyazı",
                        "35 g un",
                        "15 g nişastası",
                        "1 paket şekerli vanilin",
                        "90 g labne",
                        "Üzeri İçin:",
                        "300 gram çilek"
                    ]
                },
                new Yiyecek
                {
                    Id = 39,
                    Name = "Elmalı Kurabiye",
                    Resim = "Resources/Images/tatli/elmali_kurabiye.webp",
                    TarifMetni = "Elmalı kurabiye tarifini hazırlamak için rendelenmiş elmaları tavaya alın. Üzerine toz şekeri ilave edin. Karamelize olana dek pişirin. Piştikten sonra üzerine yarım su bardağı kadar dövülmüş ceviz ve tarçın ekleyin, karıştırın. Hamurunu hazırlamak için derin bir kaseye oda sıcaklığında yumuşamış tereyağı, sıvı yağ, yoğurt, toz şeker, limon suyu ve karbonatı ekleyin. Güzelce yoğurun ve ardından unu da azar azar ekleyerek, ele yapışmayan fakat yumuşak olan bir hamur elde edin. Hamuru tezgahın üzerinde toparlayın. Tezgaha hafifçe un serperek açın. Yuvarlak şekiller çıkarıp elmalı harcı ortasına koyun ve iki yandan katlayın. Pişirme kağıdı serdiğiniz fırın tepsisine kurabiyeleri dizin ve önceden ısıtılmış 180 derece fırında üzeri kızarana kadar, yaklaşık 20-25 dakika pişirin. Oda sıcaklığına geldikten sonra üzerine pudra şekeri serpiştirin. Elmalı kurabiye hazır!",
                    MalzemeListesi = ["Elma", "Şeker", "Un", "Yoğurt", "Kabartma Tozu", "Tereyağı", "Kuruyemiş", "Tarçın"],
                    TarifMalzemeListesi =
                    [
                        "Kurabiye Hamuru:",
                        "80 g şeker",
                        "500 g un",
                        "200 g tereyağı, yumuşak, küçük parçalara bölünmüş",
                        "150 g yoğurt",
                        "1 tatlı kaşığı kabartma tozu",
                        "İç Malzemesi ve Tamamlanması:",
                        "80 g ceviz",
                        "400 g elma, dörde bölünmüş, çekirdeksiz",
                        "120 g şeker",
                        "1 tatlı kaşığı toz tarçın"
                    ]
                },
                new Yiyecek
                {
                    Id = 40,
                    Name = "Portakallı Çikolatalı Kek",
                    Resim = "Resources/Images/tatli/portakalli_kek.webp",
                    TarifMetni = "Portakalları sekize bölüp şekerle mutfak robotundan geçirin. Yumurtayı ekleyip mikserle çırpın, süt ve sıvı yağ ekleyip çırpmaya devam edin. Tuz, kabartma tozu, unu ekleyip karıştırın. Hamurun yarısını yağlanmış kalıba dökün ardından çikolataları küçük küçük doğrayıp ekleyin. Ardından kalanı da dökün. 170 derece fırında 40-45 dakika pişirin. Afiyet olsun.",
                    MalzemeListesi = ["Portakal", "Çikolata", "Şeker", "Un", "Kabartma Tozu", "Yumurta", "Süt"],
                    TarifMalzemeListesi =
                    [
                        "1 adet portakal",
                        "250 g şeker",
                        "3 yumurta",
                        "120 ml süt",
                        "120 ml sıvıyağ",
                        "250 g un",
                        "1 paket kabartma tozu",
                        "100 g çikolata"
                    ]
                },
                new Yiyecek
                {
                    Id = 41,
                    Name = "Waffle",
                    Resim = "Resources/Images/tatli/waffle.webp",
                    TarifMetni = "Yumurta ve şekeri rengi açılıp, köpürene kadar çırpın. Üzerine süt, kabartma tozu, vanilin, un, tuz ve sıvı yağ ekleyip çırpmaya devam edin. Hafif akışkan kıvamlı bir harç elde edin. Waffle ya da tost makinesini kızdırın ve yağlayın. Hazırladığınız harçtan bir kepçe kadar dökün. Makinanın kapağını kapattıktan sonra orta ısıda, aralarda kontrol ederek pişirme işlemini gerçekleştirin. Hazırladığınız waffle karışımı bitene kadar aynı işlemi tekrarlayın. Renk alıp, dışı çıtır içi daha yumuşak kıvamda kalarak pişen waffle'ları servis tabağına alın. Nutella, fındık kreması, çilek ve muz dilimleri ekleyip Hindistan cevizi, Antep fıstığı ve dövülmüş fındık serpiştirip, sevdiklerinizle afiyetle tüketin. Afiyetler olsun!",
                    MalzemeListesi =["Yumurta", "Süt", "Un", "Kabartma Tozu", "Vanilya", "Muz", "Çilek", "Şeker"],
                    TarifMalzemeListesi =
                [
                    "2 adet yumurta",
                    "1 yemek kaşığı toz şeker",
                    "1 su bardağı süt",
                    "1 paket kabartma tozu",
                    "1 paket vanilin",
                    "1,5 su bardağı un",
                    "1 çay kaşığı tuz",
                    "4 yemek kaşığı sıvı yağ",
                    "2 yemek kaşığı çikolata (isteğe bağlı)",
                    "2 yemek kaşığı fındık kreması (isteğe bağlı)",
                    "5 adet çilek",
                    "1 adet muz"
                    ]
                },
                new Yiyecek
                {
                    Id = 42,
                    Name = "Limon Soslu Cheesecake",
                    Resim = "Resources/Images/tatli/limonlu_cheesecake.webp",
                    TarifMetni = "Rondoda bisküvileri toz haline gelene dek çekin. Toz şekeri ve eritilmiş tereyağıyla karıştırarak bir araya gelmesini sağlayın. Yağlı kağıttan kelepçeli kalıbın tabanını kaplayacak büyüklükte bir parça kesin. Kalıbı kağıdın üzerine yerleştirerek, kalıbın etrafını kalemle çizerek sonrasında makasla kesebilirsiniz. Kağıdı kalıbın tabanına yerleştirin ve bisküvi karışımını kalıba aktarın. Bisküviyi kalıba eşit şekilde yayın ve bir bardakla üzerine bastırarak düzleştirin. Önceden ısıttığınız fırında 10 dakika pişirip dışarı alın ve fırın ısısını 150 dereceye düşürün. \n\nİç Harcı İçin:\nKarıştırma kabında labne, un ve toz şekeri düşük devirde çırpın. Fazla hava almamasına özen gösterin. Ayrı bir kasede limon suyu, krema ve limon kabuğunu karıştırın ve labneli karışımın içerisine ilave edin ve spatula ile karışıma yedirin. Yumurtaları teker teker ilave edin. Bir yumurta ekleyip iyice karıştırdıktan sonra bir sonrakini ilave edin. Yumurtalar karışıma iyice karıştıktan sonra, kelepçeli kalıba bu harcı dökün. Kelepçeli kalıbın her yanını sıkıca alüminyum folyo ile kaplayın. Kelepçeli kalıbın içine oturabileceği bir kalıp ayarlayın ve içerisine 3 parmak olacak şekilde su koyun ve bu şekilde fırına verin. 70 dakika boyunca pişirin. 70 dakika sonunda fırının kapağını açmadan 15 dakika boyunca bu şekilde bekletin. 15 dakika sonunda, fırının kapağını açın ve cheesecake'i içinde 20 dakika daha bekletin. \n\nLimonlu Sos İçin:\nLimonlu sos için gerekli tüm malzemeleri ufak bir tencereye alın. Orta ateşte sürekli karıştırarak kıvamı koyulaşana kadar pişirin. Soğuyan sosu dinlenen kekin üzerine dökerek servis edin. Afiyet olsun!",
                    MalzemeListesi = ["Limon", "Tereyağı", "Labne", "Krema", "Bisküvi", "Şeker", "Nişasta"],
                    TarifMalzemeListesi =
                    [
                        "300 gram yulaflı bisküvi",
                        "110 gram tereyağı(eritilmiş)",
                        "40 gram toz şeker",
                        "700 gr. labne peyniri",
                        "200 gram toz şeker",
                        "200 gram krema",
                        "4 adet yumurta(oda sıcaklığında)",
                        "25 gram un",
                        "3,5 yemek kaşığı limon suyu",
                        "1 yemek kaşığı limon rendesi",
                        "1 su bardağı limon suyu",
                        "1 adet limon kabuğu rendesi",
                        "1/2 su bardağı toz şeker",
                        "1 yemek kaşığı (silme) nişasta",
                        "1 yemek kaşığı tereyağı"
                    ]
                },
                new Yiyecek
                {
                    Id = 43,
                    Name = "Baklava",
                    Resim = "Resources/Images/tatli/baklava.jpg",
                    TarifMetni = "Önce şerbetini hazırlıyoruz. Şeker ve su kaynatılır. Birkaç dakika kaynadıktan sonra altı kapatılır. Soğuması için kenara alınır. Fırın tepsisi yağlanır. Yufkalardan biri tepsiye serilir. Üzerine ceviz serpilir. İkinci yufka üzerine serilir ve sıvı yağ gezdirilir. Üçüncü yufka serilip ceviz serpilir. Dördüncü yufka serilip sıvı yağ gezdirilir. Bu şekilde bir ceviz bir sıvı yağ olmak üzere tüm yufkalara sırasıyla aynı işlem uygulanır. En son yufka serildiğinde üzerine bir şey koymuyoruz. Ve baklavamızı dilimliyoruz. Ayrı bir yerde tereyağını eritiyoruz. İlk sıcaklığı geçince soğumadan dilimlediğimiz baklavanın üzerine döküyoruz. 180-200 derece fırında kızarana kadar pişiriyoruz. Fırından çıkan baklavanın ilk sıcaklığı geçince soğumuş olan şerbetimizi döküyoruz. Baklavamız şerbetini iyice çekip dinlendikten sonra servise hazırdır.",
                    MalzemeListesi =["Baklavalık Yufka", "Şeker", "Kuruyemiş", "Tereyağı"],
                    TarifMalzemeListesi =
                    [
                        "1 paket baklavalık yufka (40 adet oluyor içinde)",
                        "3-4 su bardağı dövülmüş ceviz veya fıstık",
                        "1,5 su bardağı sıvı yağ",
                        "200 g tereyağı",
                        "4 su bardağı su",
                        "3 su bardağı şeker"
                    ]
                },
                new Yiyecek
                {
                    Id = 44,
                    Name = "Bisküvili Pasta",
                    Resim = "Resources/Images/tatli/biskuvili_pasta.jpg",
                    TarifMetni = "İlk olarak muhallebimizi hazırlayalım. Bunun için uygun bir tencereye un, kakao, toz şeker ve sütü alalım ve karıştıralım. Tencereyi ocağa alalım ve muhallebi koyulaşıncaya kadar karıştırarak pişirelim. Koyulaşan muhallebimizi ocaktan alalım, içerisine tereyağı ve vanilyayı ekleyerek karıştıralım. Orta boy kare borcama petibör bisküvimizden bir sıra dizelim. Üzerine hazırladığımız muhallebiyi boşaltarak yayalım. Muhallebiyi yaydıktan sonra 2. kata geçelim. Aynı işlemi uygulayarak 4 kat bisküvi 4 kat muhallebi olacak şekilde pastamızı tamamlayalım. Oda sıcaklığına geldikten sonra pastayı en az 2 saat buzdolabında bekletelim. Pastamızı dolaptan aldıktan sonra üzerine rondodan geçirilmiş bisküvilerle kaplayalım. Daha sonra dilimleyip süsleyerek servis edelim. Afiyet olsun :)",
                    MalzemeListesi =["Bisküvi", "Kakao", "Un", "Şeker", "Süt"],
                    TarifMalzemeListesi =
                    [
                        "3 yemek kaşığı un",
                        "4 yemek kaşığı kakao",
                        "1 su bardağı toz şeker",
                        "6 su bardağı süt",
                        "1 yemek kaşığı tereyağı",
                        "1 paket vanilya",
                        "3 paket petibör bisküvi"
                    ]
                },
                new Yiyecek
                {
                    Id = 45,
                    Name = "Brownie",
                    Resim = "Resources/Images/tatli/brownie.jpg",
                    TarifMetni = "Öncelikle 150 gram tereyağını küçük parçalara bölün ve eritin. Erittiğiniz tereyağını bir karıştırma kabına alın ve içine 260 gram bitter çikolatayı ekleyerek karıştırın. Bu karışımı sos kıvamına gelene kadar eritin. Bir başka kapta 3 yumurta ve 1 su bardağı toz şekeri çırpın. Ardından bu karışıma eritilmiş çikolata ve tereyağı karışımını azar azar ekleyin. Karışımı iyice çırpın. Elenmiş 1 su bardağı unu, 1 paket vanilyayı ve 1.5 yemek kaşığı kakao tozunu ekleyerek spatula yardımıyla karıştırın. Hamuru yağlı kağıt serilmiş bir fırın kabına dökün ve düzleştirin. Önceden ısıtılmış 160 derece fırında 30-35 dakika pişirin. Pişen brownieyi fırından çıkarın ve oda sıcaklığında 1 saat dinlendirin. Ardından dilimleyerek servis yapın. Afiyet olsun!",
                    MalzemeListesi =[ "Tereyağı", "Yumurta", "Şeker", "Un", "Kakao", "Çikolata", "Vanilya" ],
                    TarifMalzemeListesi =
                    [
                        "150 gram tereyağı",
                        "260 gram bitter çikolata",
                        "3 yumurta",
                        "1 su bardağı toz şeker",
                        "1 su bardağı un",
                        "1 paket vanilya",
                        "1.5 yemek kaşığı kakao"
                    ]
                },
                new Yiyecek
                {
                    Id = 46,
                    Name = "Mozaik Pasta",
                    Resim = "Resources/Images/tatli/mozaikpasta.webp",
                    TarifMetni = "Öncelikle 2 paket petibör bisküviyi (400 g) elimizle ufak parçalar olmayacak şekilde kıralım. Sos için uygun bir karıştırma kabına 1 su bardağı süt (200 ml) alalım. Üzerine 50 gram eritilmiş tereyağı, 3 yemek kaşığı kakao ve 2 yemek kaşığı toz şekeri ekleyerek güzelce çırpalım. Ardından kırdığımız bisküvileri de karışıma ekleyerek güzelce karıştıralım. Her yanını sosa buladığımız bisküvilerimizi streç film üzerine boşaltalım ve sıkıca sararak şekillendirelim. Son olarak şekillendirdiğimiz pastayı derin dondurucuya kaldırarak en az 2 saat bekletelim. Dolaptan aldıktan sonra streç filmi açalım ve pastamızı dilediğimiz kalınlıkta dilimleyelim. Dilimlerden bir tanesini alıp benmari usulü erittiğimiz çikolataya batırarak üzerine Antep fıstığı, fındık veya ceviz kırığı serpelim. Servis edelim. Afiyet olsun!",
                    MalzemeListesi =["Bisküvi", "Kakao", "Tereyağı", "Şeker", "Süt"],
                    TarifMalzemeListesi =
                    [
                        "2 paket petibör bisküvi (400 g)",
                        "3 yemek kaşığı kakao",
                        "50 gram tereyağı",
                        "2 yemek kaşığı toz şeker",
                        "1 su bardağı süt (200 ml)"
                    ]
                },
                new Yiyecek
                {
                    Id = 47,
                    Name = "Kakaolu Islak Kek",
                    Resim = "Resources/Images/tatli/islak_kek.jpg",
                    TarifMetni = "Şeker ve yumurtayı güzelce çırpın. İçine diğer sıvı malzemeleri ilave edin. Eleyerek kuru malzemeleri ilave edin ve çırpın. Dikdörtgen fırın kabınızı yağlayarak harcınızı içine dökün. Önceden ısıtılmış 180 derece fırında kürdan testinden geçene kadar pişirin. Kek pişerken sosu hazırlayın. Süt, şeker, kakao ve çikolata parçalarını bir sos tavasına alın ve çikolata eriyene kadar pişirin. Kaynatma yapmıyoruz, çikolatanın erimesi yeterli. Sosu ılımaya bırakın. Fırından çıkan kekin her yerine kürdan batırın ki sos her yerine ulaşsın. Daha sonra dilimleyin ve sosunuzu dökün. Kekin sıcak sosun ılık olmasına dikkat edin. Sosu tamamen çekince servis edin. Üzerini Hindistan cevizi, Antep fıstığı ve çilekle süsleyebilirsiniz. Afiyet olsun!",
                    MalzemeListesi =["Yumurta", "Şeker", "Süt", "Kakao", "Un", "Vanilya", "Kabartma Tozu", "Çikolata"],
                    TarifMalzemeListesi =
                    [
                        "4 adet yumurta",
                        "1 su bardağı toz şeker",
                        "1 su bardağı süt",
                        "1/2 su bardağı sıvı yağ",
                        "3 yemek kaşığı kakao",
                        "2 su bardağı un",
                        "2 paket vanilin",
                        "1 paket kabartma tozu",
                        "2 su bardağı süt (sos için)",
                        "2 yemek kaşığı kakao (sos için)",
                        "2 yemek kaşığı toz şeker (sos için)",
                        "60 gram çikolata (sos için)"
                    ]
                },
                new Yiyecek
                {
                    Id = 48,
                    Name = "Muzlu Rulo Pasta",
                    Resim = "Resources/Images/tatli/muzlu_rulo_pasta.jpg",
                    TarifMetni = "İlk olarak pastanın kreması hazırlanır. Krema için bir tencereye vanilya ve tereyağı hariç tüm malzemeleri katarak koyulaşıncaya kadar karıştırın. Kaynadıktan sonra ocağın altını kapatın. Vanilyayı ve tereyağını ekleyip karıştırın. Daha sonra pandispanya hazır oluncaya kadar hızlı bir şekilde soğuması için başka bir kaba alarak üzerini hava almayacak şekilde streçleyin ve soğumaya bırakın. Pastamızın pandispanyasını hazırlayalım. Yumurtaları ve şekeri derince bir kapta karışım beyazlayana kadar iyice mikser yardımı ile çırpın. Daha sonra unu, vanilya ve kabartma tozunu ekleyerek tekrar çırpın. Pandispanyamızı pişirelim. Tepsiye yağlı kağıt sererek hamuru her yeri eşit ince bir katman olacak şekilde yayın. Fırın tepsisini tezgaha vurarak ya da ileri geri sallayarak eşit bir şekilde yayıldığından emin olun ve önceden ısıtılmış 170 derece fansız fırında yaklaşık 12 dakika pişirin. Kekimizi rulo yapalım. Kek pembeleştikten sonra fırından çıkarın, başka bir pişirme kağıdı üzerine ters çevirin. Altındaki pişirme kağıdını soyun. Kenarları çok düzgün değilse bıçak ile keserek düzeltin. Pastamızın kremasını sürelim. Hazırladığımız kremanın tamamını üzerine yayın. Daha sonra ortadan ikiye kestiğiniz muzu veya sevdiğiniz diğer meyvelerden kremanın üzerine yerleştirdikten sonra pişirme kağıdı ile rulo şeklinde sarabilirsiniz, böylece meyveli rulo pastalar yapabilirsiniz. Pastamızın buzdolabında dinlendirelim. Hazırlanan ruloyu iyice soğuması için üzerini streçleyin, en az 2-3 saat buzdolabında dinlendirin.  Pastanızı dilimleyerek servis edin. Afiyet olsun!",
                    MalzemeListesi =["Muz", "Süt", "Un", "Nişasta", "Şeker", "Yumurta", "Kabartma Tozu", "Vanilya"],
                    TarifMalzemeListesi =
                    [
                        "3 adet yumurta",
                        "120 g toz şeker",
                        "1 paket kabartma tozu",
                        "1 su bardağı un",
                        "1 paket vanilya",
                        "500 ml süt",
                        "1 paket vanilya",
                        "2,5 yemek kaşığı un",
                        "1 yemek kaşığı nişasta",
                        "4 yemek kaşığı şeker",
                        "1 yemek kaşığı tereyağı",
                        "Muz (arası için)"
                    ]
                },
                new Yiyecek
                {
                    Id = 49,
                    Name = "Çikolatalı Mus",
                    Resim = "Resources/Images/tatli/cikolatali_mus.jpg",
                    TarifMetni = "Çikolatayı ince ince kıyın ve kenara alın. Süt ve kremayı bir sos tenceresine alıp ocağın küçük gözüne koyun ve karıştırarak ısıtın. Krema karışımı fıkırdamaya başladığında ocaktan alın. 1 yumurta sarısını kase içinde çırpın, üzerine ısıttığınız krema ve süt karışımından bir miktar ekleyerek çırpın. Sıcaklığını dengelediğiniz yumurtayı tenceredeki kremaya aktarın ve hızlıca karıştırın. Doğradığınız çikolatayı tencereye ekleyerek karıştırın ve tamamen erimesini sağlayın. 1 su bardağı kremayı mikserinizin yüksek devrinde 1-2 dk kadar çırpın. Hazırladığınız çikolata sosu azar azar kremanın içine ilave edin. Sosu dökerken kremanın sönmemesi için spatula yardımıyla ile alttan yukarıya doğru karıştırın. Çikolata ve krema tamamen karışınca bir kepçe yardımıyla bardaklara paylaştırın. Buzdolabında 1-2 saat kadar dinlendirip hafifçe donmasını bekledikten sonra süsleyerek servis yapın.",
                    MalzemeListesi =["Çikolata", "Krema", "Süt", "Yumurta"],
                    TarifMalzemeListesi =
                    [
                        "150 g bitter çikolata",
                        "1 yumurta sarısı",
                        "200 ml krema",
                        "60 ml süt"
                    ]
                },
                new Yiyecek
                {
                    Id = 50,
                    Name = "Revani",
                    Resim = "Resources/Images/tatli/revani.jpg",
                    TarifMetni = "İlk olarak şerbet hazırlanır. Şerbet için tencereye şeker ve su alınarak kaynatılır. Kaynadıktan sonra yarım limon suyu eklenip 1-2 dakika daha kaynatılıp altı kapatılır. Kek için, yumurta ve şeker çırpma kabına alınarak iyice çırpılır. Ardından sıvı yağ, yoğurt ve irmik eklenip çırpılır. Son olarak un, kabartma tozu ve vanilya da eklenerek iyice çırpılır. Yağlamış olduğumuz fırın kabına kek hamuru dökülür. 170 derece fırında üstü kızarana dek yaklaşık 30 dakika pişirilir. İlk sıcaklığı çıkan kek dilimlere kesilir ve sıcak kekin üstüne soğumuş şerbet dökülür. 1-2 saat dinlendirdikten sonra üzeri isteğe göre krem şanti, hindistan cevizi yada fıstık vb. ile süslenerek servis edilir. Afiyet olsun.",
                    MalzemeListesi = [ "Yumurta", "Şeker", "Yoğurt", "İrmik", "Un", "Vanilya", "Kabartma Tozu"],
                    TarifMalzemeListesi =
                    [
                        "3 adet yumurta",
                        "1 su bardağı şeker",
                        "1 su bardağı yoğurt",
                        "1 su bardağı irmik",
                        "1 su bardağı un",
                        "1 paket vanilya",
                        "1 paket kabartma tozu",
                        "1 çay bardağı sıvı yağ",
                        "3 su bardağı su",
                        "3 su bardağı şeker",
                        "Yarım limon suyu"
                    ]
                }
            };

            }
        public static void AddToFavorites(Yiyecek recipe)
        {
            if (!FavoriteRecipes.Contains(recipe))
            {
                FavoriteRecipes.Add(recipe);
            }
        }

        public static void RemoveFromFavorites(Yiyecek recipe)
        {
            if (FavoriteRecipes.Contains(recipe))
            {
                FavoriteRecipes.Remove(recipe);
            }
        }

        public static bool IsFavorite(Yiyecek recipe)
        {
            return FavoriteRecipes.Contains(recipe);
        }





    }
}
