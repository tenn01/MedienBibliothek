using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedienBibliothek;

public class Picture : IMediaElement
{
    public string Name { get; set; }

    public string Id { get; set; }

    public Picture(string id, string nae)
    {
        this.Name = Name;
        this.Id = id;
    }


}
