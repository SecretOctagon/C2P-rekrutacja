using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Rendering;

[RequireComponent(typeof(Camera))]
public class CaptureCamera : MonoBehaviour
{
    public Camera MainCam;
    Camera cCam;
    public bool captureNextFrame;
    int n = 0;

    private void Start()
    {
        if (!MainCam)
            MainCam = Camera.main;
        cCam = GetComponent<Camera>();
        cCam.enabled = false;
    }

    void OnEnable()
    {
        RenderPipelineManager.endCameraRendering += RenderPipelineManager_endCameraRendering;
    }
    void OnDisable()
    {
        RenderPipelineManager.endCameraRendering -= RenderPipelineManager_endCameraRendering;
    }
    private void RenderPipelineManager_endCameraRendering(ScriptableRenderContext context, Camera camera)
    {
        OnPostRender();
    }

    private void OnPostRender()
    {
        if (captureNextFrame)
        {
            RenderTexture renderTexture = cCam.targetTexture;

            Texture2D renderResult = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.ARGB32, false);
            Rect rect = new Rect(0, 0, renderTexture.width, renderTexture.height);
            renderResult.ReadPixels(rect, 0, 0);

            byte[] byteArray = renderResult.EncodeToPNG();
            n++;
            //string outputPath = Application.dataPath + "/Output/Screenshot" + n.ToString() + ".png";
            string outputPath = Application.dataPath + "/Output/Screenshot" + System.DateTime.Now.ToString("ddMMHHmmss") + ".png";
            File.WriteAllBytes(outputPath, byteArray);

            Debug.Log("Image saved as " + outputPath);
            cCam.enabled = false;
            captureNextFrame = false;
            MainCam.enabled = true;
        }
    }

    public void StartCapture()
    {
        MainCam.enabled = false;
        int width = Mathf.RoundToInt(cCam.sensorSize.x);
        int height = Mathf.RoundToInt(cCam.sensorSize.y);
        cCam.targetTexture = RenderTexture.GetTemporary(width, height, 16);
        cCam.enabled = true;
        captureNextFrame = true;
        Debug.Log("Capturing");
    }
}
