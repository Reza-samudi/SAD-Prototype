using System;
using System.Collections.Generic;
    public class Manager
    {
        public int Id { get; set; }
        
        
        public string Name { get ; set ; }
        public string gender { get ; set ; }
        public double Mobile { get ; set; }
        public string Email { get; set; }
        public DateTime? UploadTime { get; set; } // optional
        public string RoleName { get; set; }  
        public StatusTypes StatusRole { get; set; } // برای نقش های مختلف هر مدیر
        public string Address { get; set; }
        public ICollection<Video> Videos { get; set; }
        public ICollection<Register> Registers { get; set; }
        
    }
    public enum StatusTypes {

        SiteAdmin, // مدیر سایت
        HumanResourcesManager, // مدیر منابع انسانی
        GraphicDesignerManager // مدریت گرافیک

    } 
