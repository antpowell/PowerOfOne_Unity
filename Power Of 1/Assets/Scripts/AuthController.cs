using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Auth;
using UnityEngine.SceneManagement;
//using Proyecto26;
using TMPro;
using Firebase.Extensions;
using System.Threading.Tasks;


public static class AuthController
{

    private static Firebase.Auth.FirebaseUser newUser;
    private static User currentUser = new User();
    //public Text email, password;


    public static void Login(string email, string pwd)
    {
        FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync(email,
            pwd).ContinueWithOnMainThread((task =>
            {

                if (task.IsCanceled)
                {
                    Debug.LogError("SignInWithEmailAndPasswordAsync was canceled.");
                    return;
                }
                if (task.IsFaulted)
                {
                    Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                    return;
                }

                if (task.IsCompleted)
                {

                    newUser = task.Result;
                    Debug.LogFormat("User signed in successfully: {0} ({1})",
                        newUser.Email, newUser.UserId);
                    currentUser = new User(newUser.Email, newUser.UserId);
                    SceneManager.LoadScene(2);
                    Debug.Log("screne should've loaded");


                }

                // newUser = task.Result;




            }));

    }


    public static void Register(string email, string pwd)
    {
        if (email.Equals("") && pwd.Equals(""))
        {
            Debug.Log("Please enter an email and password to register");
        }

        FirebaseAuth.DefaultInstance.CreateUserWithEmailAndPasswordAsync(email, pwd).ContinueWith((task =>
            {


                if (task.IsCanceled)
                {
                    Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                    return;
                }

                if (task.IsFaulted)
                {
                    Firebase.FirebaseException e =
                    task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;


                    GetErrorMessage((AuthError)e.ErrorCode);
                    Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + e);
                    return;
                }

                if (task.IsCompleted)
                {
                    Debug.Log("Registration COMPLETE");
                    Firebase.Auth.FirebaseUser newUser = task.Result;
                    Debug.LogFormat("Firebase user created successfully: {0} ({1})",
                        newUser.Email, newUser.UserId);
                }

            }));

    }

    public static void Logout()
    {
        if (FirebaseAuth.DefaultInstance.CurrentUser != null)
        {
            FirebaseAuth.DefaultInstance.SignOut();
        }
    }


    static void GetErrorMessage(AuthError errorCode)
    {
        string msg = "";

        msg = errorCode.ToString();

        switch (errorCode)
        {
            case AuthError.AccountExistsWithDifferentCredentials:
                break;

            case AuthError.MissingPassword:
                break;

            case AuthError.WrongPassword:
                break;

            case AuthError.InvalidEmail:
                break;


        }
        Debug.Log(msg);
    }

    public static void updateUserProfile(string playerName)
    {
        Debug.Log("updating User profile");
        if (newUser != null)
        {
            Debug.Log("found user to update");
            Firebase.Auth.UserProfile profile = new Firebase.Auth.UserProfile
            {
                DisplayName = playerName,
            };
            newUser.UpdateUserProfileAsync(profile).ContinueWith(task =>
            {
                if (task.IsCanceled)
                {
                    Debug.LogError("UpdateUserProfileAsync was canceled.");
                    return;
                }
                if (task.IsFaulted)
                {
                    Debug.LogError("UpdateUserProfileAsync encountered an error: " + task.Exception);
                    return;
                }
                if (task.IsCompleted)
                {
                    DB.postNewUser(AuthController.GetUser().UserId, AuthController.GetUser().Email, AuthController.GetUser().DisplayName);
                    Debug.LogFormat("User profile updated successfully. email {0}, username {1}, id {2}", newUser.Email, newUser.DisplayName, newUser.UserId);
                }



            });
        }
        else
        {
            Debug.LogErrorFormat("No new user found: {0}", newUser);
        }


    }

    public static FirebaseUser GetUser()
    {
        return newUser;
    }
}
