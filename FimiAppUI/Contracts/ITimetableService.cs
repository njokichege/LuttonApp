﻿namespace FimiAppUI.Contracts
{
    public interface ITimetableService
    {
        Task<HttpResponseMessage> AddTimetableEntry(TimetableModel timetableModel);
        Task<TimetableModel> GetLastEntry();
        Task<int> GetTimetableEntryByTimeslot(int classId, int subjectCode, int timeslotId, string dayOfTheWeek);
        Task<List<TimetableModel>> GetTimetableModels();
        Task<List<TimetableModel>> GetTimetableModelsByClass(int classId);
    }
}