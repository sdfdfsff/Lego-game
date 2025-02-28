using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PutDetail : MonoBehaviour
{
    public GameObject cubePrefab;
    public TextMeshProUGUI count;
    public void OnClick() 
    {
        ClickControl.cubeChoosen = true;
        ClickControl.cubePrefab = cubePrefab;
        ClickControl.count = count;
    }
    public void Update()
    {
        if (count.text == "0")
        {
            count.text = "";
            count.enabled = false;
            gameObject.SetActive(false);
            var activeObjects = GameObject.FindGameObjectsWithTag("Detail");
            var isNotActiveObject = true;
            foreach (var obj in activeObjects)
            {
                if (obj.activeSelf)
                {
                    isNotActiveObject = false;
                    break;
                }
            }
            
            if (isNotActiveObject)
                if (MoveToStep3.isCompleted) Debug.Log("!!!!!!!!!");
                else if (MoveToStep2.isCompleted) MoveToStep3.goToNextStep = true;
                else MoveToStep2.goToNextStep = true;
        }
    }
}
