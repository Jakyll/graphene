using UnityEngine;
using System.Collections;

public class Tile {

	private int id;
	private Card card;

	public int Id {
		get {
			return id;
		}
		set {
			id = value;
		}
	}

	public Card Card {
		get {
			return card;
		}
		set {
			card = value;
		}
	}
}
