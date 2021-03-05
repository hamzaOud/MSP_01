using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyNetwork : MonoBehaviour
{
    public string UserId;
    // Start is called before the first frame update
    void Start()
    {
        print("Connecting to server");

        string nickName = "DemoNick";
        nickName = PlayerPrefs.GetString("NickName");
        //if (string.IsNullOrEmpty(UserId))
        //{
        //    this.UserId = nickName + "ID";
        //}

        if (PhotonNetwork.AuthValues == null)
        {
            PhotonNetwork.AuthValues = new AuthenticationValues();
        }
        //else
        //{
        //    Debug.Log("Re-using AuthValues. UserId: " + PhotonNetwork.AuthValues.UserId);
        //}


        PhotonNetwork.AuthValues.UserId = nickName;

        PhotonNetwork.player.UserId = nickName;

        Debug.Log("Nickname: " + nickName);



        PhotonNetwork.playerName = nickName;


        PhotonNetwork.ConnectUsingSettings("0.1");
    }

    private void OnConnectedToMaster()
    {
        print( PhotonNetwork.player.UserId + " Connected to Master");
        PhotonNetwork.automaticallySyncScene = true;
        PhotonNetwork.playerName = PlayerNetwork.instance.PlayerName;

        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }

    private void OnJoinedLobby()
    {
        print("Joined lobby");

        if(!PhotonNetwork.inRoom)
            MainCanvasManager.Instance.LobbyCanvas.transform.SetAsLastSibling();
    }
}
