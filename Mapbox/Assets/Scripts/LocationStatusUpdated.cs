using Mapbox.Unity.Location;
using Mapbox.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationStatusUpdated : MonoBehaviour
{

    [SerializeField]
    Text _statusText;

    public GameObject blockerImage;

    private AbstractLocationProvider _locationProvider = null;
    void Start()
    {
        if (null == _locationProvider)
        {
            _locationProvider = LocationProviderFactory.Instance.DefaultLocationProvider as AbstractLocationProvider;
        }
    }


    void Update()
    {
        Location currLoc = _locationProvider.CurrentLocation;

        if (currLoc.IsLocationServiceInitializing)
        {
            _statusText.text = "location services are initializing";
        }
        else
        {
            if (!currLoc.IsLocationServiceEnabled)
            {
                _statusText.text = "location services not enabled";
            }
            else
            {
                if (currLoc.LatitudeLongitude.Equals(Vector2d.zero))
                {
                    _statusText.text = "Waiting for location ....";
                }
                else
                {
                    _statusText.text = "";
                    blockerImage.SetActive(false);
                }
            }
        }

    }
}