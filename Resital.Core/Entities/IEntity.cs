using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.Core.Entities
{
    public interface IEntity<T> where T : struct
    {
        T Id { get; set; }
    }
}
