using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiPegawai.ClassInduk
{
    public abstract class Pegawai
    {
        public string Nama { get; set; }
        public string Nik { get; set; }
        public string jenis_pegawai { get; set; }

        public abstract int Gaji(); 
    }
}
