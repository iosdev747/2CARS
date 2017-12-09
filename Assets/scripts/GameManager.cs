using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    //public Text textfield;
    public static float c1,c2,c3,c4;
    public static int i,j;
    public static void points()
    {
        i++;
  //      updatetext();
    }
    // Use this for initialization
    void Start () {
        c1 = c2 = c3 = c4 = 2f;
        i = 0;
        j = PlayerPrefs.GetInt("high");
        PlayerPrefs.SetFloat("speed", 2f);
	}
	
	// Update is called once per frame
	void Update () {
        c1 = Mathf.Clamp(c1 - Time.deltaTime, 0f, 2f);
        c2 = Mathf.Clamp(c2 - Time.deltaTime, 0f, 2f);
        c3 = Mathf.Clamp(c3 - Time.deltaTime, 0f, 2f);
        c4 = Mathf.Clamp(c4 - Time.deltaTime, 0f, 2f);
        Debug.Log(i);
        Debug.Log(j);
        if (j < i) 
        { j = i;
            PlayerPrefs.SetInt("high", j); }
 /*
    Debug.Log(c1);
    Debug.Log(c2);
    Debug.Log(c3);
    Debug.Log(c4);
*/
    }
    // public void updatetext()
    //   {
    //     textfield.text = i.ToString();  
    // }
}