using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{


	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 pos;
		GameObject gObj = GameObject.Find("Player");
		if (gObj)
		{
			pos = gObj.transform.position;
			Debug.Log(pos);
			pos.z -= 8;
			transform.position = pos;
		}

	}

	private void FixedUpdate()
	{
	}
}
