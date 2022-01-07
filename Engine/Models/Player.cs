using System.ComponentModel;
using System.Runtime.CompilerServices;

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
            OnPropertyChanged("Name");
        }
    }

    public string CharacterClass
    {
        get { return _characterClass; }
        set
        {
            _characterClass = value;
            OnPropertyChanged("CharacterClass");
        }
    }

    public int HitPoints
    {
        get { return _hitPoint; }
        set
        {
            _hitPoint = value;
            OnPropertyChanged("HitPoints");
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
            OnPropertyChanged("Level");
        }
    }

    public int Gold
    {
        get { return _gold; }
        set
        {
            _gold = value;
            OnPropertyChanged("Gold");
        }
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
    
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}