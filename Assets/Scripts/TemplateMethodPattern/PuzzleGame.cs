using UnityEngine;

public class PuzzleGame : GameFlow
{
    protected override void Initialize() => Debug.Log("Puzzle setup");

    protected override void Play() => Debug.Log("Play start");
}
