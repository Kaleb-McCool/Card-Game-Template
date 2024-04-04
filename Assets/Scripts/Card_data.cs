using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card_data", menuName = "Cards/Card_data", order = 1)]
public class Card_data : ScriptableObject
{
    public Sprite Image1;
    public string description;
    public string number1;
    public Sprite MEME;
    public bool isPlayer = false;

}
