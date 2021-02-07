using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverTasarımDeseni
{
   public class BlogYazarı : IBildirimServisi
    {
        List<IBlogOkuyucuları> lst = new List<IBlogOkuyucuları>();

        public void OkuyucuEkle(IBlogOkuyucuları blogOkuyucu)
        {
            lst.Add(blogOkuyucu);
        }

        public void OKuyucuKaldır(IBlogOkuyucuları blogOkuyucu)
        {
            lst.Remove(blogOkuyucu);
        }

        public void OkuyucuyaBildir(String bildirimMesajı)
        {
            foreach (var okuyucu in lst)
            {
                okuyucu.BildirimAlındı(bildirimMesajı);
            }
        }
    }
}
