using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WPM_Waypoint : MonoBehaviour
{


    [Header("Location Settings")]
    [SerializeField] private Vector3 worldTransfrom;
    [SerializeField] private Vector3 worldRotation;


    [Header("Data Settings")]
    [SerializeField] private int waypointNumber;

    private void Start() {
        GetComponent<Renderer>().material.DOColor(Color.yellow, 1f).SetLoops(-1,LoopType.Yoyo);
    }

   void OnMouseDown()
   {
       print("Waypoint" + waypointNumber);
       WPM_ViewerManager.Instance.ChangeToWaypoint(this);
   }

   public Vector3 getWorldTransfrom(){
       return worldTransfrom;
   }

    public Vector3 getWorldRotation(){
       return worldRotation;
   }

   public int getWayPointNumebr(){
       return waypointNumber;
   }
}
