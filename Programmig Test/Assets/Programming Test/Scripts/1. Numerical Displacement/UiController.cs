using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public InputField nArray;
    public InputField kPosition;
    public Text result;
    
    private Displacement _displacement = new Displacement();

    public void Submit()
    {
        string numbers = nArray.text;
        int position = int.Parse(kPosition.text);
        
        result.text = _displacement.DisplacementPosition(numbers, position);
    }
}
