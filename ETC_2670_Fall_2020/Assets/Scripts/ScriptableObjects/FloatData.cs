
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;
    public UnityEvent LessThanZeroEvent;

    public void SetValue(float number)
    {
        value = number;
    }

    public void UpdateValue(float number)
    {
        value += number;
    }

    public void SetImageFillAmount(Image img)
    {
        if (value >= 0 || value <= 1)
        {
            img.fillAmount = value;
        }

        if (value < 0)
        {
            LessThanZeroEvent.Invoke();
        }

        if (value >= 1)
        {
            value = 1;
        }
    }
}
