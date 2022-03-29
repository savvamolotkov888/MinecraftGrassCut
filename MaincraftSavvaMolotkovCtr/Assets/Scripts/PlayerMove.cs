using UnityEngine;
using DG.Tweening;

public class PlayerMove : MonoBehaviour
{

    private float _playerRadius = 5f;
    private float _animationTime = 0.2f;
    [SerializeField] private Transform _targetPosition;

    private void Awake()
    {
        _targetPosition.position = transform.position;

    }
    public void SwipeRight()
    {//puts Transform Dot
        Ray ray = new Ray(transform.position, transform.right);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            _targetPosition.position = new Vector3(hit.point.x - _playerRadius, hit.point.y, 0);
            Move(_targetPosition.position);
        }
    }



    public void SwipeLeft()//puts Transform Dot
    {
        Ray ray = new Ray(transform.position, -transform.right);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            _targetPosition.position = new Vector3(hit.point.x + _playerRadius, hit.point.y, 0);
            Move(_targetPosition.position);
        }
    }




    public void SwipeUp()//puts Transform Dot
    {
        Ray ray = new Ray(transform.position, transform.up);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            _targetPosition.position = new Vector3(hit.point.x, hit.point.y - _playerRadius, 0);
            Move(_targetPosition.position);
        }
    }


    public void SwipeDown()//puts Transform Dot
    {
        Ray ray = new Ray(transform.position, -transform.up);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            _targetPosition.position = new Vector3(hit.point.x, hit.point.y + _playerRadius, 0);
            Move(_targetPosition.position);
        }
    }
    private void Move(Vector3 targetPosition)
    {
        transform.DOMove(targetPosition, _animationTime).SetEase(Ease.Flash);
    }


}
