﻿namespace FimiAppApi.Contracts
{
    public interface IClassPerformanceRepository
    {
        Task<IEnumerable<ClassPerformanceModel>> GetStudentResults(int studentNumber);
        Task<IEnumerable<ClassPerformanceModel>> GetStudentResultsByClass(int classId, int sessionYearId, int termId, int examTypeId);
        Task UpdateStudentResults(ClassPerformanceModel classPerformanceModel);
    }
}
