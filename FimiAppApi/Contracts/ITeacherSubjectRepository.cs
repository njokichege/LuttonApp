﻿namespace FimiAppApi.Contracts
{
    public interface ITeacherSubjectRepository
    {
        Task<int> AddTeacherSubjectWithoutTeacherId(int subjectCode);
        Task<int> CreateTeacherSubject(int teacherId, int subjectCode);
        Task<IEnumerable<TeacherSubjectModel>> GetSubjectsMultipleMapping();
        Task<IEnumerable<TeacherSubjectModel>> GetSubjectsMultipleMappingBySubject(int subjectCode);
        Task<IEnumerable<TeacherSubjectModel>> GetSubjectsMultipleMappingByTeacher(int teacherId);
        Task<TeacherSubjectModel> GetTeacherSubject(int teacherId, int subjectCode);
    }
}
