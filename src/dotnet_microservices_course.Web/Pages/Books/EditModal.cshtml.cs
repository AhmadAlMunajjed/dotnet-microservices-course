using System;
using System.Threading.Tasks;
using dotnet_microservices_course.Books;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_microservices_course.Web.Pages.Books;

public class EditModalModel : dotnet_microservices_coursePageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateUpdateBookDto Book { get; set; }

    private readonly IBookAppService _bookAppService;

    public EditModalModel(IBookAppService bookAppService)
    {
        _bookAppService = bookAppService;
    }

    public async Task OnGetAsync()
    {
        var bookDto = await _bookAppService.GetAsync(Id);
        Book = ObjectMapper.Map<BookDto, CreateUpdateBookDto>(bookDto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _bookAppService.UpdateAsync(Id, Book);
        return NoContent();
    }
}