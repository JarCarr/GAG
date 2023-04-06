using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZXing;
using TMPro;
using UnityEngine.UI;

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

<<<<<<< Updated upstream
=======
    private bool[] codes = new bool[200];

    [SerializeField]
    private AudioSource audiojingle;

>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        SetUpCamera();
<<<<<<< Updated upstream
=======
        //audiojingle = Resources.Load<AudioClip>("Audio/jingle.mp3");
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
                _textOut.text = result.Text;
=======
                int rnum;

                if(int.TryParse(result.Text, out rnum))
                {
                    if(rnum > 0 && rnum <= 200)
                    {
                        _textOut.text = "1";
                        string codes = PlayerPrefs.GetString("values");
                        _textOut.text = codes;
                        if (codes[rnum-1] == '0')
                        {
                            char[] values = codes.ToCharArray();

                            _textOut.text = "3";
                            values[rnum - 1] = '1';
                            _textOut.text = "4";
                            string newValues = new string(values);
                            _textOut.text = "5";
                            PlayerPrefs.SetString("values", newValues);
                            _textOut.text = "6";
                            _textOut.text = "You found one!";
                            audiojingle.Play();
                        }
                        //_textOut.text = "7";
                    }
                    else
                    {
                       // _textOut.text = "Not valid QR code";
                    }
                }
                else
                {
                    //_textOut.text = "Not valid QR code";
                }
>>>>>>> Stashed changes
            }
            else
            {
                //_textOut.text = "Failed to read QR code";
            }
        }
        catch
        {
           // _textOut.text = "Failed to Scan";
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