using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LatihanBlazor.Models;

namespace LatihanBlazor.Pages
{
    public partial class Calculator
    {
        Calculators cal = new Calculators();
        private int angka1;
        private int angka2;
        private int hasil;
        private int ope;

        private void Hitung(){
            switch (cal.ope)
            {
                case 1: bagi();
                    break;
                case 2: kali();
                    break;
                case 3: tambah();
                    break;
                case 4: kurang();
                    break;
            }
        }

        private void bagi(){
            hasil = angka1/angka2;
        }
        private void kali(){
            hasil = angka1*angka2;
        }
        private void tambah(){
            hasil = angka1+angka2;
        }
        private void kurang(){
            hasil = angka1-angka2;
        }
    }
}