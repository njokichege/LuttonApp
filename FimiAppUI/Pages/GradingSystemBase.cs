﻿using System.Net;

namespace FimiAppUI.Pages
{
    public class GradingSystemBase : Microsoft.AspNetCore.Components.ComponentBase
    {
        [Inject] public IGradeService GradeService { get; set; }
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }
        public GradeModelFluentValidator GradeValidator { get; set; } = new GradeModelFluentValidator();
        public IEnumerable<GradeModel> GradesList { get; set; } = new List<GradeModel>();
        public string ModelFail { get; set; }
        public string ModelSuccess { get; set; }
        public bool showSuccessAlert = false;
        public bool showFailAlert = false;
        public GradeModel NewGrade { get; set; } = new GradeModel();
        public MudForm addGradeForm;
        public MudDialog registerDialog;
        public DialogOptions dialogOptions = new() { FullWidth = true };
        public bool visible;
        protected override async Task OnInitializedAsync()
        {
            GradesList = await GradeService.GetAllGrades();
        }
        public void AddGrade()
        {
            if (NewGrade.StartGrade <= NewGrade.EndGrade)
            {
                ShowFailAlert($"Percentage from({NewGrade.StartGrade}) cannot be greater than or equal to percentage to({NewGrade.EndGrade})");
            }
            else
            {
                visible = true;
            }
        }
        public async Task DialogSubmit()
        {
            visible = false;
            var response = await GradeService.AddGrades(NewGrade);
            if(NewGrade.StartGrade >= NewGrade.EndGrade)
            {
                ShowFailAlert($"Percentage from({NewGrade.StartGrade}) cannot be greater than or equal to percentage to({NewGrade.EndGrade})");
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                ShowSuccessAlert($"Grade {NewGrade.Grade} ({NewGrade.StartGrade} - {NewGrade.EndGrade}) has been added");
            }
            else
            {
                ShowFailAlert($"Failed to add Grade {NewGrade.Grade} ({NewGrade.StartGrade} - {NewGrade.EndGrade})");
            }
            await addGradeForm.ResetAsync();
            GradesList = await GradeService.GetAllGrades();
        }
        public void Cancel() => MudDialog.Cancel();
        public void ShowSuccessAlert(string modelType)
        {
            ModelSuccess = modelType;
            showSuccessAlert = true;
        }
        public void ShowFailAlert(string modelType)
        {
            ModelFail = modelType;
            showFailAlert = true;
        }
        public void CloseMe(bool value)
        {
            if (value)
            {
                showSuccessAlert = false;
                showFailAlert = false;
            }
            else
            {
                showSuccessAlert = false;
                showFailAlert = false;
            }
        }
    }
}
