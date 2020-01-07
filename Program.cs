using System;

namespace TES1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputJmlMhs;

            Console.Write("Masukkan Jumlah Mahasiswa: ");
            
            bool isNumeric = int.TryParse(Console.ReadLine(), out inputJmlMhs);

            Console.WriteLine(isNumeric);

            double[] nQ = new double[inputJmlMhs];
            double[] nM = new double[inputJmlMhs];
            double[] nU = new double[inputJmlMhs];
            string[] namaMhs = new string[inputJmlMhs];
            string[] nimMhs = new string[inputJmlMhs];

            double[] nilaiAkhirMahasiswa = new double[inputJmlMhs];
            string[] hurufNAM = new string[inputJmlMhs];
            string[] ketNAM = new string[inputJmlMhs];
            

            Console.Clear();

           if(isNumeric){
                if(inputJmlMhs > 0) {
                for(int i = 0; i < inputJmlMhs; i++) {
                    Console.Write("Nama :");
                    namaMhs[i] = Console.ReadLine();

                    Console.Write("Quiz :");
                    nQ[i] = Convert.ToDouble(Console.ReadLine()); 

                    Console.Write("MID :");
                    nM[i] = Convert.ToDouble(Console.ReadLine());

                    Console.Write("UAS :");
                    nU[i] = Convert.ToDouble(Console.ReadLine());

                    nilaiAkhirMahasiswa[i] = (nQ[i]+nM[i]+nU[i])/3;
                    if(nilaiAkhirMahasiswa[i] > 80){
                        hurufNAM[i] = "A";
                        ketNAM[i] = "Lulus";
                    } else if(nilaiAkhirMahasiswa[i] > 70){
                        hurufNAM[i] = "B";
                        ketNAM[i] = "Lulus";
                    } else if(nilaiAkhirMahasiswa[i] > 60){
                        hurufNAM[i] = "C";
                        ketNAM[i] = "Lulus";
                    } else if(nilaiAkhirMahasiswa[i] > 50){
                        hurufNAM[i] = "D";
                        ketNAM[i] = "Tidak Lulus";
                    } else {
                        hurufNAM[i] = "E";
                        ketNAM[i] = "Tidak Lulus";
                    }

                    Console.Clear();
                };

                for(int j = 0; j < inputJmlMhs; j++){
                    for(int k = j; k <= j; k++){
                        Console.WriteLine("Nama \t\t: "+namaMhs[k]);
                        Console.WriteLine("Nilai Akhir \t: "+ Math.Round(nilaiAkhirMahasiswa[k], 2));
                        Console.WriteLine("Nilai Huruf \t: "+hurufNAM[k]);
                        Console.WriteLine("Keterangan \t: "+ketNAM[k]);
                    };
                    Console.WriteLine();
                };

            } else {
                Console.WriteLine("Anda Tidak Memiliki Mahasiswa");
            }
           } else {
               Console.WriteLine("Masukkan Angka !");
           }

            
        }
    }
}
