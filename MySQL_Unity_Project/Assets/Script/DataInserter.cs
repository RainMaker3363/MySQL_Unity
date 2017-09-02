using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataInserter : MonoBehaviour {

    public string inputUserName;
    public string inputPassword;
    public string inputEmail;

    private string CreateUserURL = "http://localhost:8181/Cool_YT_RPG/InsertUser.php";
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            CreateUser(inputUserName, inputPassword, inputEmail);
        }
	}

    public void CreateUser(string username, string password, string email)
    {
        WWWForm form = new WWWForm();

        form.AddField("usernamePost", username);
        form.AddField("emailPost", email);
        form.AddField("passwordPost", password);

        WWW www = new WWW(CreateUserURL, form);

        Debug.Log("Insert Process Complete");
    }
}
