using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject Jelly;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", 2f, 2f);
	}
	


    void Spawn(){
        Instantiate(Jelly, transform.position, Quaternion.identity);
    }
}
