namespace StudyPlannerSoft.Entities;
public enum SemesterType
{
    Autumn = 1,
    Spring = 2
}
public class PlannedGroup
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty; // Jeigu yra per kableli reiskia yra srautas
    public Semester Semester { get; set; } // semestras 
    public int Vf { get; set; } = 0;
    public int Vnf { get; set; } = 0;
    public int OtherType { get; set; } = 0;
    public int CurrentYear { get; set; } = 0;
    public SemesterType SemesterType { get; set; } = SemesterType.Autumn;
}