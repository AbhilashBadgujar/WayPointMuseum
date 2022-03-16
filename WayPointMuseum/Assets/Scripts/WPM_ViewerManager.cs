using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class WPM_ViewerManager : WPM_Singleton<WPM_ViewerManager>
{


    private void Start()
    {
        //RUpdate();
    }

    public void ChangeToWaypoint(WPM_Waypoint waypoint)
    {

        transform.DOMove(waypoint.getWorldTransfrom(), 8f, false);
        transform.DORotate(waypoint.getWorldRotation(), 8f, RotateMode.Fast);
        //rotation = new Vector2(transform.rotation.y, transform.rotation.x);
    }


    [SerializeField] Vector2 rotation;// = new Vector2(transform.rotation.y,transform.rotation.x);
    public float speed = 3; //the sensibility

    private  void Update()
    {
        //while(true){
        if (Input.GetMouseButton(0))
        {
             float h = 2f * Input.GetAxis("Mouse X");
             float v = 0f * Input.GetAxis("Mouse Y");
             transform.Rotate(v, h, 0);
        }
        //await Task.Yield();
        //}
    }
}
