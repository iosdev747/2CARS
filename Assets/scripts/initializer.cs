using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initializer : MonoBehaviour {
    public enum category
    {
        A, B, C, D
    }
    public category obj;
    public GameObject[] objects;
    public GameObject[] copyclone;
    private GameObject clones;
    private float tempt;
    private int destructor;
    public float final; 
    public float initial;
    public float counter;

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(this.transform.position, 0.6f);
    }


	void Start () {
        counter = 1f;
        initial = 2f;
        final = 0f;
    }
	void Update ()
    {
        if (Time.time > tempt)
        {
            if (obj == category.A && GameManager.c1 <= 0f)
            {
                if (counter * Time.deltaTime < Random.value)
                {
                    int spawnnumber = Random.Range(0, 2);
                    GameObject clones = Instantiate(objects[spawnnumber]) as GameObject;
                    clones.transform.position = this.transform.position;
                    clones.transform.parent = GameObject.Find("Spawns").transform;
                }
                tempt = Time.time + initial;
                GameManager.c1 = 4f;
                GameManager.c2 = 2f;
                //Debug.Log(GameManager.c1);
            }
            if (obj == category.B && GameManager.c2 <= 0f)
            {
                if (counter * Time.deltaTime < Random.value)
                {
                    int spawnnumber = Random.Range(0, 2);
                    GameObject clones = Instantiate(objects[spawnnumber]) as GameObject;
                    clones.transform.position = this.transform.position;
                    clones.transform.parent = GameObject.Find("Spawns").transform;
                }
                tempt = Time.time + initial;
                GameManager.c1 = 2f;
                //Debug.Log(GameManager.c1);
            }
            if (obj == category.C && GameManager.c3 <= 0f)
            {
                if (counter * Time.deltaTime < Random.value)
                {
                    int spawnnumber = Random.Range(0, 2);
                    GameObject clones = Instantiate(objects[spawnnumber]) as GameObject;
                    clones.transform.position = this.transform.position;
                    clones.transform.parent = GameObject.Find("Spawns").transform;
                }
                tempt = Time.time + initial;
                GameManager.c4 = 2f;
                GameManager.c3 = 4f;
                //Debug.Log(GameManager.c1);
            }
            if (obj == category.D && GameManager.c4 <= 0f)
            {
                if (counter * Time.deltaTime < Random.value)
                {
                    int spawnnumber = Random.Range(0, 2);
                    GameObject clones = Instantiate(objects[spawnnumber]) as GameObject;
                    clones.transform.position = this.transform.position;
                    clones.transform.parent = GameObject.Find("Spawns").transform;
                }
                tempt = Time.time + initial;
                GameManager.c3 = 2f;
                //Debug.Log(GameManager.c1);
            }
        }
	}
}
