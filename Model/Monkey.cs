﻿using System.Text.Json.Serialization;

namespace Maui_Test_App.Model;

public class Monkey
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Details { get; set; }
    public string Image { get; set; }
    public int Population { get; set; }
    public double Latitide { get; set; }
    public double Longitude { get; set; }
}
