using UnityEngine;

public class MuzzleView : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    public SpriteRenderer SpriteRenderer => _spriteRenderer;
    public GameObject MuzzleObject => gameObject;
}
