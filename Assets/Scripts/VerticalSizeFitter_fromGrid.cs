using UnityEngine;
using UnityEngine.UI;


public class VerticalSizeFitter_fromGrid : MonoBehaviour
{
    
    public GridLayoutGroup gridLayoutGroup;

    RectTransform rect_transform;

    void Awake()
    {
        if(gridLayoutGroup == null)
            gridLayoutGroup = GetComponent<GridLayoutGroup>();
    }

    public void Resize(int count)
    {
        float height = gridLayoutGroup.cellSize.y;
        float spacing = gridLayoutGroup.spacing.y;

        Vector2 size = GetComponent<RectTransform>().sizeDelta;
        size.y = (height + spacing) * (count + 1);

        GetComponent<RectTransform>().sizeDelta = size;

        // Debug.Log("Resized !!!");
    }
}
