using System;
class Odev1 {
  static void Main() {
    //1. soru
		
		Console.WriteLine("1.soru:");
		
		Console.WriteLine("Lutfen pozitif bir sayi giriniz:");

        int sayi = int.Parse(Console.ReadLine());
		
		int[] sayilar = new int[sayi];
		
		for(int i=0;i<sayi;i++)

            {

            Console.WriteLine("Lutfen {0}. sayiyi giriniz:",i+1);

            sayilar[i] = int.Parse(Console.ReadLine());

        }
		Console.Write("Cift sayi,sayilar: ");
		foreach(int i in sayilar){

            if(i%2==0){

                Console.Write(i+" ");

            }

        }
		//2.soru
		Console.WriteLine("");
		 Console.WriteLine("2.soru:");
		
		Console.WriteLine("Lutfen pozitif bir sayi giriniz");

        int sayi1 = int.Parse(Console.ReadLine());

        int[] sayilar2 = new int[sayi1];

        Console.WriteLine("Lutfen pozitif bir sayi daha  giriniz");

        int sayi2 = int.Parse(Console.ReadLine());

        for(int i=0;i<sayi1;i++)

            {

            Console.WriteLine("Lutfen {0}. sayiyi giriniz",i+1);

            sayilar2[i] = int.Parse(Console.ReadLine());

        }

        

        foreach(int i in sayilar2){

            if(i%sayi2==0){

                Console.Write(i+" ");

            }

        }

// 3. soru
  Console.WriteLine("");

        Console.WriteLine("3.soru:");

        Console.WriteLine("Lutfen pozitif bir sayi giriniz");

int sayi3 = int.Parse(Console.ReadLine());

string[] kelimeler = new string[sayi3];

for(int i=0;i<sayi3;i++){

    Console.WriteLine("Lutfen {0}. kelimeyi giriniz",i+1);

    kelimeler[i] = Console.ReadLine();

}
Console.WriteLine("Sondan basa giris yaptiginiz kelimeler:");
for(int i=kelimeler.Length-1;i>=0;i--){

    Console.WriteLine(kelimeler[i]);

}



//4. soru

        

        Console.WriteLine("4.soru:");

        Console.WriteLine("Lutfen bir cumle giriniz");

        string cumle = Console.ReadLine();

        string[] kelimeler2 = cumle.Split(' ');//new string[cumle.Length];

        

        string[] harfler = new string[cumle.Length];

        int sayac = 0;

        foreach(char c in cumle){

            if(c == ' '){

                sayac++;}

        }
     Console.WriteLine("Cumlede {0} kelime var",kelimeler2.Length);
	  Console.WriteLine("Cumlede {0} tane harf var",cumle.Length-sayac);	
  }
}
