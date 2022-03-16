using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using DG.Tweening;

public class WPM_Model : MonoBehaviour
{

    [SerializeField] private GameObject modelToSelect;
    [SerializeField] private int modelNumber;

    [SerializeField] private String modelText;

    [SerializeField] private String moreText;

    [SerializeField] private Sprite[] images;
    // Start is called before the first frame update

    private void Start() {
        GetComponent<Renderer>().material.DOColor(Color.black, 1f).SetLoops(-1,LoopType.Yoyo);

    }

    private void OnMouseDown()
    {

        if ((WPM_ViewerManager.Instance.getWayPointSelected()-1) == modelNumber)
        {

            WPM_ViewerManager.Instance.SetIsModelViewBool(true);
            WPM_ViewerManager.Instance.SetToViewModel(modelToSelect);
            WPM_UIManager.Instance.OpenModelPannel(modelNumber, modelText, moreText, images);
        }
    }
}
