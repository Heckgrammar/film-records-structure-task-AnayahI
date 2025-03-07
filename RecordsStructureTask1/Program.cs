namespace RecordsStructureTask1
{
    internal class Program
    {
        struct Film
        {
            public string title;
            public string certificate;
            public int year;
            public bool beingShown;

            public Film(string title, string certificate, int year, bool beingShown)
            {
                this.title = title;
                this.certificate = certificate;
                this.year = year;
                this.beingShown = beingShown;

            }
        }
        static void Main(string[] args)
        {
            Film hulk = new Film("Hulk", "12A", 2005, false);
            Film ironMan = new Film("Iron Man","12A",2008,false);
            Film antMan = new Film("Ant-Man", "12A", 2015, false);
            Film[] filmCollection = new Film[] { antMan,hulk,ironMan };
            int year = 0;
 int position = 0;
 string newest = "iuhyg";
 int latestyear = 2005;
 for (int i = 0; i > 3; i++) 
 {
     if (filmCollection[i].year > latestyear) 
     {
         latestyear = filmCollection[i].year;
         newest = filmCollection[i].title;
     }
 }
 Console.WriteLine($"Newest film: {newest}");

        }
    }
}
