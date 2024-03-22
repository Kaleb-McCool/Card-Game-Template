using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Stsh;
    public int bt;
    public static GameManager gm;
    public List<Card> deck = new List<Card>();
    public List<Card> player_deck = new List<Card>();
    public List<Card> ai_deck = new List<Card>();
    public List<Card> player_hand = new List<Card>(); 
    public List<Card> ai_hand = new List<Card>();
    public List<Card> discard_pile = new List<Card>();
    private void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Deal();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current mouse position
        Vector3 mousePosition = Input.mousePosition;

        // Convert the screen coordinates to world coordinates
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Output the mouse position
        Debug.Log("Mouse Position: " + mousePosition);
        Stsh = Chips.Chp;
        bt = Chips.Bet;
    }

    void Initial()
    {
        
    }
    void Deal()
    {
        
        var firs = deck[0];
        if (deck.Count > 0)
        {
            deck.RemoveAt(0);
            player_hand.Add(firs);
        }
        //for player
        
        
    }

    void Shuffle()
    {
        //3 rounds then shuffy
    }

    void AI_Turn()
    {

    }



    
}
