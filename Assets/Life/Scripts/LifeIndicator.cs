using UnityEngine;

// Controls life indicator elements

public class LifeIndicator : MonoBehaviour
{
    [SerializeField] private GameObject onImage;
    [SerializeField] private GameObject offImage;

    public void SwitchOn()
    {
        onImage.SetActive(true);
        offImage.SetActive(false);
    }

    public void SwitchOff()
    {
        onImage.SetActive(false);
        offImage.SetActive(true);
    }
}
