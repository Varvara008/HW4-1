using System;

namespace HW4_1
{
    internal interface ILineArray<T>
    {
        public void Add(T item);
        public void Pop(int i);
        public void Sort(bool reverse);
        public void Count();
        public void CountByCondition(bool condition);
        public void CheckOne(Predicate<T> predicate);
        public void CheckAll();
        public void CheckExistence();
        public void GetFirstByCondition(bool condition);
        public void GetAllByCondition(bool condition);
        public void GetAllByType(bool type);
        public void GetMin();
        public void GetMax();
        public void GetColFromI(int i);


    }
}
