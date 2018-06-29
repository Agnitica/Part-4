using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mountainscroll : MonoBehaviour {


	public GameObject[] m;
	public List<GameObject> mts;
	public float hspeed=-2f;
	public CameraController cam;
	private Vector3 distance;
	// Use this for initialization
	void Awake ()
	{
		mts = new List<GameObject> ();
		GameObject a = Instantiate (m[Random.Range (0, m.Length)]);
		GameObject b = Instantiate (m[Random.Range (0, m.Length)]);
		GameObject c = Instantiate (m[Random.Range (0, m.Length)]);
		a.transform.position = new Vector3 (transform.position.x + a.transform.GetComponent<SpriteRenderer> ().size.x, transform.position.y, transform.position.z);
		b.transform.position = new Vector3 (a.transform.position.x + b.transform.GetComponent<SpriteRenderer> ().size.x, transform.position.y, transform.position.z);
		c.transform.position = new Vector3 (b.transform.position.x + c.transform.GetComponent<SpriteRenderer> ().size.x, transform.position.y, transform.position.z);


		mts.Add (a);
		mts.Add (b);
		mts.Add (c);
	
		transform.position =c.transform.position;

	}


	void Start () {

		distance =   transform.position-cam.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x - cam.transform.position.x < distance.x) { 
			GameObject sc = (GameObject) Instantiate (m [Random.Range (0, m.Length)]);

			sc.transform.position = new Vector3 (transform.position.x + sc.transform.GetComponent<SpriteRenderer> ().size.x, transform.position.y, transform.position.z);
			mts.Add (sc);
			Debug.Log (mts.Count);
			transform.position=sc.transform.position;

		}

		for (int i = 0; i < mts.Count; i++) {
			mts[i].transform.position += Vector3.right * hspeed * Time.deltaTime;

		}

		transform.position += Vector3.right * hspeed * Time.deltaTime;
	}
}
