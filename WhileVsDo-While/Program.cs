int limit = 0;
int i=0;
int i2=0;
Console.WriteLine("Lütfen limit değerini giriniz");
limit= Convert.ToInt32(Console.ReadLine());
// While döngüsü
while (i<limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    i++;
}
// Do-while döngüsü
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    i2++;
} while (i2<limit);

// While'da -5 yazdığımda limit değerden düşük olduğu için "Ben bir Patika'lıyım" yazısı ekrana çıktı olarak gelmedi 
//fakat do-while yapısında -5 yazdığımda ekrana 1 defa "Ben bir Patika'lıyım" yazısı geldi yani do-while en az 1 kere çalıştırmayı garanti ediyor. İşte while'dan farkı budur.