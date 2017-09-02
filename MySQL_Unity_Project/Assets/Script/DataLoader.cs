using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour {

    public string[] items;

    private void Start()
    {
        StartCoroutine(StartLoadData());
    }

    // Use this for initialization
    IEnumerator StartLoadData () {

        WWW itemsData = new WWW("http://localhost:8181/Cool_YT_RPG/ItemsData.php");

        yield return itemsData;

        string itemsDataString = itemsData.text;
        print(itemsDataString);

        items = itemsDataString.Split(';');

        print(GetDataValue(items[0], "Name : "));
	}

    private string GetDataValue(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);

        if(value.Contains("|"))
        {
            value = value.Remove(value.IndexOf("|"));
        }
        
        return value;
    }

}
