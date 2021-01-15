using System;
namespace GoFDesinPattern.Iterator
{
    public interface IIterator
    {
        // 次の要素が存在するか
        public abstract bool IsNext();
        // 次の要素を取得する
        public abstract object Next();
    }
}
