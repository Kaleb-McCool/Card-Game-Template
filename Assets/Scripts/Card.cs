 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Card_data data;

    
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI number1;
    public TextMeshProUGUI number2;
    public Image spriteImage;
    public Image spriteImage2;
    public Image memeImage;
        

    // Start is called before the first frame update
    void Start()
    {
        descriptionText.text = data.description;
        spriteImage.sprite = data.Image1;
        spriteImage2.sprite= data.Image1;
        memeImage.sprite = data.MEME;
        
        number1.text = data.number1;
        number2.text = data.number1;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
