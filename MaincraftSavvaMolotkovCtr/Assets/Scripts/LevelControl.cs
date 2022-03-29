using UnityEngine;

public class LevelControl : MonoBehaviour
{
    [SerializeField] private GameObject _criperPlayMap;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _AnimationMap, GroundAnim, Explosion;

    public void FinichLevel()
    {
        DestroyMapAndPlayer();
        ExplosionAnimation();

    }

    private void DestroyMapAndPlayer()
    {
        Destroy(_criperPlayMap);
        Destroy(_player);

    }


    public void ExplosionAnimation()
    {
        _AnimationMap.SetActive(true);
        GroundAnim.SetActive(true);
        Invoke("ExplosionPlay", 1.9f);



    }
    private void ExplosionPlay()
    {

        Explosion.SetActive(true);

        Destroy(_AnimationMap);
    }

}
