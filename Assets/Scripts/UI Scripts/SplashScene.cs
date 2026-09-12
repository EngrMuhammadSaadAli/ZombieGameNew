using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashScene : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		Time.timeScale = 1;
        LevelSelection.startDialog();
        StartCoroutine(lateStart());
	}
	
	// Update is called once per frame
	IEnumerator lateStart()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("LevelSelection");
        // Application.LoadSecne("LevelSelection");
    }

}
