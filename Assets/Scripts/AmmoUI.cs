using UnityEngine;

public class AmmoUI : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI ammoText;
    public void UpdateAmmo(int ammo)
    {
        ammoText.text = ammo.ToString();
    }
}
