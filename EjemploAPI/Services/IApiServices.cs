using System;
using EjemploAPI.Models;

namespace EjemploAPI.Services;

public interface IApiServices
{
    Task<Country> GetCountryInfo();

}
