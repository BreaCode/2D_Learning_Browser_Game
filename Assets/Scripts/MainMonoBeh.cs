using UnityEngine;

public class MainMonoBeh : MonoBehaviour
{
    //
    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private SpriteRenderer _background;
    //

    [SerializeField]
    private CharacterView _characterView;

    [SerializeField]
    private SpriteAnimationConfig _spriteAnimationConfig;

    [SerializeField]
    private MuzzleView _muzzleView;

    private SpriteAnimator _spriteAnimator;
    private MainHeroWalker _mainHeroWalker;
    private MuzzleAiming _muzzleAiming;


    private void Start()
    {
        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        _mainHeroWalker = new MainHeroWalker(_characterView, _spriteAnimator);
        _muzzleAiming = new MuzzleAiming(_muzzleView.MuzzleObject.transform, _characterView.gameObject.transform);
    }

    private void Update()
    {
        _spriteAnimator.Update();
        _mainHeroWalker.Update();
        _muzzleAiming.Update();
    }

    private void FixedUpdate()
    {

    }

    private void OnDestroy()
    {

    }
}
