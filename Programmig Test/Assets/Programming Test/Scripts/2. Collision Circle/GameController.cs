using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject circleOne;
    public GameObject circleTwo;
    public float radioOne;
    public float radioTwo;
    
    private CollisionCircle _collision = new CollisionCircle();
    
    // Start is called before the first frame update
    private void Start()
    {
        circleOne.transform.localScale = new Vector2(DiameterCircle(radioOne), DiameterCircle(radioOne));
        circleTwo.transform.localScale = new Vector2(DiameterCircle(radioTwo), DiameterCircle(radioTwo));
    }

    // Update is called once per frame
    private void Update()
    {
        if (_collision.IsCircleCollider(circleOne.transform.position, circleTwo.transform.position, radioOne, radioTwo))
        {
            Debug.Log("Collision Circle");
        }
    }

    private float DiameterCircle(float radio)
    {
        return radio * 2;
    }
}
