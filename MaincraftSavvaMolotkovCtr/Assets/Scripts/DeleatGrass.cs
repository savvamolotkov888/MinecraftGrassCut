using UnityEngine;

public class DeleatGrass : MonoBehaviour
{
     private int _score;
    [SerializeField] private int _grassBlocksCount = 68;
    [SerializeField] private LevelControl _levelControl;
    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            if (_score <= _grassBlocksCount)
            {
                _score = value;
            }
            else if (_score > _grassBlocksCount)
            {
                Debug.Log("Win");
                _levelControl.FinichLevel();
               
            }

        }

    }


    private void Awake()
    {
        LevelControl _levelControl = GetComponent<LevelControl>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Grass")
        {
            Destroy(other.gameObject);
            Score++;
        }
    }
}