class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 5;
		
		Console.WriteLine("Hasil Penambahan : {0} + {1} + {2}",a,b,tambah);
		Console.WriteLine("Hasil Pengurangan : {0} - {1} + {2}",a,b,kurang);
		Console.WriteLine("Hasil Perkalian : {0} * {1} + {2}",a,b,kali);
		Console.WriteLine("Hasil Pembagian : {0} / {1} + {2}",a,b,bagi);
		
		Console.WriteLine("\n Tekan Sembarang");
		Console.ReadKey();
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