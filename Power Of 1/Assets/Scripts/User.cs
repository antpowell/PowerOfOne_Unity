using System;
using System.Threading.Tasks;
using UnityEngine;

[Serializable]

public class User
{

    public string uid;
    public string email;
    public string player;

    public string Uid { get => uid; set => uid = value; }
    public string Email { get => email; set => email = value; }
    public string Player { get => player; set => player = value; }

    public User()
    {
    }

    public User(string email)
    {
        Email = email;
    }

    public User(string email, string id)
    {
        Email = email;
        Uid = id;
    }

    public User(string email, string id, string userName)
    {
        Email = email;
        Uid = id;
        Player = userName;
    }


    public void updateUserDiaplyName(string playerName)
    {

        player = playerName;

        PlayerPrefs.SetString("playername", playerName);
        Debug.Log("updating AuthController");
        AuthController.updateUserProfile(player);
        //DB.postNewUser(AuthController.GetUser().UserId, AuthController.GetUser().Email, player);
    }



}

