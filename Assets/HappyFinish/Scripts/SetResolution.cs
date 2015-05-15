using UnityEngine;
using System.Collections;

public class SetResolution : MonoBehaviour 
{

	public int ScreenWidth = 2560;
	public int ScreenHeight = 1440;

	// Use this for initialization
	void Start () 
	{
		ChangeScale ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		if ( transform.localScale.x != ScreenWidth || transform.localScale.z != ScreenHeight )
		{
			ChangeScale();
		}
	}

	void ChangeScale()
	{
		transform.localScale = new Vector3 (ScreenWidth, 1, ScreenHeight);
	}
}
