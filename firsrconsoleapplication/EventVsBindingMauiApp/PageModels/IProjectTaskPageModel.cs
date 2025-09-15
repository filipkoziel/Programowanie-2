using CommunityToolkit.Mvvm.Input;
using EventVsBindingMauiApp.Models;

namespace EventVsBindingMauiApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}