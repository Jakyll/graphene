using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Player player = new Player();

		player.Id = 1;
		player.Name = "Jack";
		player.Health = 20;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
