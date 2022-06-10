using System;
using System.Collections.Generic;
using System.Text;

namespace App.Entities
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }

    public interface IEntity
    {
        object Id { get; set; }
    }
}
