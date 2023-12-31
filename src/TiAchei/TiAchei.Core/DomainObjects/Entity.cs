﻿using TiAchei.Core.Messages;

namespace TiAchei.Core.DomainObjects
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public override bool Equals(object? obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        private List<Event> _events;
        public IReadOnlyCollection<Event> Events => _events?.AsReadOnly();

        public void AddEvent(Event myEvent)
        {
            _events = _events ?? new List<Event>();
            _events.Add(myEvent);
        }

        public void RemoveEvent(Event myEvent)
        {
            _events?.Remove(myEvent);
        }

        public void ClearEvents()
        {
            _events?.Clear();
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id]={Id}]";
        }

        public static bool operator ==(Entity a, Entity b)
        {

            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }
    }
}
