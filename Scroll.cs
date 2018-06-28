using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

	public GameObject[] bckg;
	public List<GameObject> back;
	public float hspeed=-1f;
	public CameraController cam;
	private Vector3 distance;


	void Awake ()
	{
		back = new List<GameObject> ();
		GameObject a = Instantiate (bckg[Random.Range (0, bckg.Length)]);
		GameObject b = Instantiate (bckg[Random.Range (0, bckg.Length)]);
		a.transform.position = new Vector3 (transform.position.x + a.transform.GetComponent<SpriteRenderer> ().size.x, transform.position.y, transform.position.z);
		b.transform.position = new Vector3 (a.transform.position.x + b.transform.GetComponent<SpriteRenderer> ().size.x, transform.position.y, transform.position.z);
		back.Add (a);
		back.Add (b);
		transform.position =b.transform.position;

	}



	void Start () {
		
		
		distance =   transform.position-cam.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x - cam.transform.position.x < distance.x) { 
			GameObject sc = (GameObject) Instantiate (bckg [Random.Range (0, bckg.Length)]);

			sc.transform.position = new Vector3 (transform.position.x + sc.transform.GetComponent<SpriteRenderer> ().size.x, transform.position.y, transform.position.z);
			back.Add (sc);
			Debug.Log (back.Count);
			transform.position=sc.transform.position;

		}

		for (int i = 0; i < back.Count; i++) {
			back [i].transform.position += Vector3.right * hspeed * Time.deltaTime;

		}

		transform.position += Vector3.right * hspeed * Time.deltaTime;
	}

}
