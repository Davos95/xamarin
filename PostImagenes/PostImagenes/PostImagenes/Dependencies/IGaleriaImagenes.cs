using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PostImagenes.Dependencies
{
    public interface IGaleriaImagenes
    {
        Task<Stream> GetFotoAsync();
    }
}
