﻿using System.Collections;

namespace MiniOrmFramework
{
    public class DbSet<TEntity> : ICollection<TEntity>
        where TEntity : class, new()
    {
        internal ChangeTracker<TEntity> ChangeTracker { get; set; }
        internal IList<TEntity> Entities { get; set; }

        internal DbSet(IEnumerable<TEntity> entities)
        {
            this.Entities = entities.ToList();
            this.ChangeTracker = new ChangeTracker<TEntity>(entities);
        }

        public int Count => this.Entities.Count;

        public bool IsReadOnly => this.Entities.IsReadOnly;

        public void Add(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be bull!");
            }

            this.Entities.Add(item);

            this.ChangeTracker.Add(item);
        }

        public bool Remove(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "item cannot be null");
            }
        }

        public void Clear()
        {
            while (this.Entities.Any())
            {
                var entity = this.Entities.First();
                this.Remove(entity);
            }
        }

        public bool Contains(TEntity item)
        {
            return this.Entities.Contains(item);
        }

        public void CopyTo(TEntity[] array, int arrayIndex)
        {
            this.Entities.CopyTo(array, arrayIndex);
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            throw new NotImplementedException();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
