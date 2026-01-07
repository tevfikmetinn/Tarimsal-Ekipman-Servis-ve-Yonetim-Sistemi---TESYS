using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firat.Tesys.Forms
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Modern WXI Temasını Yükle
            // (Eğer burada hata alırsan BonusSkins referansını eklememişsin demektir)
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXI");

            // 2. Açılış Ekranını Göster
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Firat.Tesys.Forms.SplashScreen1));

            // 3. Beklet (Havalı görünsün)
            System.Threading.Thread.Sleep(2500);

            // 4. Kapat (BUNU EKLEMEZSEN EKRANDA KALIR)
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();

            // 5. Ana Uygulamayı Başlat
            Application.Run(new FrmLogin());
        }
    }
}
