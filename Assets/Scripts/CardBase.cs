using System.Collections;
using System.Collections.Generic;

public class CardBase {

	private int id;
	private string name;
	private string description;
	private Mana neutralCost;
	private Mana colorCost;
	private string type;
	private string subtype;

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

	public Mana NeutralCost {
		get {
			return neutralCost;
		}
		set {
			neutralCost = value;
		}
	}

	public Mana ColorCost {
		get {
			return colorCost;
		}
		set {
			colorCost = value;
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

	public string Subtype {
		get {
			return subtype;
		}
		set {
			subtype = value;
		}
	}
}
