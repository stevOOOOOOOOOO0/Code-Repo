using System;
using System.Collections.Generic;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class ImageDisplay : MonoBehaviour
{
    public Image BaseImage;
    public List<Image> UIImages;
    public FloatData Value;
    public float length;
    public Canvas canvas;

    public void Start()
    {
        UIImages.Add(BaseImage);

        for (int i = 1; i < Value.Value; i++)
        {
            UIImages.Add(Instantiate(BaseImage));
            UIImages[UIImages.Count - 1].gameObject.transform.SetParent(canvas.transform, true);
            UIImages[UIImages.Count - 1].gameObject.SetActive(true);
            UIImages[UIImages.Count - 1].rectTransform.anchoredPosition = BaseImage.rectTransform.anchoredPosition + new Vector2(length * i, 0);
        }
    }

    public void UpdateImages()
    {
        while (UIImages.Count > Value.Value)
        {
            Destroy(UIImages[UIImages.Count - 1]);
            UIImages.RemoveAt(UIImages.Count - 1);
        }
    }
}
