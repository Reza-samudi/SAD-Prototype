public class Video {
    public int Id { get; set; } // ای دی هر ویدیو
    public string Name { get; set; }
    public string Tags { get; set; }
    public string VideoName { get; set; }
    public Status TypeOfVideo { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } // یعنی کدوم کاربر ویدیو را ایجاد کرده است
    public Manager Manager { get; set; } // یعنی کدوم مدیر ویدیو را ایجاد کرده است
    public int ManagerId { get; set; }
}
public enum Status { //اسامی مختلف در ویدیو
    Sport ,
    Art,
    Nature,
    Movie,
    Sience,
    Academic

}