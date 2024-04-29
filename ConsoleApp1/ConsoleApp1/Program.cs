// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Collections;
using System.Dynamic;
using System.Reflection;
using System.Runtime.CompilerServices;

Console.WriteLine("....");

decimal price = 19.95m, discount = 0.15m, discountedPrice = price - (price * discount);
Console.WriteLine("Discounted Price:" + discountedPrice+"$");

string ad = "Burak", soyad = "Baloglu", email = "brk@brk.com";
Console.WriteLine("Ad: " + ad + " ,Soyad: " + soyad + ", E-mail: " + email);

System.Text.StringBuilder builder = new System.Text.StringBuilder();
builder.Append("Ad:" + ad);
builder.Append(Environment.NewLine);
builder.Append("Soyad:" + soyad);
builder.Append(Environment.NewLine);
Console.WriteLine(builder.ToString());

int result;
bool olduMu = int.TryParse("10k", out result);
Console.WriteLine(olduMu);

int? num = null;
double? dob = null;
bool? cinsiyet = null;


var isim = "Burak Baloglu";
var sayi = 123456;
var nesne = new Program();

object o1 = 1;
object o2 = new Program();

object obj1 = "Burak";
obj1 = 123;

var v1 = 3;
//v1 = "Burak";
//hata verir. varın tipi değiştirilemez ama objectin tipi değiştirilebilir.
//var metotlarda parametre olarak kullanılamaz
//var başlangıç değeri belirtilmeden kullanılamaz
//var global scopeda kullanılamaz. Metot içerisinde (local scope) da kullanılabilir.



int x = 10;

Console.WriteLine(x); //10
Param(x);
Console.WriteLine(x); //10
ParamRef(ref x);
Console.WriteLine(x); //20
ParamOut(out x);
Console.WriteLine(x); //2


static void Param(int x) 
{
    x = x * 2;
    
}

static void ParamRef(ref int x)
{
    x = x * 2;

}
static void ParamOut(out int x)
{
    x = 2;

}

bool isValid = true;
if (isValid)
{
    Console.WriteLine("Doğru");
}
else
{
    Console.WriteLine("Yanlış");
}

int x1 = 1, y = 3;
if (x1 > y)
{
    Console.WriteLine("Doğru");
}
else
{
    Console.WriteLine("Yanlış");

}



int sayi1 = 1;
switch (sayi1)
{
    case 1:
        Console.WriteLine("1");
        break;

    case 2: 
        Console.WriteLine("2"); 
        break;
    default:
        Console.WriteLine("Tanımlanamadı");
        break;
}


int[] dizi = new int[25];
bool[] dizi2 = new bool[10];

int[] dizi3;
dizi3 = new int[25];

int[] strDizi = new int[3];
strDizi[0] = 5;
strDizi[1] = 6;
strDizi[2] = 7;
Console.WriteLine("Değer:" + strDizi[2]);

float[] fDizi = new float[3];
float[] fDizi2 = { 1.3F, 3.2F };
string[] fString = { "Ali", "ata", "bak" };
string[] fString2 = new string[] { "Ali", "ata", "bak"};
int[] iDizi = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

for (int i = 0; i < fString.Length; i++)
{
    Console.WriteLine(fString[i]);
}
string akademi = "dijibil";
for (int i = 0; i < akademi.Length; i++)
{
    Console.WriteLine(akademi[i]);
}

int[] d1 = new int[4], d2 = new int[3], d3 = new int[10];

string[] sehirler = new string[3];
sehirler[0] = "İstanbul";
sehirler[1] = "Ankara";
sehirler[2] = "İzmir";

for (int i = 0; i < sehirler.Length; i++)
{
    for (global::System.Int32 j = 0; j < sehirler[i].Length; j++)
    {
        Console.WriteLine(sehirler[i][j]);
    }
        Console.WriteLine("******");
}

int[] values = new int[3];
values[0] = 5;
values[1] = values[0] * 2;
values[2] = values[1] * 2;
Console.WriteLine(values[2]);

foreach (var arg in args)
{
    if (arg == "flushdns")
    {
        Console.WriteLine("DNS temizlendi");
    }
    else
    {
        Console.WriteLine("Komut bulunamadı");
    }
}

//int[,] ikiBoyut = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

//for (int i = 0; i < ikiBoyut.Length; i++)
//{
//    for (global::System.Int32 j = 0; j < 2; j++)
//    {
//        //Console.WriteLine(ikiBoyut[i,j]);
//    }
//}

//int[,,] ucBoyut = {
//    { { 1, 2 }, { 3, 4 } },
//    { { 5, 6 }, {7,8} },
//    { { 8, 9 }, { 9, 10 }, },
//    { { 10, 11 }, { 11, 12 }}
//};
//for (int i = 0; i < 4; i++)
//{
//    for (global::System.Int32 j = 0; j < 2; j++)
//    {
//        for (global::System.Int32 k = 0; k < 2; k++)
//        {
            
//        }

//    }
//}

int[][] jagged =
{
    new int[]{1,2,3,4,5,6},
    new int[]{1,2},
    new int[]{1,2,3,4},
    new int[]{1}
};

foreach (var jag in jagged)
{
    foreach (var item in jag)
    {
        Console.WriteLine(item);
    }
}



//var id = (int)Yetki.Admin;
//enum Yetki
//{
//    Normal,
//    Moderator,
//    Editor,
//    Admin,
//    SuperAdmin
//}
//enum Yetki2
//{
//    Normal = 3,
//    Moderator = 4,
//    Editor = 5,
//    Admin = 7,
//    SuperAdmin = 9
//}

//enum OnayDurum
//{
//    OnayBekliyor = 1,
//    Onaylandı = 2,
//    Reddedildi = 3
//}

//public enum DayOfWeek
//{
//    Sunday = 0,
//    Monday = 1,
//    Tuesday = 2,
//    Wednesday = 3,
//    Thursday = 4,
//    Friday = 5,
//    Saturday = 6,
//}

//class Ayakkabi
//{
//    public string Brand { get; set; }
//    public void SearchByBrand (string brand)
//    {
//        if (Brand == brand)
//        {
//            Console.WriteLine("Buldum");
//        }
//        else
//        {
//            Console.WriteLine("Bulamadım");
//        }
//    }


//}
//Ayakkabi ayakkabi = new Ayakkabi();
//ayakkabi.Brand = "Adidas";
//ayakkabi.SearchByBrand("adidas");


#region NonGeneric

//Farklı türlerdeki verilerin bir arada saklanabildiği koleksiyon türleridir.
//ArrayList, HashTable, SortedList

#endregion

#region ArrayListExample

ArrayList Sehirler = new ArrayList();
Sehirler.Add("İstanbul");
Sehirler.Add("Ankara");
Sehirler.Add("Antalya");

foreach (var sehir in Sehirler)
{
    Console.WriteLine(sehir);
}
Console.WriteLine("Count:"+Sehirler.Count);
sehirler.Contains("İzmir");
Sehirler.Add(3);

Array array = Array.CreateInstance(typeof(int), 10);
object[] sehirX = Sehirler.ToArray();
foreach (var sehir in sehirX)
{
    Console.WriteLine(sehir);
}

ArrayList liste = new ArrayList();
liste.Add("İstanbul");
liste.Add(4.3M);
liste.Add(false);

for (int i = 0; i < liste.Count; i++)
{
    Console.WriteLine(liste[i]);
}
#endregion

#region HashTableExample

Hashtable siniflar = new Hashtable();
siniflar.Add("007", "Yazılım ve Veritabanı Uzmanlığı");
siniflar.Add("008", "Sistem ve Ağ Uzmanlığı");
siniflar.Add("001", "Ağ Uzmanlığı");

foreach (var sinif in siniflar)
{
    Console.WriteLine(sinif);
}


#endregion


#region Generik

//Veriler object türünde değil belirtilen türde alınır.
//Oluşturma sırasında veri tipi belirlenmelidir.
//NonGeneric yapılara göre daha performanslıdır.

//List, Stack, Queue, LinkedList, Dictionary, SortedDictionary, SortedSet, HashSet

#endregion

#region ListExample

List<string> Diller = new List<string>();
Diller.Add("C");
Diller.Add("C#");
Diller.Add("C++");

foreach (var dil in Diller)
{
    Console.WriteLine(dil);
}


#endregion

#region Dictionary

Dictionary<int, string> data = new Dictionary<int, string>();

data.Add(2, "Ali");
data.Add(3, "Velis");

foreach (var i in data)
{
    //Console.WriteLine(i.Value);
    KeyValuePair<int, string> kullanıcı = i;
}


#endregion

int a = 5, b = 0;

//try
//{
//    Console.WriteLine(a/b);
//}
//catch
//{
//    Console.WriteLine("Hata oluştu");
//}

//try
//{
//    int[] dizi1 = new int[2];
//    dizi1[2] = 10;
//    Console.WriteLine(a/b);
//}
//catch (IndexOutOfRangeException ex) 
//{
//    Console.WriteLine("Hata:"+ ex.Message);
//}
//catch (DivideByZeroException ex) 
//{
//    Console.WriteLine("Hata:"+ex.Message);
//}catch(Exception exception)
//{
//    Console.WriteLine("Hata" + exception.Message);
//}

//Beklet();

//static void Beklet()
//{
//    Console.ReadLine();
//}

Topla(1,2);
static int Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;
    return sonuc;
}

GetAccountName(1);
static string GetAccountName(int accountID)
{
    string accountName = string.Empty;
    switch (accountID)
    {
        case 1:
            accountName = "Cihan";
            break;
        case 2:
            accountName = "Burak";
            break;
        default:
            accountName = "Unknown";
            break;
    }
    return accountName;
}

static bool isValid1(string email)
{
    bool isValid = default(bool);
    if (email.Contains("@"))
    {
        isValid = true;
    }
    return isValid;
}

RandomMethod();
static int RandomMethod()
{
    Random random = new Random();   
    return random.Next(1000, int.MaxValue);
}

static void KullaniciEkle(string ad, string soyad, bool aktifMi = true)
{
    Console.WriteLine("Ad:"+ad+"\nSoyad:"+soyad+"\nAktif Mi?"+aktifMi);
}


// Erişim Belirteçleri
// Public: Her yerden erişilebilir.
// Private: Sadece tanımlandığı sınıf içerisinden erişilebilir.
// Internal: Sadece bulunduğu projede erişilebilir.
// Protected: Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
// Protected Internal.: Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir. Tanımlamanın aynı proje içinde olmasına gerek yoktur. Protected'tan tek farkı budur.


//public class Kutu
//{
//    public int uzunluk { get; set; }
//    public int genislik { get; set; }
//    public int yukseklik { get; set; }
//}


//public class Account
//{

//    public string getAccount(string username)
//    {
//        if (!string.IsNullOrEmpty(username))
//        {
//            username = "NULL";
//        }
//        else
//        {

//        }
//        return username;
//    }

//    public string getAccount(int userID) 
//    {
//        string result = string.Empty;
//        if (userID > 0)
//        {
//            result = "Burak Baloglu";
//        }
//        else
//        {
//            throw new Exception("Hata");
//        }
//        return result;
//    }

//}

//Account account = new Account();
//var result = account.getAccount(3);
//ProjectA.TeamA.ClassA sinif1 = new ProjectA.TeamA.ClassA();
////sinif1.Print();
//Console.ReadLine();
//namespace ProjectA
//{
//    namespace TeamA
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("ProjectA, TeamA, ClassA print");
//            }
//        }
//    }
//    namespace TeamB
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("ProjectA, TeamB, ClassA print");
//            }
//        }
//    }
//}


//namespace ProjectB
//{
//    namespace TeamA
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("ProjectB, TeamA, ClassA print");
//            }
//        }
//    }
//}

//A a1 = new A();
//a1.PropA = 5;

//B b1 = new B();
//b1.PropB = 7;
//b1.PropA = 8;
//class A
//{
//    public int PropA { get; set; }
//}
//class B:A
//{
//    public int PropB { get; set; }
//}

Basket basket = new Basket();
Ekmek ekmek = new Ekmek(BreadType.Odun);
Tekstil tekstil = new Tekstil();
tekstil.Marka = TekstilMarka.Beymen;
tekstil.ProductName = "Özel Dikim";
tekstil.Price = 250;

basket.Add(ekmek);
basket.Add(tekstil);
Console.WriteLine("Toplam Fiyat:"+basket.TotalPrice());



//Encryption encryption = new Encryption();
//encryption.Encrypt("asd");
//encryption.Decrypt("dsa");

Encryption.Encrypt("ads");
Encryption.Decrypt("dsa");

Console.WriteLine(Encryption.Encrypt("asd"));



Kullanici2 k1 = new Kullanici2();
Kullanici2 k2 = new Kullanici2();
Kullanici2 k3 = new Kullanici2();
Kullanici2 k4 = new Kullanici2();

Console.WriteLine(k1.getID());





People people = new People();
people.FirstName = "Cihan";
people.LastName= "Özhan";
people.Email = "cihan.ozhan@gmail.com";
people.Password= "cihan123";
people.BirthDate = new DateTime(1980, 1, 1);

Console.WriteLine(people.GetFullName());
Console.WriteLine(people.getEmail(2));




//B b1 = new B();
//b1.PropA = 1;
//b1.PropB = 2;
//Console.ReadLine();
//sealed class A
//{
//    public int PropA { get; set; }
//}

//class B : A
//{
//    public int PropB { get; set; }
//}

//Calisan calisan = new Calisan();
//calisan.Ad = "Cihan";
//calisan.Soyad= "Özhan";
//Console.WriteLine(calisan.ToString());
//Console.WriteLine("Maaş:"+calisan.MaasHesapla());

Muhendis muhendis = new Muhendis();
muhendis.Ad = "Dennis";
muhendis.Soyad = "Ritchie";
Console.WriteLine(muhendis.ToString());
Console.WriteLine("Maas:"+muhendis.MaasHesapla());

Console.WriteLine(muhendis.MaasHesapla());



//Liste<decimal> liste2 = new Liste<decimal>();

//Liste<string> liste3 = new Liste<string>();
//liste3.Add("Ali");
//liste3.Add("Veli");
//liste3.Get();
//class Liste
//{

//}


//class Liste<T>
//{
//    public Liste()
//    {
//        Console.WriteLine(typeof(T));
//    }
//}

//class Liste<T>
//{
//    List<T> list = new List<T>();
//    public void Add(T t)
//    {
//        list.Add(t);
//    }

//    public void Get()
//    {
//        foreach (var item in list)
//        {
//            Console.WriteLine(item);
//        }
//    }

//}

//MyList<string> myList = new MyList<string>();
//myList.Ekle("İstanbul");
//myList.Ekle("Ankara");
//Console.WriteLine("Eleman Sayısı:"+ myList.ElementSayi);
//Console.ReadLine();
//class MyList<T>
//{
//    T[] dizi;
//    public void Ekle(T deger)
//    {
//        try
//        {
//            T[] geciciDizi = new T[dizi.Length];
//            geciciDizi = dizi;
//            dizi = new T[geciciDizi.Length + 1];

//            for (global::System.Int32 i = 0; i < geciciDizi.Length; i++)
//            {
//                dizi[i] = geciciDizi[i];
//            }
//            dizi[dizi.Length - 1] = deger;
//        }
//        catch
//        {
//            dizi = new T[1];
//            dizi[0] = deger;
//        }
//    }


//    public int ElementSayi
//    {
//        get { return dizi.Length; }
//    }
//}


//Islemler<double> sinif = new Islemler<double>();
//double sonuc = sinif.IslemYap(5.4D, 2);
//Console.WriteLine(sonuc);
//Console.ReadLine();

//class Islemler<T>
//{
//    public T IslemYap(T t, int param)
//    {
//        if (param >= 0)
//        {
//            return t;
//        }
//        else
//        {
//            return default(T);
//        }
//    }
//}


static int Topla1(int a, int b)
{
    return a + b;
}
static int Cikar1(int a, int b)
{
    return a - b;
}
static int Carp1(int a, int b)
{
    return a * b;
}
static int Bol1(int a, int b)
{
    if (a > 0 && b > 0)
    {
        return a / b;
    }
    return 0;
}

//Hesap hesap = Topla1;
//int sonuc = hesap(5, 4);
//Console.WriteLine(sonuc);

//hesap = Carp1;
//Console.WriteLine("Carp:" + hesap(4,5));

//Hesap hesap2 = new Hesap(Topla);
//Console.WriteLine("Topla:"+ hesap(2,3));
//hesap2 = new Hesap(Cikar1);
//Console.WriteLine("Çıkar:"+ hesap(2,1));


//delegate int Hesap(int x, int y);


static void StringTarget(string arg)
{
    Console.WriteLine("Arg metnini büyüt:"+ arg.ToUpper());
}


static void IntTarget(int arg)
{
    Console.WriteLine("++arg:" + ++arg);
}

//MyGenericDelegate<string> stringDelegate = new MyGenericDelegate<string>(StringTarget);
//stringDelegate("Cihan Özhan");

//MyGenericDelegate<int> intDelegate = new MyGenericDelegate<int>(IntTarget);
//intDelegate(3);


static void KullaniciBilgi(int kullaniciId, string adSoyad)
{
    Console.WriteLine("Id:"+ kullaniciId);
    Console.WriteLine("Ad Soyad:"+ adSoyad);
}

static double getUserAgeAtTime(DateTime birthDate)
{
    return (DateTime.Now - birthDate).TotalDays;
}

Action<int, string> action = new Action<int, string>(KullaniciBilgi);
action(3, "Cihan Özhan");

//Action
// Geriye değer döndürmeyen (void) metodlar için kullanılır.
//delegate in geriye değer döndürmeyen .NET Framework sınıfı versiyonudur.

//Func
// Geriye değer dönebilen action/delegate versiyonudur.

Func<DateTime, double> func = new Func<DateTime, double>(getUserAgeAtTime);
double dateDiff = func(new DateTime(1987, 4, 15));
Console.WriteLine(dateDiff + "gündür yaşıyorsunuz.");

dynamic a1 = 5;
Console.WriteLine(a);
a1 = "AA";
Console.WriteLine(a);



dynamic insan = new ExpandoObject();
insan.Ad = "Cihan";
insan.Soyad = "Özhan";
Console.WriteLine(insan.Ad + " " + insan.Soyad);


dynamic kisi = new ExpandoObject();
kisi.Ad = "Cihan";
kisi.Soyad = "Özhan";
kisi.AdGoster = new Action(() =>
{
    Console.WriteLine("Ad:"+kisi.Ad);
});

kisi.TekrarEt = new Func<string, string>(gelen =>
{
    return gelen;
});


kisi.AdGoster();

dynamic sonuc = kisi.TekrarEt("Çoklu tekrar");
Console.WriteLine("Gelen cevap:"+sonuc);
//foreach (dynamic user in GetList())
//{
//    Console.WriteLine("{0}{1}", user.Ad, user.Soyad);
//}
//static IEnumerable<dynamic> GetList()
//{
//    //var users = new List<User>() { new User() { Id=3, FirstName = "Muhammet", LastName = "Ali"} };

//    return from k in users
//           select new { Ad = k.FirstName, Soyad = k.LastName };
//}

//class User
//{
//    public int Id { get; set; }
//    public string FirstName { get; set; }
//    public string LastName{ get; set; }
//}


//delegate void MyGenericDelegate<T>(T args);



object obj2 = new object();
obj2 = new Program();
obj2.DisplayASMInfo();


int x2 = 5;
x2.Square();

ArrayList list = new ArrayList();
list.Add("Ali");
list.Add("Veli");
list.ShowItems();



//LINQ


List<Ogrenci> ogrenciler = new List<Ogrenci>()
{
    new Ogrenci{Id=1, Name="Cihan", Surname="Özhan", BirthDate = new DateTime(1988, 7, 17)},
    new Ogrenci{Id=2, Name="Burak", Surname="Baloglu", BirthDate = new DateTime(1982, 1, 10)},
    new Ogrenci{Id=3, Name="Mehmet", Surname="Bulut", BirthDate = new DateTime(1986, 5, 22)},
    new Ogrenci{Id=4, Name="Ali", Surname="Yağmur", BirthDate = new DateTime(1992, 8, 08)},
    new Ogrenci{Id=5, Name="Ayşe", Surname="Toprak", BirthDate = new DateTime(1999, 11, 21)}
};

#region C#

List<Ogrenci> ogrenciler1 = new List<Ogrenci>();
foreach (var ogrenci in ogrenciler)
{
    if (ogrenci.Id > 4)
    {
        ogrenciler1.Add(ogrenci);
    }
}

foreach (var ogrenci in ogrenciler1)
{
    Console.WriteLine(ogrenci.Name + " " + ogrenci.Surname);
}


#endregion

#region LINQ

var query = from ogrenci in ogrenciler
            where ogrenci.Id > 4
            select ogrenci;

foreach (var ogrenci in query)
{
    Console.WriteLine(ogrenci.Name + " " + ogrenci.Surname);
}

#endregion

#region Lambda Expression

var q = ogrenciler.Where(x => x.Id > 4);

foreach (var ogrenci in q)
{
    Console.WriteLine(ogrenci.Name + " "+ ogrenci.Surname);
}
#endregion



var q1 = ogrenciler.Where(x => x.Name[0].ToString() == "M");
var q2 = ogrenciler.Where(x => x.Name.StartsWith("M"));
var q3 = ogrenciler.Where(x => x.Name.Substring(0,1).ToUpper() == "M");
//var q4 = from y in ogrenciler
//         where y.Name.Substring(0, 1).ToUpper() == "M"
//         select y;
var q5 = ogrenciler.Where(x => x.Surname[x.Surname.Length -1].ToString() == "t");
var q6 = ogrenciler.Where(x => x.Surname.Substring(x.Surname.Length-1,1).ToString().ToLower() == "t");
var q7 = ogrenciler.Where(x => x.Surname.EndsWith("t"));



var q8 = ogrenciler.Where(x => (DateTime.Now.Year - x.BirthDate.Year) < 27);
var q9 = ogrenciler.Where(x => ((DateTime.Now - x.BirthDate).TotalDays / 365)<30);

var q10 = ogrenciler.Where(x=> (x.BirthDate.DayOfWeek == DayOfWeek.Monday) && x.Name.StartsWith("A"));

var q11 = ogrenciler.Select(x => x.Id < 4);

var q12 = ogrenciler.Select(x => new {No=x.Id, AdSoyad=x.Name+ " " + x.Surname});

foreach (var ogrenci in q12)
{
    //Console.WriteLine(ogrenci.Name + " " + ogrenci.Surname);
    Console.WriteLine(ogrenci.No + " " + ogrenci.AdSoyad);
}


var q13 = ogrenciler.Where(x=> (x.BirthDate.DayOfWeek == DayOfWeek.Monday));
List<Ogrenci> ogrenciler2 = new List<Ogrenci>();
ogrenciler2 = q13.ToList();

//List<OgrDemo> q14 = ogrenciler.Select(x=> new OgrDemo(x.Id, x.Name+ " " + x.Surname)).ToList();

//foreach (var og in q14)
//{
//    Console.WriteLine(og.AdSoyad);
//}
Console.ReadLine();
//public class OgrDemo
//{
//    public int No { get; set; }
//    public string AdSoyad { get; set; }

//    public OgrDemo()
//    {

//    }
//    public OgrDemo(int no, string adSoyad)
//    {
//        this.No = no;
//        this.AdSoyad = adSoyad;
//    }
//}

string path = @"C:\Windows\Microsoft.NET\Framework\v2.0.50727\System.dll";
Assembly assembly = Assembly.LoadFile(path);
AssemblyBilgiGoster(assembly);
Assembly ourAsm = Assembly.GetExecutingAssembly();
AssemblyBilgiGoster(ourAsm);

static void AssemblyBilgiGoster(Assembly asm)
{
    Console.WriteLine("--------------");
    Console.WriteLine(asm.FullName);
    Console.WriteLine("GAC'da mı?"+ (asm.GlobalAssemblyCache ? "Evet" : "Hayır"));
    Console.WriteLine("Path:"+asm.Location);
    Console.WriteLine("Versiyon:" + asm.ImageRuntimeVersion);
    
}

//var ogrenci = new Ogrenci1() 
//{
//    Ad = "Burak",
//    Soyad = "Baloglu",
//};

Type ogrenciTip = typeof(Ogrenci);
Console.ReadLine();

FieldInfo[] ogrenciAlanlar = ogrenciTip.GetFields(BindingFlags.Public | BindingFlags.Instance);

foreach (var ogrenciAlan in ogrenciAlanlar)
{
    Console.WriteLine("Alan:"+ ogrenciAlan.Name);
    //Console.WriteLine("Değer:"+ ogrenciAlan.GetValue(ogrenci));
}
//public class Ogrenci1
//{
//    public string Ad;
//    public string Soyad;
//    string email;
//}

//var user = new User() 
//{
//    UserId = 2,
//    UserName = "Cihan Özhan",
//    Email = "cihanozhan@gmail.com"
//};
//var props = user.GetType().GetProperties();
//foreach (var prop in props)
//{
//    Console.WriteLine(prop.Name);
//}
Console.WriteLine("--------------");
//var prop1 = user.GetType().GetProperty("UserName");
//Console.WriteLine(prop1.Name);
//Console.WriteLine(prop1.GetValue(user));
//public class User
//{
//    public int UserId { get; set; }
//    public string UserName { get; set; }
//    public string Email { get; set; }
//}


//Type t = typeof(MyClass);
//Console.WriteLine("İncelenecek Metod:"+t.Name);
//Console.WriteLine("Desteklenen Metodlar:");
//MethodInfo[] mi = t.GetMethods();
//foreach (MethodInfo m in mi)
//{
//    Console.WriteLine(""+m.ReturnType.Name+" "+m.Name+"(");
//    ParameterInfo[] pi = m.GetParameters();
//    for (global::System.Int32 i = 0; i < pi.Length; i++)
//    {
//        Console.WriteLine(pi[i].ParameterType.Name + " "+ pi[i].Name);
//        if (i+1<pi.Length)
//        {
//            Console.WriteLine(",");
//        }
//    }
//    Console.WriteLine(")");
//    Console.ReadLine();
//}

//Type t = typeof(MyClass);
//MyClass reflect = new MyClass(10,20);
int val;
//Console.WriteLine("Kullanılan sınıf:"+ t.Name);
Console.WriteLine();
//MethodInfo[] mi = t.GetMethods();

//foreach (MethodInfo m in mi)
//{
//    ParameterInfo[] pi = m.GetParameters();
//    if (m.Name.Equals("Set", StringComparison.Ordinal) && pi[0].ParameterType == typeof(int))
//    {
//        object[] args1 = new object[2];
//        args1[0] = 9;
//        args1[1] = 10;
//        m.Invoke(reflect, args1);
//    }
//    else if(m.Name.Equals("Set", StringComparison.Ordinal) && pi[0].ParameterType == typeof(double))
//    {
//        object[] args1 = new object[2];
//        args1[0] = 2.32;
//        args1[1] = 45.3;
//        m.Invoke(reflect, args1);
//    }
//    else if(m.Name.Equals("Sum", StringComparison.Ordinal))
//    {
//        val = (int)m.Invoke(reflect, null);
//        Console.WriteLine("Sum() Sonuç:"+val);
//    }else if (m.Name.Equals("IsBetween", StringComparison.Ordinal)) 
//    {
//        object[] args1 = new object[1];
//        args1[0] = 15;
//        if ((bool)m.Invoke(reflect, args1))
//        {
//            Console.WriteLine("x-y arası 15");
//        }
//    }
//    else if(m.Name.Equals("Show", StringComparison.Ordinal))
//    {
//        m.Invoke(reflect, null);
//    }


//}

//class MyClass
//{
//    int x;
//    int y;

//    public MyClass(int x, int y)
//    {
//        this.x = x;
//        this.y = y;
//    }

//    public int Sum()
//    {
//        return x + y;
//    }
//    public bool isBetween(int i)
//    {
//        if (x<i && i<y)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }


//    public void Set(int a, int b)
//    {
//        Console.WriteLine("Inside Set(int, int).");
//        x = a;
//        y = b;
//        Show();

//    }

//    public void Set(double a, double b)
//    {
//        Console.WriteLine("Inside Set(double, double).");
//        x = (int)a;
//        y = (int)b;
//        Show();
//    }
//    public void Show()
//    {
//        Console.WriteLine("x:{0}, y:{1}", x, y);
//    }
//}


// IsAlive Thread'in çalışma durumunu verir.
// Name Thread'in adını verir.
// Priority Thread'in çalışma önceliğini verir.
// Abort ThreadAbortException hatasını verip thread'in çalışmasını engeller.
// Resume Beklemeye geçirilmiş threadi çalıştırır.
// Sleep Belirtilen süre kadar beklemeye alır.
// Suspend Thread'i geçici süre durdurur.

Console.WriteLine("Main thread starting");
IsParcacigi isParcacigi = new IsParcacigi("Child 1");
Thread newThread = new Thread(isParcacigi.Run);
newThread.Start();
Console.ReadLine();
do
{
    Console.WriteLine(".");
    Thread.Sleep(100);
} while (isParcacigi.Count != 10);
Console.WriteLine("Main thread ending.");
Console.ReadLine();


Thread myThread = new Thread(CalisacakMethod);
myThread.IsBackground = true;
myThread.Start();
Thread.Sleep(2000);
Console.WriteLine("Main thread sona erdi.");

static void CalisacakMethod()
{
    for (global::System.Int32 i = 0; i < 10; i++)
    {
        Console.WriteLine("İslem"+i);
        Thread.Sleep(500);
    }
    Console.WriteLine("CalisacalMethod() threadi sona erdi.");
    Console.ReadLine();
}

AddParams ap = new AddParams(10,20);
Thread thread1 = new Thread(new ParameterizedThreadStart(Add));
thread1.Start();

static void Add(object data)
{
    if (data is AddParams)
    {
        Console.WriteLine("Id of thread in main():{0}", Thread.CurrentThread.ManagedThreadId);
        AddParams ap = (AddParams)data;
        Console.WriteLine("{0}+{1}={2}",ap.a, ap.b, ap.a+ap.b);
    }
}

class AddParams
{
    public int a;
    public int b;

    public AddParams(int num1, int num2)
    {
        a = num1;
        b = num2;
    }
}



class IsParcacigi
{
    public int Count;
    public Thread thread;
    public IsParcacigi(string name)
    {
        Count = 0;
        thread = new Thread(this.Run);
        thread.Name = name;
        thread.Start();
    }

    public void Run()
    {
        Console.WriteLine(thread.Name+ "starting");
        do
        {
            Thread.Sleep(500);
            Console.WriteLine("In "+thread.Name+", Count is "+ Count);
            Count++;
        } while (Count <= 10);
        Console.WriteLine(thread.Name + "terminating.");
    }
}


