using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    [SerializeField]
    private InputField usernameInput;
    [SerializeField]
    private InputField passwordInput;


    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", usernameInput.text);
        form.AddField("pw", passwordInput.text);
        print(usernameInput.text);
        print(passwordInput.text);

        using (UnityWebRequest www = UnityWebRequest.Post("https://kunet.kingston.ac.uk/~k1910115/Register.php", form))
        {
            yield return www.SendWebRequest();
            //yield return www;
            if (www.isHttpError || www.isNetworkError)
            {
                Debug.Log("User creation failed. Error #" + www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }

    }
}
