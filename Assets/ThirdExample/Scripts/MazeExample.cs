using System;
using UnityEngine;

public class MazeExample : MonoBehaviour
{
    [SerializeField] private CellType _cellType;
    [SerializeField] private MazeFormType _formType;
    [SerializeField, Range(4, 100)] private int _numberOfCells;

    [SerializeField] private Maze _maze;

    [ContextMenu("Build")]
    public void BuildMaze()
    {
        MazeFormFactory formFactory; 

        switch (_cellType)
        {
            case CellType.Square:
                formFactory = new SquareMazeFormFactory();
                break;

            case CellType.Hex:
                formFactory = new HexMazeFormFactory();
                break;

            default:
                throw new ArgumentException(nameof(_formType));
        }

        _maze.Build(formFactory.Get(_formType), _numberOfCells);
    }
}
