using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SignIn_Up : MonoBehaviour
{

    public TMP_InputField emailInput, passwordInput;
    private User currentUser;
    // Start is called before the first frame update
    void Start()
    {
        DB.Start();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateUser()
    {
        AuthController.Register(emailInput.text, passwordInput.text);
        if (AuthController.GetUser() != null)
        {
            LoginUser();
        }

    }

    public void LoginUser()
    {

        AuthController.Login(emailInput.text, passwordInput.text);
        if (AuthController.GetUser() != null)
        {

            /*currentUser = new User(emailInput.text, AuthController.GetUser().UserId);
            SceneManager.LoadScene(2);
            Debug.Log("screne should've loaded");*/
            

        }

    }

    public void LogOut()
    {
        AuthController.Logout();
    }

}
