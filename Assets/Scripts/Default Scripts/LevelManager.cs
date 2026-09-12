using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{

    public GameObject[] Levels;

    public GameObject Player;
    public bool respawnPlayer = false;
    public GameObject[] playerSpawns;
    int curLevel;

    [Header("Only for Testing Levels")]
    public bool testLevel = false;
    public int testLevelNum = 1;
    void Start()
    {
        //Preferences.Instance.Reset ();
        if (testLevel)
        {
            curLevel = testLevelNum;
            Preferences.Instance.Level = testLevelNum;
        }
        else
            curLevel = Preferences.Instance.Level;
        if (Player && respawnPlayer)
        {
            Player.transform.position = playerSpawns[curLevel - 1].transform.position;
            Player.transform.rotation = playerSpawns[curLevel - 1].transform.rotation;
        }

        Levels[curLevel - 1].SetActive(true);

        Debug.Log("level " + Preferences.Instance.Level);
    }
}
