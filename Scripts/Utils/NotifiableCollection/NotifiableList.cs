using System.Collections;
using System.Collections.Generic;

namespace NotifiableCollection
{
    public class NotifiableList<TType> : IList<TType>
    {
        public delegate void OnChangedDelegate(NotifiableListAction action, int index, TType oldItem, TType newItem);
        public delegate void OnChangedWithoutItemDelegate(NotifiableListAction action, int index);
        protected readonly List<TType> _list;
        private readonly object _lockObject = new object();

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
            get
            {
                lock (_lockObject)
                {
                    return _list[index];
                }
            }
            set
            {
                lock (_lockObject)
                {
                    TType oldItem = _list[index];
                    _list[index] = value;
                    InvokeNotifiableListAction(NotifiableListAction.Set, index, oldItem, value);
                }
            }
        }

        public int Count
        {
            get
            {
                lock (_lockObject)
                {
                    return _list.Count;
                }
            }
        }

        public bool IsReadOnly => false;

        public void Add(TType item)
        {
            lock (_lockObject)
            {
                int index = _list.Count;
                _list.Add(item);
                InvokeNotifiableListAction(NotifiableListAction.Add, index, default, item);
            }
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
            lock (_lockObject)
            {
                _list.Clear();
                InvokeNotifiableListAction(NotifiableListAction.Clear, -1, default, default);
            }
        }

        public bool Contains(TType item)
        {
            lock (_lockObject)
            {
                return _list.Contains(item);
            }
        }

        public void CopyTo(TType[] array, int arrayIndex)
        {
            lock (_lockObject)
            {
                _list.CopyTo(array, arrayIndex);
            }
        }

        public IEnumerator<TType> GetEnumerator()
        {
            lock (_lockObject)
            {
                foreach (var item in _list)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(TType item)
        {
            lock (_lockObject)
            {
                return _list.IndexOf(item);
            }
        }

        public void Insert(int index, TType item)
        {
            lock (_lockObject)
            {
                _list.Insert(index, item);
                InvokeNotifiableListAction(NotifiableListAction.Insert, index, default, item);
            }
        }

        public bool Remove(TType item)
        {
            lock (_lockObject)
            {
                int index = _list.IndexOf(item);
                if (index >= 0)
                {
                    _list.RemoveAt(index);
                    TType oldItem = _list[index];
                    InvokeNotifiableListAction(NotifiableListAction.RemoveAt, index, oldItem, default);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void RemoveAt(int index)
        {
            lock (_lockObject)
            {
                TType oldItem = _list[index];
                _list.RemoveAt(index);
                InvokeNotifiableListAction(NotifiableListAction.RemoveAt, index, oldItem, default);
            }
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