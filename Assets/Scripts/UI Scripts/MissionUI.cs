using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MissionUI : MonoBehaviour 
{
    public Text txtMission;
    public GameObject panelMission;
    public string[] missions;
	public int awyvalue = 0;



	// Use this for initialization
	void Start () 
    {
        txtMission.text = missions[Preferences.Instance.Level - 1];
	}

	void Update()
	{
		if (awyvalue == 1)
        {
			Time.timeScale = 0;
		} else
        {
			Time.timeScale = 1;
		}
		
	}


    public void btnCloseBriefing()
    {
		awyvalue = 0;
        panelMission.SetActive(false);
    }
    public void btnOpenBriefing()
    {
		awyvalue = 1;
        panelMission.SetActive(true);
    }


}
