namespace MyProject.BookService
{
    public class BookAppService : MyProjectAppServiceBase, IBookAppService
    {
        private readonly IBookRepository _bookRepository;

        public BookAppService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book GetOneItem()
        {
            return new Book() { Name="123",Price=12, MyProperty =new int[] { 1,3} };
        }

        //public void Creat()
        //{
        //    var data = new Book()
        //    {
        //        //_id = 1,
        //        Name = "一本新书",
        //        Price = 99.99,
        //        MyProperty =new int[] { 1,2,3}
        //    };
        //    _bookRepository.Insert(data);
        //}

        //public void Update()
        //{
        //    var data = new Book()
        //    {
        //        //_id = 1,
        //        Name = "二本",
        //        Price = 23,
        //        MyProperty = new int[] { 1,1,11,11}
        //    };
        //    _bookRepository.Update(data);
        //}
    }
}
