using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplikasiPegawai.ClassInduk;

namespace AplikasiPegawai.ClassAnak
{
    public class PegawaiHarian : Pegawai
    {
        public int UpahPerJam { get; set; }
        public int JumlahJamKerja { get; set; }

        public override int Gaji() => UpahPerJam * JumlahJamKerja;
       
    }
}
