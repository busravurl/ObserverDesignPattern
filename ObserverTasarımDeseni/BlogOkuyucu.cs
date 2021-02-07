using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverTasarımDeseni
{
   public class BlogOkuyucu: IBlogOkuyucuları
    {
        private String _okuyucuAdı;
        public BlogOkuyucu(String okuyucuAdı)
        {
            _okuyucuAdı = okuyucuAdı;
        }

        public void BildirimAlındı(String bildirimMesajı)
        {
            Console.WriteLine(_okuyucuAdı + "" + bildirimMesajı);
        }
    }
}
