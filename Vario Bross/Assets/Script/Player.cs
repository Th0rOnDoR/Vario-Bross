using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public int Talent;
    public float TalentSpeed;
    public float TalentTime;
    // Start is called before the first frame update
    void Start()
    {
        if (Talent < 0)
        {
            Debug.Log("Tqt Start");
        }
        else
        {
            Debug.Log(TalentSpeed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Talent < 0)
            {
                Console.Write("Oui");
            }
        }
	}
}
