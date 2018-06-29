using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruction : MonoBehaviour {

	// Use this for initialization

	private float d;
	public Scroll sc;
	public mountainscroll ms;
	public mountainscroll msn;
	public GameObject player;
	void Start () {
		d = player.transform.position.x - transform.position.x;
		
	}
	
	// Update is called once per frame
	void Update () {
		

		transform.position=new Vector3(player.transform.position.x-d,transform.position.y,transform.position.z);

		GameObject a=GameObject.FindGameObjectWithTag ("backg");
		if (a != null) {


			if (a.transform.position.x < transform.position.x) {

				sc.back.Remove (a);
				Destroy (a);
			}
		}

		GameObject b=GameObject.FindGameObjectWithTag ("mountainfar");
		if (b != null) {
			
			if (b.transform.position.x < transform.position.x) {
				
				ms.mts.Remove (b);
				Destroy (b);
			}
		}
	
		GameObject c=GameObject.FindGameObjectWithTag ("mountainnear");
		if (c != null) {


			if (c.transform.position.x < transform.position.x) {
				
				msn.mts.Remove (c);
				Destroy (c);
			}
		}
	
	}
}
