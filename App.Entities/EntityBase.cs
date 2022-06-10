using System;
using System.Collections.Generic;
using System.Text;
using static App.Entities.IEntity;

namespace App.Entities
{
    public class EntityBase : IEntity
    {
        object IEntity.Id { get; set; }
    }

    public abstract class EntityBase<TKey> : EntityBase, IEntity<TKey>
    {
        public TKey Id
        {
            get
            {
                return (TKey)(((IEntity)this).Id ?? default(TKey));
            }
            set
            {
                (this as IEntity).Id = value;
            }
        }
    }
}
