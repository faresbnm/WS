using System;
using System.ComponentModel;
using System.Windows.Input;

public class ViewModel : INotifyPropertyChanged
{
    private Model _model;
    private string _inputString;
    private string _outputString;

    public event PropertyChangedEventHandler PropertyChanged;

    private ICommand _convertCommand;
    public ICommand ConvertCommand => _convertCommand ?? (_convertCommand = new RelayCommand(Convert));

    public string InputString
    {
        get => _inputString;
        set
        {
            _inputString = value;
            OnPropertyChanged(nameof(InputString));
        }
    }

    public string OutputString
    {
        get => _outputString;
        private set
        {
            _outputString = value;
            OnPropertyChanged(nameof(OutputString));
        }
    }

    public ViewModel(Model model)
    {
        _model = model;
    }

    public void Convert()
    {
        if (string.IsNullOrEmpty(InputString) || InputString.Length > 8)
        {
            OutputString = "Erreur: 1-8 caractères requis";
            return;
        }

        _model.setText(InputString);
        OutputString = _model.ConvertToUpper(_model.getText());
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}