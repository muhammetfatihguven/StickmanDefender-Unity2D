using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAdMobScript : MonoBehaviour
{
    string _adUnitID = "ca-app-pub-2242119874920140/5392604541";
    //test : ca-app-pub-3940256099942544/1033173712
    //gercek : ca-app-pub-2242119874920140/5392604541
   

    public static InterstitialAd _GecisReklami;

    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
         
        });
        GecisReklamiOlustur();

        
    }

    
    void GecisReklamiOlustur()
    {
        if (_GecisReklami !=null)
        {
            _GecisReklami.Destroy();
            _GecisReklami = null;
        }
        Debug.Log("Reklam Yüklendi");

        var _AdRequest = new AdRequest.Builder().Build();
        InterstitialAd.Load(_adUnitID, _AdRequest,
        (InterstitialAd Ad, LoadAdError error) =>
        {
            if(error != null || Ad==null) {
                Debug.Log("Reklam Yüklenirken Hata oldu : " + error);
                return;
            }

            _GecisReklami = Ad;
        });

        ReklamOlaylariniDinle(_GecisReklami);
    }

    void ReklamOlaylariniDinle(InterstitialAd ad)
    {
       ad.OnAdPaid +=(AdValue adValue) =>
       {
        Debug.Log(string.Format("Geçiş reklamı {0} {1}.",
        adValue.Value,
        adValue.CurrencyCode));
       };

       ad.OnAdImpressionRecorded += () =>
       {
        Debug.Log("Geçiş reklamı gösterildi");
        
       };

       ad.OnAdClicked += () =>
       {
        Debug.Log("Geçiş Tıklandı");
        
       };

       ad.OnAdFullScreenContentOpened += () =>
       {
        Debug.Log("Geçiş Reklamı Tam Ekran Açıldı");
        
       };

       ad.OnAdFullScreenContentClosed += () =>
       {
        Debug.Log("Geçiş Reklamı Tam Ekran Kapatıldı");
        GecisReklamiOlustur();
       };

       ad.OnAdFullScreenContentFailed += (AdError error) =>
       {
        Debug.Log("Geçiş Reklamı Tam Ekran açılamadı. Hata : " + error);
        GecisReklamiOlustur();
       };
    }

    public static void GecisReklamiGoster()

    {

        if(_GecisReklami != null && _GecisReklami.CanShowAd())
        {
            _GecisReklami.Show();
            Debug.Log("Reklam Gösterildi");
            
        }
        else
        {
            Debug.Log("Hazır değil Reklamınız");
        }
    }

    void ReklamiOldur()
    {
        _GecisReklami.Destroy();
    }
}
