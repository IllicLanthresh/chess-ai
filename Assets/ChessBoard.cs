using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour {

	public GameObject blackTilePrefab, whiteTilePrefab;

	List<List<GameObject>> Tiles;

	// Use this for initialization
	void Start () {
		SpawnBoard();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnBoard()
	{
		int boardWidth = 8;
		int boardHeight = 8;
		bool black = true;

		for (int i = 0; i < boardWidth; i++)
		{
			for (int j = 0; j < boardHeight; j++)
			{
				GameObject GO = Instantiate(black?blackTilePrefab:whiteTilePrefab, this.transform);
				
				GO.transform.localPosition = new Vector3(i, j);

				black = !black;
			}
			black = !black;
		}

	}
}