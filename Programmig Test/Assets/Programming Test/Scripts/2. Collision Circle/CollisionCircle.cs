using UnityEngine;

public class CollisionCircle
{
    public bool IsCircleCollider(Vector2 circleOne, Vector2 circleTwo, float radioOne, float radioTwo)
    {
        return radioOne + radioTwo > Distance(circleOne, circleTwo);
    }

    private static float Distance(Vector2 circleOne, Vector2 circleTwo)
    {
        return Mathf.Abs(Mathf.Pow((circleTwo.x - circleOne.x), 2) + Mathf.Pow((circleTwo.y - circleOne.y), 2));
    }
}
