using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player {

	private int id;
	private string name;
	private int health;
	private List<Card> hand;
	private List<Card> deck;
	private List<Card> graveyard;
	private List<Mana> manaPool;

	public int Id {
		get {
			return id;
		}
		set {
			id = value;
		}
	}

	public string Name {
		get {
			return name;
		}
		set {
			name = value;
		}
	}

	public int Health {
		get {
			return health;
		}
		set {
			health = value;
		}
	}

	public List<Card> Hand {
		get {
			return hand;
		}
		set {
			hand = value;
		}
	}

	public List<Card> Deck {
		get {
			return deck;
		}
		set {
			deck = value;
		}
	}

	public List<Card> Graveyard {
		get {
			return graveyard;
		}
		set {
			graveyard = value;
		}
	}

	public List<Mana> ManaPool {
		get {
			return manaPool;
		}
		set {
			manaPool = value;
		}
	}

	public void drawCard() {
		hand.Add(deck[0]);
		deck.RemoveAt(0);
	}

	public void drawCard(int count) {
		for(int i = 0; i < count; i++) {
			hand.Add(deck [0]);
			deck.RemoveAt(0);
		}
	}
}
