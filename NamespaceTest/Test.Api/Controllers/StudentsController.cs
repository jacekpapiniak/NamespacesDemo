namespace Test.Api.Controllers
{
    using Test.Api.Controllers.Unicorns;
    using myUnicorn = Test.Api.Controllers.Unicorns.UnicornController;
    public class StudentsController
    {
        public string Call()
        {
            var apiRequester = new ApiRequester();
            var unicorn = new UnicornController();

            return $"A* student {unicorn.Call()}";
        }
    }  
    
    namespace Test.Api.Controllers.Unicorns
    {
        public class UnicornController
        {
            public string Call() => "on the unicorn";
        }  

    }
}