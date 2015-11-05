using System.Collections;

public class CardUnit : CardBase {
	private int attack;
	private int defence;
	private int move;

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

	public int Move {
		get {
			return move;
		}
		set {
			move = value;
		}
	}
}
