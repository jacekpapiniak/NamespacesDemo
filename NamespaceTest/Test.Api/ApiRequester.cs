namespace Test.Api;

public class ApiRequester
{
    private string _someSupeRsH;

    public ApiRequester(string someSupeRsH)
    {
        _someSupeRsH = someSupeRsH;
    }

    public string GetResponse() => "Hello fom ApiRequester";
}