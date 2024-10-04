using System;
namespace EjemploAPI.Models;

public class Country
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? StateCapital { get; set; }
    public float Surface { get; set; }
    public float Population { get; set; }
    public string?[] Languages { get; set; }
    public string? TimeZone { get; set; }
    public string? Currency { get; set; }
    public string? CurrencyCode { get; set; }
    public string? CurrencySymbol { get; set; }
    public string? ISOCode { get; set; }
    public string? InternetDomain { get; set; }
    public string? PhonePrefix { get; set; }
    public string? RadioPrefix { get; set; }
    public string? AircraftPrefix { get; set; }
    public string? SubRegion { get; set; }
    public string? Region { get; set; }
    public string[] Borders { get; set; }
    public string[] Flags { get; set; }

//Implementamos Cambios en el modelo de los datos para la vista
public string CurrencyVM
    {
        get
        {
            // Devuelve los valores de Borders separados por comas
            return $"{Currency} - {CurrencySymbol}";
        }
    }
public string BordersVM
    {
        get
        {
            // Devuelve los valores de Borders separados por comas
            return Borders != null && Borders.Any() ? string.Join(", ", Borders) : "No existen fronteras ";
        }
    }
public string LanguagesVM
    {
        get
        {
            // Devuelve los valores de Languages separados por comas
            return Languages != null && Languages.Any() ? string.Join(", ", Languages) : "No existen lenguajes";
        }
    }
}
