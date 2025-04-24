using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData
{
    public string playerName;
    public int level;
    public string[] inventory;
}


[Serializable]
public class CountryData
{
    public List<Country> countries;
}

[Serializable]
public class Country
{
    public Name name;
    public List<string> tld;
    public string cca2;
    public string ccn3;
    public string cca3;
    public string cioc;
    public bool independent;
    public string status;
    public bool unMember;
    public Dictionary<string, Currency> currencies;
    public Idd idd;
    public List<string> capital;
    public List<string> altSpellings;
    public string region;
    public string subregion;
    public Dictionary<string, string> languages;
    public Dictionary<string, Translation> translations;
    public List<float> latlng;
    public bool landlocked;
    public List<string> borders;
    public float area;
    public Dictionary<string, Demonyms> demonyms;
    public string flag;
    public Maps maps;
    public int population;
    public Dictionary<string, float> gini;
    public string fifa;
    public Car car;
    public List<string> timezones;
    public List<string> continents;
    public Flags flags;
    public CoatOfArms coatOfArms;
    public string startOfWeek;
    public CapitalInfo capitalInfo;
    public PostalCode postalCode;
}

[Serializable]
public class Name
{
    public string common;
    public string official;
    public Dictionary<string, NativeName> nativeName;
}

[Serializable]
public class NativeName
{
    public string official;
    public string common;
}

[Serializable]
public class Currency
{
    public string name;
    public string symbol;
}

[Serializable]
public class Idd
{
    public string root;
    public List<string> suffixes;
}

[Serializable]
public class Translation
{
    public string official;
    public string common;
}

[Serializable]
public class Demonyms
{
    public string f;
    public string m;
}

[Serializable]
public class Maps
{
    public string googleMaps;
    public string openStreetMaps;
}

[Serializable]
public class Car
{
    public List<string> signs;
    public string side;
}

[Serializable]
public class Flags
{
    public string png;
    public string svg;
    public string alt;
}

[Serializable]
public class CoatOfArms
{
    public string png;
    public string svg;
}

[Serializable]
public class CapitalInfo
{
    public List<float> latlng;
}

[Serializable]
public class PostalCode
{
    public string format;
    public string regex;
}