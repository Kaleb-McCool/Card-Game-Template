using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Chips : MonoBehaviour
{
    public GameObject Chip;
    public int val;
    public int bet;
    public int chp;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        if (Chip.name == "$10 Chip") 
        {
            val = 10;
        } 
        if (Chip.name == "$25 Chip") 
        {
            val = 25;
        } 
        if (Chip.name == "$50 Chip") 
        {
            val = 50;
        } 
        if (Chip.name == "$100 Chip") 
        {
            val = 100;
        } 
        bet = 0;
        time = 0;
        chp = 200;
    }

    // Update is called once per frame
    void Update()
    {
        time--;
    }
    void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.Mouse0)&&time<0)
        {
            bet += val;
            time = 200;
            chp -= val;
        }
    }
}



