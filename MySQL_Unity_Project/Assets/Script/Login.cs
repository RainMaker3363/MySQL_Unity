using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour {

    public string InputUserName;
    public string InputPassWord;

    private string CreateUserURL = "http://localhost:8181/Cool_YT_RPG/login.php";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.L))
        {
            StartCoroutine(LoginToDB(InputUserName, InputPassWord));
        }
	}

    IEnumerator LoginToDB(string userName, string Password)
    {
        WWWForm form = new WWWForm();

        form.AddField("usernamePost", userName);
        form.AddField("passwordPost", Password);

        WWW www = new WWW(CreateUserURL, form);


        yield return www;

        Debug.Log(www.text);
    }
}
