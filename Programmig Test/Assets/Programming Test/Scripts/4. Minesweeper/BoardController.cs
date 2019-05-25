using UnityEngine;

public class BoardController : MonoBehaviour
{
    int[,] board = 
    {
        {0,0,0,0},
        {0,1,1,1},
        {0,0,1,0},
        {0,0,0,1}
    };

    private Minesweeper _minesweeper = new Minesweeper();
    
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(_minesweeper.Mines(board));
    }
}
