using Microsoft.AspNetCore.Components;

namespace YourNoteBook.Pages;

public partial class Folder : ComponentBase
{
    private bool _isNoteShowing;

    void ShowShortCut()
    {
        _isNoteShowing = false;
    }

    void ShowNotes()
    {
        _isNoteShowing = true;
    }

    protected override void OnInitialized()
    {
        InMemoryRepo.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        InMemoryRepo.OnChange -= StateHasChanged;
    }
}