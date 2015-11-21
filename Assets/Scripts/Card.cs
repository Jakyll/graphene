using System.Collections;
using System.Collections.Generic;

public class Card {
	
	private int id;
	private string name;
	private string description;
	private List<Mana> manaCost = new List<Mana>();
	private string type;
	private List<string> subtype = new List<string>();
	private int baseAttack;
	private int baseDefence;
	private int attack;
	private int defence;
	private int move;
	
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
	
	public string Description {
		get {
			return description;
		}
		set {
			description = value;
		}
	}
	
	public List<Mana> ManaCost {
		get {
			return manaCost;
		}
		set {
			manaCost = value;
		}
	}
	
	public string Type {
		get {
			return type;
		}
		set {
			type = value;
		}
	}
	
	public List<string> Subtype {
		get {
			return subtype;
		}
		set {
			subtype = value;
		}
	}

	public int Attack {
		get {
			return attack;
		}
		set {
			attack = value;
		}
	}
	
	public int Defence {
		get {
			return defence;
		}
		set {
			defence = value;
		}
	}

	public int BaseAttack {
		get {
			return baseAttack;
		}
		set {
			baseAttack = value;
		}
	}

	public int BaseDefence {
		get {
			return baseDefence;
		}
		set {
			baseDefence = value;
		}
	}
	
	public int Move {
		get {
			return move;
		}
		set {
			move = value;
		}
	}
}
