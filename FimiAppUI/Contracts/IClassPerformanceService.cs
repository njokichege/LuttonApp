﻿namespace FimiAppUI.Contracts
{
    public interface IClassPerformanceService
    {
        Task<IEnumerable<ClassPerformanceModel>> GetStudentResults(int studentNumber);
        Task<IEnumerable<ClassPerformanceModel>> GetStudentResultsByClass(int classId, int sessionYearId, int termId, int examTypeId);
        Task<HttpResponseMessage> UpdateStudentResults(ClassPerformanceModel classPerformanceModel);
    }
}
