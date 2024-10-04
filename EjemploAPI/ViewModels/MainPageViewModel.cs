using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using EjemploAPI.Models;
using EjemploAPI.Services;

namespace EjemploAPI.ViewModels;

public partial class MainPageViewModel:BaseViewModel
{
    #region Variables
    IApiServices _apiServices;
    #endregion

    #region CONSTRUCTOR
    public MainPageViewModel(IApiServices apiServices)
    {
        _apiServices=apiServices;
        InitData();
    }
    
    #endregion

    #region Propiedades
    [ObservableProperty]
    private Country countryData;

    #endregion

    #region PROCESOS
    public async void InitData()
    {
       CountryData = await _apiServices.GetCountryInfo();
       if (CountryData != null)
       {
        Foto= CountryData.Flags[1];
        Title= CountryData.Name;
       }
    }

    #endregion

    #region COMANDOS

    #endregion
}
