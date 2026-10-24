using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] private Slider hpSlider;

    public void UpdateHP(int hp, int maxHp)
    {
        hpSlider.maxValue = maxHp;
        hpSlider.value = hp;
    }
}
