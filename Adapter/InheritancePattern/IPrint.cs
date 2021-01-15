using System;
namespace GoFDesignPattern.Adapter.InheritancePattern
{
    public interface IPrint
    {
        public abstract void PrintWeak();
        public abstract void PrintStrong();
    }
}
