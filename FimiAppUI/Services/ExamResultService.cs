﻿namespace FimiAppUI.Services
{
    public class ExamResultService : IExamResultService
    {
        private readonly HttpClient _httpClient;

        public ExamResultService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<ExamResultModel>> GetYearlySchoolResults(int sessionYearId)
        {
            return await _httpClient.GetFromJsonAsync<ExamResultModel[]>($"api/examresult/{sessionYearId}");
        }
    }
}