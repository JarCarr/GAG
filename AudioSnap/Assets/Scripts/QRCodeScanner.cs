using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZXing;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class QRCodeScanner : MonoBehaviour
{
    [SerializeField]
    private RawImage _rawImageBackground;

    [SerializeField]
    private AspectRatioFitter _aspectRatioFitter;

    [SerializeField]
    private TextMeshProUGUI _textOut;

    [SerializeField]
    private RectTransform _scanZone;

    private bool _isCamAvaliable;
    private WebCamTexture _cameraTexture;

    private bool[] codes = new bool[200];

    [SerializeField]
    private AudioSource audiojingle;

    // Start is called before the first frame update
    void Start()
    {
        SetUpCamera();
        //audiojingle = Resources.Load<AudioClip>("Audio/jingle.mp3");
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCameraRender();
    }

    private void SetUpCamera()
    {
        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length == 0)
        {
            _isCamAvaliable = false;
            return;
        }
        for (int i = 0; i < devices.Length; i++)
        {
            if (devices[i].isFrontFacing == false)
            {
                _cameraTexture = new WebCamTexture(devices[i].name, (int)_scanZone.rect.width, (int)_scanZone.rect.height);
            }
        }

        _cameraTexture.Play();
        _rawImageBackground.texture = _cameraTexture;
        _isCamAvaliable = true;
    }

    private void Scan()
    {
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode(_cameraTexture.GetPixels32(), _cameraTexture.width, _cameraTexture.height);
            if (result != null)
            {
                int rnum;

                if(int.TryParse(result.Text, out rnum))
                {
                    if(rnum > 0 && rnum <= 200)
                    {
                        string codes = PlayerPrefs.GetString("values");
                        if (codes[rnum-1] == '0')
                        {
                            char[] values = codes.ToCharArray();
                            values[rnum - 1] = '1';
                            string newValues = new string(values);
                            PlayerPrefs.SetString("values", newValues);
                            audiojingle.Play();
                        }
                    }
                }
            }
        }
        catch
        {

        }
    }

    public void OnClickScan()
    {
        Scan();
    }

    private void UpdateCameraRender()
    {
        if (_isCamAvaliable == false)
        {
            return;
        }
        float ratio = (float)_cameraTexture.width / (float)_cameraTexture.height;
        _aspectRatioFitter.aspectRatio = ratio;

        int orientation = -_cameraTexture.videoRotationAngle;
        _rawImageBackground.rectTransform.localEulerAngles = new Vector3(0, 0, orientation);
    }
}