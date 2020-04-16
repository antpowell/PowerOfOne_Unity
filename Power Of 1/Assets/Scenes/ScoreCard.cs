using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCard : MonoBehaviour
{
    public TextMeshProUGUI playerName;

    public Text freethrowText;
    public static int MadeFreeThrow;

    public Text freethrowmissText;
    public static int FreeThrowMiss;

    public Text twopointText;
    public static int TwoPoint;

    public Text twopointmissText;
    public static int TwoPointMiss;

    public Text threepointText;
    public static int ThreePoint;

    public Text threepointmissText;
    public static int ThreePointMiss;

    public Text offreboundText;
    public static int OffRebound;

    public Text stealsText;
    public static int Steals;

    public Text blocksText;
    public static int Blocks;

    public Text turnoversText;
    public static int TurnOvers;

    public Text assistText;
    public static int Assist;


    public Text averageScoreText;
    public static int AverageScore;

    //Split grade avarege into power of 1 score and feedback
    public TextMeshProUGUI gradeaverageText;
    public string GradeAverage;

    public TextMeshProUGUI powerofoneText;
    public string PowerOfOne;
    public int TotalPointsScored;
    private void Start()
    {
        gradeaverageText.text = PlayerPrefs.GetString("gradeaverageText", "NF");
        powerofoneText.text = PlayerPrefs.GetString("powerofoneText", "NF");
        playerName.text = PlayerPrefs.GetString("playername", "No Player Found");
        freethrowText.text = PlayerPrefs.GetInt("MadeFreeThrow").ToString();
        freethrowmissText.text = PlayerPrefs.GetInt("FreeThrowMiss").ToString();
        twopointText.text = PlayerPrefs.GetInt("TwoPoint").ToString();
        twopointmissText.text = PlayerPrefs.GetInt("TwoPointMiss").ToString();
        threepointText.text = PlayerPrefs.GetInt("ThreePoint").ToString();
        threepointmissText.text = PlayerPrefs.GetInt("ThreePointMiss").ToString();
        stealsText.text = PlayerPrefs.GetInt("Steals").ToString();
        blocksText.text = PlayerPrefs.GetInt("Blocks").ToString();
        assistText.text = PlayerPrefs.GetInt("Assist").ToString();
        offreboundText.text = PlayerPrefs.GetInt("OffRebound").ToString();
        turnoversText.text = PlayerPrefs.GetInt("TurnOvers").ToString();
        TotalPointsScored = PlayerPrefs.GetInt("TotalPointsScored");



    }

    public void SaveData()
    {



        ////////////Saves GRADE AVERAGE \\\\\\\\\\\\\\\\
        print("calc feedback");

        if (AverageScore <= 2)
        {
            gradeaverageText.text = " " + "You should practice more.";
            
        }
        if (AverageScore >= 2)
        {
            gradeaverageText.text = "  " + "Keep trying.";
            
        }

        if (AverageScore >= 6)
        {
            gradeaverageText.text = "  " + "You're half way there.";
        }

        if (AverageScore >= 9)
        {
            gradeaverageText.text = "   " + "You're taking this serious.";
        }

        if (AverageScore >= 12)
        {
            gradeaverageText.text = " " + "You are on fire!";
        }

        print("saving feedback");

        PlayerPrefs.SetString("gradeaverageText", gradeaverageText.text);




        ////////////Saves POWER OF 1 SCORE \\\\\\\\\\\\\\\\
        ///
        print("calc PO1S");

        if (AverageScore <= 2)
        {
            powerofoneText.text = "" + "F ";

        }
        if (AverageScore >= 2)
        {
            powerofoneText.text = "" + "D";
        }

        if (AverageScore >= 6)
        {
            powerofoneText.text = "" + "C";
        }

        if (AverageScore >= 9)
        {
            powerofoneText.text = ""+"B";
        }

        if (AverageScore >= 12)
        {
            powerofoneText.text = "" + "A";
        }

        print("saveing PO1S");

        PlayerPrefs.SetString("powerofoneText", powerofoneText.text);

        savePoints();

    }
    

    //We add team and player name when we click button. This also display

    /* public void AddTeam_btn()
     {
         teamnameText.text = "" + teamName.text;
     }
    */

    public void SavedGames_btn()
    {
        SceneManager.LoadScene("HistoryGame");
    }

    public void StartGame_btn()
    {
        SceneManager.LoadScene("Player1 StartGame");
        //PlayerPrefs.SetString("playername", playername);

        

    }

    public void Reset_btn()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Clear();
        savePoints();

        Debug.LogFormat("User Account INFO:\n UserID: {0} \nEmail: {1} \nDisplayName: {2}", AuthController.GetUser().UserId, AuthController.GetUser().Email, AuthController.GetUser().DisplayName);
    }

    public void Back_btn()
    {
        Reset_btn();
        SceneManager.LoadScene(2);
    }

    public void ReportCard_btn()
    {
        SaveData();
        SceneManager.LoadScene(4);

    }

    /* public void GetData_btn()
     {
         playernameText.text = RetrieveFromDatabase().userPlayerName.ToString();
         freethrowText.text = RetrieveFromDatabase().userFreeThrow.ToString();

     }*/

    ////// This keeps player1 score. 
    public void freethrow_btn()
    {
        {
            MadeFreeThrow++;
            AverageScore++;
            //GradeAverage++;
            freethrowText.text = "" + MadeFreeThrow;
            gradeaverageText.text = "" + GradeAverage;
            averageScoreText.text = "" + AverageScore;
            powerofoneText.text = "" + PowerOfOne;
            TotalPointsScored++;

        // RetrieveFromDatabase();
        }

    }

    public void freethrowmiss_btn()
    {



        {

            FreeThrowMiss++;
            AverageScore--;
            //GradeAverage--;
            freethrowmissText.text = "" + FreeThrowMiss;
            gradeaverageText.text = "" + GradeAverage;
            averageScoreText.text = "" + AverageScore;
            powerofoneText.text = "" + PowerOfOne;
            //RetrieveFromDatabase();
            
        }

    }

    public void twopoint_btn()
    {



        {

            TwoPoint++;
            //GradeAverage++;
            AverageScore++;
            twopointText.text = "" + TwoPoint;
            gradeaverageText.text = "" + GradeAverage;
            averageScoreText.text = "" + AverageScore;
            powerofoneText.text = "" + PowerOfOne;
            //RetrieveFromDatabase();
            TotalPointsScored += 2;
        }

    }

    public void twopointmiss_btn()
    {



        {

            TwoPointMiss++;
            AverageScore--;
            // GradeAverage--;
            twopointmissText.text = "" + TwoPointMiss;
            gradeaverageText.text = "" + GradeAverage;
            averageScoreText.text = "" + AverageScore;
            powerofoneText.text = "" + PowerOfOne;
            //RetrieveFromDatabase();
        }

    }


    public void threepoint_btn()
    {


        {

            ThreePoint++;
            AverageScore++;
            //GradeAverage++;
            threepointText.text = "" + ThreePoint;
            gradeaverageText.text = "" + GradeAverage;
            averageScoreText.text = "" + AverageScore;
            powerofoneText.text = "" + PowerOfOne;
            //RetrieveFromDatabase();
            TotalPointsScored += 3;
        }

    }

    public void threepointmiss_btn()
    {


        {

            ThreePointMiss++;
            AverageScore--;
            //GradeAverage--;
            threepointmissText.text = "" + ThreePointMiss;
            gradeaverageText.text = "" + GradeAverage;
            averageScoreText.text = "" + AverageScore;
            powerofoneText.text = "" + PowerOfOne;
            //RetrieveFromDatabase();
        }

    }

    public void offrebound_btn()
    {



        {

            OffRebound++;
            AverageScore++;
            //GradeAverage++;
            offreboundText.text = "" + OffRebound;
            gradeaverageText.text = "" + GradeAverage;
            averageScoreText.text = "" + AverageScore;
            powerofoneText.text = "" + PowerOfOne;
            //RetrieveFromDatabase();
        }

    }

    public void steals_btn()
    {



        {

            Steals++;
            AverageScore++;
            //GradeAverage++;
            stealsText.text = "" + Steals;
            gradeaverageText.text = "" + GradeAverage;
            averageScoreText.text = "" + AverageScore;
            powerofoneText.text = "" + PowerOfOne;
            //RetrieveFromDatabase();
        }

    }

    public void blocks_btn()
    {



        {

            Blocks++;
            AverageScore++;
            //GradeAverage++;
            blocksText.text = "" + Blocks;
            gradeaverageText.text = "" + GradeAverage;
            averageScoreText.text = "" + AverageScore;
            powerofoneText.text = "" + PowerOfOne;
            //RetrieveFromDatabase();
        }

    }

    public void turnovers_btn()
    {



        {

            TurnOvers++;
            AverageScore--;
            //GradeAverage--;
            turnoversText.text = "" + TurnOvers;
            gradeaverageText.text = "" + GradeAverage;
            averageScoreText.text = "" + AverageScore;
            powerofoneText.text = "" + PowerOfOne;
            // RetrieveFromDatabase();

        }

    }

    public void assist_btn()
    {



        {

            Assist++;
            AverageScore++;
            //GradeAverage++;
            assistText.text = "" + Assist;
            gradeaverageText.text = "" + GradeAverage;
            averageScoreText.text = "" + AverageScore;
            powerofoneText.text = "" + PowerOfOne;
            //RetrieveFromDatabase();
        }

    }

    private void Clear()
    {
        //Add possible fields, set to 0
        //Add power of 1 score, set to N/A
        //Add feedback, set to N/A
        MadeFreeThrow = 0;
        FreeThrowMiss = 0;
        TwoPoint = 0;
        TwoPointMiss = 0;
        ThreePoint = 0;
        ThreePointMiss = 0;
        Steals = 0;
        Blocks = 0;
        Assist = 0;
        OffRebound = 0;
        TurnOvers = 0;
        AverageScore = 0;
        powerofoneText.text = "";
        gradeaverageText.text = "";
        TotalPointsScored = 0;
    }

    private void savePoints()
    {
        //save data in feed back and grade
        PlayerPrefs.SetInt("MadeFreeThrow", MadeFreeThrow);
        PlayerPrefs.SetInt("FreeThrowMiss", FreeThrowMiss);
        PlayerPrefs.SetInt("TwoPoint", TwoPoint);
        PlayerPrefs.SetInt("TwoPointMiss", TwoPointMiss);
        PlayerPrefs.SetInt("ThreePoint", ThreePoint);
        PlayerPrefs.SetInt("ThreePointMiss", ThreePointMiss);
        PlayerPrefs.SetInt("Steals", Steals);
        PlayerPrefs.SetInt("Blocks", Blocks);
        PlayerPrefs.SetInt("Assist", Assist);
        PlayerPrefs.SetInt("OffRebound", OffRebound);
        PlayerPrefs.SetInt("TurnOvers", TurnOvers);
        PlayerPrefs.SetInt("AverageScore", AverageScore);
        PlayerPrefs.SetInt("TotalPointsScored", TotalPointsScored);
        /* PlayerPrefs.SetString("gradeaverageText", gradeaverageText.text);
         PlayerPrefs.SetString("powerofoneText", powerofoneText.text);
         */
    }

    
}
