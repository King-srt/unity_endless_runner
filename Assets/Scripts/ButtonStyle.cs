using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 originalScale;
    private Image buttonImage;
    private Color originalColor;
    private Color hoverColor = new Color(0.3f, 0.7f, 1f); // Biru terang

    void Start()
    {
        originalScale = transform.localScale;

        // Ambil komponen Image dari Button
        buttonImage = GetComponent<Image>();
        if (buttonImage != null)
        {
            originalColor = buttonImage.color;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = originalScale * 1.1f;

        if (buttonImage != null)
        {
            buttonImage.color = hoverColor;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = originalScale;

        if (buttonImage != null)
        {
            buttonImage.color = originalColor;
        }
    }
}
