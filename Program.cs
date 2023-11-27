using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Orident_Programming_Method_Clas
{
    //internal class müsteri
    //{
    //    public int Id;
    //    public string Name;
    //    public string SurName;

    //    public void info()
    //    {
    //        Console.WriteLine($"Müşteri bilgileri = {Id} || Adı = {Name} || Soy Adı = {SurName}");
    //    }
    //    static void Main(string[] args)
    //    {
    //        müsteri m = new müsteri();
    //        m.Id = 1;
    //        m.Name = "Mehmet";
    //        m.SurName = "Çiftçi";
    //        m.info();

    //        müsteri m2 = new müsteri();
    //        m2.Id = 2;
    //        m2.Name = "Eymen";
    //        m2.SurName = "Çiftçi";
    //        m2.info();
    //    }


    //<---------------------------------Constractors------------------------------------------------>
    //public class musteri
    // {
    //     public int Id;
    //     public string Name;

    //     public void info()
    //     {
    //Console.WriteLine($"Müşteri bilgileri = {Id} || Ad = {Name}");
    //     }
    //     static void Main(string[] args)
    //     {
    //musteri m = new musteri();
    //m.Id = 1;
    //m.Name = "Mehmet";
    //m.info();
    //     }



    //public class musteri
    //{
    //    public int Id;
    //    public string Name;
    //        public musteri(int id,string name) 
    //        { 
    //        this.Id = id;
    //        this.Name = name;
    //        }
    //    public void info()
    //    {
    //        Console.WriteLine($"Müşteri bilgileri = {this.Id} || Ad = {this.Name}");
    //    }
    //    static void Main(string[] args)
    //    {
    //            musteri m = new musteri(1, "Mehmet");
    //            m.info();
    //    }

    //public class musteri
    //{
    //    public int Id;
    //    public string Name;

    //    public musteri(int id) 
    //    { 
    //        this.Id = id;   
    //    }

    //    public musteri() 
    //    {

    //    }
    //    public musteri(int id, string name)
    //    {
    //        this.Id = id;
    //        this.Name = name;
    //    }


    //    public void info()
    //    {
    //        Console.WriteLine($"Müşteri bilgileri = {this.Id} || Ad = {this.Name}");
    //    }
    //    static void Main(string[] args)
    //    {
    //        musteri m = new musteri();
    //        m.Id = 1;
    //        m.Name = "Mehmet";
    //        m.info();


    //        musteri m2 = new musteri(2);
    //        m2.Name = "Ali";
    //        m2.info();
    //    }

    //<---------------------------------Static Members------------------------------------------------>
    public class Program
    {
        static void Main(string[] args)
    {
            Methods_Tutorial d1 = new Methods_Tutorial(1);
            float alan1 = d1.AlaniHesapla();
            Console.WriteLine(alan1);


            Methods_Tutorial d2 = new Methods_Tutorial(2);
            float alan2 = d2.AlaniHesapla();
            Console.WriteLine(alan2);
            Console.Write("Alan değeri = ");
            Console.Write(alan1*alan1*alan2);
            Console.ReadKey();
    }
        

}
}