using System;
using System.Collections.Generic;
using BackendTiki.Models;

namespace BackendTiki.Interface
{
    public interface IOTPRepository : IDisposable
    {
    
        int getOPT (string CategoryId);

    }
}
