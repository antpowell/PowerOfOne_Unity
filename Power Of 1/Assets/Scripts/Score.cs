using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using Proyecto26;
using UnityEngine.SceneManagement;
using TMPro;

public class Score : MonoBehaviour
{
  



    //private int currentSceneIndex;

   /* public void Start()
    {
        /////Retrieve data from player device 
        ///
        FreeThrow = PlayerPrefs.GetInt("FreeThrow");
        FreeThrowMiss = PlayerPrefs.GetInt("FreeThrowMiss");
        TwoPoint = PlayerPrefs.GetInt("TwoPoint");
        TwoPointMiss = PlayerPrefs.GetInt("TwoPointMiss");
        ThreePoint = PlayerPrefs.GetInt("ThreePoint");
        ThreePointMiss = PlayerPrefs.GetInt("ThreePointMiss");
        Steals = PlayerPrefs.GetInt("Steals");
        Blocks = PlayerPrefs.GetInt("Blocks");
        Assist = PlayerPrefs.GetInt("Assist");
        OffRebound = PlayerPrefs.GetInt("OffRebound");
        TurnOvers = PlayerPrefs.GetInt("TurnOvers");
        //teamname = PlayerPrefs.GetString("teamname");
        AverageScore = PlayerPrefs.GetInt("AverageScore");
        GradeAverage = PlayerPrefs.GetString("GradeAverage");
        //playername = PlayerPrefs.GetString("playername");




        /////dynamically shows player1 text on screen////
        ///
        */
        /*freethrowText.text = "" + FreeThrow;
         freethrowmissText.text = "" + FreeThrowMiss;
         twopointText.text = "" + TwoPoint;
         twopointmissText.text = "" + TwoPointMiss;
         threepointText.text = "" + ThreePoint;
         threepointmissText.text = "" + ThreePointMiss;
         offreboundText.text = "" + OffRebound;
         stealsText.text = "" + Steals;
         blocksText.text = "" + Blocks;
         turnoversText.text = "" + TurnOvers;
         assistText.text = "" + Assist;
         //teamnameText.text = "" + teamname;
         gradeaverageText.text = "" + GradeAverage;
         averageScoreText.text = "" + AverageScore;     
        */
        /*






        ////////////GRADE AVERAGE BEGANS \\\\\\\\\\\\\\\\

        if (AverageScore <= 2)
        {
            gradeaverageText.text = "F  -   " + "You should practice more.";

        }
        if (AverageScore >= 2)
        {
            gradeaverageText.text = "D  -   " + "Keep trying.";
        }

        if (AverageScore >= 6)
        {
            gradeaverageText.text = "C -  " + "You're half way there.";
        }

        if (AverageScore >= 9)
        {
            gradeaverageText.text = "B -    " + "You're taking this serious.";
        }

        if (AverageScore >= 12)
        {
            gradeaverageText.text = "A  -  " + "You are on fire!";
        }


    }*/





    
   
    //// 
    ///Connect to Firebase data base.
    ///
    
   /*  private void PostToDatabase()
     {

         User user = new User();
       //  RestClient.Put("https://power-of-1.firebaseio.com/Power%20Of%201" + playername +".json", user);
     }


     private User RetrieveFromDatabase()
     {

         User user = new User();
    *//*RestClient.Get<User>( "https://power-of-1.firebaseio.com/Power%20Of%201" + playername + ".json").Then(response =>
         {
             return response;
         });*//*
        return null;
     }*/
     
 }
