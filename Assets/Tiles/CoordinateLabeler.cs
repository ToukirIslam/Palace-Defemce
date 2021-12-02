using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    [SerializeField] Color defaultColor = Color.white;
    [SerializeField] Color blockedColor = Color.gray;
    TextMeshPro lable;
    Waypoints waypoints;
    Vector2Int coordinates = new Vector2Int();
    private void Awake()
    {
        waypoints = GetComponentInParent<Waypoints>();
        lable = GetComponent<TextMeshPro>();
        DisplayCoordinates();
        lable.enabled = false;
    }
    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateObjectName();
        }
        ColorCoordinates();
        ToggleLabels();
    }
    void ToggleLabels()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            lable.enabled = !lable.IsActive();
        }
    }
    void ColorCoordinates()
    {
        if(waypoints.IsPlaceble)
        {
            lable.color = defaultColor;
        }else
        {
            lable.color = blockedColor;
        }
    }
    void DisplayCoordinates()
    {
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x/UnityEditor.EditorSnapSettings.move.x); 
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        lable.text = coordinates.x + "," + coordinates.y;
    }
    void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }
}
