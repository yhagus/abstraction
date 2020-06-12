using System;

using TugasLab7.Abstract;
using TugasLab7.Interface;

namespace TugasLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //USING ABSTRACT
            
            Laptop laptop;

            Console.WriteLine("==========CALL WITH ABSTRACT CLASS==========\n");
            laptop = new A31541();
            laptop.Spesifikasi();

            laptop = new E5475G();
            laptop.Spesifikasi();
            

            //USING INTERFACE
            

            Ilaptop ilaptop;

            Console.WriteLine("==========CALL WITH INTERFACE==========\n");
            ilaptop = new IA31541();
            ilaptop.Spesifikasi();

            ilaptop = new IE5475G();
            ilaptop.Spesifikasi();

            Console.ReadKey();
        }
    }
}
