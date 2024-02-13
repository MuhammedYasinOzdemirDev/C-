//Array -> kapasiet sınırı vardır
//Collections
//non generic ve generic olmak uzere iki turdur
//HashTable,SortedList,ArrayList,BitArray,Queue,Stack
//ArrayList
using Collections;
using System.Collections;

ArrayList mylist= new ArrayList();
mylist.Add(5);
mylist.Add("as");
mylist.Add(true);
mylist.Add(5.458);
ArrayList arrayList= new ArrayList() { 4,5,"as"};//da olabilir
Console.WriteLine(arrayList[0]);//ulasma get etme
foreach(var item in arrayList)
    Console.WriteLine(item);
mylist.Insert(1, 20);//1 indexe 20 elemanı eklenir
mylist.InsertRange(3,arrayList);//3 indisten itirbaren liste ekler
mylist.AddRange(arrayList);//sona liste ekler

mylist.Remove(10);//10 elemanı silinir
mylist.RemoveAt(2);//2 indis silinir
mylist.RemoveRange(3, 4);//3 indisten itibaren 4 eleman siler

Console.WriteLine(mylist.Contains(5));//eleman varmı

//Generic List<T>
List<int> list= new List<int>();//HERHANGİ SINIFTA OLUR
list.Add(5);
list.Add(6);
list.Add(7);
list.Add(8);
list.Add(9);
list.Add(0);
list.ForEach(item=> Console.WriteLine(item));//for each yapar item belirlenş degerler
List<string> list2 = new List<string>()
{
    "xas","saas","ssd",null,"dwddw"
};
List<Product> list3 = new List<Product>()
{
    new Product(4,"saka"),new Product(5,"wdwd"),new Product(6,"xssx")
};
list3.ForEach(item=>Console.WriteLine(item.name));
int count=list.Count();//eleman sayısını bulur

//Dictionary<Tkey,TValue>
//plaka 34,istanbul

Dictionary<int,string> plakalar=new Dictionary<int,string>();
plakalar.Add(34, "İstanbul");
plakalar.Add(35, "İzmir");
plakalar.Add(56, "Siirt");
Dictionary<int,string>sayilar=new Dictionary<int, string>()
{
    {1,"Bir"},{2,"iki"},{3,"uc"}
};

foreach (var plaka in plakalar)
    Console.WriteLine($"{plaka.Key} {plaka.Value}");
for(int i = 0; i < plakalar.Count; i++)
{
    Console.WriteLine($"{plakalar.Keys.ElementAt(i)} {plakalar[plakalar.Keys.ElementAt(i)]}");
}
Console.WriteLine(plakalar.ContainsKey(34));
Console.WriteLine(plakalar.ContainsValue("Siirt"));
Console.WriteLine(plakalar.Contains(new KeyValuePair<int, string>(41, "Kocaeli")));
plakalar.Remove(35);

Hashtable ht=new Hashtable();
ht.Add(1, "sas");
ht.Add("saa", "s");
