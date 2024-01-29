using System;

public class HexMazeFormFactory : MazeFormFactory
{
    public override MazeGridForm Get(MazeFormType formType)
    {
        switch (formType)
        {
            case MazeFormType.Rectangle:
                return new RectangleHexMazeForm();

            case MazeFormType.Ellipse:
                return new EllipseHexMazeForm();

            case MazeFormType.Triangle:
                return new TriangleHexMazeForm();

            default:
                throw new ArgumentException(nameof(formType));
        }
    }
}
