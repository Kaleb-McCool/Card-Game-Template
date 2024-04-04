using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

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

        for (int i = deck.Count - 1; i >= 0; i--)
        {
            int randomNumber = Random.Range(0, deck.Count);
            var firs = deck[randomNumber];
                    if (deck.Count > 0)
                    {
                        player_deck[randomNumber].data.isPlayer = true;
                        deck.RemoveAt(randomNumber);
                        player_deck.Add(firs);
                        
                    }
                    if (deck.Count > 0)
                    {
                        ai_deck[randomNumber].data.isPlayer = false;
                        deck.RemoveAt(randomNumber);
                        ai_deck.Add(firs);
                        
                    }
                        
        }
                    
        
        //for player
        
        
    }

    void Shuffle()
    {
         
    }

    void Turn()
    {
        if (player_deck.Count <= 0)
        {
            player_deck.AddRange(player_hand);
        }

        if (ai_deck.Count <= 0)
        {
            ai_deck.AddRange(ai_hand);
        }
        var win1 = player_deck[0];
        var win2 = ai_deck[0];
        if (player_deck[0].data.number1 < ai_deck[0].data.number1)
        {
            player_deck.RemoveAt(0);
            ai_deck.RemoveAt(0);
            player_hand.Add(win1);
            player_hand.Add(win2);
        }
        if (player_deck[0].data.number1 < ai_deck[0].data.number1)
        {
            player_deck.RemoveAt(0);
            ai_deck.RemoveAt(0);
            ai_hand.Add(win1);
            ai_hand.Add(win2);
        }
    }



    
}
