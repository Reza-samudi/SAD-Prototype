using System;
using System.Collections.Generic;
public class User {
    
    public int Id { get; set; }
    public double Mobile { get; set; } 
    public string Name { get; set; }
    public string gender { get ; set ; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string gender1 { get ; set ; }
    public DateTime? UploadTime { get; set; } // optional
    public string Address { get; set; }
    public StatusType StatusRole { get; set; }
    public ICollection<Video> Videos { get; set; } 
    public ICollection<Register> Registers { get; set; }
    
}

public enum StatusType{
    
    HumanResources, // افرادی که در منابع انسانی کار میکنند
    GraphicDesigner // گرافیست کارها

}