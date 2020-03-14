class Calculator
{
	static void Main(string[] args)
	{
		//int a = 10;
		//int b = 5;
		int x,y;
		
		//Console.WriteLine("Hasil Penambahan : {0} + {1} + {2}",a,b,tambah);
		//Console.WriteLine("Hasil Pengurangan : {0} - {1} + {2}",a,b,kurang);
		//Console.WriteLine("Hasil Perkalian : {0} * {1} + {2}",a,b,kali);
		//Console.WriteLine("Hasil Pembagian : {0} / {1} + {2}",a,b,bagi);
		Console.WriteLine("Pilih Menu Calculator\n");
		Console.WriteLine("1. Penambahan");
		Console.WriteLine("2. Pengurangan");
		Console.WriteLine("3. Perkalian");
		Console.WriteLine("4. Pembagian");
		Console.WriteLine("Input nomor menu : 1-4 : ");
		Console.ReadKey(x);
		
		switch(x){
			case 1:
			Console.WriteLine("Penambahan");
			opsi();
			Console.WriteLine("Hasil Penambahan : {0} + {1} + {2}",a,b,tambah);
			break;
			case 2:
			Console.WriteLine("Pengurangan");
			opsi();
			Console.WriteLine("Hasil Pengurangan : {0} + {1} + {2}",a,b,kurang);
			break;
			case 3:
			Console.WriteLine("Perkalian");
			opsi();
			Console.WriteLine("Hasil Perkalian : {0} + {1} + {2}",a,b,kali);
			break;
			case 4:
			Console.WriteLine("Pembagian");
			opsi();
			Console.WriteLine("Hasil Pembagian : {0} + {1} + {2}",a,b,bagi);
			break;
			default:
			Console.WriteLine("Maaf Menu Tidak Tersedia");
		}
		
		Console.WriteLine("\n Tekan Sembarang untuk keluar");
		Console.ReadKey();
	}
	static void opsi (){
		Console.Write("Inputkan Nilai A = ");
		int a = int.Parse(Console.ReadLine());
		
		Console.Write("Inputkan Nilai B = ");
		int b = int.Parse(Console.ReadLine());
	}
	
	static int tambah(int a, int b){
		return a+b;
	}
	
	static int kurang(int a, int b){
		return a-b;
	}
	
	static int kali(int a, int b){
		return a*b;
	}
	
	static int bagi(int a, int b){
		return a/b;
	}
}