using TMPro;
using UnityEngine;

public class AmmoUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ammoText;

    public void UpdateAmmo(int ammo)
    {
        ammoText.text = ammo.ToString();
    }
}
