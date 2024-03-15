using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card_data", menuName = "Cards/Card_data", order = 1)]
public class Card_data : ScriptableObject
{
    public string card_name;
    public Sprite Image1;
    public Sprite Image2;
    public string description;
    public int number1;
    public int number2;
    public Sprite MEME;

}
