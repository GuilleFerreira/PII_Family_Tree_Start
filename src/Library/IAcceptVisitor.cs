using System;

namespace Library
{
    public interface IAcceptVisitor
    {
        void Accept(IVisitor visitor);
    }
}