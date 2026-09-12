//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class AdsManager : MonoBehaviour
//{
//    public static AdsManager instance;
//    void Awake()
//    {
//        if (instance != null)
//        {
//            Destroy(gameObject);
//        }
//        else
//        {
//            instance = this;
//            DontDestroyOnLoad(gameObject);
//        }
//        Advertisements.Instance.SetUserConsent(true);
//        if (Advertisements.Instance.UserConsentWasSet())
//        {
//            Advertisements.Instance.Initialize();
//        }
//    }
//    public void ShowBanner()
//    {
//        Advertisements.Instance.ShowBanner(BannerPosition.TOP);
//    }

//    public void HideBanner()
//    {
//        Advertisements.Instance.HideBanner();
//    }

//    public void ShowInterstitial()
//    {
//        Advertisements.Instance.ShowInterstitial();
//    }
//    public void ShowRewardedVideo()
//    {
       
//            if (Advertisements.Instance.IsRewardVideoAvailable())
//            {
//                Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
//            }
           
//    }
//    private void CompleteMethod(bool completed)
//    {
//        if (completed)
//        {
//            //Reward the Player
//            Debug.Log("PlayerRewarded");
          
//        }
//        else
//        {
            
//        }
//    }
//}
