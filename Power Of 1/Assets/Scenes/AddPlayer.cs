using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Threading.Tasks;

public class AddPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField playerNameInputField;
    public TextMeshProUGUI errorMessage;


    public void Start()
    {
        errorMessage.alpha = 0.0f;
    }

    public void onClick()
    {
        if (playerNameInputField.text == string.Empty)
        {
            errorMessage.alpha = 1.0f;
        }
        else
        {

            errorMessage.alpha = 0.0f;

            UpdateUser();

            // Update user in database
            SceneManager.LoadScene(3);
        }


    }

    public void UpdateUser()
    {
        //DB.postNewUser(AuthController.GetUser().UserId, AuthController.GetUser().Email, playerNameInputField.text);
        User currentUser = new User();
        currentUser.updateUserDiaplyName(playerNameInputField.text);
    }


}
