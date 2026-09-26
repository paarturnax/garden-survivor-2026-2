using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{
    [SerializeField] private Image[] images;

    public void UpdateHp(int hp)
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].gameObject.SetActive(i < hp);
        }
    }
}
