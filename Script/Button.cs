using UnityEngine;
using UnityEngine.UI;

public class ButtonEffects : MonoBehaviour
{
    private Button button;
    private Color colorOriginal;

    public Color colorHover = Color.gray;

    void Start()
    {
        button = GetComponent<Button>();
        colorOriginal = button.image.color;
    }

    public void OnHover()
    {
        button.image.color = colorHover;
    }

    public void OnExit()
    {
        button.image.color = colorOriginal;
    }
}
