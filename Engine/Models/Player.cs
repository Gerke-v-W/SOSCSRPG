using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Engine.Models;

public class Player : BaseNotificationClass
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
            OnPropertyChanged(nameof(Name));
        }
    }

    public string CharacterClass
    {
        get { return _characterClass; }
        set
        {
            _characterClass = value;
            OnPropertyChanged(nameof(CharacterClass));
        }
    }

    public int HitPoints
    {
        get { return _hitPoint; }
        set
        {
            _hitPoint = value;
            OnPropertyChanged(nameof(HitPoints));
        }
    }

    public int ExperiencePoints
    {
        get { return _experiencePoints; }
        set
        {
            _experiencePoints = value;
            OnPropertyChanged(nameof(ExperiencePoints));
        }
    }

    public int Level
    {
        get { return _level; }
        set
        {
            _level = value;
            OnPropertyChanged(nameof(Level));
        }
    }

    public int Gold
    {
        get { return _gold; }
        set
        {
            _gold = value;
            OnPropertyChanged(nameof(Gold));
        }
    }
}