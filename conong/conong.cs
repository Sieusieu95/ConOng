using System;
using System.Collections.Generic;
using System.Text;

namespace conong
{
    public class conong
    {
        public string TenConOng { get; set; }
        public int Mau { get; set; }

        public conong(string tenconong, int mau)
        {
            this.TenConOng = tenconong;
            this.Mau = mau;
        }
        public override string ToString()
        {
            if ((Mau < 70 && TenConOng == "OngChua") ||
                                (Mau < 20 && TenConOng == "OngDuc") ||
                      (Mau < 50 && TenConOng == "OngTho"))

                return TenConOng + " Da Chet " + Mau;
            else
                return TenConOng + " Chua Chet " + Mau;

        }

    }
}
