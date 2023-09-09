using System.Collections;
using System.Collections.Generic;

namespace NotifiableCollection
{
    public class NotifiableList<TType> : IList<TType>
    {
        protected readonly List<TType> _list;

        public event NotifiableListChangedEventHandler ListChanged;

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
                _list[index] = value;
                InvokeNotifiableListAction(NotifiableListAction.Set, index);
            }
        }

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public void Add(TType item)
        {
            int index = _list.Count;
            _list.Add(item);
            InvokeNotifiableListAction(NotifiableListAction.Add, index);
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
            InvokeNotifiableListAction(NotifiableListAction.Clear, -1);
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
            InvokeNotifiableListAction(NotifiableListAction.Insert, index);
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
            if (index == 0)
            {
                _list.RemoveAt(index);
                InvokeNotifiableListAction(NotifiableListAction.RemoveFirst, 0);
            }
            else if (index == _list.Count - 1)
            {
                _list.RemoveAt(index);
                InvokeNotifiableListAction(NotifiableListAction.RemoveLast, index);
            }
            else
            {
                _list.RemoveAt(index);
                InvokeNotifiableListAction(NotifiableListAction.RemoveAt, index);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public void Dirty(int index)
        {
            InvokeNotifiableListAction(NotifiableListAction.Dirty, index);
        }

        private void InvokeNotifiableListAction(NotifiableListAction action, int index)
        {
            ListChanged?.Invoke(this, action, index);
        }
    }
}