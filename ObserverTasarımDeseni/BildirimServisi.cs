using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverTasarımDeseni
{
    public interface IBildirimServisi
    {
        void OkuyucuEkle(IBlogOkuyucuları blogOkuyucu);
        void OKuyucuKaldır(IBlogOkuyucuları blogOkuyucu);

        void OkuyucuyaBildir(String BildirimMesajı);
    }

    public interface IBlogOkuyucuları
    {
        void BildirimAlındı(String mesaj);
    }
}
