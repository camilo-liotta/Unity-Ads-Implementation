using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{

    public static AdsManager instance;

    string gameID = "5591990";

    string intestitialAdId = "Interstitial_Android";

    string bannerAdId = "Banner_Android";

    private void Awake()
    {
        
        instance = this;

        InitializeAds();

    }

    void InitializeAds()
    {
        Advertisement.Initialize(gameID, false, this);
    }

    public void ShowAds()
    {

        Advertisement.Load(intestitialAdId, this);

        Advertisement.Show(intestitialAdId, this);

    }

    /*
        Para mostrar ads desde una funcion de cualquier otro script se llama a la funcion ShowAds de la siguiente manera:

        AdsManager.instance.ShowAds();

        Lo mismo para la funcon ShowBannerAds.
     
     */

    public void ShowBannerAd ()
    {

        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);

        Advertisement.Banner.Load(bannerAdId);

        Advertisement.Banner.Show(bannerAdId);

    }



    public void OnInitializationComplete()
    {
        Debug.Log("Initialized");
        //throw new System.NotImplementedException();
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("Adds Loaded");
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("Ads Clicked");
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log("Ads Completed");
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log("Ads Failed");
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("Ads Start");
        //throw new System.NotImplementedException();
    }

}
