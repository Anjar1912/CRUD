﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplikasiPegawai.ClassInduk; 

namespace AplikasiPegawai.ClassAnak
{
    public class Leader : Pegawai
    {
        public int JumlahPenjualan { get; set; }
        public int Komisi { get; set; }

        public override int Gaji() => JumlahPenjualan * Komisi;
      
    }
}