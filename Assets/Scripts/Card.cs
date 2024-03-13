using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Card_data data;

    public string card_name;
    public string description;
    public Sprite Image1;
    public Sprite Image2;
    public Sprite MEME;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI number1;
    public TextMeshProUGUI number2;
    public Image spriteImage;
        

    // Start is called before the first frame update
    void Start()
    {
        card_name = data.card_name;
        description = data.description;
        Image1 = data.Image1;
        Image2 = data.Image2;
        MEME = data.MEME;
        descriptionText.text = description;
        number1.text = number1.ToString();
        number2.text = number2.ToString();
        spriteImage.sprite = MEME;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
