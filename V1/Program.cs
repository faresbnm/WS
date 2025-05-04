class Program
{
    static void Main(string[] args)
    {
        var model = new Model();
        var viewModel = new ViewModel(model);
        var view = new ConsoleView(viewModel);

        view.Run();
    }
}