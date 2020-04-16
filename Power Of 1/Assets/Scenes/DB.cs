using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Proyecto26;
using Firebase.Unity.Editor;
using Firebase;
using Firebase.Database;

public static class DB
{
    private static DatabaseReference dbRef;
    private static Firebase.Auth.FirebaseAuth auth;


    public static void Start()
    {

        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://powerof1.firebaseio.com/");

        // Root reference location of database
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;
    }



    public static void postNewUser(string userID, string email, string player)
    {


        User user = new User(email, userID, player);

        string json = JsonUtility.ToJson(user);

        Debug.Log("adding user to DB");

        dbRef.Child("users").Child(email).Push().SetRawJsonValueAsync(json);

        Debug.LogFormat("user added as: {0}", json);


    }


    private static void Postdata()
    {

    }

    private static void Getdata()
    {

    }
}
