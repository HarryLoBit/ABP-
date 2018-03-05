using Abp.Application.Services;

namespace MyProject.BookService
{
    public interface IBookAppService : IApplicationService
    {
        //void Creat();
        //void Update();
        [HttpGet]
        Book GetOneItem();
    }
}
