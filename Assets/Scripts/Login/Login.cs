using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    [SerializeField]
    private InputField usernameInput;
    [SerializeField]
    private InputField passwordInput;


    public void CallLogin()
    {
        StartCoroutine(LoginClick());
    }

    IEnumerator LoginClick()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", usernameInput.text);
        form.AddField("pw", passwordInput.text);

        using (UnityWebRequest www = UnityWebRequest.Post("https://kunet.kingston.ac.uk/~k1910115/Login.php", form))
        {
            yield return www.SendWebRequest();
            //yield return www;
            if (www.isHttpError || www.isNetworkError)
            {
                Debug.Log("User login failed. Error #" + www.error);
            }
            else
            {
                if (www.downloadHandler.text == "0")
                {
                    Debug.Log("Logged in sucessfully");
                    DBManager.username = usernameInput.text;
                    PlayerPrefs.SetString("NickName", usernameInput.text);
                    SceneManager.LoadScene(1);
                }
                else
                {
                    Debug.Log("User Login failed. Error #" + www.downloadHandler.text);
                }
            }
        }

    }
}
