using UnityEngine;

public class HideSwitcher : MonoBehaviour
{
    [SerializeField] private Collider2D _playerCollider;
    [SerializeField] private GameObject _visual;

    private void OnTriggerEnter(Collider _playerCollider)
    {
        _visual.SetActive(false);
    }

    private void OnTriggerExit(Collider _playerCollider)
    {
        _visual.SetActive(true);
    }

}
