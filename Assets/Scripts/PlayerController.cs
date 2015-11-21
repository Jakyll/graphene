using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	ArrayList deck = new ArrayList();
	// Use this for initialization
	void Start () 
	{
		Player player = new Player();
		player.Id = 1;
		player.Name = "Jack";
		player.Health = 20;
		//Deck deck = new Deck("Assets/Resources/XML/deck.xml");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void InitialiseDeck()
	{
		
	}
}
