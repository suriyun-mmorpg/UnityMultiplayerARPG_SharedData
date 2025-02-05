using System.Collections;
using System.Collections.Generic;

namespace NotifiableCollection
{
    public class NotifiableList<TType> : IList<TType>
    {
        public delegate void OnChangedDelegate(NotifiableListAction action, int index, TType oldItem, TType newItem);
        public delegate void OnChangedWithoutItemDelegate(NotifiableListAction action, int index);
        protected readonly List<TType> _list;

        public event OnChangedDelegate ListChanged;
        public event OnChangedWithoutItemDelegate ListChangedWithoutItem;

        public NotifiableList()
        {
            _list = new List<TType>();
        }

        public NotifiableList(int capacity)
        {
            _list = new List<TType>(capacity);
        }

        public NotifiableList(IEnumerable<TType> collection)
        {
            _list = new List<TType>(collection);
        }

        public TType this[int index]
        {
            get { return _list[index]; }
            set
            {
                TType oldItem = _list[index];
                _list[index] = value;
                InvokeNotifiableListAction(NotifiableListAction.Set, index, oldItem, value);
            }
        }

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public void Add(TType item)
        {
            int index = _list.Count;
            _list.Add(item);
            InvokeNotifiableListAction(NotifiableListAction.Add, index, default, item);
        }

        public void AddRange(IEnumerable<TType> collection)
        {
            foreach (TType item in collection)
            {
                Add(item);
            }
        }

        public void Clear()
        {
            _list.Clear();
            InvokeNotifiableListAction(NotifiableListAction.Clear, -1, default, default);
        }

        public bool Contains(TType item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(TType[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<TType> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public int IndexOf(TType item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, TType item)
        {
            _list.Insert(index, item);
            InvokeNotifiableListAction(NotifiableListAction.Insert, index, default, item);
        }

        public bool Remove(TType item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            TType oldItem = _list[index];
            if (index == 0)
            {
                _list.RemoveAt(index);
                InvokeNotifiableListAction(NotifiableListAction.RemoveFirst, index, oldItem, default);
            }
            else if (index == _list.Count - 1)
            {
                _list.RemoveAt(index);
                InvokeNotifiableListAction(NotifiableListAction.RemoveLast, index, oldItem, default);
            }
            else
            {
                _list.RemoveAt(index);
                InvokeNotifiableListAction(NotifiableListAction.RemoveAt, index, oldItem, default);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public void Dirty(int index)
        {
            InvokeNotifiableListAction(NotifiableListAction.Dirty, index, this[index], this[index]);
        }

        private void InvokeNotifiableListAction(NotifiableListAction action, int index, TType oldItem, TType newItem)
        {
            ListChanged?.Invoke(action, index, oldItem, newItem);
            ListChangedWithoutItem?.Invoke(action, index);
        }
    }
}