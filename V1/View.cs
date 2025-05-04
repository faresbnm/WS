using System;


    public class ConsoleView
    {
        private ViewModel _viewModel;

        public ConsoleView(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Run()
        {
            Console.WriteLine("This is V2 not V1");
            _viewModel.InputString = Console.ReadLine();

            if (_viewModel.InputString.Length < 1 || _viewModel.InputString.Length > 8)
            {
                Console.WriteLine("La chaîne doit contenir entre 1 et 8 caractères.");
                return;
            }

            _viewModel.Convert();
            Console.WriteLine("Résultat: " + _viewModel.OutputString);
            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
