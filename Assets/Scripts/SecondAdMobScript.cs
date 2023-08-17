using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SecondAdMobScript : MonoBehaviour
{
    string _adUnitID = "ca-app-pub-2242119874920140/7948283992";
    //test : ca-app-pub-3940256099942544/5224354917
    //gercek : ca-app-pub-2242119874920140/7948283992

    RewardedAd _OdulluReklam;

    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
         
        });
        OdulluReklamOlustur();
    }

    
    void OdulluReklamOlustur()
    {
        if (_OdulluReklam !=null)
        {
            _OdulluReklam.Destroy();
            _OdulluReklam = null;
        }
        Debug.Log("Reklam Yüklendi");

        var _AdRequest = new AdRequest.Builder().Build();
        RewardedAd.Load(_adUnitID, _AdRequest,
        (RewardedAd Ad, LoadAdError error) =>
        {
            if(error != null || Ad==null) {
                Debug.Log("Ödüllü Reklam Yüklenirken Hata oldu : " + error);
                return;
            }

            _OdulluReklam = Ad;
        });

        ReklamOlaylariniDinle(_OdulluReklam);
    }

    void ReklamOlaylariniDinle(RewardedAd ad)
    {
       ad.OnAdPaid +=(AdValue adValue) =>
       {
        Debug.Log(string.Format("Ödül reklamı {0} {1}.",
        adValue.Value,
        adValue.CurrencyCode));
       };

       ad.OnAdImpressionRecorded += () =>
       {
        Debug.Log("Ödül reklamı gösterildi");
        
       };

       ad.OnAdClicked += () =>
       {
        Debug.Log("Ödül Tıklandı");
        
       };

       ad.OnAdFullScreenContentOpened += () =>
       {
        Debug.Log("Ödül Reklamı Tam Ekran Açıldı");
        
        
       };

       ad.OnAdFullScreenContentClosed += () =>
       {
        Debug.Log("Ödül Reklamı Tam Ekran Kapatıldı");
        
        OdulluReklamOlustur();
       };

       ad.OnAdFullScreenContentFailed += (AdError error) =>
       {
        Debug.Log("Ödül Reklamı Tam Ekran açılamadı. Hata : " + error);
        OdulluReklamOlustur();
       };
    }

    public void OdulluReklamGoster()
    {
                
          const string OdulMesaji = "Ödül Kazanıldı. Ürün : {0}, Değer {1}";

          if(_OdulluReklam != null && _OdulluReklam.CanShowAd())
          {
              MoneyScript.moneyValue += 2500;
                adbtnscript.reklamsayaci += 1;
             _OdulluReklam.Show((Reward reward) =>
             {
               
                Debug.Log(string.Format(OdulMesaji, reward.Type,reward.Amount));
             });
             

          }
          else
          {
            Debug.Log("Ödüllü Reklam Hazır değil");
          }


    }

    void ReklamiOldur()
    {
        
        _OdulluReklam.Destroy();
    }


}
