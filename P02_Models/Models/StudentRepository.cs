namespace P02_Models.Models
{
    public class StudentRepository : IStudentRepository
    {
        // DB tarafında olmayan, "InMemory" türünde bazı kayıtlar oluşturulacak. Ve bunları bir liste yapısı halinde tutacağım
        public Student Get(int StudentID)
        {
            // tek bir student getirecek

            // Eğer ilgili kayıdı listemde bulursa bulduğu kayıdı JSON formatında getircek yoksa boş kayıt getirecek

            return GetAll().FirstOrDefault(e => e.StudentId == StudentID) ?? new Student();
        }

        public List<Student> GetAll()
        {
            // tüm listeyi getirecek

            return new List<Student>()
            {
                new Student() { StudentId=1, Name="Ümit Karaçivi", Email="umit.karacivi@gmail.com", Phone="0123456789", Gender="E"},
                new Student() { StudentId=2, Name="Ahmet Mehmet", Email="ahmet.mehmet@gmail.com", Phone="0123456789", Gender="E"},
                new Student() { StudentId=3, Name="Ceylan Meylan", Email="ceylan.meylan@gmail.com", Phone="0123456789", Gender="K"},
                new Student() { StudentId=4, Name="Abuk Subuk", Email="abuk.subuk@gmail.com", Phone="0123456789", Gender="E"},
                new Student() { StudentId=5, Name="Ondan Bundan", Email="ondan.bundan@gmail.com", Phone="0123456789", Gender="K"}
            };
        }
    }
}
