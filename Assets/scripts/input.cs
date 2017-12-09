using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour {

    public bool lane1;
    public bool lane2;

	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
            {
                if (this.gameObject.tag == "left")
                {
                    if (lane1 && !lane2)
                    {
                        lane1 = false;
                        lane2 = true;
                        this.transform.Translate(Vector3.right * 2f);
                    }
                    else if (lane2 && !lane1)
                    {
                        lane1 = true;
                        lane2 = false;
                        this.transform.Translate(Vector3.left * 2f);
                    }
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (Input.mousePosition.x > Screen.width / 2)
            {
                if (this.gameObject.tag == "right")
                {
                    if (lane1 && !lane2)
                    {
                        lane1 = false;
                        lane2 = true;
                        this.transform.Translate(Vector3.right * 2f);
                    }
                    else if (lane2 && !lane1)
                    {
                        lane1 = true;
                        lane2 = false;
                        this.transform.Translate(Vector3.left * 2f);
                    }
                }
            }
        }
    }
}
