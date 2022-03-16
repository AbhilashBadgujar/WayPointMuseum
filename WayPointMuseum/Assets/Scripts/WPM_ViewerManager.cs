using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class WPM_ViewerManager : WPM_Singleton<WPM_ViewerManager>
{


    [SerializeField] private bool isModelViewing = false;

    [SerializeField] private GameObject modelToView;

    [SerializeField] private int waypointSelected;

    private void Start()
    {
        RUpdate();
    }


    public void SetToViewModel(GameObject _modelToView){
        modelToView = _modelToView;
    }

    public void ChangeToWaypoint(WPM_Waypoint waypoint)
    {
        waypointSelected = waypoint.getWayPointNumebr();
        transform.DOMove(waypoint.getWorldTransfrom(), 8f, false);
        transform.DORotate(waypoint.getWorldRotation(), 8f, RotateMode.Fast);
        //rotation = new Vector2(transform.rotation.y, transform.rotation.x);
    }

    public int getWayPointSelected(){
        return waypointSelected;
    }


    public void SetIsModelViewBool(bool _val){
        isModelViewing = _val;
    }


    private async void RUpdate()
    {
        while (true)
        {
            if (Input.GetMouseButton(0))
            {
                float h = 2f * Input.GetAxis("Mouse X");
                float v = 0f * Input.GetAxis("Mouse Y");
                if (!isModelViewing)
                {
                    transform.Rotate(v, h, 0);
                }
                else
                {
                    modelToView.transform.Rotate(0,h,0);
                }
            }
            await Task.Yield();
        }
    }
}
