using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedienBibliothek;

public class Song : IMediaElement
{
    private string _name = string.Empty;

    public string Name => _name;

    private string _id = string.Empty;

    public string Id => _id;

    public Song(string id, string name)
    {
        this._name = name;
        this._id = id;
    }

    public int Seconds { get; set; } = 0;

    public double Minutes
    {
        get
        {
            return Math.Round(Seconds / 60.0, 2);
            
        }
        
    }

}
