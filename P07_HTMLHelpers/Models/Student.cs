namespace P07_HTMLHelpers.Models
{
    public enum Gender
    {
        Seçiniz,
        Male,
        Female,
        Male2,
        Female2
    }


    public class Student
    {
        public int StudentId { get; set; }
        public string IlkAd { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        public bool IsActive { get; set; }
        public Gender StuGender { get; set; }

    }
}
