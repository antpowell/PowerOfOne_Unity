using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


[Serializable]

public class UIButtons : MonoBehaviour
{
    


    /// <summary>
    /// Will reset Game, data is still saved in database
    /// </summary>
    /*public void Reset_btn()
    {
        ScoreCard.Clear();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.DeleteKey("FreeThrow");
        PlayerPrefs.DeleteKey("FreeThrowMiss");
        PlayerPrefs.DeleteKey("TwoPoint");
        PlayerPrefs.DeleteKey("TwoPointMiss");
        PlayerPrefs.DeleteKey("ThreePoint");
        PlayerPrefs.DeleteKey("ThreePointMiss");
        PlayerPrefs.DeleteKey("Steals");
        PlayerPrefs.DeleteKey("Blocks");
        PlayerPrefs.DeleteKey("Assist");
        PlayerPrefs.DeleteKey("OffRebound");
        PlayerPrefs.DeleteKey("TurnOvers");
        PlayerPrefs.DeleteKey("AverageScore");
        PlayerPrefs.DeleteKey("GradeAverage");
        PlayerPrefs.DeleteKey("PowerOfOne");
        //PlayerPrefs.DeleteKey("teamname");
        //PlayerPrefs.DeleteKey("playername");
    }

    
    */
    /// <summary>
    /// View Player full reportcard
    /// </summary>
    public void ReportCard_btn()
    {
        SceneManager.LoadScene(4);
        
    }

    
    public void Back_btn()
    {
        SceneManager.LoadScene(1);
    }

    public void NewGame_btn()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(2);
    }

    public void ScoreCard_btn()
    {
        SceneManager.LoadScene(3);
    }

    public void AddPlayer_btn()
    {
        //ScoreCard.Reset_btn();
        SceneManager.LoadScene(2);
    }

    public void TermsCond_btn()
    {
        //SceneManager.LoadScene(1);
    }
    /// <summary>
    /// Exit the game
    /// </summary>
    public void ExitGame_btn()
    {
        Application.Quit();
    }

    /// Deletes saved data on device and database
    /// </summary>
    public void Delete_All()
    {

        PlayerPrefs.DeleteAll();
    }
}
