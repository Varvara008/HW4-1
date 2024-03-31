using System;


namespace HW4_1
{
    class LineArray<T>
    {
        private T[] _array; // Массив
        private int _capacity; // Емкость
        private int _size; // Размер

        public LineArray(int capacity)
        {
            _capacity = capacity;
            _array = new T[capacity];
            _size = 0;
        }

        public LineArray() : this(7)
        {
        }

        public void Display()
        {
            Console.Write("[");
            for(int i = 0; i < _capacity; i++)
            {
                Console.Write($"{_array[i]}, ");
            }
            Console.Write("]");
            Console.WriteLine();

        }
        public void Add(T item)
        {
            if (_size >= _capacity)
            {
                _capacity = _capacity * 2 + 1;
                Array.Resize(ref _array, _capacity);
            }
            _array[_size] = item;
            _size++;
        }

        public void Pop(int index)
        {
            if(index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException("Индекс вышел за пределы массива");
            }
            T[] newArray = new T[_capacity - 1];
            Array.Copy(_array, 0, newArray, 0, index);
            Array.Copy(_array, index + 1, newArray, index, _capacity - index - 1);
        }

        public T[] Where(Func<T, bool> condition)
        {
            T[] newArray = new T[_array.Length];
            int count = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (condition(_array[i]))
                {
                    newArray[count] = _array[i];
                    count++;
                }
            }
            Array.Resize(ref newArray, count);
            return newArray;
        }

        public int Count()
        {
            return _size;
        }

        public int CountWhere(Func<T, bool> condition)
        {
            int count = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (condition(_array[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public void ForEachAction(Action<T> action)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                action(_array[i]);
            }
        }

        void DoSomething<T>(T item)
        {

        }
        void AnotherMethod<T>(T item)
        {

        }
    }
}
