using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginCanvasManager : MonoBehaviour
{
    private bool isRegisterHidden = true;
    [SerializeField]
    private GameObject LoginCanvas;
    [SerializeField]
    private GameObject RegisterCanvas;

    // Start is called before the first frame update
    void Start()
    {
        RegisterCanvas.SetActive(!isRegisterHidden);
        LoginCanvas.SetActive(isRegisterHidden);
    }

    public void OnClickSwitchUI()
    {
        isRegisterHidden = !isRegisterHidden;
        if (isRegisterHidden)
        {
            RegisterCanvas.SetActive(!isRegisterHidden);
            LoginCanvas.SetActive(isRegisterHidden);
        }
        else
        {
            RegisterCanvas.SetActive(!isRegisterHidden);
            LoginCanvas.SetActive(isRegisterHidden);
        }
    }
}
