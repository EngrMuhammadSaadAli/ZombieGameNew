using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{

    public AudioClip BtnClickClip = null;
    AudioSource srcBtnClick;

   
    public Button[] levels;
    public Sprite lockSprite;
    [Header("Multiple lock sprites")]
    public bool multipleLocks= false;
    public Sprite[] multipleLockSprite;

	public GameObject playbutton;

	public GameObject iPanel;
	public GameObject iback;

	public GameObject musicon;
	public GameObject musicoff;
	public GameObject gamemusic;
	public bool onmusic = true;

	public GameObject charcterselction;
	public GameObject chrtrsltionback;
	public GameObject Gobutton;

	public int characters=0;
	public GameObject[] charact;
	public GameObject buy1;
	public GameObject buy2;
	public bool canbuy=true;
	public bool firstbuy=false;
	public bool scondbuy=false;
	public int hogyavalue;
	public GameObject chPurchased;

	public int buyy1;
	public int buyy2;


	public Text scoress;
	public int myscores;

	public GameObject weaponslectn;
	public GameObject backweapon;

	public int weaponscount = 0;
	public GameObject[] weapons;
	public GameObject purchase1;
	public GameObject purchase2;
	public GameObject purchase3;
	public GameObject purchase4;
	public bool weaponcanbuy=true;
	public int weaponvalue;
	public GameObject Purchased;
	public int trues1;
	public int trues2;
	public int trues3;
	public int trues4;

	public int LevelNumber;

	public GameObject missions;
	public GameObject mission1;
	public GameObject mission2;
	public GameObject mission3;
	public GameObject mission4;
	public GameObject mission5;
	public GameObject mission6;
	public GameObject mission7;
	public GameObject mission8;
	public GameObject mission9;
	public GameObject mission10;
	public GameObject mission11;
	public GameObject mission12;
	public GameObject missiontolevelback;





	public GameObject myPlayButton;
	public bool Onplaybutton=false;

    // Use this for initialization
    void Start()
    {
		PlayerPrefs.GetInt ("abcd", 0);

		if (PlayerPrefs.GetInt("abcd")==0)
        {
			PlayerPrefs.SetInt ("weapons", 7);
			PlayerPrefs.SetInt ("abcd", 1);
		}
		if (weaponscount == 0)
        {
            Debug.Log("no weapon");
		}
        else
        {
			PlayerPrefs.SetInt ("weapons", 7);
		}

		myscores = PlayerPrefs.GetInt ("myscore");
		scoress.text = myscores.ToString ();

        srcBtnClick = gameObject.AddComponent<AudioSource>();
        Time.timeScale = 1;
       
        for (int i = 0; i < levels.Length; i++)
        {
            if (i <= Preferences.Instance.LevelUnlock - 1)
            {
                levels[i].enabled = true;
                levels[i].transform.Find("lock").gameObject.SetActive(false);
            }
            else
            {
                levels[i].enabled = false;
                if (multipleLocks)
                    levels[i].transform.Find("lock").GetComponent<Image>().sprite = multipleLockSprite[i];
                else
                    levels[i].transform.Find("lock").GetComponent<Image>().sprite = lockSprite;
            }
        }
     
    }

	void Update()
	{

		if (Onplaybutton)
        {
			myPlayButton.SetActive (true);
		}

		LevelNumber = Preferences.Instance.Level;

		weaponvalue = PlayerPrefs.GetInt ("weaponvaluess");
		hogyavalue = PlayerPrefs.GetInt ("hogya");

		trues1 = PlayerPrefs.GetInt("myy1");
		trues2 = PlayerPrefs.GetInt("myy2");
		trues3 = PlayerPrefs.GetInt("myy3");
		trues4 = PlayerPrefs.GetInt("myy4");
		buyy1=PlayerPrefs.GetInt ("myy5");
		buyy2=PlayerPrefs.GetInt ("myy6");


		for (int i = 0; i < charact.Length; i++)
        {
			if (i == characters) 
				charact [i].SetActive (true);
			else
				charact [i].SetActive (false);
		}

		for (int i = 0; i < weapons.Length; i++)
        {
			if (i == weaponscount)
				weapons [i].SetActive (true);
			else
				weapons [i].SetActive (false);
		}

		myscores = PlayerPrefs.GetInt ("myscore");
		scoress.text = myscores.ToString ();
		
	}

    //weapon purchase button

	public void purchasebtn1()
	{
		if (myscores >= 500) {
			myscores = myscores - 500;
			PlayerPrefs.SetInt ("myscore", myscores);
			PlayerPrefs.SetInt ("weapons", 4);
			PlayerPrefs.SetInt ("weaponvaluess", 1);
			PlayerPrefs.SetInt ("myy1",1);
			PlayerPrefs.SetInt ("changegun", 1);
			Purchased.SetActive (true);
			purchase1.SetActive (false);
			PlayerPrefs.SetInt ("myupdateweapon", 1);
			PlayerPrefs.SetInt ("hogyaweaponupdate", 1);
		}
	}

	public void purchasebtn2()
	{
		if (myscores >= 2000) {
			myscores = myscores - 2000;
			PlayerPrefs.SetInt ("myscore", myscores);
			PlayerPrefs.SetInt ("weapons", 2);
			PlayerPrefs.SetInt ("myy2",1);
			PlayerPrefs.SetInt ("weaponvaluess", 2);
			PlayerPrefs.SetInt ("changegun1", 1);
			Purchased.SetActive (true);
			purchase2.SetActive (false);
			PlayerPrefs.SetInt ("myupdateweapon", 2);
			PlayerPrefs.SetInt ("hogyaweaponupdate", 1);
		}
	}
	public void purchasebtn3()
	{
		if (myscores >= 3500) {
			myscores = myscores - 3500;
			PlayerPrefs.SetInt ("myscore", myscores);
			PlayerPrefs.SetInt ("weaponvaluess", 3);
			PlayerPrefs.SetInt ("weapons", 3);
			PlayerPrefs.SetInt ("myy3",1);
			PlayerPrefs.SetInt ("changegun2", 1);
			Purchased.SetActive (true);
			purchase3.SetActive (false);
			PlayerPrefs.SetInt ("myupdateweapon", 3);
			PlayerPrefs.SetInt ("hogyaweaponupdate", 1);
		}
	}
	public void purchasebtn4()
	{
		if (myscores >= 5000) {
			myscores = myscores - 5000;
			PlayerPrefs.SetInt ("myscore", myscores);
			PlayerPrefs.SetInt ("weaponvaluess", 4);
			PlayerPrefs.SetInt ("changegun3", 1);
			PlayerPrefs.SetInt ("weapons", 5);
			PlayerPrefs.SetInt ("myy4",1);
			Purchased.SetActive (true);
			purchase4.SetActive (false);
			PlayerPrefs.SetInt ("myupdateweapon", 4);
			PlayerPrefs.SetInt ("hogyaweaponupdate", 1);
		}
	}

    //character purchase btn

	public void buy1btn()
	{
		if (myscores >= 1000) {
			myscores = myscores - 1000;
			PlayerPrefs.SetInt ("myscore", myscores);
			PlayerPrefs.SetInt ("hogya", 1);
			chPurchased.SetActive (true);
			PlayerPrefs.SetInt ("myy5",1);
			firstbuy = true;
			buy1.SetActive (false);
		}
	}

	public void buy2btn()
	{
		if (myscores >= 2000) {
			myscores = myscores - 2000;
			PlayerPrefs.SetInt ("myscore", myscores);
			PlayerPrefs.SetInt ("hogya", 2);
			Purchased.SetActive (true);
			PlayerPrefs.SetInt ("myy6",1);
			scondbuy = true;
			buy2.SetActive (false);
		}
	}

	public void Weaponselectnbtn()
	{
		weaponslectn.SetActive (true);
		backweapon.SetActive (true);
	}
	public void weaponsbackbtn()
	{
		weaponslectn.SetActive (false);
		backweapon.SetActive (false);
	}

	public void weaponSelectionTeamBtn()
	{
		charcterselction.SetActive (true);
		chrtrsltionback.SetActive (true);
		weaponslectn.SetActive (false);
		
	}


    //weapon selection next or privious btn

	public void weaponbtnNext()
	{
		weaponscount++;
		if (weaponscount > 4) {
			weaponscount = 0;
		}
		if (weaponcanbuy) {
			if (weaponscount == 1)
            {
				if (trues1==1)
                {
						PlayerPrefs.SetInt ("weapons", 4);
					    PlayerPrefs.SetInt ("myupdateweapon", 1);
						Debug.Log ("1");
						Purchased.SetActive (true);
						purchase1.SetActive (false);
						purchase2.SetActive (false);
						purchase3.SetActive (false);
						purchase4.SetActive (false);
				} 
				else
                {
					Debug.Log ("1-1");
					Purchased.SetActive (false);
					purchase1.SetActive (true);
					purchase2.SetActive (false);
					purchase3.SetActive (false);
					purchase4.SetActive (false);
				}
			}
			if (weaponscount == 2)
            {
				if (trues2==1)
                {
						Debug.Log ("2");
						PlayerPrefs.SetInt ("weapons", 2);
					    PlayerPrefs.SetInt ("myupdateweapon", 2);
						Purchased.SetActive (true);
						purchase1.SetActive (false);
						purchase2.SetActive (false);
						purchase3.SetActive (false);
						purchase4.SetActive (false);
					
				}
			    else
                {
					Debug.Log ("2-2");
					Purchased.SetActive (false);
					purchase1.SetActive (false);
					purchase2.SetActive (true);
					purchase3.SetActive (false);
					purchase4.SetActive (false);
				}
			}
			if (weaponscount == 3)
            {
				if (trues3==1)
                {
						Debug.Log ("3");
						PlayerPrefs.SetInt ("weapons", 3);
					    PlayerPrefs.SetInt ("myupdateweapon", 3);
						Purchased.SetActive (true);
						purchase1.SetActive (false);
						purchase2.SetActive (false);
						purchase3.SetActive (false);
						purchase4.SetActive (false);
				}

				else
                {
					Debug.Log ("3-3");
					Purchased.SetActive (false);
					purchase1.SetActive (false);
					purchase2.SetActive (false);
					purchase3.SetActive (true);
					purchase4.SetActive (false);
				}
			}
			if (weaponscount == 4)
            {
				if (trues4==1)
                {
						Debug.Log ("4");
						PlayerPrefs.SetInt ("weapons", 5);
					    PlayerPrefs.SetInt ("myupdateweapon", 4);
						Purchased.SetActive (true);
						purchase1.SetActive (false);
						purchase2.SetActive (false);
						purchase3.SetActive (false);
						purchase4.SetActive (false);
				}
				else
                {
					Debug.Log ("4-4");
					Purchased.SetActive (false);
					purchase1.SetActive (false);
					purchase2.SetActive (false);
					purchase3.SetActive (false);
					purchase4.SetActive (true);
				}
			}
			if (weaponscount == 0)
            {
				Debug.Log ("0");
				PlayerPrefs.SetInt ("weapons", 7);
				Purchased.SetActive (false);
				purchase1.SetActive (false);
				purchase2.SetActive (false);
				purchase3.SetActive (false);
				purchase4.SetActive (false);
			}

		}
	}

	public void weaponbtnPrevious()
	{
		weaponscount--;
		if (weaponscount < 0) {
			weaponscount = 4;
		}
		if (weaponcanbuy)
        {
			if (weaponscount == 1)
            {
				if (trues1==1)
                {
					PlayerPrefs.SetInt ("weapons", 4);
					PlayerPrefs.SetInt ("myupdateweapon", 1);
					Purchased.SetActive (true);
					purchase1.SetActive (false);
					purchase2.SetActive (false);
					purchase3.SetActive (false);
					purchase4.SetActive (false);
				}
                else
                {
					Purchased.SetActive (false);
					purchase1.SetActive (true);
					purchase2.SetActive (false);
					purchase3.SetActive (false);
					purchase4.SetActive (false);
				}
			}
			if (weaponscount == 2)
            {
				if (trues2 == 1)
                {
					PlayerPrefs.SetInt ("weapons", 2);
					PlayerPrefs.SetInt ("myupdateweapon", 2);
					Purchased.SetActive (true);
					purchase1.SetActive (false);
					purchase2.SetActive (false);
					purchase3.SetActive (false);
					purchase4.SetActive (false);
				}
                else
                {
					Purchased.SetActive (false);
					purchase1.SetActive (false);
					purchase2.SetActive (true);
					purchase3.SetActive (false);
					purchase4.SetActive (false);
				}
			}
			if (weaponscount == 3)
            {
				if (trues3 == 1)
                {
					PlayerPrefs.SetInt ("weapons", 3);
					PlayerPrefs.SetInt ("myupdateweapon", 3);
					Purchased.SetActive (true);
					purchase1.SetActive (false);
					purchase2.SetActive (false);
					purchase3.SetActive (false);
					purchase4.SetActive (false);
				}
                else
                {
					Purchased.SetActive (false);
					purchase1.SetActive (false);
					purchase2.SetActive (false);
					purchase3.SetActive (true);
					purchase4.SetActive (false);
				}
			}
			if (weaponscount == 4)
            {
				if (trues4 == 1)
                {
					PlayerPrefs.SetInt ("weapons", 5);
					PlayerPrefs.SetInt ("myupdateweapon", 4);
					Purchased.SetActive (true);
					purchase1.SetActive (false);
					purchase2.SetActive (false);
					purchase3.SetActive (false);
					purchase4.SetActive (false);
				}
                else
                {
					Purchased.SetActive (false);
					purchase1.SetActive (false);
					purchase2.SetActive (false);
					purchase3.SetActive (false);
					purchase4.SetActive (true);
				}
			}
			if (weaponscount == 0)
            {
				PlayerPrefs.SetInt ("weapons", 7);
				Purchased.SetActive (false);
				purchase1.SetActive (false);
				purchase2.SetActive (false);
				purchase3.SetActive (false);
				purchase4.SetActive (false);
			}

		}
	}


    //character selection next or privious buttons 


	public void btnNext()
	{
		characters++;
		if (characters > 2)
        {
			characters = 0;
		}
		if(canbuy)
        {
		   if (characters == 1)
           {
				if (buyy1==1)
                {
					chPurchased.SetActive (true);
					buy1.SetActive (false);
					buy2.SetActive (false);
				}
                else
                {
					chPurchased.SetActive (false);
					buy1.SetActive (true);
					buy2.SetActive (false);
				}
		   }
		   if (characters == 2)
           {
				if (buyy2==1)
                {
					chPurchased.SetActive (true);
					buy2.SetActive (false);
					buy1.SetActive (false);
				}
                else
                {
					chPurchased.SetActive (false);
					buy2.SetActive (true);
					buy1.SetActive (false);
				}
		   }
		   if (characters == 0)
           {
				chPurchased.SetActive (false);
				buy1.SetActive (false);
				buy2.SetActive (false);
		   }
		}
	}
	public void btnpre()
	{
		characters--;
		if (characters < 0)
        {
			characters = 2;
		}
		if(canbuy)
        {
			if (characters == 1)
            {
				if (buyy1==1)
                {
					chPurchased.SetActive (true);
					buy1.SetActive (false);
					buy2.SetActive (false);
				}
                else
                {
					chPurchased.SetActive (false);
					buy1.SetActive (true);
					buy2.SetActive (false);
				}
			}
			if (characters == 2)
            {
				if (buyy2==1)
                {
					chPurchased.SetActive (true);
					buy2.SetActive (false);
					buy1.SetActive (false);
				}
                else
                {
					chPurchased.SetActive (false);
					buy2.SetActive (true);
					buy1.SetActive (false);
				}
			}
			if (characters == 0)
            {
				chPurchased.SetActive (false);
				buy1.SetActive (false);
				buy2.SetActive (false);
			}
		}

			
	}




	public void i()
	{
		iPanel.SetActive (true);
		iback.SetActive (true);
	}
	public void Ibackbtn()
	{
		iPanel.SetActive (false);
		iback.SetActive (false);
	}

    //music on off

	public void musiconbtn()
	{
		if (onmusic)
        {
			gamemusic.SetActive (false);
			musicoff.SetActive (true);
			onmusic = false;
			musicon.SetActive (false);

		}
	}
	public void musicoffbtn()
	{
		if (!onmusic)
        {
			gamemusic.SetActive (true);
			musicon.SetActive (true);
			onmusic = true;
			musicoff.SetActive (false);

		}
	}

    // play button for levels

	public void playbuttonon()
	{
		playbutton.SetActive (true);
	}
	public void playbuttonon1()
	{
		playbutton.SetActive (true);
	}
	public void playbuttonon2()
	{
		playbutton.SetActive (true);
	}
	public void playbuttonon3()
	{
		playbutton.SetActive (true);
	}
	public void playbuttonon4()
	{
		playbutton.SetActive (true);
	}
	public void playbuttonon5()
	{
		playbutton.SetActive (true);
	}
	public void playbuttonon6()
	{
		playbutton.SetActive (true);
	}
	public void playbuttonon7()
	{
		playbutton.SetActive (true);
	}
	public void playbuttonon8()
	{
		playbutton.SetActive (true);
	}
	public void playbuttonon9()
	{
		playbutton.SetActive (true);
	}
	public void playbuttonon10()
	{
		playbutton.SetActive (true);
	}
	public void playbuttonon11()
	{
		playbutton.SetActive (true);
	}


	public void Exit()
	{
		StartCoroutine(LoadLoading1());
	}
	public void MoreGames()
	{
		StartCoroutine(LoadLoading2());
	}
	public void rateus()
	{
		StartCoroutine(LoadLoading3());
	}

    // mission details for levels

	public void Playbutton()
	{
		if (LevelNumber == 1)
        {
			missiontolevelback.SetActive (true);
			missions.SetActive (true);
			mission1.SetActive (true);
			mission2.SetActive (false);
			mission3.SetActive (false);
			mission4.SetActive (false);
			mission5.SetActive (false);
			mission6.SetActive (false);
			mission7.SetActive (false);
			mission8.SetActive (false);
			mission9.SetActive (false);
			mission10.SetActive (false);
			mission11.SetActive (false);
			mission12.SetActive (false);
			charcterselction.SetActive (false);
			weaponslectn.SetActive (false);
		}
		if (LevelNumber == 2)
        {
			missiontolevelback.SetActive (true);
			missions.SetActive (true);
			mission1.SetActive (false);
			mission2.SetActive (true);
			mission3.SetActive (false);
			mission4.SetActive (false);
			mission5.SetActive (false);
			mission6.SetActive (false);
			mission7.SetActive (false);
			mission8.SetActive (false);
			mission9.SetActive (false);
			mission10.SetActive (false);
			mission11.SetActive (false);
			mission12.SetActive (false);
			charcterselction.SetActive (false);
			weaponslectn.SetActive (false);
		}
		if (LevelNumber == 3)
        {
			missiontolevelback.SetActive (true);
			missions.SetActive (true);
			mission1.SetActive (false);
			mission2.SetActive (false);
			mission3.SetActive (true);
			mission4.SetActive (false);
			mission5.SetActive (false);
			mission6.SetActive (false);
			mission7.SetActive (false);
			mission8.SetActive (false);
			mission9.SetActive (false);
			mission10.SetActive (false);
			mission11.SetActive (false);
			mission12.SetActive (false);
			charcterselction.SetActive (false);
			weaponslectn.SetActive (false);
		}
		if (LevelNumber == 4)
        {
			missiontolevelback.SetActive (true);
			missions.SetActive (true);
			mission1.SetActive (false);
			mission2.SetActive (false);
			mission3.SetActive (false);
			mission4.SetActive (true);
			mission5.SetActive (false);
			mission6.SetActive (false);
			mission7.SetActive (false);
			mission8.SetActive (false);
			mission9.SetActive (false);
			mission10.SetActive (false);
			mission11.SetActive (false);
			mission12.SetActive (false);
			charcterselction.SetActive (false);
			weaponslectn.SetActive (false);
		}
		if (LevelNumber == 5)
        {
			missiontolevelback.SetActive (true);
			missions.SetActive (true);
			mission1.SetActive (false);
			mission2.SetActive (false);
			mission3.SetActive (false);
			mission4.SetActive (false);
			mission5.SetActive (true);
			mission6.SetActive (false);
			mission7.SetActive (false);
			mission8.SetActive (false);
			mission9.SetActive (false);
			mission10.SetActive (false);
			mission11.SetActive (false);
			mission12.SetActive (false);
			charcterselction.SetActive (false);
			weaponslectn.SetActive (false);
		}
		if (LevelNumber == 6)
        {
			missiontolevelback.SetActive (true);
			missions.SetActive (true);
			mission1.SetActive (false);
			mission2.SetActive (false);
			mission3.SetActive (false);
			mission4.SetActive (false);
			mission5.SetActive (false);
			mission6.SetActive (true);
			mission7.SetActive (false);
			mission8.SetActive (false);
			mission9.SetActive (false);
			mission10.SetActive (false);
			mission11.SetActive (false);
			mission12.SetActive (false);
			charcterselction.SetActive (false);
			weaponslectn.SetActive (false);
		}
		if (LevelNumber == 7)
        {
			missiontolevelback.SetActive (true);
			missions.SetActive (true);
			mission1.SetActive (false);
			mission2.SetActive (false);
			mission3.SetActive (false);
			mission4.SetActive (false);
			mission5.SetActive (false);
			mission6.SetActive (false);
			mission7.SetActive (true);
			mission8.SetActive (false);
			mission9.SetActive (false);
			mission10.SetActive (false);
			mission11.SetActive (false);
			mission12.SetActive (false);
			charcterselction.SetActive (false);
			weaponslectn.SetActive (false);
		}
		if (LevelNumber == 8)
        {
			missiontolevelback.SetActive (true);
			missions.SetActive (true);
			mission1.SetActive (false);
			mission2.SetActive (false);
			mission3.SetActive (false);
			mission4.SetActive (false);
			mission5.SetActive (false);
			mission6.SetActive (false);
			mission7.SetActive (false);
			mission8.SetActive (true);
			mission9.SetActive (false);
			mission10.SetActive (false);
			mission11.SetActive (false);
			mission12.SetActive (false);
			charcterselction.SetActive (false);
			weaponslectn.SetActive (false);
		}
		if (LevelNumber == 9)
        {
			missiontolevelback.SetActive (true);
			missions.SetActive (true);
			mission1.SetActive (false);
			mission2.SetActive (false);
			mission3.SetActive (false);
			mission4.SetActive (false);
			mission5.SetActive (false);
			mission6.SetActive (false);
			mission7.SetActive (false);
			mission8.SetActive (false);
			mission9.SetActive (true);
			mission10.SetActive (false);
			mission11.SetActive (false);
			mission12.SetActive (false);
			charcterselction.SetActive (false);
			weaponslectn.SetActive (false);
		}
		if (LevelNumber == 10)
        {
			missiontolevelback.SetActive (true);
			missions.SetActive (true);
			mission1.SetActive (false);
			mission2.SetActive (false);
			mission3.SetActive (false);
			mission4.SetActive (false);
			mission5.SetActive (false);
			mission6.SetActive (false);
			mission7.SetActive (false);
			mission8.SetActive (false);
			mission9.SetActive (false);
			mission10.SetActive (true);
			mission11.SetActive (false);
			mission12.SetActive (false);
			charcterselction.SetActive (false);
			weaponslectn.SetActive (false);
		}
		if (LevelNumber == 11)
        {
			missiontolevelback.SetActive (true);
			missions.SetActive (true);
			mission1.SetActive (false);
			mission2.SetActive (false);
			mission3.SetActive (false);
			mission4.SetActive (false);
			mission5.SetActive (false);
			mission6.SetActive (false);
			mission7.SetActive (false);
			mission8.SetActive (false);
			mission9.SetActive (false);
			mission10.SetActive (false);
			mission11.SetActive (true);
			mission12.SetActive (false);
			charcterselction.SetActive (false);
			weaponslectn.SetActive (false);
		}
		if (LevelNumber == 12)
        {
			missiontolevelback.SetActive (true);
			missions.SetActive (true);
			mission1.SetActive (false);
			mission2.SetActive (false);
			mission3.SetActive (false);
			mission4.SetActive (false);
			mission5.SetActive (false);
			mission6.SetActive (false);
			mission7.SetActive (false);
			mission8.SetActive (false);
			mission9.SetActive (false);
			mission10.SetActive (false);
			mission11.SetActive (false);
			mission12.SetActive (true);
			charcterselction.SetActive (false);
			weaponslectn.SetActive (false);
		}


	}

	public void missiontoLevelBackbtn()
	{
		charcterselction.SetActive (false);
		weaponslectn.SetActive (false);
		missions.SetActive (false);
		mission1.SetActive (false);
		mission2.SetActive (false);
		mission3.SetActive (false);
		mission4.SetActive (false);
		mission5.SetActive (false);
		mission6.SetActive (false);
		mission7.SetActive (false);
		mission8.SetActive (false);
		mission9.SetActive (false);
		mission10.SetActive (false);
		mission11.SetActive (false);
		mission12.SetActive (false);
		missiontolevelback.SetActive (false);

	}


	public void missionPlayBtn()
	{
		startDialog();
		StartCoroutine(LoadLoading());
	}


	public void charcterselectionbtn()
	{
		charcterselction.SetActive (true);
		chrtrsltionback.SetActive (true);
		Gobutton.SetActive (true);
	}
	public void characterselectionabckbtn()
	{
		charcterselction.SetActive (false);
	}


    public void btnSelectLevel(int levelNum)
    {
       Preferences.Instance.Level = levelNum;
		LevelNumber = Preferences.Instance.Level;
	
	}

	IEnumerator LoadLoading1()
	{
		yield return new WaitForSeconds(3);
		Application.Quit ();
	}
	IEnumerator LoadLoading2()
	{
		yield return new WaitForSeconds(3);
		Application.OpenURL ("");
	}
	IEnumerator LoadLoading3()
	{
		yield return new WaitForSeconds(3);
		Application.OpenURL ("");
	}

    IEnumerator LoadLoading()
    {
        yield return new WaitForSeconds(3);
        Application.LoadLevel("LoadingScene");
    }
    public static void startDialog()
    {
#if UNITY_ANDROID
        Handheld.SetActivityIndicatorStyle(AndroidActivityIndicatorStyle.Large);
        Handheld.StartActivityIndicator();
# endif
    }


}
