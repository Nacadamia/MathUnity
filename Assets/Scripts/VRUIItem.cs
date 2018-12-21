using UnityEngine;

//Benötigt ein Objekt vom Typ RectTransform, wie z.b. einen Button
[RequireComponent(typeof(RectTransform))]
public class VRUIItem : MonoBehaviour
{
    private BoxCollider boxCollider;
    private RectTransform rectTransform;

    private void OnEnable()
    {
        ValidateCollider();
    }

    private void OnValidate()
    {
        ValidateCollider();
    }

    private void ValidateCollider()
    {
        //Holt die RectTransform des gebundenen Objektes
        rectTransform = GetComponent<RectTransform>();

        //Holt den BoxCollider des Objektes
        boxCollider = GetComponent<BoxCollider>();
        if (boxCollider == null)
        {
            boxCollider = gameObject.AddComponent<BoxCollider>();
        }
        
        boxCollider.size = rectTransform.sizeDelta;
    }
}