using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplikasiPegawai.ClassInduk;

namespace AplikasiPegawai.ClassAnak
{
    public class PegawaiTetap : Pegawai
    {
        public int GajiBulanan { get; set; }

        public override int Gaji() => GajiBulanan;
    }
}
