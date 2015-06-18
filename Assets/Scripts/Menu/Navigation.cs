using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
    }

   public void navigate(string sceneName)
    {
        Debug.Log("navigate was triggered.");
        Application.LoadLevel(sceneName);
    }
}
