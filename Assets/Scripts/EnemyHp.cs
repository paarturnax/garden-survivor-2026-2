using UnityEngine;
using UnityEngine.UI;

public class EnemyHp : MonoBehaviour
{
    [SerializeField] private Slider hpSlider;

    public void UpdateHp(int hp, int maxHp)
    {
        hpSlider.maxValue = maxHp;
        hpSlider.value = hp;
    }
}
