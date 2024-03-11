using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Chips : MonoBehaviour
{
    public int bet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnMouseOver
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                bet = +1;
            }
        }
    }
}


