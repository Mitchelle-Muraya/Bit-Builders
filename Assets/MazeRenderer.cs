using UnityEngine;

public class MazeRenderer : MonoBehaviour
{
    [SerializeField] MazeGenerator mazeGenerator;
    [SerializeField] GameObject mazeCellPrefab;

    public float CellSize = 1f;

    private void Start()
    {
        MazeCell[,] maze = mazeGenerator.GetMaze();

        for (int x = 0; x < mazeGenerator.mazeWidth; x++)
        {
            for (int y = 0; y < mazeGenerator.mazeHeight; y++)
            {
                // Fix: missing variable name before * CellSize
                GameObject newCell = Instantiate(
                    mazeCellPrefab,
                    new Vector3((float)x * CellSize, 0f, (float)y * CellSize),
                    Quaternion.identity,
                    transform
                );

                MazeCellObject mazeCell = newCell.GetComponent<MazeCellObject>();

                bool top = maze[x, y].topWall;
                bool left = maze[x, y].leftWall;
                bool right = false;
                bool bottom = false;

                // Fix: bottom was misspelled as botton
                if (x == mazeGenerator.mazeWidth - 1) right = true;
                if (y == 0) bottom = true;

                // Fix: use dot instead of comma
                mazeCell.Init(top, bottom, right, left);
            }
        }
    }
}
