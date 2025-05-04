using System;


    public class ViewModel
    {
        private Model _model;

        public string InputString { get; set; }
        public string OutputString { get; private set; }

        public ViewModel(Model model)
        {
            _model = model;
        }

        public void Convert()
        {
            _model.setText(InputString);
            OutputString = _model.ConvertToUpper(_model.getText());
        }

    }



