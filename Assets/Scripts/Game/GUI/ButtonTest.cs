using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [PunRPC]
    public void OnClickTestButton()
    {
        GameObject unit = GameObject.FindWithTag("Unit");
        unit.GetComponent<Renderer>().material.color = Color.black;

        PhotonView photonView = PhotonView.Get(this);
        photonView.RPC("OnClickTestButton", PhotonTargets.Others);
    }

    [PunRPC]
    public void OnClickOtherButton()
    {
        GameObject unit = GameObject.FindWithTag("Unit");
        unit.GetComponent<Renderer>().material.color = Color.cyan;

        PhotonView photonView = PhotonView.Get(this);
        photonView.RPC("OnClickOtherButton", PhotonTargets.Others);
    }
}
