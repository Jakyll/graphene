using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player {

	private int id;
	private string name;
	private int health;
	private List<int> hand;
	private List<int> deck;
	private List<int> graveyard;
	private List<Mana> manaPool;
	private Board board = new Board();

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

	public List<int> Hand {
		get {
			return hand;
		}
		set {
			hand = value;
		}
	}

	public List<int> Deck {
		get {
			return deck;
		}
		set {
			deck = value;
		}
	}

	public List<int> Graveyard {
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

	public Board Board {
		get {
			return board;
		}
		set {
			board = value;
		}
	}

	public void drawCard() {
		hand.Add(deck[0]);
		deck.RemoveAt(0);
	}

	public void drawCard(int count) {
		for(int i = 0; i < count; i++) {
			hand.Add(deck[0]);
			deck.RemoveAt(0);
		}
	}
}
