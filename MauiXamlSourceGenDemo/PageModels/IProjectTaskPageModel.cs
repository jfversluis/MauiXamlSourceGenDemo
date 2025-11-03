using CommunityToolkit.Mvvm.Input;
using MauiXamlSourceGenDemo.Models;

namespace MauiXamlSourceGenDemo.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}