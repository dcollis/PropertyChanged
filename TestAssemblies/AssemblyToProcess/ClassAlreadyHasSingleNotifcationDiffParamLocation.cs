using System.ComponentModel;

public class ClassAlreadyHasSingleNotifcationDiffParamLocation : INotifyPropertyChanged
{
    string property1;

    public string Property1
    {
        get { return property1; }
        set
        {
            property1 = value;
            OnPropertyChanged(7, "Property1");
        }
    }
    public string Property2 { get { return Property1; } }

    public virtual void OnPropertyChanged(int fake, string propertyName)
    {
        var handler = PropertyChanged;
        if (handler != null)
        {
            handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
}