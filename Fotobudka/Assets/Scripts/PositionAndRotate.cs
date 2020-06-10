using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionAndRotate : MonoBehaviour
{
    public Transform secondaryTransform;
    public Vector2 rotationSpeed;
    public float scrollSpeed;
    public float wheelScrollMagnitude;
    public float dragScrollMagnitude;
    public float sliderScrollMagnitude;
    public Slider zoomSlider;

    InputActions inputActions;
    Vector2 mouseDelta;

    float zoom;
    bool trackRotation = false;

    void Awake()
    {
        inputActions = new InputActions();
        inputActions.InpAct.DeltaRotation.performed += ctx => mouseDelta = ctx.ReadValue<Vector2>();
        inputActions.InpAct.Scroll.performed += ctx => SetZoomWheel(ctx.ReadValue<Vector2>());
        inputActions.InpAct.emulateScroll.performed += ctx => SetZoomDrag();
        inputActions.InpAct.Click.performed += ctx => StartRotating();
        inputActions.InpAct.UnClick.performed += ctx => StopRotating();
    }
    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }

    void Start()
    {
        RangeParameters();
        ResetTransforms();
    }
    void ResetTransforms()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;

        if (!secondaryTransform)
            secondaryTransform = transform.GetChild(0);
        secondaryTransform.position = Vector3.zero;
        secondaryTransform.rotation = Quaternion.identity;
    }
    void RangeParameters()
    {
        if (scrollSpeed < 0)
            scrollSpeed = Mathf.Abs(scrollSpeed);
    }
    
    private void Update()
    {
        UpdateZoom();
        if (trackRotation)
            UpdateRotation();
    }

    void UpdateZoom()
    {
        float difference = zoom - transform.position.z;
        difference = Mathf.Clamp(difference, -scrollSpeed, scrollSpeed);
        transform.Translate(0f, 0f, difference);
    }
    void SetZoomWheel(Vector2 delta)
    {
        zoom += delta.y * wheelScrollMagnitude;
        zoomSlider.value = zoom / sliderScrollMagnitude;
    }
    void SetZoomDrag()
    {
        zoom += (mouseDelta.x + mouseDelta.y) * dragScrollMagnitude;
        zoomSlider.value = zoom / sliderScrollMagnitude;
    }
    public void SetZoomSlider()
    {
        zoom = zoomSlider.value * sliderScrollMagnitude;
    }

    void UpdateRotation()
    {
        float upRot = mouseDelta.y * rotationSpeed.y;
        transform.Rotate(upRot, 0f, 0f);
        float sideRot = mouseDelta.x * rotationSpeed.x;
        secondaryTransform.Rotate(0f, sideRot, 0f);
    }
    void StartRotating()
    {
        Debug.Log("rotate started");
        trackRotation = true;
    }
    public void StopRotating()
    {
        Debug.Log("rotate ended");
        trackRotation = false;
    }
}
