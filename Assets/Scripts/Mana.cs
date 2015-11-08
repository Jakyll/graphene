﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana {

	private string type;
	private int cost;
	private Color color= new Color();
	private Dictionary<string, Color> colorList = new Dictionary<string, Color>();

	public Mana(string type, int cost) {
		colorList.Add("white", new Color (1f, 1f, 1f, 1f));
		colorList.Add("green", new Color (0.2f, 0.8f, 0.2f, 1f));
		colorList.Add("red", new Color (0.85f, 0f, 0.1f, 1f));
		colorList.Add("black", new Color (0.8f, 0.8f, 0.8f, 1f));
		colorList.Add("purple", new Color (0.5f, 0f, 0.5f, 1f));
		colorList.Add("cyan", new Color (0f, 0f, 1f, 1f));
		colorList.Add("neutral", new Color (0.3f, 0.3f, 0.3f, 1f));

		this.type = type;
		this.cost = cost;
		this.color = (Color)this.colorList[type];
	}

	public string Type {
		get {
			return type;
		}
		set {
			type = value;
		}
	}

	public int Cost {
		get {
			return cost;
		}
		set {
			cost = value;
		}
	}

	public Color Color {
		get {
			return color;
		}
		set {
			color = value;
		}
	}
}
