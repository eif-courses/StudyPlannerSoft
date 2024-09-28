using System.Globalization;
using OfficeOpenXml;
using StudyPlannerSoft.Data;
using StudyPlannerSoft.Entities;

namespace StudyPlannerSoft.Features.Imports.Lecturers;

public class LecturerImporter
{
    private readonly MyDatabaseContext _dbContext;

    public LecturerImporter(MyDatabaseContext dbContext)
    {
        _dbContext = dbContext;
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
    }

    public IEnumerable<Lecturer> ImportFromExcel(Stream excelStream)
    {
        
        var lithuanianCulture = new CultureInfo("lt-LT");
        var lecturers = new List<Lecturer>();

        using (var package = new ExcelPackage(excelStream))
        {
            var worksheet = package.Workbook.Worksheets[1];
            var rowCount = worksheet.Dimension.Rows;

            for (int row = 7; row <= rowCount; row++)
            {
                // Log department name
                var departmentName = worksheet.Cells[row, 7].Text?.Trim();
                Console.WriteLine($"Looking for department with short name: {departmentName}");
            
                var department = _dbContext.Departments.FirstOrDefault(dep => dep.ShortName == departmentName);
                
                if (department == null)
                {
                    Console.WriteLine($"Department not found for short name: {departmentName}");
                    throw new KeyNotFoundException($"Department not found for short name: {departmentName}");
                }

                var positionName = worksheet.Cells[row, 6].Text?.Trim();
                
                Console.WriteLine($"Looking for position with name: {positionName}");

                var position = _dbContext.Positions.FirstOrDefault(pos => pos.Name == positionName);

                if (position == null)
                {
                    Console.WriteLine($"Position not found for name: {positionName}");
                    throw new KeyNotFoundException($"Position not found for name: {positionName}");
                }

                var lecturer = new Lecturer
                {
                    Id = Ulid.NewUlid(),
                    Name = worksheet.Cells[row, 4].Text,
                    Email = worksheet.Cells[row, 5].Text,
                    PositionId = position.Id,
                    DepartmentId = department.Id
                };

                lecturers.Add(lecturer);
            }
        }

        return lecturers;
    }
}
