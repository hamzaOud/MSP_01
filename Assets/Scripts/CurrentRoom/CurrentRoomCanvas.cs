using UnityEngine;
using Photon;
using UnityEngine.UI;

public class CurrentRoomCanvas : UnityEngine.MonoBehaviour
{

    [SerializeField]
    private Button startGameButton;

    public void OnClickStartSync()
    {
        PhotonNetwork.LoadLevel(2);
    }

    private void Update()
    {
        /*if (PhotonNetwork.room.PlayerCount < PhotonNetwork.room.MaxPlayers)
        {
            startGameButton.enabled = false;
        }
        else
        {
            startGameButton.enabled = true;
        }*/
    }
}
