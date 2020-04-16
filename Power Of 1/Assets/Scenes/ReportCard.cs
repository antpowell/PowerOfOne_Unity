using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ReportCard : MonoBehaviour
{
    public TextMeshProUGUI playerName;

    //Split grade avarege into power of 1 score and feedback
    public TextMeshProUGUI gradeaverageText;
    public string GradeAverage;

    public TextMeshProUGUI powerofoneText;
    public string PowerOfOne;

    public Text averageScoreText;
    public static int AverageScore;
    public int TotalPointsScored;

    public TextMeshProUGUI TotalPointsText;

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = PlayerPrefs.GetString("playername", "No Player Found");
        gradeaverageText.text = PlayerPrefs.GetString("gradeaverageText", "NF");
        powerofoneText.text = PlayerPrefs.GetString("powerofoneText", "NF");
        averageScoreText.text =PlayerPrefs.GetInt("AverageScore", AverageScore).ToString();
        TotalPointsScored= PlayerPrefs.GetInt("TotalPointsScored", TotalPointsScored);
        TotalPointsText.text = TotalPointsScored.ToString();
    }

    private void savePoints()
    {
        PlayerPrefs.SetString("gradeaverageText", gradeaverageText.text);
        PlayerPrefs.SetString("powerofoneText", powerofoneText.text);
        PlayerPrefs.SetString("averageScoreText", averageScoreText.text);
        PlayerPrefs.SetInt("TotalPointsScored", TotalPointsScored);
    }

    
}
