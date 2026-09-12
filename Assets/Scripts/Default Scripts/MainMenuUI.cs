using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Soomla.Store;


public class MainMenuUI : MonoBehaviour {

	// Use this for initialization
	public AudioClip BtnClickClip=null;
	AudioSource srcBtnClick;

    public GameObject TemporaryLoading;

    public static bool firstLoad = false;
	void Start () {

       // AdsManager.instance.ShowBanner();
		srcBtnClick=gameObject.AddComponent<AudioSource> ();
        TemporaryLoading.SetActive(false);
        AudioListener.pause = false;
        Time.timeScale = 1;
        Preferences.Instance.RateUs++;
        Debug.Log(Preferences.Instance.RateUs);
        if (Preferences.Instance.RateUs % 8 == 0)
        {
           print("in rateus");
           // rate_Us_Panel.SetActive(true);
           
        }

//		SabloSdk.Instance.LogScreen("Main Menu");
//
//		SabloSdk.Instance.ShowBanner ();
	}
	

    public void btn_Play()
    {
		PlaySound ();
        TemporaryLoading.SetActive(true);
        //AdsManager.instance.ShowInterstitial();
        SceneManager.LoadScene("LevelSelection");
      
    
    }
    public void btn_RemoveAds()
    {
		PlaySound ();
        //StoreInventory.BuyItem(GameObject.FindObjectOfType<SoomlaFoo>().purchaseIDs[0]);
    }




    public void btn_More_Fun()
    {
		PlaySound ();
		Application.OpenURL("https://play.google.com/store/apps/developer?id=alfa+games");
    
    }

   

    public void btn_rate_Now()
    {
		PlaySound ();
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.alfagames.ZombieSniperZombieWar");
      

    }



 





	public void PlaySound()
	{
		srcBtnClick.clip=BtnClickClip;
		srcBtnClick.Play();
		
	}
}
