using System.ComponentModel;
using System.Runtime.CompilerServices;
using Engine.Annotations;

namespace Engine.Models;

public class Player : INotifyPropertyChanged
{
    private string _name;
    private string _characterClass;
    private int _experiencePoints;
    private int _hitPoint;
    private int _level;
    private int _gold;

    public string Name
    {
        get { return _name; }
        set
        {
            _name = value;
            OnPropertyChanged("ExperiencePoints");
        }
    }

    public string CharacterClass
    {
        get { return _characterClass; }
        set
        {
            _characterClass = value;
            OnPropertyChanged("ExperiencePoints");
        }
    }

    public int HitPoints
    {
        get { return _hitPoint; }
        set
        {
            _hitPoint = value;
            OnPropertyChanged("ExperiencePoints");
        }
    }

    public int ExperiencePoints
    {
        get { return _experiencePoints; }
        set
        {
            _experiencePoints = value;
            OnPropertyChanged("ExperiencePoints");
        }
    }

    public int Level
    {
        get { return _level; }
        set
        {
            _level = value;
            OnPropertyChanged("ExperiencePoints");
        }
    }

    public int Gold
    {
        get { return _gold; }
        set
        {
            _gold = value;
            OnPropertyChanged("ExperiencePoints");
        }
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}